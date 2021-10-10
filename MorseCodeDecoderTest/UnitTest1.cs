using System;
using MorseCodeDecoder;
using NUnit.Framework;

[TestFixture]
public class MorseCodeDecoderTests
{
    [Test]
    public void MorseCodeDecoderBasicTest_1()
    {
        try
        {
            string input = ".... . -.--   .--- ..- -.. .";
            string expected = "HEY JUDE";

            string actual = Decoder.Decode(input);

            Assert.AreEqual(expected, actual);
        }
        catch (Exception ex)
        {
            Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " +
                        ex.Message);
        }
    }
    
    [Test]
    public void MorseCodeDecoderBasicTest_2()
    {
        try
        {
            string input = ".... . -.--   .--- ..- -.. .";
            string expected = "HEY JUDE";

            string actual = Decoder.Decode_(input);

            Assert.AreEqual(expected, actual);
        }
        catch (Exception ex)
        {
            Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " +
                        ex.Message);
        }
    }
}