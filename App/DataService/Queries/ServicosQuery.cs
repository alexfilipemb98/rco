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
	public static class ServicosQuery
	{
		public static async Task<List<ServicosEntity>> GetServicos()
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				List<ServicosEntity> lista = await _SQL.LoadDataListAsync<ServicosEntity>("Select * from Servicos");
				return lista;
			}
		}
		
		public static async Task<ServicosEntity> DevolveServico(int Id)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				ServicosEntity servico = await _SQL.GetValueAsync<ServicosEntity, object>("Select * from Servicos where Id = @Id", new { Id });
				return servico;
			}
		}

		public static async Task<string> GerarProximoCodigoAsync()
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string query = @"
					SELECT Codigo
					FROM Servicos
					WHERE Codigo LIKE 'S%'
					ORDER BY LENGTH(Codigo) DESC, Codigo DESC
					LIMIT 1;
				";

				string ultimoCodigo = await _SQL.GetValueAsync<string>(query);

				int novoNumero = 1;

				if (!string.IsNullOrEmpty(ultimoCodigo) && ultimoCodigo.Length >= 4)
				{
					string parteNumerica = ultimoCodigo.Substring(1);

					if (int.TryParse(parteNumerica, out int numeroAtual))
						novoNumero = numeroAtual + 1;
				}

				return $"S{novoNumero:D3}";
			}
		}

		public static async Task<bool> SaveServico(ServicosEntity servico)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string select = "SELECT Id FROM Servicos WHERE Id = @Id LIMIT 1;";
				int? existingId = await _SQL.GetValueAsync<int?, object>(select, new { servico.Id });

				servico.DataAtualizacao = DateTime.Now;

				if (existingId != null)
				{
					string update = @"
						UPDATE Servicos SET
							Nome = @Nome,
							Codigo = @Codigo,
							Duracao = @Duracao,
							Custo = @Custo,
							Notas = @Notas,
							Ativo = @Ativo,
							DataAtualizacao = @DataAtualizacao
						WHERE Id = @Id;
					";

					await _SQL.SaveDataAsync(update, servico);
				}
				else
				{
					servico.DataCriacao = DateTime.Now;

					string insert = @"
						INSERT INTO Servicos (
							Codigo, Nome, Duracao, Custo, Notas, Ativo,
							DataCriacao, DataAtualizacao
						)
						VALUES (
							@Codigo, @Nome, @Duracao, @Custo, @Notas, @Ativo,
							@DataCriacao, @DataAtualizacao
						);
						SELECT last_insert_rowid();
					";

					long id = await _SQL.ExecuteScalarAsync<long, ServicosEntity>(insert, servico);

					servico.Id = (int)id;
				}

				return servico.Id > 0;
			}
		}
	}
}
