using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class CircleFood
    {
        //location X and Y
        public int X { get; set; }
        public int Y { get; set; }//Acces in other class

        //constructor
        public CircleFood ()
        {
            X = 0;
            Y = 0;
        }
    }
}
