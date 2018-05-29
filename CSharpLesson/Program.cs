using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson {
	class Program {
		struct gamer {
			public string name;
			public int favnumber;
		}
		static void Main(string[] args) {

			string name = "Marcus";
			int numofdays = 6;
			string days = numofdays.ToString();
			String msg = "my name is " + name + ". I've been in bootcamp for " + days + " days!";
			Console.WriteLine(msg);

			///////////////////////////////////////////////////////////////////

			double daysinyear = 365.25;
			int yearborn = 1997;
			int currentyear = 2018;
			double daysalive = (currentyear - yearborn) * daysinyear;
			Console.WriteLine("You have been alive for about " + daysalive + " days! Congrats!");

			///////////////////////////////////////////////////////////////////

			int[] frames = new int[10];
			int total = 0;
			var rand = new Random();
			for (var i = 0; i < frames.Length; i++) {
				frames[i] = rand.Next(0, 30);
				total += frames[i];
			};
			Console.WriteLine("Total using random: " + total);

			///////////////////////////////////////////////////////////////////

			frames[0] = 30;
			frames[1] = 17;
			frames[2] = 10;
			frames[3] = 15;
			frames[4] = 26;
			frames[5] = 7;
			frames[6] = 28;
			frames[7] = 20;
			frames[8] = 6;
			frames[9] = 4;

			total = 0;
			foreach (int frame in frames) {
				total += frame;
			};
			Console.WriteLine("Total using Greg's random and foreach: " + total);

			///////////////////////////////////////////////////////////////////

			total = 0;
			for (var i = 0; i < frames.Length; i++) {
				total += frames[i];
			};
			Console.WriteLine("Total using Greg's random and var i: " + total);

			///////////////////////////////////////////////////////////////////

			string[] names = {
				"greg", "michael", "dan", "anna",
				"marcus", "foster", "jermaine",
				"mitchell", "jonathan", "larry", "william"
			};

			foreach(string aname in names) {
				Console.WriteLine("Hi " + aname);
			};

			///////////////////////////////////////////////////////////////////

			string[] me = {
				"Marcus", "Fields", "West Chester, OH", "fieldsmu@gmail.com"
			};

			foreach(string x in me) {
				Console.WriteLine(x);
			};

			///////////////////////////////////////////////////////////////////

			gamer ken;
			ken.name = "ken";
			ken.favnumber = 27;
			gamer nick;
			nick.name = "nick";
			nick.favnumber = 7;

			gamer[] gamers = { ken, nick };
			foreach(gamer gamer in gamers) {
				Console.WriteLine("This is " + gamer.name);
				Console.WriteLine("Gamer's name is {0}. Their favorite number is {1}.", gamer.name, gamer.favnumber);
			};
		}
	}
}
