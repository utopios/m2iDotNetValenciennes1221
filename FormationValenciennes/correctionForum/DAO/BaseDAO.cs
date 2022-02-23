using System.Collections.Generic;

namespace correctionForum.DAO
{
    public abstract class BaseDAO<T>
    {
        #region attribut des objets pour l'intération avec la base de donnée
        #endregion

        public abstract T Save(T element);

        public abstract T FindById(int id);

        public abstract List<T> FindAll();
        
    }
}