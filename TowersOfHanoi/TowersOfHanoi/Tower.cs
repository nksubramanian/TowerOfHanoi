using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    public class Tower
    {
        public string Name { get; set; }
        public Stack<int> tower;


        public Tower(string Name) 
        {
            this.Name = Name;
            this.tower = new Stack<int>();
        }
    }
}
