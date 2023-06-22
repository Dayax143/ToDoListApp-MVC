using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListApp.Models
{
    public class Task
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime StartDate { get; set; } = DateTime.UtcNow;

        public DateTime EndDate { get; set; }

        [ForeignKey("Project")]
        public string ProjectId { get; set; }
        public Project Project { get; set; }


        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Title) 
                || string.IsNullOrEmpty(Description)
                || string.IsNullOrEmpty(ProjectId)
                || StartDate == DateTime.MinValue
                || EndDate == DateTime.MinValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
