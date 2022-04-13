using System;
using static System.Console;
using System.Globalization;

class GreenvilleRevenue
{
    //First, run the code for the existing starting code in the debuger to understand how the current code functions. Then, you can start changing the code.
    //Second, use the code in this file to update your starting code.
    //Next, in Visual Studio step through the code to refactor the main method and other methods using and updating Contestant class as needed to per the assignment instructions.

    //Here is the continuation for the instructions from MindTap that were started and numbered below in the Contestant class
    //Modify the GreenvilleRevenue program so that it uses the Contestant class and performs the following tasks:
    //(5)The program prompts the user for the number of contestants in this year’s competition; the number must be between 0 and 30. 
    //(6)The program continues to prompt the user until a valid value is entered.
    //(7)The expected revenue is calculated and displayed. The revenue is $25 per contestant. For example if there were 3 contestants, the expected revenue would be displayed as:
    //Revenue expected this year is $75.00
    //(8)The program prompts the user for names and talent codes for each contestant entered. Along with the prompt for a talent code, display a list of the valid categories.
    //The categories should be displayed in the following format:
    //The types of talent are:
    //S Singing
    //D Dancing
    //M Musical instrument
    //O Other
    //(9)After data entry is complete, the program displays the valid talent categories and then continuously prompts the user for talent codes [and (this next phrase is NOT graded in MindTap) displays the names of all contestants in the category].]
    //(10)Appropriate messages are displayed if the entered code is not a character or a valid code.

    public static void Main()
    {
        //Now, that you have the assignment directions laid out you are ready to edit the code. Before making any changes, comment out the existing Main method code
        //then, copy and paste the commented instructions above into the Main method
        //First, you will need the constants:
        const int ENTRANCE_FEE = 25;
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;

        //Given that we left off with #4 in the Contestant class at the bottom of the file, we will now pickup with #5:
        //(5)The program prompts the user for the number of contestants in this year’s competition; the number must be between 0 and 30. 
        //note that there is not a comparison of this and last year's number of contestants.
        //Use the getContestantNumber method here to get the contestant number variable value. Note that you will use only the 
        //MIN_CONTESTANTS and MAX_CONTESTANTS as input parameters for the getContestantNumber method.
        int contestantNumber = getContestantNumber(MIN_CONTESTANTS, MAX_CONTESTANTS);

        //(7)The expected revenue is calculated and displayed.The revenue is $25 per contestant. For example if there were 3 contestants, the expected revenue would be displayed as:
        //Revenue expected this year is $75.00
        //Here, you will calculate the revenue variable and display that to the user as: Revenue expected this year is $75.00
        int revenue = contestantNumber * ENTRANCE_FEE;
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C"));

        //Now use the Contestant class created below to declare and initialize a array of contestants. Use the MAX_CONTESTANTS constant as the index for the array.
        Contestant[] contestants = new Contestant[MAX_CONTESTANTS];

        //(8)The program prompts the user for names and talent codes for each contestant entered. Along with the prompt for a talent code, display a list of the valid categories.
        //The categories should be displayed in the following format:
        //The types of talent are:
        //S Singing
        //D Dancing
        //M Musical instrument
        //O     Other
        //use the updated getContestantData. Since you are using an array of Contestants, you do not need the input params of 
        //string[] names, char[] talents, char[] talentCodes, and string[] talentCodesStrings as each array index value is in the Contestant object in 
        //the Contestant array. The int[] counts holds counts for each talent type and the Contestant object in the Contestant array will hold those now.
        //So, you need the contestant number and the Contestant array to be passed in the getContestantData method
        getContestantData(contestantNumber, contestants);

        //(9)After data entry is complete, the program displays the valid talent categories and then continuously prompts the user for talent codes and displays the names of all contestants in the category. 
        //Here, as with the getContestantData method, you need the contestant number and the Contestant array to be passed in the getLists method
        //***********************************
        //your code here
        //***********************************
    }

    //5 Refactor the getContestantNumber method removing the "when" input param and its use
    public static int getContestantNumber(int min, int max)
    {
        //***********************************
        //your code here
        //***********************************
        //(6)The program continues to prompt the user until a valid value is entered.

        //this return statement is temporary to allow the project to build and be debugged
        return 0;
    }

    //Since there is no comparison between years, this method can be removed
    //public static void displayRelationship(int numThisYear, int numLastYear)
    //{
    //    if (numThisYear > 2 * numLastYear)
    //        WriteLine("The competition is more than twice as big this year!");
    //    else
    //       if (numThisYear > numLastYear)
    //        WriteLine("The competition is bigger than ever!");
    //    else
    //          if (numThisYear < numLastYear)
    //        WriteLine("A tighter race this year! Come out and cast your vote!");
    //}

    //8. Comment the old method signature and refactor the method with the new signature.
    //public static void getContestantData(int numThisYear, string[] names, char[] talents, char[] talentCodes, string[] talentCodesStrings, int[] counts)
    public static void getContestantData(int numThisYear, Contestant[] contestants)
    {
        int x = 0;
        bool isValid;
        char talent;
        while (x < numThisYear)
        {
            //***********************************
            //your code here
            //***********************************
        }
    }

    //9 Comment the old method signature and refactor the method with the new signature.
    //public static void getLists(int numThisYear, char[] talentCodes, string[] talentCodesStrings, string[] names, char[] talents, int[] counts)
    public static void getLists(int numThisYear, Contestant[] contestants)
    {
        int x;
        char QUIT = 'Z';
        char option;
        bool isValid;
        int pos = 0;
        bool found;
        WriteLine("\nThe types of talent are:");
        for (x = 0; x < Contestant.talentStrings.Length; ++x)
            WriteLine("{0, -5}  {1, -20}", Contestant.talentCodes[x], Contestant.talentStrings[x]);
        Write("\nEnter a talent type or {0} to quit >> ", QUIT);
        isValid = false;
        while (!isValid)
        {
            if (!char.TryParse(ReadLine(), out option))
            {
                isValid = false;
                //10 Appropriate messages are displayed if the entered code is not a character or a valid code.
                WriteLine("Invalid format - entry must be a single character");
                Write("\nEnter a talent type or {0} to quit >> ", QUIT);
            }
            else
            {
                //***********************************
                //your code here
                //***********************************
            }
        }
    }
}

class Contestant
{
    //I have taken the instructions and divided them into numbered sections. Look at the sections in the class by number as they apply to the instructions.
    //(1)The Contestant class contains public static arrays that hold talent codes and descriptions.Recall that the talent categories are Singing, Dancing, Musical instrument, and Other. Name these fields talentCodes and talentStrings respectively.
    //(2)The class contains an auto-implemented property Name that holds a contestant’s name.
    //(3a)The class contains fields for a talent code(talentCode) and description(talent). (3b) The set accessor for the code assigns a code only if it is valid. (3c)Otherwise, it assigns I for Invalid.
    //(4)The talent description is a read-only property that is assigned a value when the (talent) code is set.

    //1. pulled these from the Main method
    public static char[] talentCodes = { 'S', 'D', 'M', 'O' };
    public static string[] talentStrings = { "Singing", "Dancing", "Musical instrument", "Other" };

    //2. pages 365 - 366
    //public string Name
    //{
    //    get { return Name; }
    //    set { Name = value; }
    //}
    //or
    public string Name { get; set; }

    private char talentCode;//3a
    private string talent;//4
    //3a. Create the property like GradePointAverage on p. 369. Note the private class variable that is used in the set and get routine on p. 368
    public char TalentCode
    {
        get
        {
            return talentCode;
        }
        set
        {
            //3b
            //The set accessor for the code assigns a code only if it is valid (See on page 369 #4 of the You Do It section). Also, use a for loop to iterate the talentCodes array 
            //***********************************
            //your code here
            //***********************************
        }
    }

    //4
    public string Talent
    {
        get
        {
            return talent;
        }
    }
}