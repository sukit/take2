using App.Lib;
using NUnit.Framework;

namespace App.Tests;

[TestFixture]
public class RemoveWordWithVowelMidStringFilterTests
{
    [Test]
    public void ApplyShouldRemoveStringIfMidStringContainsVowel()
    {
        var f = new RemoveWordWithVowelMidStringFilter();

        using (Assert.EnterMultipleScope())
        {
            Assert.That(f.Apply("had"), Is.EqualTo(string.Empty));
            Assert.That(f.Apply("pictures"), Is.EqualTo(string.Empty));
            Assert.That(f.Apply("ORANGE"), Is.EqualTo(string.Empty));
            Assert.That(f.Apply("deep"), Is.EqualTo(string.Empty));

            Assert.That(f.Apply("beginning"), Is.EqualTo("beginning"));
            Assert.That(f.Apply("empty"), Is.EqualTo("empty"));
            Assert.That(f.Apply("Rabbit"), Is.EqualTo("Rabbit"));
        }
    }
}