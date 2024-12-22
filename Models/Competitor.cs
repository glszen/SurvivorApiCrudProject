using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurvivorProject.Models
{
    public class Competitor
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsDeleted { get; set; }

        public string FirstName {  get; set; }

        public string LastName { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
