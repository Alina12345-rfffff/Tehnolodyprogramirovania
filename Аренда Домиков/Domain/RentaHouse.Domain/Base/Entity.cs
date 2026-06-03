using System;

namespace RentaHouse.Domain.Base
{
    /// <summary>
    /// Represents an entity in the system.
    /// </summary>
    /// <typeparam name="TId">The type of the entity's ID.</typeparam>
    /// <param name="id">The ID of the entity.</param>
    public abstract class Entity<TId>(TId id) where TId : IEquatable<TId>
    {
        /// <summary>
        /// Gets the ID of the entity.
        /// </summary>
        public TId Id { get; } = id;

        /// <summary>
        /// Protected constructor for entity framework if needed.
        /// </summary>
        protected Entity() : this(default!)
        {
        }

        // Переопределяем Equals для корректного сравнения сущностей по их идентификаторам
        public override bool Equals(object? obj)
        {
            if (obj is not Entity<TId> other) return false;
            if (ReferenceEquals(this, other)) return true;
            if (Id is null || other.Id is null) return false;
            return Id.Equals(other.Id);
        }

        public override int GetHashCode() => Id?.GetHashCode() ?? 0;
    }
}
