namespace intro_oop;

public abstract class Shape : INamable
{
    public abstract double Area();
    public Location? Location { get; set; }
    public string GetName()
    {
        return GetType().Name;
    }
}
