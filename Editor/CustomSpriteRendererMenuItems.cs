using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using EditorUtility = WinuXGames.SplitFramework.Utility.Editor.EditorUtility;

namespace WinuXGames.SplitFramework.Rendering.Editor
{
    public static class CustomSpriteRendererMenuItems
    {
        private static SpriteRenderer GetSpriteRenderer(MenuCommand command) => EditorUtility.MenuCommandContextToType<SpriteRenderer>(command);

        private static void SetSpriteRendererShadowSettings(MenuCommand command, ShadowCastingMode shadowCastingMode, bool receiveShadows)
        {
            Renderer renderer = GetSpriteRenderer(command);

            renderer.shadowCastingMode = shadowCastingMode;
            renderer.receiveShadows    = receiveShadows;

            UnityEditor.EditorUtility.SetDirty(renderer.gameObject);
        }

        [MenuItem("CONTEXT/SpriteRenderer/Activate Shadows")]
        private static void ActivateShadows(MenuCommand command) => SetSpriteRendererShadowSettings(command, ShadowCastingMode.On, true);

        [MenuItem("CONTEXT/SpriteRenderer/Deactivate Shadows")]
        private static void DeactivateShadows(MenuCommand command) => SetSpriteRendererShadowSettings(command, ShadowCastingMode.Off, false);

        [MenuItem("CONTEXT/SpriteRenderer/Shadows Only")]
        private static void ShadowsOnly(MenuCommand command) => SetSpriteRendererShadowSettings(command, ShadowCastingMode.ShadowsOnly, false);
    }
}