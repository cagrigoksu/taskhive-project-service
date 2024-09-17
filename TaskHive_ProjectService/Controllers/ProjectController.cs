using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TaskHive_ProjectService.Models;
using TaskHive_ProjectService.Services;
using TaskHive_ProjectService.Services.Interface;
namespace TaskHive_ProjectService.Controllers{


    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController: Controller
    {

        private readonly IProjectService? _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("get-project-list")]
        public async Task<IActionResult> GetProjectListAsync()
        {
            var projectList = await _projectService.GetProjectListAsync();
            return Ok(projectList);
        }
    }
}