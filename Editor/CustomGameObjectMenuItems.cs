using UnityEditor;
using UnityEngine;

namespace WinuXGames.SplitFramework.Rendering.Editor
{
    public static class CustomGameObjectMenuItems
    {
        [MenuItem("GameObject/Split Framework/Sprites/Lit Sprite")]
        public static void CreateLitSprite()
        {
            Object gameObject = Resources.Load("SHUGADUGA");
            PrefabUtility.InstantiatePrefab(gameObject);
        }
        

    }
}