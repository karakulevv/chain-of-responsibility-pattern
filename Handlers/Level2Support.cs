using ChainOfResponsibilityPattern.Interfaces;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers;

// Concrete handler
public class Level2Support : ISupportHandler
{
    private ISupportHandler nextHandler;

    public Level2Support(ISupportHandler nextHandler)
    {
        this.nextHandler = nextHandler;
    }

    public void HandleIssue(Issue issue)
    {
        if (issue.Level <= 2)
        {
            Console.WriteLine("Level 2 Support: Issue resolved.\n");
        }
        else if (nextHandler != null)
        {
            Console.WriteLine("Level 2 Support: Escalating issue to Level 3 Support.");
            nextHandler.HandleIssue(issue);
        }
        else
        {
            Console.WriteLine("Level 2 Support: Unable to handle the issue.\n");
        }
    }
}