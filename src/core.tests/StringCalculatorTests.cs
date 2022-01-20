using Xunit;
using NFluent;
using core;

namespace core.tests;

public class StringCalculatorTests
{
    [Fact]
    public void DummyTest()
    {
        Check.That(1).IsEqualTo(1);
    }

    [Fact]
    public void Should_return_zero_if_number_is_empty()
    {
        var sut = new StringCalculator();
        var expected = "0";
        var actual = sut.Add(string.Empty);

        Check.That(actual).IsEqualTo(expected);
    }

    [Fact]
    public void Should_return_one_if_number_is_one()
    {
        var sut = new StringCalculator();
        var expected = "1";
        var actual = sut.Add("1");
        
        Check.That(actual).IsEqualTo(expected);
    }

    [Fact]
    public void Should_return_three_if_numbers_are_one_and_two()
    {
        var sut = new StringCalculator();
        var expected = "3";
        var actual = sut.Add("1,2");

        Check.That(actual).IsEqualTo(expected);
    }

    //[Theory]
    //[InlineData("","0")]
    //[InlineData("1","1")]
    //[InlineData("1,2","3")]
    //public void Sh
}