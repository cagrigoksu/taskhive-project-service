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

    public async Task<ProjectDataModel> EditProjectAsync(ProjectDataModel project)
    {
        var data = await _db.Projects.FirstOrDefaultAsync(p => p.Id == project.Id);

        if (data != null)
        {
            data.Name = project.Name;
            data.Description = project.Description;
            data.StartDate = project.StartDate;
            data.EndDate = project.EndDate;
            data.StatusId = project.StatusId;
            data.PriorityId = project.PriorityId;
            data.Budget = project.Budget;

            data.LastUpdateDate = DateTime.Now;
            _db.Update(data);
            await _db.SaveChangesAsync();

            return data;
        }
        
        return null;
    }

    public async Task<ProjectDataModel> GetProjectByIdAsync(int projectId)
    {
        var project = _db.Projects.FirstOrDefaultAsync<ProjectDataModel>(x => x.Id == projectId && x.IsDeleted == false);
        return await project;
    }

    public async Task<List<ProjectDataModel>> GetProjectsAsync()
    {
        var projectList = await _db.Projects.OrderByDescending(x => x.CreateDate).ToListAsync();
        return projectList;
    }
}