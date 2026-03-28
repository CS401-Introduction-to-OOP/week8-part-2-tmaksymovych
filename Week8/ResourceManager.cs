namespace Week8;

class ResourceManager<T> where T : Resource
{
    private List<T> _resource = new List<T>();

    public void AddResource(T resource)
    {
        _resource.Add(resource);
    }

    public void OpenAll()
    {
        foreach (var item in _resource)
        {
            item.Open();
        }
    }

    public void CloseAll()
    {
        foreach (var item in _resource)
        {
            item.Close();
        }
    }
}