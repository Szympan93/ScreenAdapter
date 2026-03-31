using UnityEngine;

namespace FunFact.Screen.Adapter
{
    
    public class Settings : ScriptableObject
    {
        [field: SerializeField] public float MinAspect { get; private set; } = 0.001f;
        [field: SerializeField] public float MaxAspect { get; private set; } = 100.0f;

        private static Settings _instance;

        public static Settings Instance => _instance ??= Resources.Load<Settings>("FunFact/Screen/Adapter/Settings") ?? CreateInstance<Settings>();

        public Rect Area
        {
            get
            {
                var rect = UnityEngine.Screen.safeArea;

                if (rect.width / rect.height < Settings.Instance.MinAspect)
                {
                    var delta = rect.height - rect.width / Settings.Instance.MinAspect;
                    rect.height -= delta;
                    rect.y += delta / 2;
                }
                else if (rect.width / rect.height > Settings.Instance.MaxAspect)
                {
                    var delta = rect.width - rect.height * Settings.Instance.MaxAspect;
                    rect.width -= delta;
                    rect.x += delta / 2;
                }
                
                return rect;
            }
        }

        public Rect NormalizedArea
        {
            get
            {
                var rect = Area;
            
                rect.x /= UnityEngine.Screen.width;
                rect.y /= UnityEngine.Screen.height;
                rect.width /= UnityEngine.Screen.width;
                rect.height /= UnityEngine.Screen.height;
                
                return rect;
            }
        }
    }
}
