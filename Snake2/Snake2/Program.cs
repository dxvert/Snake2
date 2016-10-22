using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            
            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lineLeft = new VerticalLine(0, 24, 0, '+');
            VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');

            lineLeft.DrawLine();
            lineRight.DrawLine();
            lineUp.DrawLine();
            lineDown.DrawLine();

            Point p = new Point(4, 5, '+');
            p.Draw();


            Console.ReadLine();

            
        }



    }
}
