using ImageMagick;

namespace ImageEditing
{
    public static class ReadImage
    {
        private static byte[] LoadImageBytes(string image)
            => File.ReadAllBytes(image);
        
        private static MemoryStream LoadMemoryStreamImage(string image)
            => new MemoryStream(LoadImageBytes(image));
        
        public static MagickImageInfo ReadBasicImageInformation(string image)
            => new MagickImageInfo(image);
    }
}
