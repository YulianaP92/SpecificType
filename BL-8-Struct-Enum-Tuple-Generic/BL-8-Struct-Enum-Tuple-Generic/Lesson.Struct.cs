using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Lesson
    {
        public static void StructExample()
        {
            Coordinate coord0 = new Coordinate(0, 0);
            Coordinate coord1;
            Coordinate coord2;

            coord1.x = 15;
            coord1.y = 15;
            var value = coord1.Vector();

            coord2 = coord1;
            Console.WriteLine(coord2.Vector());
            coord2.y = 10;
            Console.WriteLine(value);
        }
        public static void Struct2Example()
        {
            var array=new Coordinate[]{new Coordinate(20,25)};
            var list=new List<Coordinate>(){new Coordinate(20,25)};
            var arrayElement1 = array[0];
            var listElement1 = list[0];

            arrayElement1.y = 1;
            listElement1.y = 2;

            Console.WriteLine(array[0]);//20
            Console.WriteLine(list[0]);//25
        }
    }

    public struct Color
    {
        public string rgb;
        public string name;
       
    }

    public struct Coordinate
    {
        public int x;
        public int y;
        

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
           
        }

        public Double Lenght
        {
            get { return Vector(); }
        }

        public double Vector()
        {
            var lenght = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return lenght;
        }

        public override string ToString()
        {
            return $"{this.x}{this.y}";
        }
    }
}
