using ChainOfResponsibilityPattern.Interfaces;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers;

public class Level3Support : ISupportHandler
{
    public void HandleIssue(Issue issue)
    {
        if (issue.Level <= 3)
        {
            Console.WriteLine("Level 3 Support: Issue resolved.\n");
        }
        else
        {
            Console.WriteLine("Level 3 Support: Unable to handle the issue.\n");
        }
    }
}