using System.Collections.Generic;
using correctionForum.Models;

namespace correctionForum.DAO
{
    public class AbonneDAO : BaseDAO<Abonne>
    {
        public override Abonne Save(Abonne element)
        {
            throw new System.NotImplementedException();
        }
        /*public Abonne Save(Abonne element, int forum_id)
        {
            throw new System.NotImplementedException();
        }*/

        public bool JoinAbonneForum(int abonneId, int forumId)
        {
            return false;
        }

        public override Abonne FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public override List<Abonne> FindAll()
        {
            throw new System.NotImplementedException();
        }

        
    }
}