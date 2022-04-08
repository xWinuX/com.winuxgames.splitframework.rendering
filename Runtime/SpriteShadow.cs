using UnityEngine;
using UnityEngine.Rendering;

namespace WinuXGames.SplitFramework.Rendering
{
    public class SpriteShadow : MonoBehaviour
    {
        [SerializeField] private ShadowCastingMode _shadowCastingMode;
        [SerializeField] private bool              _receiveShadows;

        private void OnValidate()
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.shadowCastingMode = _shadowCastingMode;
            spriteRenderer.receiveShadows    = _receiveShadows;
        }
    }
}
