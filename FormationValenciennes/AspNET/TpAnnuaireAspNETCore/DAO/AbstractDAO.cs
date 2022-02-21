using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text;

namespace TpAnnuaireAspNETCore.DAO
{
    abstract class AbstractDAO<T>
    {
        protected static SqlCommand command;
        protected static SqlConnection connection;
        protected static SqlDataReader reader;
        protected static string request;

        public abstract bool Create(T element);

        public abstract bool Delete(T element);

        public abstract bool Update(T element);

        public abstract T Find(int index);
        public abstract List<T> Find(Func<T,bool> criteria);

        public abstract List<T> FindAll();
    }
}
