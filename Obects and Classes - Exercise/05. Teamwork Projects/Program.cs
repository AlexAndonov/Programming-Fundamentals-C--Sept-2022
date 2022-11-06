namespace _05._Teamwork_Projects
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = newTeam[0];
                string teamName = newTeam[1];

                Team team = new Team(teamName, creator);

                bool doesTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool doesCreatorExist = teams.Select(x => x.Creator).Contains(creator);

                if (!doesTeamExist)
                {
                    if (!doesCreatorExist)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");  
                }
            }

            string teamMembers;
            while ((teamMembers = Console.ReadLine()) != "end of assignment")
            {
                string[] cmndArgs = teamMembers.Split("->");
                string newUser = cmndArgs[0];
                string teamName = cmndArgs[1];

                bool doesTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool doesCreatorExist = teams.Select(x => x.Creator).Contains(newUser);
                bool doesMemberExist = teams.Select(x => x.Members).Any(x => x.Contains(newUser));

                if (!doesTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (doesCreatorExist || doesMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(newUser);
                }
            }

            Team[] teamsToDisband = teams.OrderBy(x => x.TeamName)
                                         .Where(x => x.Members.Count == 0)
                                         .ToArray();

            Team[] otherTeams = teams.OrderByDescending(x => x.Members.Count)
                                     .ThenBy(x => x.TeamName)
                                     .Where(x => x.Members.Count > 0)
                                     .ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (Team team in otherTeams)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }

            sb.AppendLine("Teams to disband:");
            foreach (Team team in teamsToDisband)
            {
                sb.AppendLine(team.TeamName);
            }

            Console.WriteLine(sb.ToString());
        }
    }
    public class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}
