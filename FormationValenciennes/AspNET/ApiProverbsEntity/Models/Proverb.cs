namespace ApiProverbsEntity.Models
{
    public class Proverb
    {
        private int id;
        private string author;
        private string saying;
        private string language;

        public int Id { get => id; set => id = value; }
        public string Author { get => author; set => author = value; }
        public string Saying { get => saying; set => saying = value; }
        public string Language { get => language; set => language = value; }
    }
}
