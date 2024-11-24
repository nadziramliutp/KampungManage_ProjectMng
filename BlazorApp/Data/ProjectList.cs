namespace BlazorApp.Data
{
    public class ProjectList
    {
        public List<string> List { get; set; }
        public ProjectList()
        {
            List = new List<string>();
        }
        public void Add(string name)
        {
            List.Add(name);
            Console.WriteLine("Succesfull add project {0} to list ", name);
        }
        public void Remove(string name)
        {
            List.Remove(name);
        }

    }
}
