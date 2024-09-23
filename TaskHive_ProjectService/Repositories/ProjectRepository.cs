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

    public async Task<ProjectDataModel> CreateProjectAsync(ProjectDataModel project)
    {
        project.CreateDate = DateTime.Now;
        project.LastUpdateDate = DateTime.Now;

        _db.Add(project);
        await _db.SaveChangesAsync();

        return project;        
    }

    public async Task<List<ProjectDataModel>> GetProjectsAsync()
    {
        var projectList = await _db.Projects.OrderByDescending(x => x.CreateDate).ToListAsync();
        return projectList;
    }
}