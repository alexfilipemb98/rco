﻿using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DataService.Bases
{
	/// <summary>
	/// Class principal de sql management
	/// </summary>
	public class DataSqlAccessBase : IDisposable
	{
		#region MAIN

		//PROPERTIES
		public bool IsSqlite { get => CheckIsSqlLite(); }
		public bool IsConnected { get => ChekConnection(); }

		//PRIVATE
		private IDbConnection _connection;
		private IDbTransaction _transaction;

		/// <summary>
		/// Contructor
		/// </summary>
		/// <param name="stringConn"></param>
		public DataSqlAccessBase(IDbConnection connection)
		{
			_connection = connection;
		}

		/// <summary>
		/// Contructor
		/// </summary>
		/// <param name="stringConn"></param>
		/// <param name="isSqlLite"></param>
		public DataSqlAccessBase(string stringConn, bool isSqlLite = false)
		{
			if (isSqlLite)
				_connection = new SqliteConnection(stringConn);
			else
				_connection = new SqlConnection(stringConn);
		}

		#endregion

		#region ASYNC

		public async Task<T> GetValueAsync<T>(string query) => await _connection.QueryFirstOrDefaultAsync<T>(query, transaction: _transaction);

		public async Task<T> GetValueAsync<T, U>(string query, U parameters) => await _connection.QueryFirstOrDefaultAsync<T>(query, parameters);

		public async Task<List<T>> LoadDataListAsync<T>(string sql)
		{
			IEnumerable<T> result = await _connection.QueryAsync<T>(sql, transaction: _transaction, commandType: CommandType.Text);
			return result.ToList();
		}

		public async Task<int> SaveDataAsync<T>(string sql, T parameters, int? commandTimeout = null) => await _connection.ExecuteAsync(sql, parameters, commandTimeout: commandTimeout);

		public async Task<T> ExecuteScalarAsync<T>(string sql) => await _connection.ExecuteScalarAsync<T>(sql);

		public async Task<T> ExecuteScalarAsync<T, U>(string sql, U parameters) => await _connection.ExecuteScalarAsync<T>(sql, parameters);

		#endregion

		#region QUERIES

		public IEnumerable<T> LoadData<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text);

		public IEnumerable<T> LoadData<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text);

		public List<T> LoadDataList<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text).ToList();

		public List<T> LoadDataList<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text).ToList();

		public int SaveData<T>(string sql, ref T parameters, int? commandTimeout = null) => _connection.Execute(sql, parameters, commandTimeout: commandTimeout);

		public int SaveData(string sql, int? commandTimeout = null) => _connection.Execute(sql, commandTimeout: commandTimeout);

		public void SaveData<T, U>(string sql, ref T parameters, out U outputValue) => outputValue = _connection.ExecuteScalar<U>(sql, parameters);

		public T GetValue<T, U>(string query, U parameters) => _connection.QueryFirstOrDefault<T>(query, parameters);

		public T GetValue<T>(string query) => _connection.QueryFirstOrDefault<T>(query, transaction: _transaction);

		public T ExecuteScalar<T, U>(string sql, U parameters) => _connection.ExecuteScalar<T>(sql, parameters);

		public T ExecuteScalar<T>(string sql) => _connection.ExecuteScalar<T>(sql);

		public void ExecuteScalar(string sql) => _connection.ExecuteScalar(sql);

		#endregion

		#region TRANSACTION

		public void StartTransaction() => _transaction = _connection.BeginTransaction();

		public void ExecuteInTransaction(string sql) => _connection.Execute(sql, transaction: _transaction);

		public void SaveDataInTransaction<T>(string sql, ref T parameters) => _connection.Execute(sql, parameters, transaction: _transaction);

		public void SaveDataInTransaction(string sql) => _connection.Execute(sql, transaction: _transaction);

		public void CommitTransaction() => _transaction.Commit();

		public bool isInTransaction() => _transaction?.Connection != null;

		public void RollbackTransaction() => _transaction.Rollback();

		#endregion

		#region FUNCTION'S

		/// <summary>
		/// Connect to the server
		/// </summary>
		public void Connect()
		{
			if (_connection.State == ConnectionState.Closed)
				_connection.Open();
		}

		/// <summary>
		/// Disconect the connection
		/// </summary>
		public void Disconect()
		{
			if (_connection.State == ConnectionState.Open)
				_connection.Close();
		}

		/// <summary>
		/// Returns the connection state
		/// </summary>
		/// <returns></returns>
		private bool ChekConnection() => _connection.State == ConnectionState.Open;

		/// <summary>
		/// Checks if is sql lite
		/// </summary>
		/// <returns></returns>
		private bool CheckIsSqlLite() => _connection is SqliteConnection;

		/// <summary>
		/// On dispose fechar a conexão com a base de dados!
		/// </summary>
		public void Dispose()
		{
			if (_transaction != null)
			{
				if (_transaction.Connection != null)
					_transaction.Rollback();

				_transaction.Dispose();
			}

			if (_connection != null)
			{
				_connection?.Close();
				_connection?.Dispose();
			}

			GC.SuppressFinalize(this);
		}

		#endregion
	}
}
