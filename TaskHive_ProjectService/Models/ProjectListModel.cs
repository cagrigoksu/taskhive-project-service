namespace TaskHive_ProjectService.Models{
    public class ProjectListModel{

        public int Id {get; set;}
        public string Name {get; set;}
        public string Department {get; set;}
        public string Owner {get; set;}

        //TODO Add number of members after configuring table on db.
    }
}