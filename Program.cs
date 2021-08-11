using System;

namespace ARTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator.Initialize();

            Die dieOne = new Die();
            Die dieTwo = new Die();
            dieOne.Roll();
            dieTwo.Roll();

            Console.WriteLine("Die 1: " + dieOne.TopSide);
            Console.WriteLine("Die 2: " + dieTwo.TopSide);
            int sum = dieOne.TopSide + dieTwo.TopSide;
            Console.WriteLine("Sum of the two die is: " + sum);

        }
    }
}


namespace ARTask2
{
    
    static class RandomNumberGenerator
    {
        static Random rand;
        public static void Initialize()
        {
            rand = new Random();
        }

        public static int Next(int maxValue)
        {
            return rand.Next(maxValue);
        }
    }
}



namespace ARTask2
{

    public class Die
    {
      
        int topSide;
        int numSides;

      
        public Die() : this(6)
        {
        }

        public Die(int numSides)
        {
            this.numSides = numSides;
            topSide = 1;
        }



        public int TopSide
        {
            get { return topSide; }
        }

        public int NumSides
        {
            get { return numSides; }
        }

    

        public void Roll()
        {
            topSide = RandomNumberGenerator.Next(numSides) + 1;
        }

    
    }
}

