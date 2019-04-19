
using UnityEngine;
using UnityEditor;


namespace FreakshowStudio.MoreAssets.Editor
{
    public class MoreTextAssets : UnityEditor.Editor
    {
        [MenuItem("Assets/Create/Text File", false, 11370)]
        public static void CreateTextAsset()
        {
            string path = AssetCreationHelper.GetSelectedPath();

            string assetPathAndName = AssetCreationHelper
                .CreateUniqueAssetPath(path, "Text", "txt");

            var icon = EditorGUIUtility
                .IconContent("TextAsset Icon").image as Texture2D;

            ProjectWindowUtil.CreateAssetWithContent(
                assetPathAndName, "", icon);
        }

        [MenuItem("Assets/Create/JSON File", false, 11371)]
        public static void CreateJsonAsset()
        {
            string path = AssetCreationHelper.GetSelectedPath();

            string assetPathAndName = AssetCreationHelper
                .CreateUniqueAssetPath(path, "JSON", "json");

            var icon = EditorGUIUtility
                .IconContent("TextAsset Icon").image as Texture2D;

            ProjectWindowUtil.CreateAssetWithContent(
                assetPathAndName, "", icon);
        }


        [MenuItem("Assets/Create/YAML File", false, 11372)]
        public static void CreateYamlAsset()
        {
            string path = AssetCreationHelper.GetSelectedPath();

            string assetPathAndName = AssetCreationHelper
                .CreateUniqueAssetPath(path, "YAML", "yaml");

            var icon = EditorGUIUtility
                .IconContent("TextAsset Icon").image as Texture2D;

            ProjectWindowUtil.CreateAssetWithContent(
                assetPathAndName, "", icon);
        }

        [MenuItem("Assets/Create/Markdown File", false, 11373)]
        public static void CreateMarkdownAsset()
        {
            string path = AssetCreationHelper.GetSelectedPath();

            string assetPathAndName = AssetCreationHelper
                .CreateUniqueAssetPath(path, "Markdown", "md");

            var icon = EditorGUIUtility
                .IconContent("TextAsset Icon").image as Texture2D;

            ProjectWindowUtil.CreateAssetWithContent(
                assetPathAndName, "", icon);
        }

        [MenuItem("Assets/Create/HTML File", false, 11374)]
        public static void CreateHtmlAsset()
        {
            string path = AssetCreationHelper.GetSelectedPath();

            string assetPathAndName = AssetCreationHelper
                .CreateUniqueAssetPath(path, "HTML", "html");

            var icon = EditorGUIUtility
                .IconContent("TextAsset Icon").image as Texture2D;

            ProjectWindowUtil.CreateAssetWithContent(
                assetPathAndName, "", icon);
        }
        
        [MenuItem("Assets/Create/CSS File", false, 11375)]
        public static void CreateCssAsset()
        {
            string path = AssetCreationHelper.GetSelectedPath();

            string assetPathAndName = AssetCreationHelper
                .CreateUniqueAssetPath(path, "CSS", "css");

            var icon = EditorGUIUtility
                .IconContent("TextAsset Icon").image as Texture2D;

            ProjectWindowUtil.CreateAssetWithContent(
                assetPathAndName, "", icon);
        }
        
        [MenuItem("Assets/Create/JS File", false, 11376)]
        public static void CreateJsAsset()
        {
            string path = AssetCreationHelper.GetSelectedPath();

            string assetPathAndName = AssetCreationHelper
                .CreateUniqueAssetPath(path, "JS", "js");

            var icon = EditorGUIUtility
                .IconContent("TextAsset Icon").image as Texture2D;

            ProjectWindowUtil.CreateAssetWithContent(
                assetPathAndName, "", icon);
        }
        
        [MenuItem("Assets/Create/UXML File", false, 11377)]
        public static void CreateUxmlAsset()
        {
            string path = AssetCreationHelper.GetSelectedPath();

            string assetPathAndName = AssetCreationHelper
                .CreateUniqueAssetPath(path, "UXML", "uxml");

            var icon = EditorGUIUtility
                .IconContent("TextAsset Icon").image as Texture2D;

            ProjectWindowUtil.CreateAssetWithContent(
                assetPathAndName, "", icon);
        }
        
        [MenuItem("Assets/Create/USS File", false, 11378)]
        public static void CreateUssAsset()
        {
            string path = AssetCreationHelper.GetSelectedPath();

            string assetPathAndName = AssetCreationHelper
                .CreateUniqueAssetPath(path, "USS", "uss");

            var icon = EditorGUIUtility
                .IconContent("TextAsset Icon").image as Texture2D;

            ProjectWindowUtil.CreateAssetWithContent(
                assetPathAndName, "", icon);
        }
    }
}