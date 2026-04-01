using App.Lib;

if (args.Length == 0)
{
    Console.WriteLine("Please specify input file path");
    return;
}

var p = new FileProcessor();
try
{
    var result = p.Process(args[0]);
    Console.WriteLine(result);
}
catch (FileNotFoundException e)
{
    Console.WriteLine($"The specified file does not exist: ${e.FileName}");
    return;
}

Console.WriteLine("Done");