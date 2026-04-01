using App.Lib;
using NUnit.Framework;

namespace App.Tests;

[TestFixture]
public class RemoveWordWithTFilterTests
{
    [Test]
    public void ApplyShouldRemoveStringWithTCharacter()
    {
        var f = new RemoveWordWithTFilter();

        using (Assert.EnterMultipleScope())
        {
            Assert.That(f.Apply("t"), Is.EqualTo(string.Empty));
            Assert.That(f.Apply("Thailand"), Is.EqualTo(string.Empty));

            Assert.That(f.Apply("England"), Is.EqualTo("England"));
        }
    }
}