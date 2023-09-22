using System;

namespace exercise4
{
    class Program
    {
        class Equipment
        {
            public virtual void details()
            { 

            }
        }
        class Mobile : Equipment
        {
            internal string name;
            internal string desc;
            public void moveby(int mob_wheel, int mob_distance)
            {
                Console.WriteLine("Maintainence cost will be " + mob_distance * mob_wheel);
                Console.WriteLine("Distance Moved by Equipment is " + mob_distance);
                Console.WriteLine("-----------------------------------------------------");
            }
            public void create()
            {
                Console.WriteLine("Enter the name of the item: ");
                this.name = Console.ReadLine();
                Console.WriteLine("Enter the desc of the item: ");
                this.desc = Console.ReadLine();
            }
            public override void details()
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Name            Purpose         ");
                Console.WriteLine(name + "        " + desc + "     ");
            }
        }

        class Immobile : Equipment
        {
            internal string name;
            internal string desc;
            public void create()
            {
                Console.WriteLine("Enter name of item :");
                this.name = Console.ReadLine();
                Console.WriteLine("Enter Desc of item");
                this.desc = Console.ReadLine();
            }
            public void maintCost(int immob_weight, int immob_dist)
            {
                Console.WriteLine("Maintainence cost will be " + immob_dist * immob_weight);
                Console.WriteLine("Distance Moved by Equipment is " + immob_dist);
                Console.WriteLine("-----------------------------------------------------");

            }
            public void Details()
            {

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Name       Purpose         ");
                Console.WriteLine(name + "        " + desc + "     ");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to add mobile Equipment: ");
            Console.WriteLine("Enter 2 to add imobile Equipment: ");
            Console.WriteLine("Enter 3 to exit...");
            var select = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Enter the number of wheel: ");
                        var mob_wheel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the distance move by in km: ");
                        var mob_distance = Convert.ToInt32(Console.ReadLine());
                        Mobile obj = new Mobile();
                        obj.create();
                        obj.details();
                        obj.moveby(mob_wheel, mob_distance);
                        break;

                    case 2:
                        Console.WriteLine("Enter the weight of Equipment: ");
                        var im_weight = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the distance move by in km: ");
                        var imob_distance = Convert.ToInt32(Console.ReadLine());
                        Immobile oj = new Immobile();
                        oj.create();
                        oj.maintCost(im_weight, imob_distance);
                        oj.Details();
                        break;

                    default:
                        Console.WriteLine("Thanks for cheaking the assignment...");
                        break;
                }
            } while (select != 3);
        }
    }
}
