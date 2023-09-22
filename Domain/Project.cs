using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToMany.Domain;//gruppera domain klasser 

public class Project//Skapar upp en klass
{
    public int Id { get; set; }//primärnyckel

    [MaxLength(50)]//begränsar längden på en sträng - påverkar hur migreringen ser ut 
    public required string Name { get; set; }

    [MaxLength(50)]//begränsar längden på en sträng - påverkar hur migreringen ser ut 
    public required string Description { get; set; }
 
    public required DateTime Deadline { get; set; }


}