using DataService.Bases;
using DataService.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Entities
{
	public class TrabalhosEntity : DataEntityBase
	{
		[Required]
		public int IdCliente { get; set; }

		[Required]
		public int Ano { get; set; }

		[Required]
		public int NumDoc { get; set; }

		[Required]
		public int Duracao { get; set; }

		[Required]
		[DataType(DataType.Currency)]
		public decimal Custo { get; set; }

		[Required]
		public DateTime DataInicio { get; set; }

		[Required]
		public DateTime DataFinal { get; set; }

		public string Notas { get; set; }

		public EstadosTrabalho Estado { get; set; }

		public List<LinhasTrabalhoArtigosEntity> Artigos { get; set; }

		public List<LinhasTrabalhoServicosEntity> Servicos { get; set; }
	}
}
