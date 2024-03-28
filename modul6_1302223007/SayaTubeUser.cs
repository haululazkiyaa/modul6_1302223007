using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223007
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private String username;

        public SayaTubeUser(String username)
        {
            Random generateId = new Random();
            this.id = generateId.Next(10000, 99999);
            this.uploadedVideos = [];
            this.username = username;
        }

        public int getTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += this.uploadedVideos[i].getPlayCount();
            }
            return total; 
        }

        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + username);
            for (int i = 0;i < this.uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i+1} {this.uploadedVideos[i].getTitle()}");
            }
        }
    }
}
