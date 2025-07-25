using DataService.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Entities
{
	public class ArtigosEntity : DataEntityBase
	{
		[Required]
		[MaxLength(50)]
		public string Codigo { get; set; }

		[Required]
		[MaxLength(150)]
		public string Nome { get; set; }

		[Required]
		[DataType(DataType.Currency)]
		public decimal PrecoUnit { get; set; }

		public string Notas { get; set; }

		public int StockAtual { get; set; }
		
		public bool Ativo { get; set; }

	}
}
