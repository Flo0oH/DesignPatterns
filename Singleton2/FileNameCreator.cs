namespace Singleton2
{
    static class FileNameCreator
    {
        public static FileInfo GetPath()
        {
            return new FileInfo(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);

        }
    }
}