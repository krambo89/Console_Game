using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class MadLibUI
    {
        private bool _IsRunning = true;

        public MadLibUI() { }
        public void Start()
        {
            MainMenu();

        }

        public void MainMenu()
        {
            while (_IsRunning)
            {
                string userInput = GetScenarios();
                ScenarioTypes(userInput);
            }
        }

        private string GetScenarios()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Mad Libs! \n" +
                    "Please Choose A Scenario: \n" +
                    "1. Vacation \n" +
                    "2. At Work \n" +
                    "3. At The Ballpark \n" +
                    "4. At School");
            string userInput = Console.ReadLine();
            return userInput;

        }

        private void ScenarioTypes(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Oh fun! A vacation! Press Enter to continue.");
                    RandomVacation();
                    break;

                case "2":
                    Console.WriteLine("Just another Monday...");
                    RandomAtWork();
                    break;

                case "3":
                    Console.WriteLine("Take me out to the ballpark!");
                    RandomAtBallpark();
                    break;

                case "4":
                    Console.WriteLine("Is it Summer yet?");
                    RandomAtSchool();
                    break;

                default:
                    Console.WriteLine("We do not recognize that answer, please choose 1-4. Hit Enter to return to Main Menu.");
                    Console.ReadLine();
                    return;
            }


            Console.ReadKey();
        }

        private void RandomVacation()
        {
            Random rnd = new Random();
            int scenario = rnd.Next(1, 4);

            switch (scenario)
            {
                case 1:
                    VacationScript();
                    break;
                case 2:
                    VacationScript2();
                    break;
                case 3:
                    VacationScript3();
                    break;

            }

        }

        private void VacationScript()
        {
            Vacation vacation = new Vacation();
            Console.WriteLine("Please list a place.");
            vacation.Place = Console.ReadLine();


            Console.WriteLine("Please select a verb (past tense).");
            vacation.Verb = Console.ReadLine();

            Console.WriteLine("Please name a Celebrity.");
            vacation.Celebrity = Console.ReadLine();

            Console.WriteLine("Please name an animal.");
            vacation.Animal = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine(vacation.GetVacationScript());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");
        }

        private void VacationScript2()
        {
            Vacation vacation = new Vacation();
            Console.WriteLine("Please select a family member.");
            vacation.FamilyMember = Console.ReadLine();


            Console.WriteLine("Please select a Natural Disaster).");
            vacation.NaturalDisaster = Console.ReadLine();

            Console.WriteLine("Please select an adjective.");
            vacation.AdjectiveOne = Console.ReadLine();

            Console.WriteLine("Please select an adjective.");
            vacation.AdjectiveTwo = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(vacation.GetVacationScript2());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");
        }

        private void VacationScript3()
        {
            Vacation vacation = new Vacation();
            Console.WriteLine("Please select a Place.");
            vacation.FamilyMember = Console.ReadLine();

            Console.WriteLine("Please select a Family Member.");
            vacation.FamilyMember = Console.ReadLine();

            Console.WriteLine("Please select a Comic Book Villain).");
            vacation.ComicVillain = Console.ReadLine();

            Console.WriteLine("Please select another Family Member.");
            vacation.FamilyMemberTwo = Console.ReadLine();

            Console.WriteLine("Please select a Comic Book Hero.");
            vacation.ComicHero = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(vacation.GetVacationScript3());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");
        }

        private void RandomAtWork()
        {
            Random rnd = new Random();
            int scenario = rnd.Next(1, 4);

            switch (scenario)
            {
                case 1:
                    AtWorkScript();
                    break;
                case 2:
                    AtWorkScript2();
                    break;
                case 3:
                    AtWorkScript3();
                    break;

            }

        }

        private void AtWorkScript()
        {
            AtWork atWork = new AtWork();
            Console.WriteLine("Name a Co-Worker.");
            atWork.Name = Console.ReadLine();


            Console.WriteLine("Name a verb (past tense).");
            atWork.Verb = Console.ReadLine();

            Console.WriteLine("Please name a office task.");
            atWork.Task = Console.ReadLine();

            Console.WriteLine("Please name an office supply.");
            atWork.OfficeSupplies = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(atWork.GetAtWorkScript());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");
        }

        private void AtWorkScript2()
        {
            AtWork atWork = new AtWork();
            Console.WriteLine("Name a Name.");
            atWork.Name = Console.ReadLine();


            Console.WriteLine("Name a verb ending with 'ing'.");
            atWork.IngVerb = Console.ReadLine();

            Console.WriteLine("Please name a food.");
            atWork.FoodItem = Console.ReadLine();

            Console.WriteLine("Please name an adjective.");
            atWork.Adjective = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(atWork.GetAtWorkScript2());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");
        }

        private void AtWorkScript3()
        {
            AtWork atWork = new AtWork();
            Console.WriteLine("Name a President.");
            atWork.PresidentName = Console.ReadLine();


            Console.WriteLine("Name a song.");
            atWork.SongName = Console.ReadLine();

            Console.WriteLine("Please name Item.");
            atWork.Item = Console.ReadLine();

            Console.WriteLine("Please write a wacky sentence asking someone to leave.");
            atWork.Sentence = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(atWork.GetAtWorkScript3());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");
        }

        private void RandomAtBallpark()
        {
            Random rnd = new Random();
            int scenario = rnd.Next(1, 3);

            switch (scenario)
            {
                case 1:
                    AtBallparkScript();
                    break;
                case 2:
                    AtBallparkScript2();
                    break;
                case 3:
                    AtBallparkScript3();
                    break;

            }

        }

        private void AtBallparkScript()
        {
            AtTheBallpark atBallpark = new AtTheBallpark();
            Console.WriteLine("Please list the name of the Ballpark.");
            atBallpark.NameOfPark = Console.ReadLine();

            Console.WriteLine("Please name a food.");
            atBallpark.Food = Console.ReadLine();

            Console.WriteLine("Please name a baseball player.");
            atBallpark.PlayerName = Console.ReadLine();

            Console.WriteLine("Please name a type of hit in baseball.");
            atBallpark.Noun = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(atBallpark.GetBallparkScript());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");
        }

        private void AtBallparkScript2()
        {
            AtTheBallpark atBallpark = new AtTheBallpark();
            Console.WriteLine("Please give a Team Name.");
            atBallpark.TeamName = Console.ReadLine();

            Console.WriteLine("Please name a Mascot.");
            atBallpark.MascotName = Console.ReadLine();

            Console.WriteLine("Please name a Mascot Charecter.");
            atBallpark.MascotCharacter = Console.ReadLine();

            Console.WriteLine("Please name another Mascot.");
            atBallpark.AltMascot = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(atBallpark.GetBallparkScript2());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");

        }

        private void AtBallparkScript3()
        {
            AtTheBallpark atBallpark = new AtTheBallpark();
            Console.WriteLine("Please name a luxury car.");
            atBallpark.LuxuryCar = Console.ReadLine();

            Console.WriteLine("Please name a car part.");
            atBallpark.CarPart = Console.ReadLine();

            Console.WriteLine("Please name a Business name.");
            atBallpark.BusinessName = Console.ReadLine();

            Console.WriteLine("Please name a bird tpye.");
            atBallpark.BirdType = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(atBallpark.GetBallparkScript3());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");
        }

        private void RandomAtSchool()
        {
            Random rnd = new Random();
            int scenario = rnd.Next(1, 3);

            switch (scenario)
            {
                case 1:
                    AtSchoolScript();
                    break;
                case 2:
                    AtSchoolScript2();
                    break;
                case 3:
                    AtSchoolScript3();
                    break;

            }

        }
        private void AtSchoolScript()
        {
            AtSchool atSchool = new AtSchool();
            Console.WriteLine("Please list a grade level");
            atSchool.GradeLevel = Console.ReadLine();

            Console.WriteLine("Please name a class subject.");
            atSchool.Subject = Console.ReadLine();

            Console.WriteLine("Please list a Teacher's name. Please include Mr. or Mrs.");
            atSchool.Teacher = Console.ReadLine();

            Console.WriteLine("Please write an adjective.");
            atSchool.Adjective = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(atSchool.GetSchoolScript());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");

        }

        private void AtSchoolScript2()
        {
            AtSchool atSchool = new AtSchool();
            Console.WriteLine("Please list a Dessert");
            atSchool.Dessert = Console.ReadLine();

            Console.WriteLine("Please name an Insect.");
            atSchool.Insect = Console.ReadLine();

            Console.WriteLine("Please list an Exclaimation statement");
            atSchool.Exclamation = Console.ReadLine();

            Console.WriteLine("Please name a Lunch Lady.");
            atSchool.LunchLady = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(atSchool.GetSchoolScript2());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");

        }

        private void AtSchoolScript3()
        {
            AtSchool atSchool = new AtSchool();
            Console.WriteLine("Please name a subject for your presentation");
            atSchool.Presentation = Console.ReadLine();

            Console.WriteLine("Please name Classmate.");
            atSchool.Classmate = Console.ReadLine();

            Console.WriteLine("Please list an action verb");
            atSchool.ActionVerb = Console.ReadLine();

            Console.WriteLine("Please name a Song.");
            atSchool.SongName = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(atSchool.GetSchoolScript3());
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to play again.");

        }
    }
}
