using UnityEditor;
using UnityEngine;

namespace FunFact.Screen.Adapter.Editor
{
    public static class SettingsEditor
    {
        [MenuItem("Fun Fact/Screen/Adapter/Settings")]
        public static void Create()
        {
            var settings = ScriptableObject.CreateInstance<Settings>();
            if(!AssetDatabase.IsValidFolder("Assets/Resources")) AssetDatabase.CreateFolder("Assets", "Resources");
            if(!AssetDatabase.IsValidFolder("Assets/Resources/FunFact")) AssetDatabase.CreateFolder("Assets/Resources", "FunFact");
            if(!AssetDatabase.IsValidFolder("Assets/Resources/FunFact/Screen")) AssetDatabase.CreateFolder("Assets/Resources/FunFact", "Screen");
            if(!AssetDatabase.IsValidFolder("Assets/Resources/FunFact/Screen/Adapter")) AssetDatabase.CreateFolder("Assets/Resources/FunFact/Screen", "Adapter");
            AssetDatabase.CreateAsset(settings, "Assets/Resources/FunFact/Screen/Adapter/Settings.asset");
            AssetDatabase.SaveAssets();
            
            Selection.activeObject = settings;
        }
    }
}
