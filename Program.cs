namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            
            
            int weight, number,quiz;
            double mars, venus, neptune, saturn, uranus, jupiter,score;
            string planet;



            mars = 0.39;
            venus = 0.78;
            neptune = 1.23;
            saturn = 1.17;
            uranus = 1.05;
            jupiter = 2.65;
            score = 0;


            //Console.Clear();
            //Console.WriteLine(" Please enter your earth weight(lbs):");
            //weight = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("I have the information on the following planets");
            //Console.WriteLine();
            //Console.WriteLine("1.mars " + " 2.venus" + " 3.neptune");
            //Console.WriteLine();
            //Console.WriteLine("4.saturn" + " 5.uranus" + " 6.jupiter");
            //Console.WriteLine();
            //Console.WriteLine(" which planet are you visiting?");
            //planet = Console.ReadLine().ToLower();
            //if (planet == "mars" || planet == "1")
            //{
            //    Console.WriteLine(" your weight on mars is " + (weight * mars) + "lbs");
            //}


            //if (planet == "venus" || planet == "2")
            //{
            //    Console.WriteLine(" your weight on venus is " + (weight * venus) + "lbs");
            //}
            //if (planet == "neptune" || planet == "3")
            //{
            //    Console.WriteLine(" your weight on neptune is " + (weight * neptune) + "lbs");
            //}
            //if (planet == "saturn" || planet == "4")
            //{
            //    Console.WriteLine(" your weight on saturn is " + (weight * saturn) + "lbs");

            //}
            //if (planet == "uranus" || planet == "5")
            //{
            //    Console.WriteLine(" your weight on uranus is " + (weight * uranus) + "lbs");
            //}
            //if (planet == "jupiter" || planet == "6")
            //{
            //    Console.WriteLine(" your weight on jupiter is " + (weight * jupiter) + ":lbs");
            //}

            //Console.WriteLine();
            //Console.WriteLine(" please press enter");
            //Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine(" Part 2");
            //Console.WriteLine(" This is the worse guessing game ever");
            //Console.WriteLine("Pick a number for 1 to 10");
            //int.TryParse(Console.ReadLine(),out number);
            //if (number == 1)
            //{             
            //    Console.WriteLine(" Great job! you got the right number");
            //    Console.WriteLine(" the number was 1");
            //}


            //if (number > 1)
            {
                Console.WriteLine("sorry you are incorect");
                Console.WriteLine("The number was 1");
                Console.WriteLine();
                Console.WriteLine("PLease press enter to move on");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine(" This is a basic math quiz");
                Console.WriteLine(" What is 5 * 8?");
                Int32.TryParse(Console.ReadLine(),out quiz);
                
                if (quiz == 40)
                {
                    Console.WriteLine(" great job, one point has been added to your score");
                    Console.WriteLine(" Your score is");
                    Console.WriteLine (score +1);
                       
                }
                if (quiz < 40)
                {
                    Console.WriteLine("That is incorect");

                }
                if ( quiz > 40)
                {
                    Console.WriteLine("That is incorect");
                }
                Console.WriteLine(" what is 2 + 2");
                Int32.TryParse(Console.ReadLine(), out quiz);
                if (quiz == 4)
                {
                    Console.WriteLine(" That is corect");
                    Console.WriteLine(1 + score);

                }
                if (quiz < 4)
                {
                    Console.WriteLine("That is incorect");
                    Console.WriteLine(score);
                }
                if (quiz < 4)
                {
                    Console.WriteLine(" That is incorect");
                         
                }

               

           


            }
        }
    }
}
             
            

 




























