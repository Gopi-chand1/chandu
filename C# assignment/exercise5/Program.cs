using System;

namespace exercise5
{
    class Program
    {

        enum DuckType { Rubber = 10, Mallard = 20, Redhead = 30};

        public interface IShowDetail
        {
            void ShowDetails();
        }
        class Duck: IShowDetail
        {
            private double weight;
            private int nemberWings;
            private DuckType duckType;
            public Duck() {}
            public Duck(double weight, int nemberWings, DuckType duckType)
            {
                this.weight = weight;
                this.nemberWings = nemberWings;
                this.duckType = duckType;
            }
            public virtual void ShowDetails()
            {
                if (duckType == DuckType.Mallard)
                {
                    Console.WriteLine("Mallard duck");
                }
                if (duckType == DuckType.Rubber)
                {
                    Console.WriteLine("Rubber duck");
                }
                if (duckType == DuckType.Redhead)
                {
                    Console.WriteLine("Redhead duck");
                }
                Console.WriteLine("Weight: {0}", weight);
                Console.WriteLine("Nember of wings: {0}", nemberWings);
            }
        }
        class RubberDuck : Duck
        {
            public RubberDuck(double weight, int numberWings, DuckType duckType)
                : base(weight, numberWings, duckType)
            {



            }
            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine("Rubber ducks don't fly and squeak.");
            }
        }
        class MallardDuck : Duck
        {
            public MallardDuck(double weight, int nemberWings, DuckType duckType) 
                : base(weight, nemberWings, duckType)
            {


            }
            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine("Mallad ducks fast fly and quack loud.");
            }
        }
        class RedheadDuck : Duck
        {
            public RedheadDuck(double weight, int nemberWings, DuckType duckType) 
                : base(weight, nemberWings, duckType)
            {


            }
            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine("RedheadDuck ducks slow fly and quack mild.");
            }
        }
        static void Main(string[] args)
        {
            
            IShowDetail[] ducks = new IShowDetail[3];
            ducks[0] = new RubberDuck(18, 2,DuckType.Rubber);
            ducks[1]= new MallardDuck(17, 2,DuckType.Mallard);
            ducks[2] = new RubberDuck(15, 4,DuckType.Redhead);
            for (int i = 0; i < 3; i++)
            {
                ducks[i].ShowDetails();
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}












        


    

