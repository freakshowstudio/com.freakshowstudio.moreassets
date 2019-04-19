
using System.IO;

using UnityEngine;
using UnityEditor;


namespace FreakshowStudio.MoreAssets.Editor
{
    public static class AssetCreationHelper
    {
        public static void CreateAsset<T>() where T : ScriptableObject
        {
            T asset = ScriptableObject.CreateInstance<T>();

            string path = GetSelectedPath();
            string assetPathAndName = CreateUniqueAssetPath(
                path, typeof(T).ToString(), "asset");

            ProjectWindowUtil.CreateAsset(asset, path);
        }

        public static string GetSelectedPath()
        {
            if (Selection.activeObject == null)
            {
                return "Assets";
            }

            string path = AssetDatabase.GetAssetPath(Selection.activeObject);

            if (string.IsNullOrEmpty(path))
            {
                return "Assets";
            }

            if (!File.GetAttributes(path).HasFlag(FileAttributes.Directory))
            {
                path = Path.GetDirectoryName(path);
            }

            return path;
        }

        public static string CreateUniqueAssetPath(
            string path,
            string name,
            string extension)
        {
            string assetPathAndName =
                AssetDatabase.GenerateUniqueAssetPath(
                    string.Format("{0}/New {1} File.{2}",
                        path, name, extension));

            int i = 0;
            while (File.Exists(assetPathAndName))
            {
                assetPathAndName =
                    AssetDatabase.GenerateUniqueAssetPath(
                        string.Format("{0}/New {1} File ({2}).{3}",
                            path, name, i, extension));
            }

            return assetPathAndName;
        }
    }
}