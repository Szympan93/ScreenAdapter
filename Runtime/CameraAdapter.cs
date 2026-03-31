using System;
using UnityEngine;

namespace FunFact.Screen.Adapter
{
    [RequireComponent(typeof(Camera))]
    public class CameraAdapter : MonoBehaviour
    {
        private Camera _cam;

        private void Awake()
        {
            _cam = GetComponent<Camera>();
        }

        private void Update()
        {
            if(!_cam) return;
            _cam.rect = Settings.Instance.NormalizedArea;
        }
    }
}
