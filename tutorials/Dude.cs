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

		public void printGreeting() 
		{
			System.Console.WriteLine (greetings);
		}
	}
}

