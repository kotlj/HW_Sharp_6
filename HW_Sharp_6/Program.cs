using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_6
{
    internal class Program
    {
        class Passport
        {
            private string fullName;
            private string birthDate;
            private bool engaged;
            private bool valid;

            public Passport(string _fullname, string _birthDate, bool _engaged, bool _valid)
            {
                fullName = _fullname;
                birthDate = _birthDate;
                engaged = _engaged;
                valid = _valid;
            }

            public string FullName
            {
                get
                {
                    return fullName;
                }
                set
                {
                    fullName = value;
                }
            }
            public string BirthDate
            {
                get
                {
                    return birthDate;
                }
                set
                {
                    birthDate = value;
                }
            }
            public bool Engaged
            {
                get
                {
                    return engaged;
                }
                set
                {
                    engaged = value;
                }
            }
            public bool Valid
            {
                get
                {
                    return valid;
                }
                set
                {
                    valid = value;
                }
            }
        }
        class IntPassport : Passport
        {
            private int id;
            private string visaInf;

            public IntPassport(string _fullname, string _birthDate, bool _engaged, bool _valid, int _id, string _visaInf) : 
                base(_fullname, _birthDate, _engaged, _valid)
            {
                int id = _id;
                visaInf = _visaInf;
            }
            public int Id
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }
            public string VisaInf
            {
                get
                {
                    return visaInf;
                }
                set
                {
                    visaInf = value;
                }
            }
        }

        class Animal
        {
            private string name;
            
            public Animal(string _name)
            {
                name = _name;
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            virtual public void eat()
            {
                throw new Exception("Error: override func");
            }
        }
        class Tiger : Animal
        {
            private int numberOfStratches;

            public Tiger(string _name, int _numberOfStratches) : base(_name)
            {
                numberOfStratches = _numberOfStratches;
            }

            override public void eat()
            {
                Console.WriteLine($"Tiger {Name} is hunting and killing his prey");
            }
            public void crouch()
            {
                Console.WriteLine($"Tiger {Name} hiding in grass for hunting");
            }
        }
        class Crocodile : Animal
        {
            private string color;

            public Crocodile(string _name, string _color) : base(_name)
            {
                color = _color;
            }

            public string Color
            {
                get
                {
                    return color;
                }
                set
                {
                    color = value;
                }
            }
            public override void eat()
            {
                Console.WriteLine($"Crocodile {Name} drags unlucky prey underwater");
            }
            public void swim()
            {
                Console.WriteLine($"Crocodile {Name} Just swimming");
            }
        }
        class Kangaroo : Animal
        {
            private bool boxMaster;

            public Kangaroo(string _name, bool _boxMaster) : base(_name)
            {
                boxMaster = _boxMaster;
            }

            public bool BoxMaster
            {
                get
                {
                    return boxMaster;
                }
                set
                {
                    boxMaster = value;
                }
            }
            public override void eat()
            {
                Console.WriteLine($"Kangaroo {Name} eating grass");
            }
            public void jump()
            {
                Console.WriteLine($"Kangaroo {Name} just jumping around");
            }
        }

        abstract class Figure
        {
            public abstract double Area(double compA, double compB, double addition = 0);
        }
        class Rectangle : Figure
        {
            public override double Area(double compA, double compB, double none = 0)
            {
                return compA * compB;
            }
        }
        class Triangle : Figure
        {
            public override double Area(double compH, double compB, double none = 0)
            {
                return (compH * compB) / 2;
            }
        }
        class Circle : Figure
        {
            public override double Area(double P, double r, double none = 0)
            {
                double numberP = 3.14;
                return numberP * (r * r);
            }
        }
        class RightTriangle : Figure
        {
            public override double Area(double compA, double compB, double none = 0)
            {
                return (compA * compB) / 2;
            }
        }
        class Trapeze : Figure
        {
            public override double Area(double baseA, double baseB, double h)
            {
                return (baseA + baseB) * h / 2;
            }
        }
        static void Main(string[] args)
        {
            Figure[] f = new Figure[5] {new Triangle(), new Circle(), new Rectangle(), new RightTriangle(), new Trapeze()};
        }
    }
}
