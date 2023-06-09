using BlazorApp1.Client.Entities;
using System.Collections.ObjectModel;
using static BlazorApp1.Client.Pages.Counter;

namespace BlazorApp1.Client.Services
{
	public class ClienteService
	{
		public List<Cliente> Clientes { get; private set; }

		public ClienteService()
		{
			// Inicializar a lista de Clientes
			Clientes = new List<Cliente>();

			// Criar uma nova coleção de Locacao vazia para o cliente inicial
			Collection<Locacao> locacoesIniciais = new Collection<Locacao>();

			// Criar e adicionar um novo Cliente na inicialização
			Clientes.Add(new Cliente(
				id: 1,
				cpf: "12345678901",
				nome: "Cliente Inicial",
				endereco: "Endereço Inicial",
				telefone: "1111-1111",
				celular: "99999-9999",
				habilitacao: "12345678",
				categoriaHabilitacao: "B",
				locacoes: locacoesIniciais,
				email: "email_inicial@exemplo.com",
				dataNascimento: new DateTime(1990, 1, 1),
				senha: "senha_inicial"
			));
		}
	}

}

