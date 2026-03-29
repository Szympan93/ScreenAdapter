using UnityEngine;

namespace FunFact.Screen.Adapter
{
    [RequireComponent(typeof(RectTransform))]
    public class UiSafeArea : MonoBehaviour
    {
        private RectTransform _rt;
        private Canvas _canvas;
        private RectTransform _canvasRT;

        private void Awake()
        {
            _rt = GetComponent<RectTransform>();
            _canvas = GetComponentInParent<Canvas>();
            _canvasRT = _canvas.GetComponent<RectTransform>();
        }

        private void Update()
        {
            var rect = UnityEngine.Screen.safeArea;
            rect.x /= UnityEngine.Screen.width;
            rect.y /= UnityEngine.Screen.height;
            rect.width /= UnityEngine.Screen.width;
            rect.height /= UnityEngine.Screen.height;
            
            /*
            _rt.anchorMin = rect.min;
            _rt.anchorMax = rect.max;
            _rt.anchoredPosition = Vector2.zero;
            _rt.sizeDelta = Vector2.zero;
            */
            
            var targetSize = _canvasRT.rect.size * (rect.size - _rt.anchorMax + _rt.anchorMin);
            
            _rt.sizeDelta = targetSize;
            _rt.anchoredPosition = _canvasRT.rect.size * (rect.position-_rt.anchorMin) + targetSize * _rt.pivot;
        }
    }
}