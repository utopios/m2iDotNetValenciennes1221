using ApiRestFullCrudEtudiant.Models;
using ApiRestFullCrudEtudiant.Tools;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace ApiRestFullCrudEtudiant.DAO
{
    public class StudentDAO
    {
        public static int AddStudent(Student s)
        {
            SqlConnection connection = Connection.New;
            SqlCommand command = new SqlCommand("INSERT INTO students (gender, firstName, lastName, email, student_number) OUTPUT INSERTED.Id VALUES (@Gender, @FirstName, @LastName, @Email, @StudentNumber)", connection);
            command.Parameters.Add(new SqlParameter("@Gender", s.Gender));
            command.Parameters.Add(new SqlParameter("@FirstName", s.FirstName));
            command.Parameters.Add(new SqlParameter("@LastName", s.LastName));
            command.Parameters.Add(new SqlParameter("@Email", s.Email));
            command.Parameters.Add(new SqlParameter("@StudentNumber", s.StudentNumber));

            connection.Open();
            s.Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();

            return s.Id;
        }

        public static List<Student> GetStudents()
        {
            List<Student> liste = new List<Student>();
            SqlConnection connection = Connection.New;
            SqlCommand command = new SqlCommand("SELECT id, gender, firstName, lastName, email, student_number FROM students", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student { Id = reader.GetInt32(0), Gender = reader.GetString(1), FirstName = reader.GetString(2), LastName = reader.GetString(3), Email = reader.GetString(4), StudentNumber = reader.GetInt32(5) };
                liste.Add(s);
            }
            return liste;
        }

        public static Student GetStudent(int id)
        {
            Student s = null;
            SqlConnection connection = Connection.New;
            SqlCommand command = new SqlCommand("SELECT gender, firstName, lastName, email, student_number FROM students WHERE id = @Id", connection);
            command.Parameters.Add(new SqlParameter("@Id", id));
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                s = new Student { Id = id, Gender = reader.GetString(0), FirstName = reader.GetString(1), LastName = reader.GetString(2), Email = reader.GetString(3), StudentNumber = reader.GetInt32(4) };
            }
            return s;
        }

        public static bool UpdateStudent(Student s)
        {
            SqlConnection connection = Connection.New;
            SqlCommand command = new SqlCommand("UPDATE students SET gender = @Gender, firstName = @FirstName, lastName = @LastName, email = @Email, student_number = @StudentNumber WHERE id = @Id", connection);
            command.Parameters.Add(new SqlParameter("@Id", s.Id));
            command.Parameters.Add(new SqlParameter("@Gender", s.Gender));
            command.Parameters.Add(new SqlParameter("@FirstName", s.FirstName));
            command.Parameters.Add(new SqlParameter("@LastName", s.LastName));
            command.Parameters.Add(new SqlParameter("@Email", s.Email));
            command.Parameters.Add(new SqlParameter("@StudentNumber", s.StudentNumber));

            connection.Open();
            int nbLigne = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            //if (nbLigne > 0)
            //    return true;
            //else
            //    return false;
            return nbLigne > 0;

        }

        public static bool DeleteStudent(int id)
        {
            SqlConnection connection = Connection.New;
            SqlCommand command = new SqlCommand("DELETE FROM students WHERE id = @Id", connection);
            command.Parameters.Add(new SqlParameter("@Id", id));
            connection.Open();
            int nbLigne = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            //if (nbLigne > 0)
            //    return true;
            //else
            //    return false;

            return nbLigne == 1 ;
        }
    }
}
