
namespace Core
{
    internal class FileWriter
    {
        public static void FileWrite(string INIFILE, string filepath, string TexturePath, string LODPath, string ColisionPath)
        {
            DirectoryInfo di = new DirectoryInfo(filepath);

            string Line = "";
            List<string> Final = new List<string>();

            Final.Add(MapInfo.smartCullingInfo1);
            Final.Add(MapInfo.smartCullingInfo2);
            Final.Add(MapInfo.smartCullingInfo3);
            Final.Add(MapInfo.smartCullingInfo4);
            Final.Add(MapInfo.smartCullingValue);

            Final.Add(MapInfo.AggressiveCullingInfo);
            Final.Add(MapInfo.AggressiveCullingValue);

            Final.Add(MapInfo.DrawInfo);
            Final.Add(MapInfo.DrawValue);

            Final.Add(MapInfo.LODDistanceInfo);
            Final.Add(MapInfo.LODDistanceValue);

            Final.Add(Line);

            Final.Add(MapInfo.ImportAllTransformsInfo);
            Final.Add(MapInfo.ImportAllTransformsInfo1);
            Final.Add(MapInfo.ImportAllTransformsInfo2);
            Final.Add(MapInfo.ImportAllTransforms);

            Final.Add(MapInfo.DisableMeshScalingInfo);
            Final.Add(MapInfo.DisableMeshScalingValue);
            Final.Add(MapInfo.IgnoreVertexColorInfo);
            Final.Add(MapInfo.IgnoreVertexColorValue);
            Final.Add(MapInfo.ForceCullModeInfo);
            Final.Add(MapInfo.ForceCullModeValue);

            Final.Add(Line);

            Final.Add(MapInfo.lightingparamsInfo);
            Final.Add(MapInfo.lightingparamsValue);
            Final.Add(MapInfo.lightingparamsValue1);
            Final.Add(MapInfo.lightingparamsValue2);
            Final.Add(MapInfo.lightingparamsValue3);
            Final.Add(MapInfo.lightingparamsValue4);
            Final.Add(MapInfo.lightingparamsValue5);
            Final.Add(MapInfo.lightingparamsValue6);
            Final.Add(MapInfo.lightingparamsValue7);
            Final.Add(MapInfo.lightingparamsValue8);
            Final.Add(MapInfo.lightingparamsValue9);
            Final.Add(MapInfo.lightingparamsValue10);

            Final.Add(Line);

            Final.Add(MapInfo.MapOffsetInfo);
            Final.Add(MapInfo.MapOffsetX);
            Final.Add(MapInfo.MapOffsetY);
            Final.Add(MapInfo.MapOffsetZ);

            Final.Add(Line);

            Final.Add(MapInfo.TrackModelInfo);

            string[] FBXTrackModelsPath = Directory.GetFiles(filepath, "*.fbx");

            for (int i = 1; i < FBXTrackModelsPath.Length; i++)
            {
                string TrackModelStringPath = "MapModel" + (i + 1) + "Path=" + FBXTrackModelsPath[i];
                Final.Add(TrackModelStringPath);
            }

            Final.Add(Line);
            
            Final.Add(MapInfo.LODPathInfo);
            string[] LODModelsPath = Directory.GetFiles(LODPath, "*.fbx");

            for (int i = 0; i < LODModelsPath.Length; i++)
            {
                string LODStringPath = "MapModel" + (i + 1) + "LODPath=" + LODModelsPath[i];
                Final.Add(LODStringPath);
            }

            Final.Add(Line);

            Final.Add(MapInfo.CollisionPathInfo);

            string[] FBXColisionsModelsPath = Directory.GetFiles(ColisionPath, "*.fbx");

            for (int i = 0; i < FBXColisionsModelsPath.Length; i++)
            {
                string ColisionStringPath = "MapCollision" + (i + 1) + "Path=" + FBXColisionsModelsPath[i];
                Final.Add(ColisionStringPath);
            }

            System.IO.File.WriteAllLines(INIFILE, Final);
        }
    }
}
