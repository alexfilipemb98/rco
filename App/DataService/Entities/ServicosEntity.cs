using DataService.Bases;
using DataService.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Entities
{
	public class ServicosEntity : DataEntityBase
	{
		[Required]
		[MaxLength(50)]
		public string Codigo { get; set; }

		[Required]
		[MaxLength(150)]
		public string Nome { get; set; }

		[Required]
		[DataType(DataType.Duration)]
		public int Duracao { get; set; }

		[Required]
		[DataType(DataType.Currency)]
		public decimal Custo { get; set; }

		public string Notas { get; set; }

		public bool Ativo { get; set; }

		[NotMapped]
		public string Tempo => ConversoesHelper.ConverterMinutosParaHorasEMinutos(Duracao);
	}
}
