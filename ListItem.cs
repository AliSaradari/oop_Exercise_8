using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_8
{
    internal class ListItem
    {
        public ListItem(int number)
        {
            Number = number;
        }
        public int Number { get; set; }
        public Task? Task { get; set; }
    }
}
