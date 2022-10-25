namespace Singleton2
{
    static class Facade
    {
        //wir schreiben schnell eine Datei aus einem Zufälligen Hashwert
        //diese Datei wird abgelegt mit einem zufällige hashwert
        //gekapselt in eigener Methode um ein Files zu erzeugen!!!

        public static void CreateFile()
        {
            var path = FileNameCreator.GetPath();
            var hash = HashCreator.GetHash();
            var sql = DBERMModel.GetModel();
            //hier werden TXT Datei ausgegeben
            var combined = new FileInfo($"{path}//{hash}.txt");
            var combinedsql = new FileInfo($"{path}//{sql}.sql");
            if (HashCreator.ValidateHash(combined))
            {
                Writer.Write(combined);
            }
        }
        
}
}