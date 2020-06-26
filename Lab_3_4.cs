using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"[d-e]";
        string input = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

        string pattern2b = @"[d-e][*d]";
        string input2b = @"";
        RegexOptions options2b = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2b, pattern2b, options2b))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

    
        string pattern2c = @"[a][a-z][a]";
        string input2c = @"";
        RegexOptions options2c = RegexOptions.Multiline;
        
        foreach (Match m in Regex.Matches(input2c, pattern2c, options2c))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

        string pattern2d = @"[ ][p][a-z]*";
        string input2d = @"";
        RegexOptions options2d = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2d, pattern2d, options2d))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

        string pattern2e = @"[a-z]*[e][ ]";
        string input2e = @"";
        RegexOptions options2e = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2e, pattern2e, options2e))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

        string pattern2f = @"[A-Z]";
        string input2f = @"";
        RegexOptions options2f = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2f, pattern2f, options2f))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

    }
}