using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223054
{
    public class SayaTubeVideo
    {
        private int id { get => id; set => id = value; }
        private string title { get => title; set => title = value; }
        private int playCount { get => playCount; set => playCount = value; }

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next();
            this.playCount = 0;
        }

        public void setId(int id){this.id = id;}

        public int getId() { return this.id;}

        public void setTitle(string title) { this.title = title; }

        public string getTitle() { return this.title; }

        public void setplayCount(int playCount) { this.playCount = playCount; }

        public int getplayCount() { return this.playCount; }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount++;
        }

        public void PrintVideoDetails(int id, string title, int playCount)
        {
            Console.WriteLine("\t Id : " + id);
            Console.WriteLine("\t title : " + title);
            Console.WriteLine("\t playCount : " + playCount);
        }
    }
}
