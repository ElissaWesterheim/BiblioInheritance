using System;

namespace BiblioInheritance
{
    class Video : Resource
    {
        public string Director { get; private set; }
        public int RunTime { get; private set; }
        public string MediaType { get; private set; }

        public Video(string title, string category, string director, int runTime, string mediaType) : base(title, category)
        {
            Director = director;
            RunTime = runTime;
            MediaType = mediaType;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Title: {Title}\nCategory: {Category}\nStatus: {Status}\nDirector: {Director}\nRunTime: {RunTime}\nMedia type: {MediaType}");
        }

        public override void UpdateStatus()
        {
            MediaType = "On-demand";
            if (MediaType == "DVD")
            {
                MediaType = "On-demand";
            }
            if (MediaType == "On-demand")
            {
                MediaType = "DVD";
            }
        }


    }

}
