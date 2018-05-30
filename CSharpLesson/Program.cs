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


		/// <summary>
		/// This code does stuff
		/// In fact, it does tons of all of the things 
		/// </summary>
		/// <param name="args">Command line parameters as strings</param>
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

			foreach(string parameters in me) {
				Console.WriteLine(parameters);
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

			///////////////////////////////////////////////////////////////////

			Random rnd = new Random();
			int rnd1 = rnd.Next(0, 9);
			int rnd2 = rnd.Next(0, 9);
			int rnd3 = rnd.Next(0, 9);
			int count = 0;
			while (rnd1 != rnd2 || rnd1 != rnd3 || rnd1 == 6) {
				rnd1 = rnd.Next(0, 9);
				rnd2 = rnd.Next(0, 9);
				rnd3 = rnd.Next(0, 9);
				int[] rndarr = { rnd1, rnd2, rnd3 };
				for (var i = 0; i < rndarr.Length; i++) {
					Console.Write(rndarr[i] + " ");
				}
				count++;
				Console.WriteLine();
			}
			Console.WriteLine("It took {0} attempts!", count);

			////////////////////////////////////////////////////////////////////

			string playagain = "yes";
			while (playagain == "yes") {
				int answer = rnd.Next(1, 100);
				Console.WriteLine("To exit, enter anything that is not a number.");
				Console.Write("Guess a number from 1 to 100: ");
				string response = Console.ReadLine();
				bool parsed = int.TryParse(response, out int e);
				if (parsed) {
					int responseint = int.Parse(response);
					while (responseint != answer) {
						// check if repsonse is higher or lower than answer 
						if (responseint > answer) {
							Console.WriteLine("WRONG. TOO HIGH. YOU SUCK. TRY AGAIN!");
						} else if (responseint < answer) {
							Console.WriteLine("WRONG. TOO LOW. YOU SUCK. TRY AGAIN!");
						}
						// prompt user to guess again and capture data 
						Console.Write("Guess a number from 1 to 100: ");
						response = Console.ReadLine();
						parsed = int.TryParse(response, out int r);
						while (!parsed) {
							// if not an acceptable answer, prompt the user to enter again
							Console.WriteLine("THAT IS NOT A NUMBER");
							Console.Write("Guess a number from 1 to 100: ");
							response = Console.ReadLine();
							parsed = int.TryParse(response, out int y);
						}
						responseint = int.Parse(response);
					}
					Console.WriteLine("CONGRATS! YOU GOT IT RIGHT!");
				}
				Console.WriteLine("Would you like to play again? Enter 'yes' if you would.");
				playagain = Console.ReadLine();
			}

			///////////////////////////////////////////////////////////////////////////////

			int idx = 0;
			while (idx < 1000) {
				if(idx % 2 == 0 && idx % 3 == 0 && idx % 7 == 0) {
					Console.WriteLine("The index {0} is div by 2, 3, and 7.", idx);
				}
				idx++;
			}

		}
	}
}
