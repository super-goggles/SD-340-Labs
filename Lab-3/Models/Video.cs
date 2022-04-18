using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Models
{
    internal class Video : IMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Runtime { get; set; }

        public void Play()
        {
            Console.WriteLine($"Watching {this.Title} on your inadequate viewing screen for {this.Runtime}.");
        }
    }
}
