namespace correctionForum.Models
{
    public class Nouvelle
    {
        private int id;
        private string subject;
        private string content;
        private int abonneId;
        private int forumId;

        public int AbonneId
        {
            get => abonneId;
            set => abonneId = value;
        }

        public int ForumId
        {
            get => forumId;
            set => forumId = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Subject
        {
            get => subject;
            set => subject = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }
    }
}