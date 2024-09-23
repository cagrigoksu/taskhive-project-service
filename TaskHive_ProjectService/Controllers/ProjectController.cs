using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TaskHive_ProjectService.Enums;
using TaskHive_ProjectService.Models;
using TaskHive_ProjectService.Models.Data;
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

        [HttpGet("get-projects")]
        public async Task<IActionResult> GetProjectsAsync()
        {
            var projectList = await _projectService.GetProjectsAsync();
            return Ok(projectList);
        }

        [HttpPost("create-project")]
        public async Task<IActionResult> CreateProjectAsync(ProjectDataModel project)
        {
            var result = await _projectService.CreateProjectAsync(project);

            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("get-status-enum")]
        public async Task<IActionResult> GetStatusEnum()
        {
            var result = Enum.GetValues(typeof(StatusEnum))
                    .Cast<StatusEnum>()
                    .Select(e => new {
                        id = (int)e, // enum id
                        value = e.ToString() // enum value
                    }).ToList();

            if (result != null)
            {
                return Ok(result); // Return the custom JSON structure
            }
            return BadRequest();
        }

        [HttpGet("get-priority-enum")]
        public async Task<IActionResult> GetPriorityEnum()
        {
            var result = Enum.GetValues(typeof(PriorityEnum))
                    .Cast<PriorityEnum>()
                    .Select(e => new {
                        id = (int)e, // enum id
                        value = e.ToString() // enum value
                    }).ToList();

            if (result != null)
            {
                return Ok(result); // Return the custom JSON structure
            }
            return BadRequest();
        }


    }
}