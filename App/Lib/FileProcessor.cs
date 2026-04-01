using System.Text.RegularExpressions;

namespace App.Lib;

public class FileProcessor
{
    private readonly IStringFilter[] _filters =
    [
        new RemoveWordWithVowelMidStringFilter(),
        new RemoveShortStringFilter(),
        new RemoveWordWithTFilter()
    ];

    public string Process(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("The specified file does not exist", filePath);
        }

        var content =  File.ReadAllText(filePath);

        var regex = new Regex(@"\b(\w)+\b", RegexOptions.Compiled);
        return regex.Replace(
            content,
            match => _filters.Aggregate(match.Value, (s, filter) => filter.Apply(s))
        );
    }
}