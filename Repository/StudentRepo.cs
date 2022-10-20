using nik.Models;
using System.Data.SqlClient;

namespace nik.Repository
{
    public class StudentRepo{
        string conStr = "server=DELL\\SQLEXPRESS;"+"database=Nikitadb integrated security=SSPI"; 

        public void AddStudent(Student s)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string insertQuery=$"Insert into studentinfo Values("+$"{s.Id},'{s.Name}','{s.Address}',{s.Phone}";
                SqlCommand cmd = new SqlCommand(insertQuery,con);
                con.Open();
                cmd.ExecutiveQuery();
                con.Close;           
             }
        }

    }
}