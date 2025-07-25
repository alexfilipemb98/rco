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
	public static class ArtigosQuery
	{
		public static async Task<List<ArtigosEntity>> GetArtigos()
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				List<ArtigosEntity> lista = await _SQL.LoadDataListAsync<ArtigosEntity>("Select * from Artigos");
				return lista;
			}
		}

		public static async Task<bool> SaveArtigo(ArtigosEntity artigo)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string select = "SELECT Id FROM Artigos WHERE Id = @Id LIMIT 1;";
				int? existingId = await _SQL.GetValueAsync<int?, object>(select, new { artigo.Id });

				artigo.DataAtualizacao = DateTime.Now;

				if (existingId != null)
				{
					string update = @"
						UPDATE Artigos SET
							Nome = @Nome,
							PrecoUnit = @PrecoUnit,
							StockAtual = @StockAtual,
							Ativo = @Ativo,
							Codigo = @Codigo,
							DataAtualizacao = @DataAtualizacao
						WHERE Id = @Id;
					";

					await _SQL.SaveDataAsync(update, artigo);

					artigo.Id = existingId.Value;
				}
				else
				{
					artigo.DataCriacao = artigo.DataAtualizacao;

					string insert = @"
						INSERT INTO Artigos (
							Codigo, Nome, PrecoUnit, StockAtual, Ativo,
							DataCriacao, DataAtualizacao
						)
						VALUES (
							@Codigo, @Nome, @PrecoUnit, @StockAtual, @Ativo,
							@DataCriacao, @DataAtualizacao
						);
						SELECT last_insert_rowid();
					";

					long id = await _SQL.ExecuteScalarAsync<long, ArtigosEntity>(insert, artigo);
					artigo.Id = (int)id;
				}

				return artigo.Id > 0;
			}
		}

		public static async Task<string> DevolveDescricao(int Id)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string lista = await _SQL.GetValueAsync<string, object>("Select Nome from Artigos where Id = @Id", new { Id });
				return lista;
			}
		}

		public static async Task<string> GerarProximoCodigoAsync()
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string query = @"
					SELECT Codigo
					FROM Artigos
					WHERE Codigo LIKE 'A%'
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

				return $"A{novoNumero:D3}";
			}
		}

	}
}
