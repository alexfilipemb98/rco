using DataService.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataService.Entities
{
	public class ClientesEntity : DataEntityBase
	{
		[Required]
		[MaxLength(50)]
		public string Codigo { get; set; }

		[Required]
		[MaxLength(150)]
		public string Nome { get; set; }

		[MaxLength(350)]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		
		[MaxLength(20)]
		public string Telefone { get; set; }

		[DataType(DataType.Date)]
		public DateTime DataNascimento { get; set; }

		public string Notas { get; set; }

		public bool Ativo { get; set; }

		[NotMapped]
		public string DecricaoSelect { get => $"{Codigo} | {Nome}"; }
	}
}
