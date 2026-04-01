namespace App.Lib;

public class RemoveWordWithTFilter : IStringFilter
{
    public string Apply(string input) => input.IndexOfAny(['t', 'T']) == -1 ? input : string.Empty;
}