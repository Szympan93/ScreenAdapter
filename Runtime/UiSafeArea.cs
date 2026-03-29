using UnityEngine;

namespace FunFact.Screen.Adapter
{
    [RequireComponent(typeof(RectTransform))]
    public class UiSafeArea : MonoBehaviour
    {
        private RectTransform _rt;

        private void Awake()
        {
            _rt = GetComponent<RectTransform>();
        }

        private void Update()
        {
            var rect = UnityEngine.Screen.safeArea;
            rect.x /= UnityEngine.Screen.width;
            rect.y /= UnityEngine.Screen.height;
            rect.width /= UnityEngine.Screen.width;
            rect.height /= UnityEngine.Screen.height;
            _rt.anchorMin = rect.min;
            _rt.anchorMax = rect.max;
            _rt.anchoredPosition = Vector2.zero;
            _rt.sizeDelta = Vector2.zero;
        }
    }
}