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

    public async Task<ProjectDataModel> CreateProjectAsync(ProjectDataModel project)
    {
        return await _projectRepository.CreateProjectAsync(project);
    }

    public async Task<List<ProjectDataModel>> GetProjectsAsync()
    {
        var projectList = await _projectRepository.GetProjectsAsync();
        return projectList;
    }
}