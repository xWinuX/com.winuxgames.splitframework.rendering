using UnityEditor;
using UnityEditor.U2D.Sprites;

namespace WinuXGames.SplitFramework.Rendering.Editor
{
    public static class CustomSpriteImportMenuItems
    {
        [MenuItem("CONTEXT/TextureImporter/Use first border for all Sprites")]
        private static void UseFirstBorderForAllSprites(MenuCommand command)
        {
            // Setup factory and data provider
            SpriteDataProviderFactories factory = new SpriteDataProviderFactories();
            factory.Init();
            ISpriteEditorDataProvider dataProvider = factory.GetSpriteEditorDataProviderFromObject(command.context);
            dataProvider.InitSpriteEditorDataProvider();

            // Get sprite rects and perform changes
            SpriteRect[] spriteRects = dataProvider.GetSpriteRects();
            foreach (SpriteRect spriteRect in spriteRects) { spriteRect.border = spriteRects[0].border; }

            // Set and apply changes
            dataProvider.SetSpriteRects(spriteRects);
            dataProvider.Apply();

            // Save asset
            AssetImporter assetImporter = (AssetImporter)dataProvider.targetObject;
            assetImporter.SaveAndReimport();
        }
    }
}