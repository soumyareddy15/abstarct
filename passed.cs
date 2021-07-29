using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    abstract class Student
    {
        public string name;
        public int studentid;
        public int grade;
        public abstract bool Ispassed(int grade);
    }
    class Undergraduate:Student
    {
        public override bool Ispassed(int grade)
        {
            if(grade>70)
            {
                return true;
            }
            else { return false; }

        }
    }
    class Graduate: Student
    {
        public override bool Ispassed(int grade)
        {
            if(grade>80)
            {
                Console.WriteLine("jj");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class passed
    {
        static void Main()
        {
            Console.WriteLine("ccc");
            Graduate g = new Graduate();
            g.Ispassed(82);
            Console.WriteLine("mm");
            Undergraduate k = new Undergraduate();
            k.Ispassed(82);

        }

    }
}
