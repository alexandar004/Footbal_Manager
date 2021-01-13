using System;

namespace footballManager1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var teams = new Team[4];

            teams[0] = new Team() { Name = "Chelsea", Strenght = 5 , HomeStadium="Stanford", Manager = new Manager() 
            {
                Name= "Frank Lampard",
                Wins= 67,
                YearExpririence = 5,
                Loses = 21,
            }};
            teams[1] = new Team() { Name = "FC Bayern Munchen", Strenght = 6, HomeStadium = "Alianz Arena", Manager = new Manager()
            {
                Name = "Hans-Dieter Flick",
                Wins = 56,
                YearExpririence = 6,
                Loses = 24,
            }};
            teams[2] = new Team() { Name = "Real Madrid", Strenght = 4, HomeStadium = "Santiago", Manager = new Manager()
            { 
                Name = "Zinedine Zidane",
                Wins = 70,
                YearExpririence = 4,
                Loses = 21,
            } };
            teams[3] = new Team() { Name = "PSG", Strenght = 7, HomeStadium = "Parc des Princes", Manager = new Manager()
            { 
                Name = "Mauricio Pochettino",
                Wins = 76,
                YearExpririence = 5,
                Loses = 17,
            } };


            Console.WriteLine("Choose a team: ");
            for (int i = 0; i < teams.Length; i++)
            {
                Console.WriteLine($"Select {i + 1} for {teams[i].Name} ");
            }

            var selectedTeamIndex = int.Parse(Console.ReadLine()) -1;

            Console.WriteLine("Choose a oponent team: ");
            
            for (int i = 0; i < teams.Length; i++)
            {
                if (i != selectedTeamIndex)
                {
                    Console.WriteLine($"Select {i + 1} for {teams[i].Name} ");
                }
                else
                {
                    Console.WriteLine("This team has already been selected");
                }
            }

            var oponentTeamIndex = int.Parse(Console.ReadLine()) - 1;


            Console.WriteLine("Type the name of the stadion: ");

            var stadium = Console.ReadLine();

            PlayGame(teams[selectedTeamIndex], teams[oponentTeamIndex], stadium);

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
            Console.WriteLine($"The score is {Math.Round(firstTeamScore)} : {Math.Round(secondTeamScore)}.");

        }
    }
}