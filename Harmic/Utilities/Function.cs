namespace Harmic.Utilities
{
    public class Function
    {
        public static string TitleSlugGenerationAlias(string tile)
        { 
            return SlugGenerator.SlugGenerator.GenerateSlug(tile);
        }
    }
}
