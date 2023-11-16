using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPI.Entities
{
    public class Homes
    {
        public int Id { get; set; }
        public string Location {  get; set; }

        public int UserId { get; set; } 
        public Users User { get; set; }
    }
}
