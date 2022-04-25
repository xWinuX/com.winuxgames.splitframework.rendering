using UnityEditor;
using EditorUtility = WinuXGames.SplitFramework.Utility.Editor.EditorUtility;

namespace WinuXGames.SplitFramework.Rendering.Editor
{
    public static class CustomGameObjectMenuItems
    {
        [MenuItem("GameObject/Split Framework/Sprites/Lit Sprite", priority = 0)]
        private static void CreateLitSprite() => EditorUtility.InstantiatePrefabFromResources("GameObjectMenuItemPresets/Sprites/Lit Sprite");

        [MenuItem("GameObject/Split Framework/Camera", priority = 0)]
        private static void CreateCamera() => EditorUtility.InstantiatePrefabFromResources("GameObjectMenuItemPresets/Camera");
    }
}