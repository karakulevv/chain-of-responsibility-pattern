using ChainOfResponsibilityPattern.Handlers;
using ChainOfResponsibilityPattern.Interfaces;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern;

class Program
{
    public static void Main(string[] args)
    {
        ISupportHandler level3 = new Level3Support();
        ISupportHandler level2 = new Level2Support(level3);
        ISupportHandler level1 = new Level1Support(level2);

        Issue issue1 = new Issue(1);
        Issue issue2 = new Issue(2);
        Issue issue3 = new Issue(3);
        Issue issue4 = new Issue(4);

        level1.HandleIssue(issue1);
        level1.HandleIssue(issue2);
        level1.HandleIssue(issue3);
        level1.HandleIssue(issue4);
    }
}