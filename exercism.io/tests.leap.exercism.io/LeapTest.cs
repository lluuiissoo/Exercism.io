using NUnit.Framework;
using leap.exercism.io;

[TestFixture]
public class LeapTest
{
    Year Year;

    [TestFixtureSetUp]
    public void Init()
    {
        Year = new Year();
    }

    //[Ignore("Remove to run test")]
    [Test]
    public void Valid_leap_year()
    {
        Assert.That(Year.IsLeap(1996), Is.True);
    }

    //[Ignore("Remove to run test")]
    [Test]
    public void Invalid_leap_year()
    {
        Assert.That(Year.IsLeap(1997), Is.False);
    }

    //[Ignore("Remove to run test")]
    [Test]
    public void Turn_of_the_20th_century_is_not_a_leap_year()
    {
        Assert.That(Year.IsLeap(1900), Is.False);
    }

    //[Ignore("Remove to run test")]
    [Test]
    public void Turn_of_the_25th_century_is_a_leap_year()
    {
        Assert.That(Year.IsLeap(2400), Is.True);
    }
}