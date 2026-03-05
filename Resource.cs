using System;
//base
namespace BiblioInheritance
{
    class Resource
    {
        public string Title { get; private set; }
        public string Category { get; private set; } //genre or type of resource
        public string Status { get; protected set; }
        public Resource(string title, string category)
        {
            Title = title;
            Category = category;
            Status = "Available";
        }
        public virtual void UpdateStatus()
        {
            if (Status == "Available")
            {
                Status = "Out";
            }
            if (Status == "Out")
            {
                Status = "Available";
            }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Title: {Title}\nCategory: {Category}\nStatus: {Status}");
        }
    }
}