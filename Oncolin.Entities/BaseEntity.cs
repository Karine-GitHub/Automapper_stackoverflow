using System;

namespace Oncolin.Entities
{
    /// <summary>
    /// Provides a default implementation for Equals and GetHashCode using the Id property.
    /// </summary>
    public abstract class BaseEntity : IEntity
    {
        #region IEntity abstract implementation

        public abstract int Id { get; set; }

        #endregion

        #region Equals / GetHashCode override

        public override bool Equals(object obj)
        {
            var other = obj as IEntity;
            return (other != null) && Equals(this, other);
        }

        public static bool Equals(IEntity a, IEntity b)
        {
            bool isEqual = false;

            if (a.Id != 0 || b.Id != 0)
            {
                isEqual = a.Id == b.Id;
            }
            else /* Id = other.Id = 0 */
            {
                /* Compare object references directly to etablish equality */
                isEqual = Object.ReferenceEquals(a, b);
            }

            return isEqual;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        #endregion
    }
}
