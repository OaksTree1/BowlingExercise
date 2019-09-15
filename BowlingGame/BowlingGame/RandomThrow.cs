using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
   internal class RandomThrow
    {
        public int RandomizeBadThrow()
        {
            var random = new Random();

            int RandomNumber = random.Next(0, 11);

            return RandomNumber;
        }

        public int RandomizeOkThrow()
        {
            var random = new Random();

            int RandomNumber = random.Next(6, 11);

            return RandomNumber;
        }

        public int RandomizeGoodThrow()
        {
            var random = new Random();

            int RandomNumber = random.Next(9, 11);

            return RandomNumber;
        }
    }
}
