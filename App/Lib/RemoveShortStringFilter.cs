namespace App.Lib;

public class RemoveShortStringFilter : IStringFilter
{
    public string Apply(string input) => input.Length < 3 ? string.Empty : input;
}