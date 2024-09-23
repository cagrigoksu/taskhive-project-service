using System.ComponentModel.DataAnnotations;
using TaskHive_ProjectService.Enums;

namespace TaskHive_ProjectService.Models.Data
{
    public class ProjectDataModel
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public required string Name {get; set;}
        public string Description {get; set;}
        [Required]
        public DateTime StartDate {get; set;}
        [Required]
        public DateTime EndDate {get; set;}
        [Required]
        public required StatusEnum StatusId {get; set;}
        [Required]
        public required PriorityEnum PriorityId {get; set;}
        public float Budget {get; set;}
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set;}
        public DateTime LastUpdateDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeleteDate { get; set; }
        public int DeleteUser { get; set; }
    }
}