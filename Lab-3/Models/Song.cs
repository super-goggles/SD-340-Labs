using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Models
{
    internal class Song : IMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public List<Customer> Customers { get; set; }

        void Play()
        {
            Console.WriteLine($"Playing the song {this.Title} on your favourite music platform for {this.Runtime}.");
        }

    }
}
