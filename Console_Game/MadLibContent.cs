using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Vacation
    {
        public Vacation() { }

        public Vacation(string place, string verb, string animal, string celebrity, string familyMember, string naturalDisaster, string comicHero, string adjectiveOne, string comicVillain, string adjectiveTwo, string familyMemberTwo)
        {

            Place = place;
            Verb = verb;
            Animal = animal;
            Celebrity = celebrity;
            FamilyMember = familyMember;
            NaturalDisaster = naturalDisaster;
            ComicHero = comicHero;
            ComicVillain = comicVillain;
            AdjectiveOne = adjectiveOne;
            AdjectiveTwo = adjectiveTwo;
            FamilyMemberTwo = familyMemberTwo;

        }

        public string Place { get; set; }
        public string Verb { get; set; }
        public string Animal { get; set; }
        public string Celebrity { get; set; }
        public string FamilyMember { get; set; }
        public string FamilyMemberTwo { get; set; }
        public string NaturalDisaster { get; set; }
        public string ComicHero { get; set; }
        public string ComicVillain { get; set; }
        public string AdjectiveOne { get; set; }
        public string AdjectiveTwo { get; set; }

        public string GetVacationScript()
        {
            return $"When I was on vaction at {Place} I {Verb} into {Celebrity} who was out walking their pet {Animal}.";
        }

        public string GetVacationScript2()
        {
            return $"My {FamilyMember} took a vacation to Belarus, and while there, a {NaturalDisaster} happened! According to her, it was {AdjectiveOne}, and {AdjectiveTwo}!";
        }

        public string GetVacationScript3()
        {
            return $"When I went on vacation to {Place} with {FamilyMember}, {ComicVillain} tried to ruin it by kidnapping {FamilyMemberTwo}! Thank gosh {ComicHero} swooped in and saved the day!";
        }
    }


    public class AtWork
    {
        public AtWork() { }

        public AtWork(string verb, string task, string name, string officeSupplies, string IngVerb, string PresidentName, string SongName, string Item, string Sentence, string FoodItem, string Adjective)
        {

            Verb = verb;
            Task = task;
            Name = name;
            OfficeSupplies = officeSupplies;
        }

        public string Verb { get; set; }
        public string Task { get; set; }
        public string Name { get; set; }
        public string OfficeSupplies { get; set; }
        public string IngVerb { get; set; }
        public string PresidentName { get; set; }
        public string SongName { get;  set; }
        public string Item { get; set; }
        public string Sentence { get; set; }
        public string FoodItem { get; set; }
        public string Adjective { get; set; }

        public string GetAtWorkScript()
        {
            return $"I was at work {Task}, when {Name} arrived, stole my {OfficeSupplies}, and {Verb} away laughing.";
        }

        public string GetAtWorkScript2()
        {
            return $"The new guy, {Name} and I, were {IngVerb} at the water cooler when Milton ran by and slipped on {FoodItem}! It was {Adjective}!";
        }

        public string GetAtWorkScript3()
        {
            return $"The other day at work {PresidentName} crashed into the office, sang {SongName} while attacking our printer with an {Item}! My boss managed to get them out by saying '{Sentence}'.";
        }
    }

    public class AtTheBallpark
    {
        public AtTheBallpark() { }

        public AtTheBallpark(string nameOfPark, string food, string playerName, string noun, string teamName, string mascotName, string mascotCharacter, string altMascot, string luxuryCar, string carPart, string businessName, string birdType)
        {
            NameOfPark = nameOfPark;
            Food = food;
            PlayerName = playerName;
            Noun = noun;
            TeamName = teamName;
            MascotName = mascotName;
            MascotCharacter = mascotCharacter;
            AltMascot = altMascot;
            LuxuryCar = luxuryCar;
            CarPart = carPart;
            BusinessName = businessName;
            BirdType = birdType;
        }

        public string NameOfPark { get; set; }
        public string Food { get; set; }
        public string PlayerName { get; set; }
        public string Noun { get; set; }
        public string TeamName { get; set; }
        public string MascotName { get; set; }
        public string MascotCharacter { get; set; }
        public string AltMascot { get; set; }
        public string LuxuryCar { get; set; }
        public string CarPart { get; set; }
        public string BusinessName { get; set; }
        public string BirdType { get; set; }

        public string GetBallparkScript()
        {
            return $"I was at {NameOfPark}, and enjoying a nice {Food} when {PlayerName} hit a {Noun}! That was exciting!";
        }

        public string GetBallparkScript2()
        {
            return $"The new baseball team in our town, {TeamName}, just unveiled their new mascot '{MascotName}' who is supposed to be a{MascotCharacter}, but I think it looks more like a {AltMascot}!";
        }

        public string GetBallparkScript3()
        {
            return $"At the ballgame the other day, a foul ball flew out of the park, and hit someone's {LuxuryCar}, breaking their {CarPart}! I'm sure that's an expensive one! The next ball ended up flying and smashing a window outside of {BusinessName}, when a flock of {BirdType} flew in and started terrorizing the customers!";
        }
    }

    public class AtSchool
    {
        public AtSchool() { }

        public AtSchool(string gradeLevel, string subject, string teacher, string adjective, string dessert, string insect, string exclamation, string lunchLady, string presentation, string classmate, string actionVerb, string songName)
        {
            GradeLevel = gradeLevel;
            Subject = subject;
            Teacher = teacher;
            Adjective = adjective;
            Dessert = dessert;
            Insect = insect;
            Exclamation = exclamation;
            LunchLady = lunchLady;
            Presentation = presentation;
            Classmate = classmate;
            ActionVerb = actionVerb;
            SongName = songName;
        }

        public string GradeLevel { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public string Adjective { get; set; }
        public string Dessert { get; set; }
        public string Insect { get; set; }
        public string Exclamation { get; set; }
        public string LunchLady { get; set; }
        public string Presentation { get; set; }
        public string Classmate { get; set; }
        public string ActionVerb { get; set; }
        public string SongName { get; set; }

        public string GetSchoolScript()
        {
            return $"I am in {GradeLevel}th grade, and this {Subject} class is SUPER hard. Luckily my teacher, {Teacher} is super {Adjective}.";
        }

        public string GetSchoolScript2()
        {
            return $"At school the other day, the cafeteria had {Dessert} for dessert! I took one bite of it though and found a {Insect} right in the middle of it! I shouted '{Exclamation}' and YEETed it back in {LunchLady}'s face.";
        }

        public string GetSchoolScript3()
        {
            return $"I was presenting my project on {Presentation} when {Classmate} suddenly started {ActionVerb} to the tune of {SongName}. Soon after the rest of the class joined in, and I never got to finish my presentation.";
        }
    }
}

