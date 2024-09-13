using TaskHive_ProjectService.Models.Data;

namespace TaskHive_ProjectService.Services.Interface;

public interface IProjectService
{
    List<ProjectDataModel> GetProjectListAsync();
    void AddProject(ProjectDataModel project);
}