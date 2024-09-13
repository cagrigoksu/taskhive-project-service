using Microsoft.AspNetCore.Mvc;
using TaskHive_ProjectService.Models.Data;
using TaskHive_ProjectService.Repositories.Interface;
using TaskHive_ProjectService.Services.Interface;

namespace TaskHive_ProjectService.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;
    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public void AddProject(ProjectDataModel project)
    {
        _projectRepository.AddProject(project);
    }

    public List<ProjectDataModel> GetProjectListAsync()
    {
        var projectList = _projectRepository.GetProjectListAsync();
        return projectList;
    }
}