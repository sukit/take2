using App.Lib;
using NUnit.Framework;

namespace App.Tests;

[TestFixture]
public class RemoveShortStringFilterTests
{
    [Test]
    public void ApplyShouldRemoveStringShorterThanTwoCharacters()
    {
        var f = new RemoveShortStringFilter();
        using (Assert.EnterMultipleScope())
        {
            Assert.That(f.Apply("a"), Is.EqualTo(string.Empty));
            Assert.That(f.Apply("ab"), Is.EqualTo(string.Empty));

            Assert.That(f.Apply("abc"), Is.EqualTo("abc"));
        }
    }
}