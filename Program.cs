namespace Acceleration
{
    internal class Program
    {
        //public int Number;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Riding back");
                var myCar = new Car();
                //myCar.PrintState(); 
                myCar.Name = "BMW";
                //myCar.PrintState();
                myCar.Speed = 0;
                Console.WriteLine("Введите напр.движения");
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
                Console.WriteLine("Switch transmission?");
                var answer2 = Console.ReadLine();
                if (answer2 == "Ok")
                {
                    continue;
                }
                else if (answer2 == "Stop")
                {
                    break;
                }
                
            }
            Console.WriteLine("Goodbye");
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

        public void Speedup(int delta)
        {
           Speed += delta;
           
        }   
    }
}
