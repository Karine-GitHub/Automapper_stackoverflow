namespace Oncolin.Entities
{
    /// <summary>
    /// Base interface for every persisted entity.
    /// </summary>
    public interface IEntity
    {
        #region Properties, fields and constants

        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        int Id { get; set; }

        #endregion
    }
}
