using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Matrix : Object
    {
        public int x, y, z, a;
        public Matrix(int p, int q, int r, int s)
        {
            x = p;
            y = q;
            z = r;
            a = s;
        }

        //operator overloading using method - add
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix m3 = new Matrix(obj1.x + obj2.x, obj1.y + obj2.y, obj1.z + obj2.z, obj1.a + obj2.a);
            return m3;
        }
        //operator overloading using method - sub
        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            Matrix m3 = new Matrix(obj1.x - obj2.x, obj1.y - obj2.y, obj1.z - obj2.z, obj1.a - obj2.a);
            return m3;
        }

        //override toString Method
        public override string ToString()
        {
            return (x+ " " + y + " "+ "\n" + "     " + z + " "+ a + " "+"\n");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(10, 20, 5, 30);
            Matrix m2 = new Matrix(12, 40, 17, 18);
            Matrix madd = m1 + m2;
            Matrix msub = m1 - m2;

            //will return nampespace/classname
            Console.WriteLine("M1 = "+m1);
            Console.WriteLine("M2 = "+m2);
            Console.WriteLine("madd = " + madd);
            Console.WriteLine("msub = " + msub);

            Console.ReadLine();
            // Matrix m4 = new Matrix(m1.x + m2.x, m1.y + m2.y, m1.z + m2.z, m1.a + m2.a);
            //call above using operator overloading Matrix m3 = m1+m2;
        }
    }
}
