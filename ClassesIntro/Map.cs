namespace ClassesIntro;

public class Map
{
    List<List<Cell>> cells;

    public void LoadMap(string path)
    {
        cells = new();
        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            List<Cell> row = new();
            cells.Add(row);
            foreach (char symbol in line)
            {
                Cell cell = new(symbol);
                row.Add(cell);
            }
        }
    }

    public void Display()
    {
        foreach (List<Cell> row in cells)
        {
            foreach (Cell cell in row)
            {
                cell.Display();
            }
            Console.WriteLine();
        }
    }

    public Cell GetCell(Vector2 position)
    {
        return cells[position.y][position.x];
    }
}