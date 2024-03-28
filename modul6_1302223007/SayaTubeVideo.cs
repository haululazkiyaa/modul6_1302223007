using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223007
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            // precondition
            Debug.Assert(title != null, "Judul tidak boleh null!");
            Debug.Assert(title.Length <= 100, "Panjang judul maksimal 100 karakter!");

            this.title = title;
            Random generateId = new Random();
            this.id = generateId.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int num)
        {
            // precondition
            Debug.Assert(num <= 10000000, "Penambahan jumlah pemutaran maksimal 10.000.000");

            // exception
            try
            {
                int result = checked(playCount + num);
                this.playCount = result;
            }
            catch (OverflowException)
            {
                Console.WriteLine("[WARN] Play count melebihi batas integer.\n");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id + "\nJudul : " + title + "\nJumlah Pemutaran : " + playCount + "\n");
        }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public String getTitle()
        {
            return this.title;
        }
    }
}
