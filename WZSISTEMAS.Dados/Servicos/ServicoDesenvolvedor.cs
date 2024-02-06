using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;
using WZSISTEMAS.Base.Servicos.Interfaces;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoDesenvolvedor(
    DbContext dbContext,
    IServicoFuncionarios servicoFuncionarios,
    IServicoClientes servicoClientes,
    IServicoCargos servicoCargos,
    IServicoFornecedores servicoFornecedores,
    IServicoUsuarios servicoUsuarios,
    IServicoProdutos servicoProdutos,
    IServicoEmpresas servicoEmpresas,
    IServicoJson servicoJson,
    IServicoCPF servicoCPF,
    IServicoCNPJ cnpj,
    IServicoInscricaoEstadual servicoInscricaoEstadual,
    IServicoCodigoBarras servicoCodigoBarras,
    IServicoRandomico servicoRandomico,
    IServicoToken servicoToken) : IServicoDesenvolvedor
{
    private readonly DbContext dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    private readonly IServicoCargos servicoCargos = servicoCargos ?? throw new ArgumentNullException(nameof(servicoCargos));

    private readonly IServicoClientes servicoClientes = servicoClientes ?? throw new ArgumentNullException(nameof(servicoClientes));
    private readonly IServicoCNPJ servicoCnpj = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
    private readonly IServicoCodigoBarras servicoCodigoBarras = servicoCodigoBarras ?? throw new ArgumentNullException(nameof(servicoCodigoBarras));
    private readonly IServicoCPF servicoCPF = servicoCPF ?? throw new ArgumentNullException(nameof(servicoCPF));
    private readonly IServicoEmpresas servicoEmpresas = servicoEmpresas ?? throw new ArgumentNullException(nameof(servicoEmpresas));
    private readonly IServicoFornecedores servicoFornecedores = servicoFornecedores ?? throw new ArgumentNullException( nameof(servicoFornecedores));
    private readonly IServicoFuncionarios servicoFuncionarios = servicoFuncionarios ?? throw new ArgumentNullException( nameof(servicoFuncionarios));
    private readonly IServicoInscricaoEstadual servicoInscricaoEstadual = servicoInscricaoEstadual ?? throw new  ArgumentNullException(nameof(servicoInscricaoEstadual));
    private readonly IServicoJson servicoJson = servicoJson ?? throw new ArgumentNullException(nameof(servicoJson));
    private readonly IServicoProdutos servicoProdutos = servicoProdutos ?? throw new ArgumentNullException(nameof(servicoProdutos));
    private readonly IServicoRandomico servicoServicoRandomico = servicoRandomico ?? throw new ArgumentNullException(nameof(servicoRandomico));
    private readonly IServicoToken servicoToken = servicoToken ?? throw new ArgumentNullException(nameof(servicoToken));
    private readonly IServicoUsuarios servicoUsuarios = servicoUsuarios ?? throw new ArgumentNullException(nameof(servicoUsuarios));

    public  ResultadoToken Desautenticar(string token)
    {
        return servicoUsuarios.Desautenticar(token);
    }

    public virtual void PreencherBancoDados()
    {
        if (dbContext.Set<Usuario>().Select(x => x.Id)
            .Any())
            throw new InvalidOperationException(
                "O serviço de preencher o banco de dados só pode ser utilizado em um banco de dados sem registros");

        PreencherCargos();
        PreencherFuncionarios();
        PreencherUsuarios();
        PreencherClientes();
        PreencherFornecedores();
        PreencherProdutos();
        PreencherEmpresas();

        void PreencherCargos()
        {
            servicoCargos.CriarVarios(new List<Cargo>
            {
                new()
                {
                    Nome = "ADMINISTRADOR"
                },
                new()
                {
                    Nome = "ATENDENTE"
                },
                new()
                {
                    Nome = "RECEPCIONISTA"
                },
                new()
                {
                    Nome = "VENDEDOR"
                }
            });

            servicoCargos.SalvarAlteracoes();
        }

        void PreencherFuncionarios()
        {
            var cargos = servicoCargos.ObterLista();

            foreach (var cargo in cargos)
                if (cargo.Nome == "ADMINISTRADOR")
                {
                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "HENRIQUE SOUZA DE MELO",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA JAIR DE SOUZA",
                        LogradouroNumero = "4432",
                        CEP = "19002100",
                        Bairro = "JARDIM AVIAÇÃO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132267799"
                    });

                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "JULIA GABRIELA DE OLIVEIRA",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA GONÇALVES HENRIQUE DE SOUZA",
                        LogradouroNumero = "2431",
                        CEP = "19002100",
                        Bairro = "JARDIM AVIAÇÃO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132268869"
                    });
                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "JOAO PAULO PINTO",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA MANOEL GABRIEL",
                        LogradouroNumero = "2588",
                        CEP = "19003122",
                        Bairro = "JARDIM RIBEIRO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132267799"
                    });
                }
                else if (cargo.Nome == "ATENDENTE")
                {
                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "LUIZ SOUZA MELO",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA JAIR DE SOUZA",
                        LogradouroNumero = "5432",
                        CEP = "19002100",
                        Bairro = "JARDIM AVIAÇÃO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132237591"
                    });

                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "GESSICA DE OLIVEIRA",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA GONÇALVES HENRIQUE DE SOUZA",
                        LogradouroNumero = "543",
                        CEP = "19002100",
                        Bairro = "JARDIM AVIAÇÃO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132257862"
                    });
                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "LUCAS GREGORIO DE MATOS",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA MANOEL GABRIEL",
                        LogradouroNumero = "88",
                        CEP = "19003122",
                        Bairro = "JARDIM RIBEIRO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "11988625099"
                    });
                }
                else if (cargo.Nome == "RECEPCIONISTA")
                {
                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "LEONARDO LUCAS DO SANTOS",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA JAIR DE SOUZA",
                        LogradouroNumero = "4432",
                        CEP = "19002100",
                        Bairro = "JARDIM AVIAÇÃO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132267799"
                    });

                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "MARIANE DA SILVA",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA GONÇALVES HENRIQUE DE SOUZA",
                        LogradouroNumero = "2431",
                        CEP = "19002100",
                        Bairro = "JARDIM AVIAÇÃO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132268869"
                    });
                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "GUILHERME VALENTINO",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA MANOEL GABRIEL",
                        LogradouroNumero = "2588",
                        CEP = "19003122",
                        Bairro = "JARDIM RIBEIRO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132267799"
                    });
                }
                else if (cargo.Nome == "VENDEDOR")
                {
                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "RAFAEL DE SOUZA SANTOS",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA JAIR DE SOUZA",
                        LogradouroNumero = "4432",
                        CEP = "19002100",
                        Bairro = "JARDIM AVIAÇÃO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132267799"
                    });

                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "ANTONY HENRYQUE",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA GONÇALVES HENRIQUE DE SOUZA",
                        LogradouroNumero = "2431",
                        CEP = "19002100",
                        Bairro = "JARDIM AVIAÇÃO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132268869"
                    });

                    servicoFuncionarios.Criar(new Funcionario
                    {
                        CargoId = cargo.Id,
                        NomeCompleto = "FERNANDO JOSÉ SILVA",
                        CPF = servicoCPF.Gerar(),
                        DataNascimento = ObterDataNascimento(),
                        Logradouro = "RUA MANOEL GABRIEL",
                        LogradouroNumero = "2588",
                        CEP = "19003122",
                        Bairro = "JARDIM RIBEIRO",
                        Cidade = "SÃO CAETANO",
                        UF = UFs.SP,
                        Telefone = "1132267799"
                    });
                }

            servicoFuncionarios.SalvarAlteracoes();
        }

        void PreencherUsuarios()
        {
            var funcionarios = servicoFuncionarios.ObterLista();

            var i = 0;

            foreach (var funcionario in funcionarios)
            {
                var usuario = new Usuario
                {
                    FuncionarioId = funcionario.Id,
                    NomeUsuario = funcionario.CPF
                };

                servicoUsuarios.Criar(usuario, "123456");

                i++;
            }

            servicoUsuarios.SalvarAlteracoes();
        }

        void PreencherClientes()
        {
            servicoClientes.Criar(new Cliente
            {
                NomeCompleto_RazaoSocial = "RAFAEL DE SOUZA SANTOS",
                CPF_CNPJ = servicoCPF.Gerar(),
                DataNascimento = ObterDataNascimento(),
                Logradouro = "RUA JAIR DE SOUZA",
                LogradouroNumero = "4432",
                CEP = "19002100",
                Bairro = "JARDIM AVIAÇÃO",
                Cidade = "SÃO CAETANO",
                UF = UFs.SP,
                Telefone = "1132267799",
                ConvenioAtivo = true,
                ConvenioLimite = 400,
                FaturaDiaFechamentoVencimento = DiaDeFechamentoEVencimento.Dia10_17
            });

            servicoClientes.Criar(new Cliente
            {
                NomeCompleto_RazaoSocial = "ANTONY HENRYQUE",
                CPF_CNPJ = servicoCPF.Gerar(),
                DataNascimento = ObterDataNascimento(),
                Logradouro = "RUA GONÇALVES HENRIQUE DE SOUZA",
                LogradouroNumero = "2431",
                CEP = "19002100",
                Bairro = "JARDIM AVIAÇÃO",
                Cidade = "SÃO CAETANO",
                UF = UFs.SP,
                Telefone = "1132268869",
                ConvenioAtivo = true,
                ConvenioLimite = 400,
                FaturaDiaFechamentoVencimento = DiaDeFechamentoEVencimento.Dia10_17
            });

            servicoClientes.Criar(new Cliente
            {
                NomeCompleto_RazaoSocial = "FERNANDO JOSÉ SILVA",
                CPF_CNPJ = servicoCPF.Gerar(),
                DataNascimento = ObterDataNascimento(),
                Logradouro = "RUA MANOEL GABRIEL",
                LogradouroNumero = "2588",
                CEP = "19003122",
                Bairro = "JARDIM RIBEIRO",
                Cidade = "SÃO CAETANO",
                UF = UFs.SP,
                Telefone = "1132267799",
                ConvenioAtivo = true,
                ConvenioLimite = 400,
                FaturaDiaFechamentoVencimento = DiaDeFechamentoEVencimento.Dia10_17
            });

            servicoClientes.SalvarAlteracoes();
        }

        void PreencherFornecedores()
        {
            servicoFornecedores.Criar(new Fornecedor
            {
                RazaoSocial = "FUNADA LTDA",
                CNPJ = servicoCnpj.Gerar(),
                InscricaoEstadual = servicoInscricaoEstadual.Gerar(),
                Logradouro = "ENDERECO EXEMPLO",
                LogradouroNumero = "S/N",
                CEP = "11222333",
                Bairro = "VILA NOVA",
                Cidade = "PRESIDENTE PRUDENTE",
                UF = UFs.SP,
                Telefone = "1132267799"
            });

            servicoFornecedores.Criar(new Fornecedor
            {
                RazaoSocial = "BEBIDAS WILSON",
                CNPJ = servicoCnpj.Gerar(),
                InscricaoEstadual = servicoInscricaoEstadual.Gerar(),
                Logradouro = "AV JUCELINO",
                LogradouroNumero = "22555",
                CEP = "11222333",
                Bairro = "VILA NOVA",
                Cidade = "PRESIDENTE PRUDENTE",
                UF = UFs.SP,
                Telefone = "1132267798"
            });
            servicoFornecedores.Criar(new Fornecedor
            {
                RazaoSocial = "COCA-COLA LTDA",
                CNPJ = servicoCnpj.Gerar(),
                InscricaoEstadual = servicoInscricaoEstadual.Gerar(),
                Logradouro = "AV JUCELINO",
                LogradouroNumero = "22557",
                CEP = "11222333",
                Bairro = "VILA NOVA",
                Cidade = "PRESIDENTE PRUDENTE",
                UF = UFs.SP,
                Telefone = "1132267769"
            });

            servicoFornecedores.Criar(new Fornecedor
            {
                RazaoSocial = "DISPAN ALIMENTOS",
                CNPJ = servicoCnpj.Gerar(),
                InscricaoEstadual = servicoInscricaoEstadual.Gerar(),
                Logradouro = "AV MANOEL GOULART",
                LogradouroNumero = "22587",
                CEP = "11222333",
                Bairro = "VILA NOVA",
                Cidade = "PRESIDENTE PRUDENTE",
                UF = UFs.SP,
                Telefone = "1132267799"
            });


            servicoFornecedores.SalvarAlteracoes();
        }

        void PreencherProdutos()
        {
            var iCMS = servicoJson.Serializar(new ICMS00
            {
                orig = "1",
                CST = "1",
                modBC = "1",
                vBC = 0.03m,
                pICMS = 0.02m
            }) ?? default!;

            var pIS = servicoJson.Serializar(new PISAliq
            {
                CST = "1",
                vBC = 0.02m,
                pPIS = 0.03m
            }) ?? default!;

            var cOFINS = servicoJson.Serializar(new COFINSAliq
            {
                CST = "1",
                vBC = 0.02m,
                pCOFINS = 0.04m
            }) ?? default!;

            servicoProdutos.Criar(new Item
            {
                Descricao = "REFRIGERANTE FUNADA 2L LARANJA",
                DescricaoPDV = "REFR FUNADA 2L LAR",
                CodigoBarras = servicoCodigoBarras.GerarCodigoBarras(
                    "789",
                    "83325",
                    "1205",
                    "2"),
                PrecoFinal = 4.99m,
                NCM = "22021000",
                CFOP = "5405",
                ICMS = iCMS,
                PIS = pIS,
                COFINS = cOFINS,
                EstoqueMinimo = 10,
                EstoqueAtual = 20,
                GerenciarEstoque = true
            });

            servicoProdutos.Criar(new Item
            {
                Descricao = "REFRIGERANTE FUNADA 2L UVA",
                DescricaoPDV = "REFR FUNADA 2L UVA",
                CodigoBarras = servicoCodigoBarras.GerarCodigoBarras(
                    "789",
                    "83325",
                    "1205",
                    "2"),
                PrecoFinal = 4.99m,
                NCM = "22021000",
                CFOP = "5405",
                ICMS = iCMS,
                PIS = pIS,
                COFINS = cOFINS,
                EstoqueMinimo = 10,
                EstoqueAtual = 20,
                GerenciarEstoque = true
            });

            servicoProdutos.Criar(new Item
            {
                Descricao = "REFRIGERANTE FUNADA 2L LIMAO",
                DescricaoPDV = "REFR FUNADA 2L LIM",
                CodigoBarras = servicoCodigoBarras.GerarCodigoBarras(
                    "789",
                    "83325",
                    "1206",
                    "2"),
                PrecoFinal = 4.99m,
                NCM = "22021000",
                CFOP = "5405",
                ICMS = iCMS,
                PIS = pIS,
                COFINS = cOFINS,
                EstoqueMinimo = 10,
                EstoqueAtual = 20,
                GerenciarEstoque = true
            });


            servicoProdutos.Criar(new Item
            {
                Descricao = "REFRIGERANTE FUNADA 2L TUBAINA",
                DescricaoPDV = "REFR FUNADA 2L TUB",
                CodigoBarras = servicoCodigoBarras.GerarCodigoBarras(
                    "789",
                    "83325",
                    "1207",
                    "2"),
                PrecoFinal = 4.99m,
                NCM = "22021000",
                CFOP = "5405",
                ICMS = iCMS,
                PIS = pIS,
                COFINS = cOFINS,
                EstoqueMinimo = 10,
                EstoqueAtual = 20,
                GerenciarEstoque = true
            });

            servicoProdutos.Criar(new Item
            {
                Descricao = "REFRIGERANTE FUNADA 2L COLA",
                DescricaoPDV = "REFR FUNADA 2L COLA",
                CodigoBarras = servicoCodigoBarras.GerarCodigoBarras(
                    "789",
                    "83325",
                    "1208",
                    "8"),
                PrecoFinal = 4.99m,
                NCM = "22021000",
                CFOP = "5405",
                ICMS = iCMS,
                PIS = pIS,
                COFINS = cOFINS,
                EstoqueMinimo = 10,
                EstoqueAtual = 20,
                GerenciarEstoque = true
            });

            servicoProdutos.SalvarAlteracoes();
        }

        void PreencherEmpresas()
        {
            servicoEmpresas.Criar(new Empresa
            {
                RazaoSocial = "WZSISTEMAS MATRIZ",
                CNPJ = servicoCnpj.Gerar(),
                InscricaoEstadual = servicoInscricaoEstadual.Gerar(),
                Logradouro = "AV CESAR CAVVA GALVÃO",
                LogradouroNumero = "332",
                CEP = "11222333",
                Bairro = "VITORIA REGEA",
                Cidade = "PRESIDENTE PRUDENTE",
                UF = UFs.SP,
                Telefone = "1132267799"
            });
            servicoEmpresas.Criar(new Empresa
            {
                RazaoSocial = "WZSISTEMAS SAO CARLOS",
                CNPJ = servicoCnpj.Gerar(),
                InscricaoEstadual = servicoInscricaoEstadual.Gerar(),
                Logradouro = "AV CESAR CAVVA GALVÃO",
                LogradouroNumero = "112",
                CEP = "11222333",
                Bairro = "VITORIA REGEA",
                Cidade = "PRESIDENTE PRUDENTE",
                UF = UFs.SP,
                Telefone = "1132267798"
            });

            servicoEmpresas.Criar(new Empresa
            {
                RazaoSocial = "WZSISTEMAS SAO MATEUS",
                CNPJ = servicoCnpj.Gerar(),
                InscricaoEstadual = servicoInscricaoEstadual.Gerar(),
                Logradouro = "AV CESAR CAVVA GALVÃO",
                LogradouroNumero = "220",
                CEP = "11222333",
                Bairro = "VITORIA REGEA",
                Cidade = "PRESIDENTE PRUDENTE",
                UF = UFs.SP,
                Telefone = "1132267797"
            });
            servicoEmpresas.SalvarAlteracoes();
        }

        DateTime ObterDataNascimento()
        {
            return new DateTime(
                servicoServicoRandomico.GerarRandomicamente(1990, 2004),
                servicoServicoRandomico.GerarRandomicamente(1, 12),
                servicoServicoRandomico.GerarRandomicamente(1, 20));
        }
    }
}