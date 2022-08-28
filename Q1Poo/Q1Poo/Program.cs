namespace Q1Poo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Building building1 = new Building(5);
            Building building2 = new Building(10, 43.5);
            Console.WriteLine($"b1 fait une hauteur totale de {building1.GetSize()} m");
            Console.WriteLine($"b2 a {building2.GetFloorCount()} étages d'une hauteur de {building2.GetFloorMaxSize()} m chacun");
        }
    }
}

public class Building
{
    private int _floorCount;
    private double _size;

    public Building(int floor)
    {
        this._floorCount = floor;
        this._size = floor * 3;
    }

    public Building(int floor, double size)
    {
        this._floorCount = floor;
        this._size = size;
    }

    public int GetFloorCount()
    {
        return this._floorCount;
    }

    public double GetSize()
    {
        return this._size;
    }

    public double GetFloorMaxSize()
    {
        return this._size / this._floorCount;
    }
}