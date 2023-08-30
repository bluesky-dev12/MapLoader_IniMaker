using BetterINI;

namespace Core
{
    public class MapInfo
    {
        [IniParam("INIFile")] public string? INIFile;
        [IniParam("TrackModelPath")] public string? MapModelPath;
        [IniParam("TrackTexturePath")] public string? TrackTexturePath;
        [IniParam("MapModelLODPath")] public string? MapModelLODPath;
        [IniParam("MapCollisionPath")] public string? MapCollisionPath;


        public static string smartCullingInfo1 = "[Options]";
        public static string smartCullingInfo2 = ";;; performance params";
        public static string smartCullingInfo3 = "; don't draw objects you're not looking at";
        public static string smartCullingInfo4 = "; recommended on for open GTA style maps, off for cramped NFS style maps";
        public static string smartCullingValue = "SmartCulling=0";

        public static string AggressiveCullingInfo = "; cull per mesh instead of per file, can be inaccurate but runs faster";
        public static string AggressiveCullingValue = "AggressiveCulling=1";

        public static string DrawInfo = "; don't draw models further away than this (no effect on models with LODs)";
        public static string DrawValue = "DrawDistance=500";

        public static string LODDistanceInfo = "; if the model has LODs, the LOD model is drawn if you're further away than this";
        public static string LODDistanceValue = "DrawDistance=500";

        public static string ImportAllTransformsInfo = "; ; ; import params";
        public static string ImportAllTransformsInfo1 = "; apply all transforms (i.e. scaling) instead of just rotation and position, this should make the map look more correct in-game";
        public static string ImportAllTransformsInfo2 = "; disabled by default(if this option is missing) for backwards compatibility";
        public static string ImportAllTransforms = "ImportAllTransforms=1";

        public static string DisableMeshScalingInfo = "; scales all meshes back to 1x";
        public static string DisableMeshScalingValue = "DisableMeshScaling=1";

        public static string IgnoreVertexColorInfo = "; clears all vertex colors";
        public static string IgnoreVertexColorValue = "IgnoreVertexColor=0";

        public static string ForceCullModeInfo = "; 1 - no backface culling, 2 - clockwise backface culling, 3 - counterclockwise backface culling";
        public static string ForceCullModeValue = "ForceCullMode=0";

        public static string lightingparamsInfo = ";;; lighting params";
        public static string lightingparamsValue = "UseShading=1";
        public static string lightingparamsValue1 = "ShadingMultiplier=0.45";
        public static string lightingparamsValue2 = "SunPosX=0.15";
        public static string lightingparamsValue3 = "SunPosY=-0.25";
        public static string lightingparamsValue4 = "SunPosZ=0.95";
        public static string lightingparamsValue5 = "SunColorR=255";
        public static string lightingparamsValue6 = "SunColorG=255";
        public static string lightingparamsValue7 = "SunColorB=255";
        public static string lightingparamsValue8 = "ShadowColorR=59";
        public static string lightingparamsValue9 = "ShadowColorG=72";
        public static string lightingparamsValue10 = "ShadowColorB=102";

        public static string MapOffsetInfo = "; global track offset";
        public static string MapOffsetX = "MapOffsetX=2000";
        public static string MapOffsetY = "MapOffsetY=-2200";
        public static string MapOffsetZ = "MapOffsetZ=80";


        public static string TrackModelInfo = "; track models, up to 8192";
        public static string LODPathInfo = "; LOD models, up to 8192";
        public static string CollisionPathInfo = "; track collision meshes, up to 8192";
    }
}
