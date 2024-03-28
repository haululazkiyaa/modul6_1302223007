using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            // precondition
            Debug.Assert(username.Length <= 100, "Panjang username maksimal 100 karakter!");
            Debug.Assert(username != null, "Username tidak boleh null!");
            this.username = username;

            Random generateId = new Random();
            this.id = generateId.Next(10000, 99999);
            this.uploadedVideos = [];
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
            // precondition
            Debug.Assert(video != null, "Video tidak boleh null!");
            Debug.Assert(video.getPlayCount() <= checked(video.getPlayCount()), "Video yang ditambahkan memiliki play count lebih dari maksimal inetger!");
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            // post condition
            int maxPrint = this.uploadedVideos.Count;
            if (this.uploadedVideos.Count > 8)
            {
                maxPrint = 8;
            }

            Console.WriteLine("User: " + username);
            for (int i = 0;i < maxPrint; i++)
            {
                Console.WriteLine($"Video {i+1} {this.uploadedVideos[i].getTitle()}");
            }
        }
    }
}
