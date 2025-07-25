using Clop.Domain.Interfaces;

namespace Clop.Domain.Entity;

public class User : IAuditable, IEntityId<long>
{
    public long Id { get; set; }
    
    public string Login { get; set; }
    
    public string Password { get; set; }
    
    public List<Profile> Profiles { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}