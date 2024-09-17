using System.ComponentModel.DataAnnotations;

namespace TaskHive_ProjectService.Models.Data
{
    public class ProjectDataModel
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public required string ProjectName {get; set;}
        [Required]
        public required string  Department {get; set;}
        [Required]
        public required string Team {get; set;}
        [Required]
        public required string Manager {get; set;}
        [Required]
        public int NumberOfMembers {get; set;}
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeleteDate { get; set; }
        public int DeleteUser { get; set; }
    }
}