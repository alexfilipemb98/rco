using DataService.Bases;
using DataService.Entities;
using DataService.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Queries
{
	public static class ClientesQuery
	{
		public static async Task<List<ClientesEntity>> GetClientes()
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				List<ClientesEntity> lista = await _SQL.LoadDataListAsync<ClientesEntity>("Select * from Clientes");
				return lista;
			}
		}

		public static async Task<bool> SaveCliente(ClientesEntity cliente)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string select = "SELECT Id FROM Clientes WHERE Id = @Id LIMIT 1;";
				int? existingId = await _SQL.GetValueAsync<int?, object>(select, new { cliente.Id });

				cliente.DataAtualizacao = DateTime.Now;
					
				if (existingId != null)
				{
					string update = @"
						UPDATE Clientes SET
							Nome = @Nome,
							Email = @Email,
							Telefone = @Telefone,
							Notas = @Notas,
							DataNascimento = @DataNascimento,
							Ativo = @Ativo,
							DataAtualizacao = @DataAtualizacao
						WHERE Codigo = @Codigo;
					";

					await _SQL.SaveDataAsync(update, cliente);
				}
				else
				{
					cliente.DataCriacao = DateTime.Now;

					string insert = @"
						INSERT INTO Clientes (
							Codigo, Nome, Email, Telefone, Notas, DataNascimento,
							Ativo, DataCriacao, DataAtualizacao
						)
						VALUES (
							@Codigo, @Nome, @Email, @Telefone, @Notas, @DataNascimento,
							@Ativo, @DataCriacao, @DataAtualizacao
						);
						SELECT last_insert_rowid();
					";

					long id = await _SQL.ExecuteScalarAsync<long, ClientesEntity>(insert, cliente);
					
					cliente.Id = (int)id;
				}

				return cliente.Id > 0;
			}
		}

		public static async Task<string> GerarProximoCodigoAsync()
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string query = @"
					SELECT Codigo
					FROM Clientes
					WHERE Codigo LIKE 'C%'
					ORDER BY LENGTH(Codigo) DESC, Codigo DESC
					LIMIT 1;
				";

				string ultimoCodigo = await _SQL.GetValueAsync<string>(query);

				int novoNumero = 1;

				if (!string.IsNullOrEmpty(ultimoCodigo) && ultimoCodigo.Length >= 4)
				{
					// Extrai os números depois do "C"
					string parteNumerica = ultimoCodigo.Substring(1);

					if (int.TryParse(parteNumerica, out int numeroAtual))
						novoNumero = numeroAtual + 1;
				}

				// Retorna no formato C001, C002...
				return $"C{novoNumero:D3}";
			}
		}
	}
}
