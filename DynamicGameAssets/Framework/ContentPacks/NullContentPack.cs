using StardewModdingAPI;

namespace DynamicGameAssets.Framework.ContentPacks
{
    internal class NullContentPack : IContentPack
    {
        public string DirectoryPath => null;

        public IManifest Manifest => new NullManifest();

        public ITranslationHelper Translation => new NullTranslationHelper();

        public string GetActualAssetKey(string key)
        {
            return key;
        }

        public bool HasFile(string path)
        {
            return false;
        }

        public T LoadAsset<T>(string key)
        {
            return default(T);
        }

        public TModel ReadJsonFile<TModel>(string path) where TModel : class
        {
            return default(TModel);
        }

        public void WriteJsonFile<TModel>(string path, TModel data) where TModel : class
        {
        }
    }
}
