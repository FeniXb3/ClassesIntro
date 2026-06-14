namespace ClassesIntro;

public class Cell
{
    private char _symbol;
    
    public Cell(char symbol)
    {
        _symbol = symbol;
    }

    public void Display()
    {
        Console.Write(_symbol);
    }
}