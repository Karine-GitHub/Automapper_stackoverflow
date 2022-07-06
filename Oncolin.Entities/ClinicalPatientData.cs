using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Oncolin.Entities
{
    public class ClinicalPatientData : BaseEntity
    {
        public virtual string Pseudonyme { get; set; }

        public override int Id { get; set; }

        public virtual string Commentaires { get; set; }

        public virtual ICollection<TumorEntity> Tumors { get; set; } = new Collection<TumorEntity>();
    }
}
