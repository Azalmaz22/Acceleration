using System.Runtime.CompilerServices;

namespace Acceleration
{
    internal class Program
    {
       

        static void Main(string[] args)
        {


          
            Console.WriteLine("Racing!");



            Console.WriteLine("Enter you car name, payload, power,speed, speedMax");
            
            var CarName = Console.ReadLine();
            var value = Console.ReadLine();
            var CarPayload = int.Parse(value);
            var value2 = Console.ReadLine();
            var CarPower = int.Parse(value2);
            var value3 = Console.ReadLine();
            var CarSpeed = int.Parse(value3);
            var value4 = Console.ReadLine();
            var CarSpeedMax = int.Parse(value4);
            

            var myCar = new Car(CarName, CarPayload, CarPower, CarSpeed, CarSpeedMax);
         
           

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
                    Console.WriteLine(myCar.Name + "Speed = 0");
                    Console.WriteLine("Goodbye");

                }
                break;
            }
        }
    }
    public class Car
    {
       
        public string Name;
        public int Payload;
        public int Power;
        public int Speed;
        public int SpeedMax;
        public Car(string name, int payload, int power, int speed, int speedMax)
        {
            Name = name;
            Payload = payload;
            Power = power;
            Speed = speed;
            SpeedMax = speedMax;
            
        }
   

        public void PrintState() 
        {
            Console.WriteLine("{0} is going {1} MPH is speedMax{2} MPH", Name, Speed, SpeedMax);
            Console.WriteLine("payload{0}kg is power{1}kW ", Payload, Power);
            
     
        }

        public void Speedup(int delta)
        {
           Speed = Speed + delta;
            if (Speed > SpeedMax)
            {
                Speed = SpeedMax;
            }
            else if (Speed < 0)
            {
                Speed = 0;
            }
        }
      

    }
}
