using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        // SQLite 连接字符串，指定 SQLite 数据库文件的路径
        string connectionString = "Data Source=example.sqlite;Version=3;";

        // 使用 using 语句创建 SQLiteConnection 对象，确保连接在使用完后被正确关闭和释放
        using (var connection = new SQLiteConnection(connectionString))
        {
            // 打开连接
            connection.Open();

            // 创建一个表
            string createTableSql = "CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT)";
            using (var command = new SQLiteCommand(createTableSql, connection))
            {
                command.ExecuteNonQuery();
            }

            // 插入数据
            string insertDataSql = "INSERT INTO MyTable (Name) VALUES ('John')";
            using (var command = new SQLiteCommand(insertDataSql, connection))
            {
                command.ExecuteNonQuery();
            }

            // 查询数据
            string querySql = "SELECT * FROM MyTable";
            using (var command = new SQLiteCommand(querySql, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Id: " + reader["Id"] + ", Name: " + reader["Name"]);
                    }
                }
            }
        }
    }
}
