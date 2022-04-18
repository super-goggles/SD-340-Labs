using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Models
{
    internal class Customer : User
    {
        public Customer(int id, string name) : base(id, name)
        {
        }
    }
}
