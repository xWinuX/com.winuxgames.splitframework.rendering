using UnityEngine;

namespace WinuXGames.SplitFramework.Rendering
{
    [ExecuteAlways]
    public class CustomProjectionMatrix : MonoBehaviour
    {
        [SerializeField] private Vector2Int _resolution;
        [SerializeField] private float      _pixelsInUnit;

        private Camera     _camera;
        private Vector2Int _previousResolution;
        private Coroutine  _disableCameraCoroutine;

        private void Awake() { _camera = GetComponent<Camera>(); }

        public void Update()
        {
            //float stepSize = 0.414214f / _resolution.y;
        
            Matrix4x4 matrix = _camera.projectionMatrix;

            float stretch = Mathf.Sqrt(Mathf.Pow((1f / 45f) * (transform.rotation.eulerAngles.x % 90), 2) + 1f);
            //stretch = Mathf.Round(stretch / stepSize) * stepSize;
            float orthoSize = _resolution.y / (2f * _pixelsInUnit);
            float scaleBase = 1 / (_resolution.y / (2f * _pixelsInUnit));

            matrix.m11               = scaleBase * stretch;
            _camera.projectionMatrix = matrix;
            _camera.orthographicSize = orthoSize;
        }

        private void LateUpdate()
        {
            if (_previousResolution != _resolution)
            {
                _camera.ResetProjectionMatrix();
            }

            _previousResolution = _resolution;
        }
    }
}