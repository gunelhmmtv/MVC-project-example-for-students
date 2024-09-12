namespace MentorProject.Models
{
    public partial class AddBookModel
    {
        public string BookName { get; set; }
        public int Price { get; set; }

        public bool InStock { get; set; }
    }
}
