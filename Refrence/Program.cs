using System;

namespace Refrence
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("enter two words seperated by a '?' to check to see if it's an anagram");
		    while (true)
		    {
		        string input = Console.ReadLine();
		        string[] strings = input.Split('?');
		        if (strings.Length != 2)
		            Console.WriteLine("Invalid input");
		        else
		        {
		            strings[0] = strings[0].Trim();
		            strings[1] = strings[1].Trim();
		            bool isAnagram = AnagramDetector.isAnagram(strings[0], strings[1]);
		            if(isAnagram)
		                Console.WriteLine("\""+strings[1]+"\" is an anagram of \""+strings[0]+"\"");
		            else
		                Console.WriteLine("\""+strings[1]+"\" is not an anagram of \""+strings[0]+"\"");
		        }
		    }
		}
	}
}
