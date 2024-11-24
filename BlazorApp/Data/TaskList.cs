namespace BlazorApp.Data
{
    public class TaskList
    {
        public List<TaskModel> List { get; set; }
        public TaskList()
        {
            List = new List<TaskModel>();
        }
        public void Add(string name, string project, string team)
        {
            List.Add(new TaskModel { Title = name, Assignee = team, ProjectName = project });
            Console.WriteLine("Succesfull add task {0} to list ", name);
        }
        public void Remove(string name)
        {
            List.Remove(new TaskModel { Title = name });
        }
        
    }
}
