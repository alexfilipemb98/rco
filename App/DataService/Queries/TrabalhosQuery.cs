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
	public static class TrabalhosQuery
	{

		public static async Task<int> DevolveProximo(int ano)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string query = @"
					SELECT IFNULL(MAX(NumDoc), 0) + 1
					FROM Trabalhos
					WHERE Ano = @Ano;
				";

				int proximo = await _SQL.GetValueAsync<int, object>(query, new { Ano = ano });
				return proximo;
			}
		}

		public static async Task<List<TrabalhosEntity>> DevolveTrabalhos()
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				List<TrabalhosEntity> lista = await _SQL.LoadDataListAsync<TrabalhosEntity>("Select * from Trabalhos");
				return lista;
			}
		}

		public static async Task<List<LinhasTrabalhoArtigosEntity>> DevolveLinhasArtigosTrabalhos(int idTrabalho)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string query = $"Select * from LinhasTrabalhoArtigos where IdTrabalho = '{idTrabalho}'";
				List<LinhasTrabalhoArtigosEntity> lista = await _SQL.LoadDataListAsync<LinhasTrabalhoArtigosEntity>(query);
				return lista;
			}
		}

		public static async Task<List<LinhasTrabalhoServicosEntity>> DevolveLinhasServicosTrabalhos(int idTrabalho)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string query = $"Select * from LinhasTrabalhoServicos where IdTrabalho = '{idTrabalho}'";
				List<LinhasTrabalhoServicosEntity> lista = await _SQL.LoadDataListAsync<LinhasTrabalhoServicosEntity>(query);
				return lista;
			}
		}

		public static async Task<TrabalhosEntity> DevolveTrabalho(int ano, int numDoc)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string query = $"Select * from Trabalhos where NumDoc = '{numDoc}' and Ano = '{ano}'";
				TrabalhosEntity trabalho = await _SQL.GetValueAsync<TrabalhosEntity>(query);

				if (trabalho != null)
				{
					trabalho.Artigos = await DevolveLinhasArtigosTrabalhos(trabalho.Id);
					trabalho.Servicos = await DevolveLinhasServicosTrabalhos(trabalho.Id);
				}

				return trabalho;
			}
		}

		public static async Task<bool> GuardarTrabalho(TrabalhosEntity entity)
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string select = "SELECT Id FROM Trabalhos WHERE Id = @Id LIMIT 1;";
				int? existingId = await _SQL.GetValueAsync<int?, object>(select, new { entity.Id });

				entity.DataAtualizacao = DateTime.Now;

				//CABECALHO!

				if (existingId != null)
				{
					string update = @"
						UPDATE Trabalhos SET
							IdCliente = @IdCliente,
							Ano = @Ano,
							NumDoc = @NumDoc,
							Duracao = @Duracao,
							Custo = @Custo,
							DataInicio = @DataInicio,
							DataFinal = @DataFinal,
							Notas = @Notas,
							Estado = @Estado,
							DataAtualizacao = @DataAtualizacao
						WHERE Id = @Id;
					";

					await _SQL.SaveDataAsync(update, entity);
				}
				else
				{
					entity.DataCriacao = DateTime.Now;

					string insert = @"
					
						INSERT INTO Trabalhos (
							IdCliente, Ano, NumDoc, Duracao, Custo, DataInicio, DataFinal,
							Notas, Estado, DataCriacao, DataAtualizacao
						)
						VALUES (
							@IdCliente, @Ano, @NumDoc, @Duracao, @Custo, @DataInicio, @DataFinal,
							@Notas, @Estado, @DataCriacao, @DataAtualizacao
						);
						SELECT last_insert_rowid();
					
					";

					long id = await _SQL.ExecuteScalarAsync<long, TrabalhosEntity>(insert, entity);

					entity.Id = (int)id;
				}

				//LINHAS ARTIGOS

				await _SQL.ExecuteScalarAsync<int, object>("DELETE FROM LinhasTrabalhoArtigos WHERE IdTrabalho = @IdTrabalho;", new { IdTrabalho = entity.Id });

				foreach (LinhasTrabalhoArtigosEntity artigo in entity.Artigos)
				{
					artigo.DataCriacao = artigo.DataAtualizacao = DateTime.Now;
					artigo.IdTrabalho = entity.Id;

					string insertArtigo = @"
						INSERT INTO LinhasTrabalhoArtigos (
							IdTrabalho, IdArtigo, Descricao, Preco, DataCriacao, DataAtualizacao
						)
						VALUES (
							@IdTrabalho, @IdArtigo, @Descricao, @Preco, @DataCriacao, @DataAtualizacao
						);
					";

					await _SQL.SaveDataAsync(insertArtigo, artigo);
				}

				//LINHAS SERVICOS

				await _SQL.ExecuteScalarAsync<int, object>("DELETE FROM LinhasTrabalhoServicos WHERE IdTrabalho = @IdTrabalho;", new { IdTrabalho = entity.Id });

				foreach (LinhasTrabalhoServicosEntity servico in entity.Servicos)
				{
					servico.DataCriacao = servico.DataAtualizacao = DateTime.Now;
					servico.IdTrabalho = entity.Id;

					string insertServico = @"
						INSERT INTO LinhasTrabalhoServicos (
							IdTrabalho, IdServico, Descricao, Preco, Duracao, DataCriacao, DataAtualizacao
						)
						VALUES (
							@IdTrabalho, @IdServico, @Descricao, @Preco, @Duracao, @DataCriacao, @DataAtualizacao
						);
					";

					await _SQL.SaveDataAsync(insertServico, servico);
				}

				return entity.Id > 0;
			}
		}



	}
}
