using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week6_ProjectDay
{
    class Program
    {

        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Ultimate Minute Meeting Nightmare \n**************************************************\n\n");
            string[] menuItems = { "Create Meeting", "View Teamsters", "Exit" };
            int counter = 1;
            foreach(string item in menuItems)
            {
                Console.WriteLine($"{counter}. {item}");
                counter++;
            }

            Console.WriteLine("Select number for desired option: ");
            string menuOption = Console.ReadLine();
            switch(menuOption)
            {
                case "1":
                    Console.Clear();
                    CreateFile();
                    break;
                case "2":
                    Console.Clear();
                    Teamsters();
                    break;
                case "3":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid selection, please input desired option: ");
                    Console.ReadKey();
                    Menu();
                    break;
            }

        }

        static void CreateFile()
        {
            Console.WriteLine("Ultimate Minute Meeting Nightmare \n**************************************************\n\n");
            List<string> fileContents = new List<string>(){
                "Planet Iron Gym",
                "14209 Nebula Lane, Cleveland, Ohio, 44112",
                "Meeting Minutes"};
            Console.WriteLine("Enter date (using MMDDYY): ");
            string date = Console.ReadLine();
            Console.WriteLine("Enter name of teamster recording minutes: ");
            string recorder = Console.ReadLine();
            Console.WriteLine("Enter name of the teamster leading the meeting: ");
            string lead = Console.ReadLine();
            MeetingType();
            Console.WriteLine("Enter meeting type: ");
            string meeting = Console.ReadLine();
            string meetingType = "";
            while (true)
            {
                if (meeting == "1")
                {
                    Console.WriteLine("Sale Team");
                    meetingType = "Sales Team";
                    break;
                }
                else if (meeting == "2")
                {
                    Console.WriteLine("Fitness Team");
                    meetingType = "Fitness Team";
                    break;
                }
                else if (meeting == "3")
                {
                    Console.WriteLine("Management Team");
                    meetingType = "Management Team";
                    break;
                }
                else if (meeting == "4")
                {
                    Console.WriteLine("All Team");
                    meetingType = "All Team";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Selection");
                    break;
                }
            }

            Console.WriteLine("Enter Meeting Topic: ");
            string meetTopic = Console.ReadLine();
            Console.WriteLine("Enter Notes:");
            string notes = Console.ReadLine();
            fileContents.Add(recorder);
            fileContents.Add(lead);
            fileContents.Add(meetingType);
            fileContents.Add(meetTopic);
            fileContents.Add(notes);
            fileContents.Add("");
            fileContents.Add("");

            while (true)
            {
                Console.WriteLine("Would you like to add another topic (y\n)");
                string topicSelection = Console.ReadLine();
                if (topicSelection.ToLower() == "y")
                {
                    Console.WriteLine("Enter Meeting Topic: ");
                    meetTopic = Console.ReadLine();
                    Console.WriteLine("Enter Notes:");
                    notes = Console.ReadLine();
                    fileContents.Add(meetTopic);
                    fileContents.Add(notes);
                }
                else if (topicSelection.ToLower()== "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection, please enter (y\n)");
                }
            }

            string fileDate = "Minutes" + date + ".txt";
            string[] FileHeader = { "Planet Iron Gym", "14209 Nebula Lane, Cleveland, Ohio, 44112", "Meeting Minutes" };
            using (StreamWriter writer = new StreamWriter(fileDate))
            {
                foreach(string file in fileContents)
                {
                    writer.WriteLine(file);

                }

            }

            

        }

        static void MeetingType()
        {
            List<string> meetingType = new List<string>() { "Sales Team", "Fitness Team", "Management Team", "All Teams" };
            int counter = 1;
            foreach(string team in meetingType)
            {
                Console.WriteLine($"{counter}. {team}");
                counter++;
            }
        }

        static void Teamsters()
        {
            Console.WriteLine("Ultimate Minute Meeting Nightmare \n**************************************************\n\n");
            Dictionary<string, string> teammates = new Dictionary<string, string>()
            {
                //Sales Team
                { "(Sales Team1)","Bob Jones" },
                { "(Sales Team2)","Suzy Cues"},
                { "(Sales Team3)","Tom Hawkins"},
                //Fitness Team
                { "(Fitness Team1)","Al Vega"},
                { "(Fitness Team2)","Jake Lock"},
                { "(Fitness Team3)","Gabby Marie"},
            //Management Team
                { "(Management Team1)", "Chrissy Griff" },
                { "(Management Team2)","Luke Adams"},
                { "(Management Team3)", "Mike Johnson" }
            
            };
            List<string> namesTeam = new List<string>(teammates.Keys);
            string[] teams = { "Sales Team", "Fitness Team", "Management Team", "All Teams"};
            int counter = 1;
            foreach (string team in teams)
            {
                Console.WriteLine($"{counter}. {team}");
                counter++;
            }

            Console.WriteLine("Select number for desired option: ");
            string teamOption = Console.ReadLine();
            switch (teamOption)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Sales Team \n---------------------------------");
                    Console.WriteLine("Bob Jones");
                    Console.WriteLine("Suzy Cue");
                    Console.WriteLine("Tom Hawkins");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Fitness Team \n---------------------------------");
                    Console.WriteLine("Al Vega");
                    Console.WriteLine("Jake Lock");
                    Console.WriteLine("Gabby Marie");
                    Console.ReadKey();
                    break;
                case "3":
                     Console.Clear();
                    Console.WriteLine("Management Team \n---------------------------------");
                    Console.WriteLine("Chrissy Griff");
                    Console.WriteLine("Luke Adams");
                    Console.WriteLine("Mike Johnson");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("All Teams \n------------------------------");
                    foreach (KeyValuePair<string, string> names in teammates)
                    {
                        Console.WriteLine(names);
                    }
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid selection: ");
                    Console.ReadKey();
                    break;
            }
            Menu();
           
        }

        static void Exit()
        {
            Console.WriteLine("Ultimate Minute Meeting Nightmare \n**************************************************\n\n");
            Console.WriteLine("GoodBye!");
            Console.ReadKey();
        }

    }

}
 