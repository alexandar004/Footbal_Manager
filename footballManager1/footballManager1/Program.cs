using System;

namespace footballManager1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var team1 = new Team();
            team1.Name = "Chelsea";
            team1.Strenght = 7;
            team1.Manager = new Manager()
            {
                Name = "Gosho",
                YearExpririence = 10
            };
            team1.HomeStadium = "Stanford";


            var team2 = new Team();
            Console.WriteLine("Enter the name of first team");
            team2.Name = Console.ReadLine();
            Console.WriteLine("Enter the strength of the first team");
            team2.Strenght = int.Parse(Console.ReadLine());
            team2.Manager = new Manager()
            {
                Name = "Gosho",
                YearExpririence = 10
            };
            team2.HomeStadium = "Stanford";


            //var manager = new Manager() { Name = "Pesho", Loses = 3, Wins = 34, YearExpririence = 7 };
            //var team2 = new Team("Manchester", 8, "Anfield", manager);

            PlayGame(team1, team2, "Stanford");
        }

    static void PlayGame(Team firstTeam, Team secondTeam, string stadium)
    {
            double firstTeamScore = 0;
            double secondTeamScore = 0;

            if (firstTeam.HomeStadium == stadium)
            {
                firstTeamScore++;
            }
            else if( secondTeam.HomeStadium == stadium)
            {
                secondTeamScore++;
            }

            firstTeamScore += firstTeam.Strenght;
            secondTeamScore += secondTeam.Strenght;

            // Add Manager experience
            firstTeamScore += firstTeam.Manager.YearExpririence * 0.2;
            secondTeamScore += secondTeam.Manager.YearExpririence * 0.2;

            // Add random number 
            var random = new Random();
            firstTeamScore += random.Next(1, 10) * 0.3;
            secondTeamScore += random.Next(1, 10) * 0.3;


            if (firstTeamScore > secondTeamScore)
            {
                Console.WriteLine($"The winner is {firstTeam.Name} ");
            }
            else if(firstTeamScore < secondTeamScore)
            {
                Console.WriteLine($"The winner is {secondTeam.Name} ");
            }
            else
            {
                Console.WriteLine($"The result are equal");
            } 
        }
}
}