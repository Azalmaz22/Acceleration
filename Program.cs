namespace Acceleration
{
    internal class Program
    {
       

        static void Main(string[] args)
        {


           // var myCar = new Car();
            Console.WriteLine("Racing!");
            //var myCar = new Car();
            Console.WriteLine("Enter you car name");

            var CarName = Console.ReadLine(); 

            var myCar = new Car();
            //var myCar = new Car();
            //CarName = "BMW";
            myCar.Name = CarName;

           //myCar.Speed = 0;
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
                    Console.WriteLine("BMW is going 0 MPH");
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
        public Car() 
        { 

        }
        
           
       
       
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
