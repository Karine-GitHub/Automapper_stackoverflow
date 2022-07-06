using System;
using System.Linq.Expressions;
using Oncolin.Common;

namespace Oncolin.Entities
{
    public interface IConfidentialPatientData
    {
        int Id { get; set; }
        #region Registration data
        string NumeroDossierPatient { get; set; }
        #endregion

        #region Administrative data
        string NomNaissance { get; set; }
        string Prenoms { get; set; }
        string NomUsage { get; set; }
        string AutresNoms { get; set; }
        string Matricule { get; set; }
        #endregion
    }

    [DatabaseTarget(Target = DatabaseType.Confidential)]
    public class ConfidentialPatientData : IConfidentialPatientData, IEntity, IConfidentialAudited
    {
        public virtual string Pseudonyme { get; set; }

        [Database(ColumnName = "I_ID_RHC", IgnorePreUpdateEvent = true)]
        public virtual int Id { get; set; }
        public static Expression<Func<ConfidentialPatientData, int>> ConfidentialPatientIdProperty => p => p.Id;

        [Database(ColumnName = "I_ID_CLINICAL", IgnorePreUpdateEvent = true)]
        public virtual int ClinicalPatientId { get; set; }
        public static Expression<Func<ConfidentialPatientData, int>> ClinicalPatientIdProperty => p => p.ClinicalPatientId;

        public virtual string NumeroDossierPatient { get; set; }

        public virtual string NomNaissance { get; set; }

        public virtual string Prenoms { get; set; }

        public virtual string NomUsage { get; set; }

        public virtual string AutresNoms { get; set; }

        public virtual string Matricule { get; set; }

        // migration
        [Database(ColumnName = "I_ID", IgnorePreUpdateEvent = true)]
        public virtual string AncienPseudonyme { get; set; }

        public virtual ConfidentialAuditTrace AuditTrace { get; set; }
    }
}
