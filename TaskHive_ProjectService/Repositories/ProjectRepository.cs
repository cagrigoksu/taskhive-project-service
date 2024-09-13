using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using TaskHive_ProjectService.Models.Data;
using TaskHive_ProjectService.Repositories.Interface;

namespace TaskHive_ProjectService.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly AppDbContext _db;
    public ProjectRepository(AppDbContext db)
    {
        _db = db;
    }

    public void AddProject(ProjectDataModel project){
        
    }

    public async Task<List<ProjectDataModel>> GetProjectListAsync()
    {
        var projectList = await _db.Projects.ToListAsync();
        return projectList;
    }
}