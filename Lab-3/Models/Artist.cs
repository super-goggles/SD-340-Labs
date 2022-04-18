using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Models
{
    internal class Artist : User
    {
        public Artist(int id, string name) : base(id, name)
        {
        }

        public override string GenerateEmail()
        {
            this.Email = "A" + this.Name + this.Id + "@gmail.com";
            return this.Email;
        }
    }
}
