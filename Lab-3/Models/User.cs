using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<IMedia> Collection { get; set; }

        public User(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public virtual string GenerateEmail()
        {
            this.Email = this.Name + this.Id + "@gmail.com";
            return this.Email;
        }

        public void Binge()
        {
            foreach (IMedia media in Collection)
            {
                media.Play();
            }
        }
    }
}
