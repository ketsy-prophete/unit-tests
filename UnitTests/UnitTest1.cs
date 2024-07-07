using System;
using Xunit;
using Assignment;

namespace UnitTests;

public class UnitTest1
{

    [Fact]
    public void ReturnsNumberOfVowels_WithVowels_CountVowels()
    {
        string testString = "adieu";
        VowelFinder testClass = new VowelFinder();

        var result = testClass.CountVowels(testString);

        Assert.Equal(4, result);
    }

    [Fact]
    public void ReturnsNumberOfVowels_NoVowels_CountVowels()
    {
        string testString = "rhythm";
        VowelFinder testClass = new VowelFinder();

        var result = testClass.CountVowels(testString);

        Assert.Equal(0, result);
    }

    [Fact]
    public void ReturnsNumberOfVowels_NullInput_CountVowels()
    {
        string testString = "";
        VowelFinder testClass = new VowelFinder();

        var result = testClass.CountVowels(testString);

        Assert.Equal(0, result);
    }

     [Fact]
    public void ReturnsNumberOfVowels_EmptyString_CountVowels()
    {
        string testString = " ";
        VowelFinder testClass = new VowelFinder();

        var result = testClass.CountVowels(testString);

        Assert.Equal(0, result);
    }
}