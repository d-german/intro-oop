namespace intro_oop;

public class Dog : INamable
{
    public string GetName() // note: no override keyword
    {
        return "Samson";
    }
}
