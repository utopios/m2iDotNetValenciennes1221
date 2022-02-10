using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionAnnuaireAdoNet.Classes
{
    public abstract class BaseModel<T>
    {
        protected static string request;
        protected static SqlConnection connection;
        protected static SqlCommand command;
        protected static SqlDataReader reader;

        public abstract bool Save();
        public abstract T GetById(int id);

        public abstract List<T> GetAll();
    }
}
