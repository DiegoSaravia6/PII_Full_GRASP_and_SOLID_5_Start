namespace Full_GRASP_And_SOLID
{
    public interface IRecipeCreator
    {
        string GetTextToPrint();
    }
}
// Con esta interfaz evitamos que la única posible relación entre ConsolePrinter y Recipe sea dependencia directa.
