using Microsoft.Data.Sqlite;
using SQLitePCL;
using System.Xml.Linq;

namespace DataService.Helpers
{
	public static class DbHelper
	{
		public static string connectionString = $"Data Source=Database.db;Password=dbPass123";

		public static void CheckDbFile()
		{
			Batteries_V2.Init();

			using (SqliteConnection connection = new SqliteConnection(connectionString))
			{
				connection.Open();

				SqliteCommand command = connection.CreateCommand();

				//CLIENTES
				command.CommandText = @"
					CREATE TABLE IF NOT EXISTS Clientes (
						Id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
						Codigo TEXT NOT NULL UNIQUE,
						Nome TEXT NOT NULL,
						Email TEXT NULL UNIQUE,
						Telefone TEXT NOT NULL,
						Notas TEXT,
						DataNascimento TEXT,
						Ativo BOOLEAN NOT NULL DEFAULT 1,
						DataCriacao TEXT NOT NULL,
						DataAtualizacao TEXT NOT NULL
					);";

				command.ExecuteNonQuery();

				//SERVIÇOS
				command.CommandText = @"	
					CREATE TABLE IF NOT EXISTS Servicos (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						Codigo TEXT NOT NULL UNIQUE,
						Nome TEXT NOT NULL,
						Duracao INTEGER NOT NULL,
						Custo REAL NOT NULL,
						Notas TEXT,
						Ativo BOOLEAN NOT NULL,
						DataCriacao TEXT NOT NULL,
						DataAtualizacao TEXT NOT NULL
					);";

				command.ExecuteNonQuery();

				//ARTIGOS
				command.CommandText = @"	
					CREATE TABLE IF NOT EXISTS Artigos (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						Codigo TEXT NOT NULL UNIQUE,
						Nome TEXT NOT NULL,
						PrecoUnit REAL NOT NULL,
						StockAtual INTEGER NOT NULL,
						Ativo BOOLEAN NOT NULL DEFAULT 1,
						Notas TEXT,
						DataCriacao TEXT NOT NULL,
						DataAtualizacao TEXT NOT NULL
					);";

				command.ExecuteNonQuery();

				//TRABALHOS
				command.CommandText = @"
					CREATE TABLE IF NOT EXISTS Trabalhos (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						IdCliente INTEGER NOT NULL,
						Ano INTEGER NOT NULL,
						NumDoc INTEGER NOT NULL,
						Duracao INTEGER NOT NULL,
						Custo REAL NOT NULL,
						DataInicio TEXT NOT NULL,
						DataFinal TEXT NOT NULL,
						Notas TEXT,
						Estado INTEGER NOT NULL DEFAULT 0,
						DataCriacao TEXT NOT NULL,
						DataAtualizacao TEXT NOT NULL,
						FOREIGN KEY (IdCliente) REFERENCES Clientes(Id)
					);";

				command.ExecuteNonQuery();

				//LINHAS TRABALHO ARTIGOS
				command.CommandText = @"
					CREATE TABLE IF NOT EXISTS LinhasTrabalhoArtigos (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						IdTrabalho INTEGER NOT NULL,
						IdArtigo INTEGER NOT NULL,
						Descricao TEXT NOT NULL,
						Preco REAL NOT NULL,
						DataCriacao TEXT NOT NULL,
						DataAtualizacao TEXT NOT NULL,
						FOREIGN KEY (IdTrabalho) REFERENCES Trabalhos(Id),
						FOREIGN KEY (IdArtigo) REFERENCES Artigos(Id)
					);
				";

				command.ExecuteNonQuery();
				
				//LINHAS TRABALHO SERVICOS
				command.CommandText = @"
					CREATE TABLE IF NOT EXISTS LinhasTrabalhoServicos (
						Id INTEGER PRIMARY KEY AUTOINCREMENT,
						IdTrabalho INTEGER NOT NULL,
						IdServico INTEGER NOT NULL,
						Descricao TEXT NOT NULL,
						Preco REAL NOT NULL,
						Duracao INTEGER NOT NULL,
						DataCriacao TEXT NOT NULL,
						DataAtualizacao TEXT NOT NULL,
						FOREIGN KEY (IdTrabalho) REFERENCES Trabalhos(Id),
						FOREIGN KEY (IdServico) REFERENCES Servicos(Id)
					);";

				command.ExecuteNonQuery();

				//command.CommandText = @"";
				//command.ExecuteNonQuery();
			}
		}
	}
}
