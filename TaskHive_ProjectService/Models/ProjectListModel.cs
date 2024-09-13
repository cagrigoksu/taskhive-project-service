namespace TaskHive_ProjectService.Models{
    public class ProjectListModel{

        public int Id {get; set;}
        public required string ProjectName {get; set;}
        public required string  Department {get; set;}
        public required string Team {get; set;}
        public required string Manager {get; set;}
        public int NumberOfMembers {get; set;}
    }
}