using System;
using UnityEngine;
using UnityEngine.UI;

namespace FunFact.Screen.Adapter
{
    [AddComponentMenu("")]
    public class LetterboxCanvas : MonoBehaviour
    {
        [RuntimeInitializeOnLoadMethod]
        private static void Init()
        {
            new GameObject("Letterbox").AddComponent<LetterboxCanvas>();
        }

        private Image _left;
        private Image _right;
        private Image _bottom;
        private Image _top;
        
        private void Start()
        {
            DontDestroyOnLoad(gameObject);
            var canvas = gameObject.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = Int16.MaxValue;

            var area = Settings.Instance.NormalizedArea;
            
            _left = new GameObject("Left").AddComponent<Image>();
            _left.color = Color.black;
            _left.transform.SetParent(transform);
            _left.rectTransform.anchorMin = new(0, 0);
            _left.rectTransform.anchorMax = new(area.xMin, 1);
            _left.rectTransform.anchoredPosition = Vector2.zero;
            _left.rectTransform.sizeDelta = Vector2.zero;
            
            _right = new GameObject("Right").AddComponent<Image>();
            _right.color = Color.black;
            _right.transform.SetParent(transform);
            _right.rectTransform.anchorMin = new(area.xMax, 0);
            _right.rectTransform.anchorMax = new(1, 1);
            _right.rectTransform.anchoredPosition = Vector2.zero;
            _right.rectTransform.sizeDelta = Vector2.zero;
            
            _bottom = new GameObject("Bottom").AddComponent<Image>();
            _bottom.color = Color.black;
            _bottom.transform.SetParent(transform);
            _bottom.rectTransform.anchorMin = new(0, 0);
            _bottom.rectTransform.anchorMax = new(1, area.yMin);
            _bottom.rectTransform.anchoredPosition = Vector2.zero;
            _bottom.rectTransform.sizeDelta = Vector2.zero;
            
            _top = new GameObject("Top").AddComponent<Image>();
            _top.color = Color.black;
            _top.transform.SetParent(transform);
            _top.rectTransform.anchorMin = new(0, area.yMax);
            _top.rectTransform.anchorMax = new(1, 1);
            _top.rectTransform.anchoredPosition = Vector2.zero;
            _top.rectTransform.sizeDelta = Vector2.zero;
        }
    }
}
