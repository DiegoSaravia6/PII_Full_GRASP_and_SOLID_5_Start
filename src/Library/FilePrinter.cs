using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeCreator recipeContent)
        {
            File.WriteAllText("Recipe.txt", recipeContent.GetTextToPrint());
        }
    }
}