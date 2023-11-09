namespace Danilvar.Entity;

public abstract class Entity : IEquatable<Entity>
{
    public string Id { get; private init; }

    protected Entity()
    {
        Id = Guid.NewGuid().ToString("N");
    }

    public static bool operator ==(Entity? right, Entity? left) =>
        right is not null && left is not null && right.Equals(left);

    public static bool operator !=(Entity? right, Entity? left) =>
        !(right == left);

    public bool Equals(Entity? other)
    {
        if (other is null)
            return false;

        if (other.GetType() != GetType())
            return false;

        return other.Id == Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;

        if (obj.GetType() != GetType())
            return false;

        if (obj is not Entity entity)
            return false;

        return entity.Id == Id;
    }

    public override int GetHashCode() => Id.GetHashCode();
}