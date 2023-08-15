using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZSISTEMAS.Data.Auxilares
{
    public static class AuxilaresWindowsForms
    {
        public static DialogResult ExibirMensagemErro(this IWin32Window win32Window, Exception erro, string titulo = "Mensagem de erro", MessageBoxButtons botoes = MessageBoxButtons.OK, MessageBoxIcon icone = MessageBoxIcon.Error)
        {
            return MessageBox.Show(win32Window, erro.Message, titulo, botoes, icone);
        }

        public static DialogResult ExibirMensagemOperacaoConcluida(this IWin32Window win32Window, string mensagem, string titulo = "Operação concluída com sucesso", MessageBoxButtons botoes = MessageBoxButtons.OK, MessageBoxIcon icone = MessageBoxIcon.Information)
        {
            return MessageBox.Show(win32Window, mensagem, titulo, botoes, icone);
        }

        public static DialogResult ExibirMensagemCadastroSalvo(this IWin32Window win32Window)
        {
            return win32Window.ExibirMensagemOperacaoConcluida("O cadastro foi salvo com sucesso.");
        }

        public static bool ExibirMensagemExcluirCadastroConfirmar(this IWin32Window win32Window)
        {
            return MessageBox.Show(win32Window, "Tem certeza que deseja excluir o cadastro?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static DialogResult ExibirMensagemCadastroExcluido(this IWin32Window win32Window)
        {
            return win32Window.ExibirMensagemOperacaoConcluida("O cadastro foi excluído com sucesso.");
        }

        public static DialogResult ExibirMensagemPesquisaSemResultados(this IWin32Window win32Window)
        {
            return win32Window.ExibirMensagemOperacaoConcluida("Nenhum cadastro que correspondá aos filtros informados foi encontrado.");
        }
    }
}
