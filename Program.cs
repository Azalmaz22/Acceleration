namespace Acceleration
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Speed = 0;
            Console.WriteLine("Racing!");

            Console.WriteLine("Enter you car name");

            var answer1 = Console.ReadLine();
            if (answer1 == "BMW")
            {
                myCar.Name = answer1;
                
                
            }
            Console.WriteLine("Current speed is GMPH");
            while (true)
            {

                Console.WriteLine("Enter direction");
                string answer = Console.ReadLine();
                var number = int.Parse(answer);

                for (int i = 0; i <= 10; i++)
                {
                    if (number < 0)
                    {
                        myCar.Speedup(-5);
                        myCar.PrintState();
                    }
                    else if (number > 0)
                    {
                        myCar.Speedup(5);
                        myCar.PrintState();
                        
                    }
                }
                Console.WriteLine("Do you want to stop? yes/no");
                var answer2 = Console.ReadLine();
                if (answer2 == "no")
                {
                    myCar.Speed = myCar.Speed ;
                    
                    continue;
                   
                }
                else if (answer2 == "yes")
                {
                    Console.WriteLine("Goodbye");

                }
                break;
            }
        }
    }
    public class Car
    {
        public string Name;
        public int Speed;

        public void PrintState() 
        {
            Console.WriteLine("{0} is going {1} MPH.", Name, Speed);
        }

        public void Speedup(int delta )
        {
           Speed += delta;
            
        }   
    }
}
