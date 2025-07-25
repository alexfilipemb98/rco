using DataService.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Entities
{
	public class LinhasTrabalhoArtigosEntity : DataEntityBase
	{
		[Required]
		public int IdArtigo { get; set; }

		[Required]
		public int IdTrabalho { get; set; }

		[Required]
		[MaxLength(200)]
		public string Descricao { get; set; }

		[Required]
		[DataType(DataType.Currency)]
		public decimal Preco { get; set; }
	}
}
