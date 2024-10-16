using System; 

     class Program
{
    static string name;

    static string age;

    static string eyeColor;

    static string hairColor;

    static string shoeSize;

    static string favColor;

    static string favShow;

    static string favTeacher;

    static string favClass;

    static string favHoliday;

    static string favSeason;

    static string dreamJob;

    static string howMany;

    static int number;



        public static void Main(string[] args)
        
    {
        
            AskName();


        AskAge();


        AskEyeColor();

        AskShoeSize();

        AskFavColor();

        AskFavShow();

        AskFavTeacher();

        AskFavClass();

        AskFavHoliday();

        AskFavSeason();

        AskDreamJob();

        CalculateAgeIn5Years();

        AskHowMany();

        DisplaySummaryMessage();


        
    }

        public static void AskName() {

            Console.WriteLine("What is your name?");
         name = Console.ReadLine();

        }

        public static void AskAge() {

            Console.WriteLine("What is your age?");
         age = Console.ReadLine();

        }


        public static void AskEyeColor() {

            Console.WriteLine("What is your eye color?");
           eyeColor = Console.ReadLine();

        }


        public static void AskHairColor() {

             Console.WriteLine("What is your hair color?");
         hairColor = Console.ReadLine();

        }

        public static void AskShoeSize() {

             Console.WriteLine("What about your shoe size?");
         shoeSize = Console.ReadLine();

        }


        public static void AskFavColor() {

            Console.WriteLine("Favorite color?");
         favColor = Console.ReadLine();

        }


        public static void AskFavShow() {

            Console.WriteLine("What's your favorite show or movie?");
         favShow = Console.ReadLine();

        }


        public static void AskFavTeacher() {

            Console.WriteLine("Who is your favorite teacher?");
         favTeacher = Console.ReadLine();

        }


        public static void AskFavClass() {

            Console.WriteLine("Your Favorite class?");
         favClass = Console.ReadLine();

        }


        public static void AskFavHoliday() {

            Console.WriteLine("Yer favite Oliday?");
         favHoliday = Console.ReadLine();

        }


        public static void AskFavSeason() {

            Console.WriteLine("What Season do you prefer?");
         favSeason = Console.ReadLine();

        }


        public static void AskDreamJob() {

            Console.WriteLine("Dream Job?");
         dreamJob = Console.ReadLine();

        }


        public static void AskHowMany() {

            Console.WriteLine("How many siblings you got?");
         howMany = Console.ReadLine();
            
        }

        public static void DisplaySummaryMessage() {

            Console.WriteLine("Your name is " + name + " and you are " + age + " years old currently. Your eye color is " + eyeColor + " and hair color is " + hairColor 
        + " unless you are bald. Your shoe size is " + shoeSize + " and your favorite color is " + favColor + " while your favorite show or movie is " + favShow 
        + "? very cool. Your favorite Teacher is " + favTeacher + " but your favorite class is " + favClass + ". Your favorite holiday is " + favHoliday 
        + " but your favorite season is " + favSeason + ". You want your job to be " + dreamJob + " and you have " + howMany + " siblings. You will be " + number 
        + " years old in 5 years by the way.");


        }


        public static void CalculateAgeIn5Years() {

            int num = int.Parse(age);
            number = num + 5;

        }

}


