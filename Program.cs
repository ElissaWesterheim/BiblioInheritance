// See https://aka.ms/new-console-template for more information
using System;

namespace BiblioInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource test = new Resource("Grapes of Wrath", "Fiction");
            test.GetInfo();
            test.UpdateStatus();
            Console.WriteLine(test.Status);
            Book code = new Book("Charles Petzold", 396, "Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction");
            code.GetInfo();
            Periodical p = new Periodical("Wired", "Technology", "Monthly");
            p.UpdateStatus();
            p.GetInfo();
            Console.WriteLine(p.Status);
            Console.WriteLine("Start Video below");
            Video v = new Video("Ex Machine", "Sci-Fi", "Alex Garland", 108, "On-demand");
            v.GetInfo();

        }
    }
}