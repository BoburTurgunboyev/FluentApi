using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPI.Entities
{
    public class Users
    {
        public int Id {  get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("PropiskaId")]
        public Propiska Propiska { get; set; }

        [ForeignKey("HomeID")]
        public ICollection<Homes> Home { get; set; }   

        
        


        

    }
}
