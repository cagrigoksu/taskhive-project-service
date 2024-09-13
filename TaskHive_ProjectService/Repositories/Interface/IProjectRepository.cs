using TaskHive_ProjectService.Models.Data;

namespace TaskHive_ProjectService.Repositories.Interface;

public interface IProjectRepository 
{
    List<ProjectDataModel> GetProjectListAsync();
    void AddProject(ProjectDataModel project);
}