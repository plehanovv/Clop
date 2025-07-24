using Clop.Domain.Interfaces;

namespace Clop.Domain.Entity;

public class Profile : IEntityId<long>
{
    public long Id { get; set; }
    
    public int Age { get; set; }
    
    public string Address { get; set; }
    
    public User User { get; set; }
    
    public long UserId { get; set; }
}