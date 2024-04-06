using System;

using Npgsql;
 
class Program

{

    static void Main()

    {

        string connString = "Host=localhost;Username=postgres;Password=123456;Database=test1";

        using (var conn = new NpgsqlConnection(connString))

        {

            conn.Open();

            // 查询数据库中所有的表格

            using (var cmd = new NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type = 'BASE TABLE'", conn))
            //using (var cmd = new NpgsqlCommand("SELECT students.student_id, students.name, courses.course_id, courses.title FROM students INNER JOIN student_courses ON students.student_id = student_courses.student_id INNER JOIN courses ON student_courses.course_id = courses.course_id;'", conn))

            using (var reader = cmd.ExecuteReader())

            {

                Console.WriteLine("Tables in database test1:");

                while (reader.Read())

                {

                    Console.WriteLine(reader.GetString(0));

                }

            }

        }

    }

}
