using System;

namespace Oncolin.Entities
{
    public class TreatmentEntity : BaseEntity
    {

        public override int Id { get; set; }

        public virtual int? TypeTraitement { get; set; }

        public virtual int? Surveillance { get; set; }

        public virtual int? EtablissementTraitement { get; set; }

        public virtual String Commentaires { get; set; }

        public virtual TumorEntity TreatedTumor { get; set; }

        public virtual Guid Identifier { get; set; }
    }
}
