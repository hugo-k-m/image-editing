using ImageEditing;
using ImageMagick;

namespace UnitTests;

public class ReadInfoTests
{
    [Fact]
    public void ReadBasicInfoTests()
    {
        // Arrange
        var sampleImage = ProjectSourcePath.Value +
            "SampleFiles/akane-eyes.png";

        // Act
        var info = ReadImage.ReadBasicImageInformation(sampleImage);

        // Assert
        var density = Assert.IsAssignableFrom<Density>(info.Density);
        
        Assert.Equal(1920, info.Width);
        Assert.Equal(1080, info.Height);
        Assert.Equal(1, density.X);
        Assert.Equal(1, density.Y);
    }
}
