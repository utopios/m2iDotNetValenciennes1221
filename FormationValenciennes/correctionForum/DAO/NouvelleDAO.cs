using System.Collections.Generic;
using System.Data.SqlClient;
using correctionForum.Models;
using correctionForum.Tools;

namespace correctionForum.DAO
{
    public class NouvelleDAO : BaseDAO<Nouvelle>
    {
        public override Nouvelle Save(Nouvelle element)
        {
            //Ajouter la nouvelle dans la base de données
            connection = DataBase.Connection;
            request = "INSERT into nouvelle (subject, content, forum_id, abonne_id) OUTPUT INSERTED.ID values(@subject, @content, @forum_id, @abonne_id)";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@subject", element.Subject));
            command.Parameters.Add(new SqlParameter("@content", element.Content));
            command.Parameters.Add(new SqlParameter("@abonne_id", element.AbonneId));
            command.Parameters.Add(new SqlParameter("@forum_id", element.ForumId));
            connection.Open();
            element.Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return element;
        }

        public override Nouvelle FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public override List<Nouvelle> FindAll()
        {
            throw new System.NotImplementedException();
        }
    }
}