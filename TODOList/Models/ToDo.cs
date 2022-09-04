namespace TODOList.Models;

public class ToDo
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Task { get; set; }
    public DateTime CreatedAt { get; set; }
}