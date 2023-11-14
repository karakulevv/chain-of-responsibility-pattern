using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Interfaces;

// Handler interface
public interface ISupportHandler
{
    void HandleIssue(Issue issue);
}