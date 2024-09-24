using TaskHive_ProjectService.Models.Data;

namespace TaskHive_ProjectService.Services.Interface;

public interface IProjectService
{
    Task<List<ProjectDataModel>> GetProjectsAsync();
    Task<ProjectDataModel> GetProjectByIdAsync(int projectId);
    Task<ProjectDataModel> CreateProjectAsync(ProjectDataModel project);
    Task<ProjectDataModel> EditProjectAsync(ProjectDataModel project);
}