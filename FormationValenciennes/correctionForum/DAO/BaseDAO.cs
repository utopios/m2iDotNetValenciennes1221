using System.Collections.Generic;
using System.Data.SqlClient;

namespace correctionForum.DAO
{
    public abstract class BaseDAO<T>
    {
        #region attribut des objets pour l'intération avec la base de donnée

        protected static string request;
        protected static SqlConnection connection;
        protected static SqlCommand command;
        protected static SqlDataReader reader;
        #endregion

        public abstract T Save(T element);

        public abstract T FindById(int id);

        public abstract List<T> FindAll();
        
    }
}