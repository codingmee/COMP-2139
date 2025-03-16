using Microsoft.AspNetCore.Mvc;

namespace InClass2.ViewComponents;

public class ProjectSummaryViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(int projectId)
    {
        var project = new Project
        {
            Id = projectId,
            Name = "Sample Project",
            Description = "This is a description of the sample project."
        };

        return View(project);
    }
}