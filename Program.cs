using System.Runtime.CompilerServices;

namespace Acceleration
{
    internal class Program
    {
       

        static void Main(string[] args)
        {


          
            Console.WriteLine("Racing!");



            Console.WriteLine("Enter you car name, payload, power");
            
            var CarName = Console.ReadLine();
            var CarPayload = Console.ReadLine();
            var CarPower = Console.ReadLine();
            var myCar = new Car(CarName, CarPayload, CarPower);
         
           

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
                  
                    continue;
                   
                }
                else if (answer2 == "yes")
                {
                    Console.WriteLine(CarName + "Speed = 0");
                    Console.WriteLine("Goodbye");

                }
                break;
            }
        }
    }
    public class Car
    {
       
        public string Name;
        public string Payload;
        public string Power;
        public int Speed;
       
        public Car(string name, string payload, string power)
        {
            Name = name;
            Payload = payload;
            Power = power;
        }
     
     
        public void PrintState() 
        {
            Console.WriteLine("{0} is going {1} MPH.", Name, Speed);
            Console.WriteLine("payload{0}kg is power{1}kW.", Payload, Power);
        }

        public void Speedup(int delta )
        {
           Speed += delta;
            
        }   
    }
}
