using System;

namespace tutorials
{
	public class Dude
	{
		private string greetings = "hello I'm dude";
		private int years;

		public int age
		{
			get { return years; }
			set { years = value; }
		}

        public override string ToString()
        {
            return $"{greetings}, and I am {years}y old";
        }

        public void printGreeting() 
		{
			System.Console.WriteLine (greetings);
		}
	}
}

