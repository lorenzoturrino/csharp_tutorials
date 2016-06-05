using System;

namespace tutorials
{
	public class FirstClass
	{
		static public void Main (string[] args)
		{
			System.Console.WriteLine ("hello world" + " you wrote {0} args", args.Length);
			foreach(string arg in args) {
				System.Console.WriteLine ("Arg is " + arg);
			}
		}
	}
}
