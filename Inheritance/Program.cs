using System;

namespace Inheritance
{
    class Program
    {

        public static void PrintPetInformation(Bird myPet, string petName)
        {
            
            Console.WriteLine($"My pet's name is {petName} and it is a {myPet.Species}. " +
                $"It has {myPet.NumberOfLegs} legs, eats {myPet.FoodSource}, and has {myPet.IntegumentaryType}. " +
                $"It is a {myPet.TypeOfBird} that {myPet.TalkString}, {myPet.FlyString}, and {myPet.NestString}.");
        }

        public static void PrintPetInformation(Reptile myPet, string petName)
        {
            Console.WriteLine($"My pet's name is {petName} and it is a {myPet.Species}. " +
             $"It has {myPet.NumberOfLegs} legs, eats {myPet.FoodSource}, and has {myPet.IntegumentaryType}. " +
             $"It is a {myPet.TypeOfReptile} that {myPet.MovesOnBellyString}, {myPet.LivesInWaterString}, " +
             $"and {myPet.CamoflaugeString}.");
        }


        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes


            var petBird = new Bird();
            var petReptile = new Reptile();
            string parrotName = "Polly";
            string chameleonName = "Espio";


            //Bird Section
            petBird.Species = "bird";
            petBird.NumberOfLegs = 2;
            petBird.FoodSource = "bird seed";
            petBird.IntegumentaryType = "feathers";
            petBird.TypeOfBird = "parrot";
            petBird.CanTalk = true;
            petBird.CanFly = true;
            petBird.HasNest = false;
            PrintPetInformation(petBird, parrotName);

            //Reptile Section
            petReptile.Species = "reptile";
            petReptile.NumberOfLegs = 4;
            petReptile.FoodSource = "worms";
            petReptile.IntegumentaryType = "scales";
            petReptile.TypeOfReptile = "chameleon";
            petReptile.MovesOnBelly = false;
            petReptile.CanCamoflauge = true;
            petReptile.LivesInWater = false;
            PrintPetInformation(petReptile, chameleonName);

            /*Create an object of your Bird class
             public string Species { get; set; }
		    public int NumberOfLegs { get; set; }
		    public string FoodSource { get; set; }
		    public string IntegumentaryType { get; set; } // Feathers, Scales, Hair, etc...


            public bool CanTalk { get; set; }
		    public bool CanFly { get; set; }
		    public string TypeOfBird { get; set; }
		    public bool HasNest { get; set; }

            Create an object of your Reptile class
             public string TypeOfReptile { get; set; }
		    public bool MovesOnBelly { get; set; }
		    public bool CanCamoflauge { get; set; }
		    public bool LivesInWater { get; set; } */
        }
    }
}
