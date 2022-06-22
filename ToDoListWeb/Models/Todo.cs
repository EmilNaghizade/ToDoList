using System.ComponentModel.DataAnnotations;

namespace ToDoListWeb.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Description { get; set; }

        public bool IsDone { get; set; }

        public DateTime Date { get; set; }  = DateTime.Now;

         
    }
}
