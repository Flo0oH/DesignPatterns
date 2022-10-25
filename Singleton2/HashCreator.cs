using System;

namespace Singleton2
{
    static class HashCreator
    {
        public static string GetHash()
        {
            return DateTime.Now.GetHashCode().ToString("x");
        }
        public static bool ValidateHash(FileInfo pathToFile)
        {
            if (File.Exists(pathToFile.FullName))
            {
                throw new FileNotFoundException("Dublicatge Filenmae");
            }
            return true;
        }
    }
}