namespace Lessons
{
    public struct BookSample
    {
        public decimal price;
        public string title;
        public string author;

        public BookSample(decimal price, string title, string author)
        {
            this.price = price;
            this.title = title;
            this.author = author;
        }
    }
}