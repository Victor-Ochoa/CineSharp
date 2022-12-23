using Flunt.Notifications;

namespace CineSharp.Domain.Core.Entities;

public abstract class Entity : Notifiable<Notification>
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }
}
