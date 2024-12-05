using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seoul_Software.SQL
{
	public class DbManager
	{
		string connectionStringMaster = $"Server=CUTRESON;Database=master;Trusted_Connection=True;";
		string connectionStringSeoul = $"Server=CUTRESON;Database=Seoul_01;Trusted_Connection=True;";
		public DbManager()
		{
			CreateDb();
		}
		public void CreateDb()
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionStringMaster))
				{
					connection.Open();

					// Kiểm tra và tạo cơ sở dữ liệu nếu chưa tồn tại
					string checkDatabaseQuery = $@"
                    IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Seoul_01')
                    BEGIN
                        CREATE DATABASE Seoul_01;
                    END";
					using (SqlCommand command = new SqlCommand(checkDatabaseQuery, connection))
					{
						command.ExecuteNonQuery();
						Global.Log.Operation("SQL server database 'Seoul_01' checked/created successfully.");
					}
				}

				using (SqlConnection connection = new SqlConnection(connectionStringSeoul))
				{
					connection.Open();

					// Tạo bảng Lot nếu chưa tồn tại
					string createLotTableQuery = $@"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Lot' AND xtype='U')
                    BEGIN
                        CREATE TABLE Lot (
                            id BIGINT IDENTITY(1,1) PRIMARY KEY,
                            lotNo NVARCHAR(50) NOT NULL,
                            timeInput DATETIME NOT NULL,
                            timeOutput DATETIME,
                            total DECIMAL(18, 2) NOT NULL
                        );
                    END";
					using (SqlCommand command = new SqlCommand(createLotTableQuery, connection))
					{
						command.ExecuteNonQuery();
						//Global.Log.Operation("Table 'Lot' checked/created successfully.");
					}

					// Tạo bảng Ring nếu chưa tồn tại
					string createRingTableQuery = $@"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Ring' AND xtype='U')
                    BEGIN
                        CREATE TABLE Ring (
                            id BIGINT IDENTITY(1,1) PRIMARY KEY,
                            lotNo NVARCHAR(50) NOT NULL,
                            timeOutput DATETIME NOT NULL,
                            total DECIMAL(18, 2) NOT NULL
                        );
                    END";
					using (SqlCommand command = new SqlCommand(createRingTableQuery, connection))
					{
						command.ExecuteNonQuery();
						//Global.Log.Operation("Table 'Ring' checked/created successfully.");
					}
				}
			}
			catch (Exception ex)
			{
				Global.Log.Error($"SQL server Error: {ex.Message}");
			}
		}
	}
}
