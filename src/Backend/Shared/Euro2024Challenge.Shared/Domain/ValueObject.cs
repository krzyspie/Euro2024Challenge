namespace Euro2024Challenge.Shared.Domain;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public bool Equals(ValueObject? other)
    {
        throw new NotImplementedException();
    }
}