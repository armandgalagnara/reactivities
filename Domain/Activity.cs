using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Activity
    {
        [Key]
        public Guid Id { get; set; }
        public String Title { get; set; }
        public DateTime Date { get; set; }
        public String Description { get; set; }
        public String Category { get; set; }
        public String City { get; set; }
        public String Venue { get; set; }
    }
}