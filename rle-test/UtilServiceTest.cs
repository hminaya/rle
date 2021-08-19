using rle;
using Xunit;

namespace rle_test;
public class UtilServiceTest
{
    [Theory]
    [InlineData("CFZZIIY", "1C1F2Z2I1Y")]
    [InlineData("JJUUUYYYYYVDDOAPP", "2J3U5Y1V2D1O1A2P")]
    public void Compress(string input, string expectedResult)
    {

        // Arrange
        // - nothing to arrange here, I'm using InlineData to pass in parameters

        // Act
        var res = Util.Compress(input);
        var result = String.Join(',', res);

        // Assert
        Assert.Equal(expectedResult, result);

    }

    [Theory]
    [InlineData("ABC", "1A1B1C")]
    [InlineData("LAKSKDJFHG", "1L1A1K1S1K1D1J1F1H1G")]
    public void CompressNoContiguousChars(string input, string expectedResult)
    {

        // Arrange
        // - nothing to arrange here, I'm using InlineData to pass in parameters

        // Act
        var res = Util.Compress(input);
        var result = String.Join(',', res);

        // Assert
        Assert.Equal(expectedResult, result);

    }

    [Theory]
    [InlineData("A", "1A")]
    [InlineData("H", "1H")]
    [InlineData("Z", "1Z")]
    public void CompressSingleChar(string input, string expectedResult)
    {

        // Arrange
        // - nothing to arrange here, I'm using InlineData to pass in parameters

        // Act
        var res = Util.Compress(input);
        var result = String.Join(',', res);

        // Assert
        Assert.Equal(expectedResult, result);

    }

    [Fact]
    public void CompressNoData()
    {

        // Arrange
        string input = "";
        string expectedResult = "";

        // Act
        var res = Util.Compress(input);
        var result = String.Join(',', res);

        // Assert
        Assert.Equal(expectedResult, result);

    }
}