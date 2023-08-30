using BetterINI;

namespace Core
{
    internal class Reader
    {
        public static void ReadFile()
        {
            string FileIni = File.ReadAllText(@"Setup.ini");

            IniFile ini = new IniFile();
            MapInfo MapName = IniSerializer.Deserialize<MapInfo>(FileIni);


            FileWriter.FileWrite(MapName.INIFile, MapName.MapModelPath, MapName.TrackTexturePath, MapName.MapModelLODPath, MapName.MapCollisionPath);

        }
    }
}
