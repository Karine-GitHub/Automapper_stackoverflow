using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using Oncolin.Common;

namespace Oncolin.Entities
{
    public class PatientEntity : BaseEntity
    {
        #region Données d'enregistrement du patient

        public virtual string Pseudonyme { get; set; }

        [Database(ColumnName = "I_ID_RHC")]
        public override int Id { get; set; }

        [Database(ColumnName = "I_RHC_ETAB")]
        public virtual int? Hopital { get; set; }

        public virtual string NumeroDossierPatient { get; set; }

        [Database(ColumnName = "I_DMC_I_RHC_ETAB")]
        public virtual int? DMCCreateur { get; set; }

        [Database(ColumnName = "I_REFUS_ON")]
        public virtual int? Refus { get; set; }


        public virtual AuditTraceEntity AuditTrace { get; set; }
        #endregion

        #region Données administratives
         
        public virtual string NomNaissance { get; set; }
        
        
        public virtual string Prenoms { get; set; }
        
        
        public virtual string NomUsage { get; set; }

        
        public virtual string AutresNoms { get; set; }

        [Database(ColumnName = "I_SEXE")]
        public virtual int? SexeAdministratif { get; set; }

        [Database(ColumnName = "I_SEXEMED")]
        public virtual int? SexeMedical { get; set; }

        [Database(ColumnName = "I_NAISS_DATE")]
        public virtual DateValue DateDeNaissance { get; set; }

        [Database(ColumnName = "I_NAISS_PAYS")]
        public virtual int? PaysNaissance { get; set; }

        
        public virtual string Matricule { get; set; }

        [Database(ColumnName = "I_AFFILIATION")]
        public virtual int? Affiliation { get; set; }

        [Database(ColumnName = "I_TRAIT_KONTACT")]
        public virtual int? MedecinTraitant { get; set; }

        #endregion

        #region Dernière adresse connue

        [Database(ColumnName = "I_PAYS")]
        public virtual int? Pays { get; set; }

        [Database(ColumnName = "I_COMMUNE")]
        public virtual int? Commune { get; set; }

        #endregion

        #region Dernier suivi du patient

        [Database(ColumnName = "I_DERNIER_DATE")]
        public virtual DateValue DateDernierContact { get; set; }

        [Database(ColumnName = "I_DERNIER_ETAT")]
        public virtual int? EtatDernierContact { get; set; }

        [Database(ColumnName = "I_DERNIERE_VERIF_DOSSIER_DATE")]
        public virtual DateValue DerniereVerificationDossier { get; set; }

        #endregion

        #region Décès

        [Database(ColumnName = "I_DECES_DATE")]
        public virtual DateValue DateDeces { get; set; }

        [Database(ColumnName = "I_DECESCAUSE")]
        public virtual int? CauseDeces { get; set; }

        [Database(ColumnName = "I_AUTOPSIE")]
        public virtual int? AutopsieRealisee { get; set; }

        [Database(ColumnName = "I_AUTOPSIE_RESULT_TEXT")]
        public virtual string ResultatsAutopsie { get; set; }

        #endregion

        #region Autres

        [Database(ColumnName = "I_COMMENT")]
        public virtual string Commentaires { get; set; }

        #endregion

        #region Variables de migration

        [Database(ColumnName = "I_ID")]
        public virtual string AncienPseudonyme { get; set; }

        #endregion

        public virtual ICollection<TumorEntity> Tumors { get; set; } = new Collection<TumorEntity>();

        public virtual int ErrorsCount { get; set; }

        public static Expression<Func<PatientEntity, int>> IdProperty => t => t.Id;
        public static Expression<Func<PatientEntity, string>> PseudonymeProperty => p => p.Pseudonyme;
        public static Expression<Func<PatientEntity, string>> NumeroDossierPatientProperty => p => p.NumeroDossierPatient;
        public static Expression<Func<PatientEntity, string>> NomNaissanceProperty => p => p.NomNaissance;
        public static Expression<Func<PatientEntity, string>> NomUsageProperty => p => p.NomUsage;
        public static Expression<Func<PatientEntity, string>> AutresNomsProperty => p => p.AutresNoms;
        public static Expression<Func<PatientEntity, string>> PrenomsProperty => p => p.Prenoms;
        public static Expression<Func<PatientEntity, string>> MatriculeProperty => p => p.Matricule;
        public static Expression<Func<PatientEntity, ICollection<TumorEntity>>> TumorsProperty => p => p.Tumors;
        public static Expression<Func<PatientEntity, AuditTraceEntity>> AuditTraceProperty => p => p.AuditTrace;
        public static Expression<Func<PatientEntity, int?>> PaysNaissanceProperty => p => p.PaysNaissance;
        public static Expression<Func<PatientEntity, int?>> PaysProperty => p => p.Pays;
        public static Expression<Func<PatientEntity, int?>> CommuneProperty => p => p.Commune;
        public static Expression<Func<PatientEntity, DateValue>> DateDeNaissanceProperty => p => p.DateDeNaissance;
        public static Expression<Func<PatientEntity, int?>> EtatDernierContactProperty => p => p.EtatDernierContact;
        public static Expression<Func<PatientEntity, int?>> SexeAdministratifProperty => p => p.SexeAdministratif;
        public static Expression<Func<PatientEntity, int?>> RefusProperty => p => p.Refus;
    }
}
