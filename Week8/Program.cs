namespace Week8;

class Program
{
    public static void Main()
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();
        
        manager.AddResource(file);
        manager.AddResource(network);
        manager.OpenAll();

        using (var fl = new FileResource("data.csv"))
        {
            fl.Open();
        }
        manager.CloseAll();
    }
    
}