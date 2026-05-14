using Microsoft.AspNetCore.Http;

namespace FrontToBack.Utilities.Extensions
{
    public static class FileValidator
    {
        public static bool CheckFileSize(this IFormFile file, int maxMb)
        {
            
            if (file.Length <= maxMb * 1024 * 1024)
            {
                return true;
            }
            return false;

            public static bool CheckFileSize(this IFormFile file, FileSize fileSize, int size)
        {
            switch (fileSize)
            {
                case FileSize.KB:
                    return file.Length <= size * 1024;
                case FileSize.MB:
                    return file.Length <= size * 1024 * 1024;
                case FileSize.GB:
                    return file.Length <= size * 1024 * 1024 * 1024;
            }

            return false;
        }
    }
    }
}