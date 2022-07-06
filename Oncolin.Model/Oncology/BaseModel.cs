using System;

namespace Oncolin.Model.Oncology
{
    public interface IModel
    {
        #region Properties, fields and constants

        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        int Id { get; set; }
        #endregion
    }

    public abstract class BaseModel : IModel
    {
        #region IModel abstract implementation

        public abstract int Id { get; set; }
        #endregion

        #region Equals / GetHashCode override

        public override bool Equals(object obj)
        {
            var other = obj as IModel;
            return (other != null) && Equals(this, other);
        }

        public static bool Equals(IModel a, IModel b)
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
