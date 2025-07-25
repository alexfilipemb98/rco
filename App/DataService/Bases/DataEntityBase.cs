using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Bases
{
	public class DataEntityBase
	{
		[Key]
		[Required]
		public int Id { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		public DateTime DataCriacao { get; set; }
		
		[Required]
		[DataType(DataType.DateTime)]
		public DateTime DataAtualizacao { get; set; }

		[NotMapped]
		public bool EmModoEdicao { get; set; }
	}
}
