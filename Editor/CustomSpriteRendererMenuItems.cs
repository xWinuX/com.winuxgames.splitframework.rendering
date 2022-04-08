using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using EditorUtility = WinuXGames.SplitFramework.Utility.Editor.EditorUtility;

namespace WinuXGames.SplitFramework.Rendering.Editor
{
    public static class CustomSpriteRendererMenuItems
    {
        private static SpriteRenderer GetSpriteRenderer(MenuCommand command) => EditorUtility.MenuCommandContextToType<SpriteRenderer>(command);
        
        [MenuItem("CONTEXT/SpriteRenderer/Activate Shadows")]
        private static void ActivateShadows(MenuCommand command)
        {
            SpriteRenderer renderer = GetSpriteRenderer(command);

            renderer.shadowCastingMode = ShadowCastingMode.On;
            renderer.receiveShadows    = true;
        }
        
        [MenuItem("CONTEXT/SpriteRenderer/Deactivate Shadows")]
        private static void DeactivateShadows(MenuCommand command)
        {
            SpriteRenderer renderer = GetSpriteRenderer(command);

            renderer.shadowCastingMode = ShadowCastingMode.Off;
            renderer.receiveShadows    = false;
        }
        
        [MenuItem("CONTEXT/SpriteRenderer/Shadows Only")]
        private static void ShadowsOnly(MenuCommand command)
        {
            SpriteRenderer renderer = GetSpriteRenderer(command);

            renderer.shadowCastingMode = ShadowCastingMode.ShadowsOnly;
        }
    }
}