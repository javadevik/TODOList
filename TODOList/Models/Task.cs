using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TODOList.Models;

public class Task
{
    public Task()
    {
    }

    public Task(int id, string title, string description, DateTime createdAt)
    {
        Id = id;
        Title = title;
        Description = description;
        CreatedAt = createdAt;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    
    [DisplayName(displayName: "Created at")]
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
}