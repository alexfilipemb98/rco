using DataService.Bases;
using DataService.Entities;
using DataService.Helpers;
using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Queries
{
	public static class GeralQuery
	{
		public static async Task<List<AgendaModel>> GetAgenda()
		{
			using (DataSqlAccessBase _SQL = new DataSqlAccessBase(DbHelper.connectionString, true))
			{
				string query = @"
					SELECT 
						t.Id, 
						t.Estado, 
						c.Nome, 
						t.DataInicio, 
						t.DataFinal As DataFim  
					from Trabalhos t
					INNER join Clientes c on c.Id = t.IdCliente
				";

				List<AgendaModel> lista = await _SQL.LoadDataListAsync<AgendaModel>(query);
				return lista;
			}
		}
	}
}
