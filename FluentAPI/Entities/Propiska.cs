using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPI.Entities
{
    public class Propiska
    {
        public int Id { get; set; }
        public string GivenDay { get; set; }

        
        public int UserId { get; set; }
        public Users User { get; set; } 
    }
}
