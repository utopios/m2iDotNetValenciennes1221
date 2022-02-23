namespace correctionForum.Models
{
    public class Nouvelle
    {
        private int id;
        private string subject;
        private string content;
        
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