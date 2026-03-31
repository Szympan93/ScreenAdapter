using UnityEngine;

namespace FunFact.Screen.Adapter
{
    
    public class Settings : ScriptableObject
    {
        [field: SerializeField] public float MinAspect { get; private set; } = 0.001f;
        [field: SerializeField] public float MaxAspect { get; private set; } = 100.0f;

        private static Settings _instance;

        public static Settings Instance => _instance ??= Resources.Load<Settings>("FunFact/Screen/Adapter/Settings") ?? CreateInstance<Settings>();
    }
}
