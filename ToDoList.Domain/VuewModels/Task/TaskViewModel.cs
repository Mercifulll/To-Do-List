using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.ViewModels.Task;

public class TaskViewModel
{
    public long Id { get; set; }
    
    [Display(Name = "Name")]
    public string Name { get; set; }
    
    [Display(Name = "Priority")]
    public string Priority { get; set; }
    
    [Display(Name = "Description")]
    public string Description { get; set; }
    
    [Display(Name = "Readiness")]
    public string IsDone { get; set; }
    
    [Display(Name = "Date created")]
    public string Created { get; set; }
}