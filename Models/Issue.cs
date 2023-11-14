namespace ChainOfResponsibilityPattern.Models;

// Issue class
public class Issue
{
    public int Level { get; }

    public Issue(int level)
    {
        Level = level;
    }
}