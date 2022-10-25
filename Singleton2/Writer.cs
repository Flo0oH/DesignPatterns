namespace Singleton2
{
    static class Writer
    {
        
        public static void Write(FileInfo fileInfo)
        {
            using (StreamWriter sw = new StreamWriter(fileInfo.FullName))
                sw.WriteLine("Hallo das ist meine neue Datei");
        }
   
    }
}