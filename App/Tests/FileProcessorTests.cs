using App.Lib;
using NUnit.Framework;

namespace App.Tests;

[TestFixture]
public class FileProcessorTests
{
    [Test]
    public void ProcessShouldThrowIfFileDoesNotExist()
    {
        var p = new FileProcessor();
        Assert.Throws<FileNotFoundException>(() => p.Process("bogus.txt"));
    }

    [Test]
    public void ProcessShouldApplyThreeFiltersToFileContentAndAccountForNonWordCharacters()
    {
        var p = new FileProcessor();

        var input = "“Well!” thought Alice to herself (as well as she could), How brave they’ll all think me at home!";
        var path = Path.GetTempFileName();
        try
        {
            File.WriteAllText(path, input);

            Assert.That(p.Process(path), Is.EqualTo(@"“!”    herself (   she ),   ’ all    !"));
        }
        finally
        {
            File.Delete(path);
        }
    }
}