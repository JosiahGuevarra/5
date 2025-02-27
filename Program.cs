namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weight;
            double mars, venus, neptune, saturn, uranus, jupiter;
            string planet;
            
            
            
            mars = 0.39;
            venus = 0.78;
            neptune = 1.23;
            saturn = 1.17;
            uranus = 1.05;
            jupiter = 2.65;




            Console.WriteLine(" Please enter your earth weight(lbs):");
            weight = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("I have the information on the following planets");
            Console.WriteLine();
            Console.WriteLine("1.mars " + " 2.venus" + " 3.neptune");
            Console.WriteLine();
            Console.WriteLine("4.saturn" + " 5.uranus" + " 6.jupiter");
            Console.WriteLine();
            Console.WriteLine(" which planet are you visiting?");
            planet = Console.ReadLine().ToLower();
            if  (planet == "mars" || planet == "1") 
            {
                Console.WriteLine(" your weight on mars is " + (weight * mars) + "lbs");
            }


            if (planet == "venus" || planet == "2")
            {
                Console.WriteLine(" your weight on venus is " + (weight * venus) + "lbs");
            }            
            if ( planet == "neptune" || planet == "3")
            {
                Console.WriteLine(" your weight on neptune is " + (weight * neptune) + "lbs");
            }
            if ( planet == "saturn" || planet == " 4")
            {
                Console.WriteLine(" your weight on saturn is " + (weight * saturn) + "lbs");

            }
            if ( planet == "uranus"|| planet == "5")
            {
                Console.WriteLine(" your weight on uranus is " + (weight * uranus) + "lbs");
            }
            if ( planet == "jupiter"|| planet == "6")
            {
                Console.WriteLine(" your weight on jupiter is " + (weight * jupiter) + ":lbs");
            }







        }
    }
}
