using Xunit;
using System.IO;
using System;
using System.Text;

public class TestAssign7BCase9_1
{

    [Fact]
    public void TestCase()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);

        //Sets the In property to the specified TextReader object. System.IO.StringReader is derived
        //from TextReader. The TextReader class is an abstract class. Therefore, you do not instantiate 
        //it in your code.
        //The StreamReader class derives from TextReader and provides implementations of the 
        //members for reading from a stream.
        //Use case 1
        var contestantNumber = "3";
        var contestant1Name = "Jill";
        var contestant1TalentCode = "S";
        var contestant2Name = "Mikia";
        var contestant2TalentCode = "M";
        var contestant3Name = "Sarah";
        var contestant3TalentCode = "D";
        var firstTalentCodeToObserve = "S";
        var secondTalentCodeToObserve = "D";
        var thirdTalentCodeToObserve = "M";
        var fourthTalentCodeToObserve = "O";
        var endInput = "Z";
        //separte multiple inputs with a new line break
        var stringReaderInput = new StringBuilder();
        stringReaderInput.Append(contestantNumber);
        stringReaderInput.Append(Environment.NewLine);
        //contestant 1
        stringReaderInput.Append(contestant1Name);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(contestant1TalentCode);
        stringReaderInput.Append(Environment.NewLine);
        //contestant 2
        stringReaderInput.Append(contestant2Name);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(contestant2TalentCode);
        stringReaderInput.Append(Environment.NewLine);
        //contestant 3
        stringReaderInput.Append(contestant3Name);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(contestant3TalentCode);
        stringReaderInput.Append(Environment.NewLine);
        //talent code entries to observe the contestant(s) with that talent
        stringReaderInput.Append(firstTalentCodeToObserve);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(secondTalentCodeToObserve);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(thirdTalentCodeToObserve);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(fourthTalentCodeToObserve);
        stringReaderInput.Append(Environment.NewLine);
        //end input
        stringReaderInput.Append(endInput);

        var input = new StringReader(stringReaderInput.ToString());
        Console.SetIn(input);
        
        GreenvilleRevenue.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.Append("Enter number of contestants >> ");
        expectedOutcome.AppendLine("Revenue expected this year is $75.00");
        expectedOutcome.Append("Enter contestant name >> ");
        expectedOutcome.AppendLine("Talent codes are:");
        expectedOutcome.AppendLine("  S   Singing");
        expectedOutcome.AppendLine("  D   Dancing");
        expectedOutcome.AppendLine("  M   Musical instrument");
        expectedOutcome.AppendLine("  O   Other");
        expectedOutcome.Append("       Enter talent code >> ");
        expectedOutcome.Append("Enter contestant name >> ");
        expectedOutcome.AppendLine("Talent codes are:");
        expectedOutcome.AppendLine("  S   Singing");
        expectedOutcome.AppendLine("  D   Dancing");
        expectedOutcome.AppendLine("  M   Musical instrument");
        expectedOutcome.AppendLine("  O   Other");
        expectedOutcome.Append("       Enter talent code >> ");
        expectedOutcome.Append("Enter contestant name >> ");
        expectedOutcome.AppendLine("Talent codes are:");
        expectedOutcome.AppendLine("  S   Singing");
        expectedOutcome.AppendLine("  D   Dancing");
        expectedOutcome.AppendLine("  M   Musical instrument");
        expectedOutcome.AppendLine("  O   Other");
        expectedOutcome.Append("       Enter talent code >> ");
        expectedOutcome.AppendLine("");
        expectedOutcome.AppendLine("The types of talent are:");
        expectedOutcome.AppendLine("S     Singing");
        expectedOutcome.AppendLine("D     Dancing");
        expectedOutcome.AppendLine("M     Musical instrument");
        expectedOutcome.AppendLine("O     Other");
        expectedOutcome.AppendLine("");
        expectedOutcome.AppendLine("Enter a talent type or Z to quit >> ");
        expectedOutcome.AppendLine("Contestants with talent Singing are:");
        expectedOutcome.AppendLine("Jill");
        expectedOutcome.AppendLine("");
        expectedOutcome.AppendLine("Enter a talent type or Z to quit >> ");
        expectedOutcome.AppendLine("Contestants with talent Dancing are:");
        expectedOutcome.AppendLine("Sarah");
        expectedOutcome.AppendLine("");
        expectedOutcome.AppendLine("Enter a talent type or Z to quit >> ");
        expectedOutcome.AppendLine("Contestants with talent Musical instrument are:");
        expectedOutcome.AppendLine("Mikia");
        expectedOutcome.AppendLine("");
        expectedOutcome.AppendLine("Enter a talent type or Z to quit >> ");
        expectedOutcome.AppendLine("Contestants with talent Other are:");
        expectedOutcome.AppendLine("No contestants had talent Other");
        expectedOutcome.AppendLine("");
        //Enter a talent type or Z to quit >>
        expectedOutcome.Append("Enter a talent type or Z to quit >> ");
        
        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
        input.Dispose();
    }
}
