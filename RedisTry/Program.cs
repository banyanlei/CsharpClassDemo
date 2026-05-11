using System;
using StackExchange.Redis;

class Program
{
    static void Main()
    {
        // 连接到 Redis（localhost 默认端口 6379）
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");

        // 获取数据库（默认是 db 0，可传入索引选择 db）
        IDatabase db = redis.GetDatabase(); // db = redis.GetDatabase(1) 表示使用 db1

        // 写入一个 key
        db.StringSet("mykey", "hello redis!");

        // 读取这个 key
        string value = db.StringGet("mykey");

        Console.WriteLine("Value from Redis: " + value);
    }
}
