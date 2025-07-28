using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Models
{
	public class AgendaModel
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Estado { get; set; }

		public DateTime DataInicio { get; set; }
		public DateTime DataFim { get; set; }
	

		public string Descricao { get; set; }
	}
}
