using System;

namespace BiblioInheritance
{
    class Periodical : Resource
    {
        public string Period { get; private set; }

        public Periodical(string title, string category, string period) : base(title, category)
        {
            Period = period;
        }

        public override void UpdateStatus()
        {
            Status = "In-use";
        }
    }
}