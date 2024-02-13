using WZSISTEMAS.Dados.Entidades;
using WZSISTEMAS.Dados.Servicos.Interfaces;

namespace WZSISTEMAS.WinForms.Helpers;

public static class WindowsFormsHelper
{
    public const string MensagemErroValidacao = "Erro de validação";
    public const string MensagemOperacaoConcluida = "Operação concluída com sucesso";
    public const string TituloMensagemErro = "Mensagem de erro";

    public static bool ShowDialog(
        this Form form,
        Form outroForm,
        DialogResult dialogResult = DialogResult.OK)
        => form.ShowDialog(outroForm) == dialogResult;


    public static void ExibirMensagemNaoImplementado(this Form form)
        => form.ExibirMensagem(
            "Essa funcionalidade ainda não foi implementada.\nAguarde versões futuras.",
            "Funcionalidade não implementada");

    public static DialogResult ExibirMensagem(
        this Form form,
        string mensagem,
        string? titulo = default,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.None,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        => MessageBox.Show(
            form,
            mensagem,
            titulo,
            botoes,
            icone,
            botaoPadrao);

    public static bool ExibirMensagemSimNao(
        this Form form,
        string mensagem,
        string? titulo = default,
        MessageBoxIcon icone = MessageBoxIcon.Question)
        => MessageBox.Show(
            form,
            mensagem,
            titulo,
            MessageBoxButtons.YesNo,
            icone,
            MessageBoxDefaultButton.Button1) == DialogResult.Yes;

    public static DialogResult ExibirMensagemErroComCodigoErro(
        this Form form,
        string codigoErro,
        string mensagemErro = "Um erro interno impediu que a operação seja finalizada com sucesso.\n\nContate o suporte do sistema e informado o código de erro: {codigoErro}",
        string titulo = TituloMensagemErro,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Error,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        => form.ExibirMensagem(
            mensagemErro.Replace("{codigoErro}", codigoErro),
            titulo,
            botoes,
            icone,
            botaoPadrao);
    public static DialogResult ExibirMensagemErro(
        this Form form,
        string mensagemErro,
        string titulo = TituloMensagemErro,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Error,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        => form.ExibirMensagem(
            mensagemErro,
            titulo,
            botoes,
            icone,
            botaoPadrao);

    public static DialogResult ExibirMensagemErro(
        this Form form,
        Exception erro,
        string titulo = TituloMensagemErro,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Error,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        => form.ExibirMensagemErro(
            erro.Message,
            titulo,
            botoes,
            icone,
            botaoPadrao);

    public static DialogResult ExibirMensagemOperacaoConcluida(
        this Form form,
        string mensagem,
        string titulo = MensagemOperacaoConcluida,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Information,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        => form.ExibirMensagem(mensagem, titulo, botoes, icone, botaoPadrao);

    public static DialogResult ExibirMensagemErroValidacao(
        this Form form, ValidationResult resultado,
        string titulo = MensagemErroValidacao,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Warning,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
    {
        var mensagem = "Não foi possivel concluír a operação, pois Um ou mais campos não são válido.\n\nErros de validação:";

        foreach (var erro in resultado.Errors)
            mensagem += $"\n - {erro.ErrorMessage}";

        return form.ExibirMensagem(mensagem, titulo, botoes, icone, botaoPadrao);
    }

    public static DialogResult ExibirMensagemCadastroSalvo(
        this Form form,
        string mensagem = "O cadastro foi salvo com sucesso.",
        string titulo = MensagemOperacaoConcluida,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Information,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        => form.ExibirMensagem(mensagem, titulo, botoes, icone, botaoPadrao);

    public static DialogResult ExibirMensagemCadastroNaoEncontrado(
        this Form form,
        string mensagem = "O cadastro não foi encontrado.",
        string titulo = "Cadastro não encontrado",
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Information,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        => form.ExibirMensagem(mensagem, titulo, botoes, icone, botaoPadrao);

    public static bool ExibirMensagemExcluirCadastroConfirmar(
        this Form form,
        string mensagem = "Tem certeza que deseja excluir o cadastro?",
        string titulo = "Confirmar exclusão")
        => form.ExibirMensagem(
            mensagem,
            titulo,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == DialogResult.Yes;

    public static DialogResult ExibirMensagemCadastroExcluido(
        this Form form,
        string mensagem = "O cadastro foi excluído com sucesso.",
        string titulo = MensagemOperacaoConcluida,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Information,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        => form.ExibirMensagem(mensagem, titulo, botoes, icone, botaoPadrao);

    public static DialogResult ExibirMensagemPesquisaSemResultados(
        this Form form,
        string mensagem = "Nenhum cadastro que correspondá aos filtros informados foi encontrado.",
        string titulo = "Retorno da consulta",
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Warning,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        => form.ExibirMensagem(mensagem, titulo, botoes, icone, botaoPadrao);


    public static  bool Validar<T>(
        this Form form,
        IServicoValidacao<T> validacao,
        T valor,
        string titulo = MensagemErroValidacao,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Warning,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
    {
        var resultado = validacao.Validar(valor);

        if (!resultado.IsValid)
        {
            form.ExibirMensagemErroValidacao(resultado, titulo, botoes, icone, botaoPadrao);

            return false;
        }
        else
            return true;
    }
    public static  bool ValidarEntidade<TEntidade>(
        this Form form,
        IServicoValidacaoEntidades<TEntidade> validacao,
        TEntidade entidade,
        string titulo = MensagemErroValidacao,
        MessageBoxButtons botoes = MessageBoxButtons.OK,
        MessageBoxIcon icone = MessageBoxIcon.Warning,
        MessageBoxDefaultButton botaoPadrao = MessageBoxDefaultButton.Button1)
        where TEntidade : Entidade
    {
        var resultado = validacao.Validar(entidade);

        if (!resultado.IsValid)
        {
            form.ExibirMensagemErroValidacao(resultado, titulo, botoes, icone, botaoPadrao);

            return false;
        }
        else
            return true;
    }
}
