using TaskHive_ProjectService.Models.Data;

namespace TaskHive_ProjectService.Repositories.Interface;

public interface IProjectRepository 
{
    Task<List<ProjectDataModel>> GetProjectsAsync();
    Task<ProjectDataModel> CreateProjectAsync(ProjectDataModel project);
}