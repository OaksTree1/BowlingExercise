using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BowlingGame
{
    internal class DaGame
    {
        public Players PlayerCreation()
        {
            Console.WriteLine("What is Your Name:");
            string Name = Console.ReadLine();
            RandomThrow randomThrow = new RandomThrow();
            Console.WriteLine("What is your Typical Bowling Score(0 - 300):");
            int Skill = Convert.ToInt32(Console.ReadLine());

            if (Skill <= 300)
            {
                Players players = new Players(Name, Skill);
                return players;
            }
            Console.WriteLine("Skill Level Not Possible. Please Try Again!");
            return PlayerCreation();
        }

        public void BowlingGame()
        {
            var Character = PlayerCreation();
            RandomThrow randomThrow = new RandomThrow();
            int Turns = 10;
            int Throw = 0;
            int Throw2 = 0;
            int CombineThrows = 0;
            int Extrapoints = 0;

            List<Tuple<string, string>> ThrowList = new List<Tuple<string, string>>();
            Tuple<string, string> ThrowTuple;

            for (int i = 0; i <= Turns -1; i += 1)
            {

                if (Character.Skill > 150 && Character.Skill < 300)
                {
                    Throw = randomThrow.RandomizeGoodThrow();
                    Random random = new Random();
                    Throw2 = random.Next(0, (10 - Throw) + 1);

                    CombineThrows += Throw + Throw2;


                    ThrowTuple = new Tuple<string, string>(Throw.ToString(), Throw2.ToString());
                    ThrowList.Add(ThrowTuple);
                    

                }
                if (Character.Skill > 90 && Character.Skill < 150)
                {
                    Throw = randomThrow.RandomizeOkThrow();
                    Random random = new Random();
                    Throw2 = random.Next(0, (10 - Throw) + 1);

                    CombineThrows += Throw + Throw2;


                    ThrowTuple = new Tuple<string, string>(Throw.ToString(), Throw2.ToString());
                    ThrowList.Add(ThrowTuple);
                }
                if (Character.Skill > 0 && Character.Skill < 90)
                {
                    Throw = randomThrow.RandomizeBadThrow();
                    Random random = new Random();
                    Throw2 = random.Next(0, (10 - Throw) + 1);

                    CombineThrows += Throw + Throw2;


                    ThrowTuple = new Tuple<string, string>(Throw.ToString(), Throw2.ToString());
                    ThrowList.Add(ThrowTuple);


                }

            }
            Tuple<string, string> Buffer = new Tuple<string, string>("0", "0");
            ThrowList.Add(Buffer);
            ThrowList.Add(Buffer);

            for (int j = 0; j < ThrowList.Count; j += 1)
            {
                
                if (ThrowList.ElementAt(j).Item1 == "10")
                {
                    if (j == 10)
                    {
                        Extrapoints += (Throw + Throw2);
                    }
                   
                    if (ThrowList.ElementAt(j + 1).Item1 == "10")
                    {
                       
                        Extrapoints += Convert.ToInt32(ThrowList.ElementAt(j + 1).Item1);
                        
                        Extrapoints += Convert.ToInt32(ThrowList.ElementAt(j + 2).Item1);
                        
                    }
                    Extrapoints += Convert.ToInt32(ThrowList.ElementAt(j + 1).Item1);
                  
                    Extrapoints += Convert.ToInt32(ThrowList.ElementAt(j + 1).Item2);

                }
                
               if (ThrowList.ElementAt(j).Item1 != "10" && Convert.ToInt32(ThrowList.ElementAt(j).Item1) + Convert.ToInt32(ThrowList.ElementAt(j).Item2) == 10)
                {
                    if (j == 10)
                    {
                        Extrapoints += Throw;
                        break;
                    }
                    {
                        Extrapoints += Convert.ToInt32(ThrowList.ElementAt(j + 1).Item1);
                    }
                }

            }
            Console.WriteLine("Congratulations" + " " + Character.Name + "," + "\n" + "Your Total Score is" + (CombineThrows + Extrapoints));
            Console.ReadLine();
        }

    }
}
