using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Oncolin.Entities
{
    public class TumorEntity : BaseEntity
    {
        public virtual Guid Identifier { get; set; }

        public override int Id { get; set; }

        public virtual int? Rang { get; set; }

        public virtual int? BaseDiagnostic { get; set; }

        public virtual int? Topographie { get; set; }

        public virtual int? Lateralite { get; set; }

        public virtual int? Morphologie { get; set; }

        public virtual int? Grade { get; set; }

        public virtual int? Multifocalite { get; set; }

        public virtual string Commentaires { get; set; }

        public virtual int? TraitementInitial { get; set; }

        public virtual ClinicalPatientData Patient { get; set; }

        public virtual ICollection<TreatmentEntity> Treatments { get; set; } = new Collection<TreatmentEntity>();

        public virtual ICollection<MdmEntity> RelatedMDMs { get; set; } = new Collection<MdmEntity>();

        public static Expression<Func<TumorEntity, int>> IdProperty => t => t.Id;
        public static Expression<Func<TumorEntity, ICollection<TreatmentEntity>>> TreatmentsProperty => t => t.Treatments;

        public static Expression<Func<TumorEntity, ICollection<MdmEntity>>> RelatedMDMsProperty => t => t.RelatedMDMs;

        public static Expression<Func<TumorEntity, int>> IdRHCTumeurProperty => t => t.Id;
        public static Expression<Func<TumorEntity, ClinicalPatientData>> PatientProperty => t => t.Patient;
    }
}
