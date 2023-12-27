using ToDoList.Domain.Enum;

namespace ToDoList.Domain.ViewModels.Task;

public class CreateTaskViewModel
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public Priority Priority { get; set; }

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new ArgumentNullException(Name, "Напишіть назву задачі, будь ласка");
        }
        if (string.IsNullOrWhiteSpace(Description))
        {
            throw new ArgumentNullException(Description, "Додайте опис задачі, будь ласка");
        }
    }
}