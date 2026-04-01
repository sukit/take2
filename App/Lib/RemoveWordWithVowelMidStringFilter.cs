namespace App.Lib;

public class RemoveWordWithVowelMidStringFilter : IStringFilter
{
    private static char[] _vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

    public string Apply(string input)
    {
        var len = input.Length;
        var mid = (len % 2) switch
        {
            0 => input.Substring(len / 2 - 1, 2),
            _ => new string(input[len / 2], 1)
        };
        return mid.IndexOfAny(_vowels) == -1 ? input : string.Empty;
    }
}