using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Helpers
{
	public static class ConversoesHelper
	{
		public static string ConverterMinutosParaHorasEMinutos(int totalMinutos)
		{
			int horas = totalMinutos / 60;
			int minutos = totalMinutos % 60;
			return $"{horas}H e {minutos}min";
		}
	}
}
