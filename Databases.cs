/*

1️⃣5️⃣ Read Data

Problem:
Fetch all students from a table and display in console.

🟡 INTERMEDIATE
1️⃣6️⃣ Parameterized Query

Problem:
Search student by ID using SQL parameters (prevent SQL injection).

1️⃣7️⃣ Update & Delete

Problem:
Update student marks and delete student by ID.

🔴 ADVANCED
1️⃣8️⃣ Stored Procedure Call

Problem:
Call a stored procedure from C# and read results.

🔥 DATABASE MINI PROJECT

Student Management System

Add student

View students

Search by ID

Update marks

Delete student

Use SQL + C# + Exception handling
*/

class Databases
{
    /*
    🟢 BASIC
1️⃣4️⃣ Insert Data

Problem:
Insert student data into a database using C#.

    */
    static void Main(string[] args)
    {
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

    }

}