using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223054
{
    internal class SayaTubeUser
    {
        public class sayaTubeUser
        {
            private int id;
            public string username;
            private List<SayaTubeVideo> uploadedVideos; 

            public sayaTubeUser(string id)
            {
                this.username = id;
                this.uploadedVideos = new List<SayaTubeVideo>();
            }

            public void GetTotalVideoPlayCount()
            {
                int play = 0;
                foreach(SayaTubeVideo video in uploadedVideos)
                {
                    play = play + video.getplayCount();
                }
            }


            public void AddVideo<SayaTubeVideo>()
            {
                sayaTubeUser sayaTubeUser = new sayaTubeUser(username);
            }

            public void PrintAllVideoPlaycount()
            {
                Console.WriteLine("\t User : " + username);
            }
        }
    }
}
