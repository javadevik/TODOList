using Task = TODOList.Models.Task;

namespace TODOList.Services;

public interface MockToDoService
{
    ICollection<Task> CreateMockList();
    ICollection<Task> CreateMockCompletedList();
}