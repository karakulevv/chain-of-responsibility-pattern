using ChainOfResponsibilityPattern.Interfaces;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers;

// Concrete handler
public class Level1Support : ISupportHandler
{
    private ISupportHandler nextHandler;

    public Level1Support(ISupportHandler nextHandler)
    {
        this.nextHandler = nextHandler;
    }

    public void HandleIssue(Issue issue)
    {
        if (issue.Level <= 1)
        {
            Console.WriteLine("Level 1 Support: Issue resolved.\n");
        }
        else if (nextHandler != null)
        {
            Console.WriteLine("Level 1 Support: Escalating issue to Level 2 Support.");
            nextHandler.HandleIssue(issue);
        }
        else
        {
            Console.WriteLine("Level 1 Support: Unable to handle the issue.\n");
        }
    }
}