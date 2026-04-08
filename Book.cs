using System;

namespace BiblioInheritance
{
    class Book : Resource
    {
        public string Author { get; private set; }
        public int PageCount { get; private set; }

        public Book(string author, int pageCount, string title, string category) : base(title, category)
        {
            Author = author;
            PageCount = pageCount;
            

        }
        public override void UpdateStatus()
        {
            Status = "Checked out";
        }

    }
}