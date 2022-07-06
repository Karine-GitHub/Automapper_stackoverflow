using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Oncolin.Entities;
using Oncolin.Model.Common;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Oncolin.Model.Oncology
{
    public class Tumor : BaseProxyNotifyModel<Tumor, TumorEntity>
    {
        //public Tumor(IMapper mapper) : base(mapper) { }

        public override int Id
        {
            get => IdRHCTumeur;
            set => IdRHCTumeur = value;
        }

        public Guid Identifier { get; set; }

        int _idRHCTumeur;
        public virtual int IdRHCTumeur
        {
            get => _idRHCTumeur;
            set
            {
                if (!object.Equals(_idRHCTumeur, value))
                {
                    Entity.Id = value;
                    _idRHCTumeur = value;
                }
            }
        }

        int? _rang;
        public virtual int? Rang
        {
            get => _rang;
            set
            {
                if (!object.Equals(_rang, value))
                {
                    Entity.Rang = value;
                    _rang = value;
                }
            }
        }

        int? _baseDiagnostic;
        public virtual int? BaseDiagnostic
        {
            get => _baseDiagnostic;
            set
            {
                if (!object.Equals(_baseDiagnostic, value))
                {
                    Entity.BaseDiagnostic = value;
                    _baseDiagnostic = value;
                }
            }
        }

        int? _topographie;
        public virtual int? Topographie
        {
            get => _topographie;
            set
            {
                if (!object.Equals(_topographie, value))
                {
                    Entity.Topographie = value;
                    _topographie = value;
                }
            }
        }

        int? _lateralite;
        public virtual int? Lateralite
        {
            get => _lateralite;
            set
            {
                if (!object.Equals(_lateralite, value))
                {
                    Entity.Lateralite = value;
                    _lateralite = value;
                }
            }
        }

        int? _morphologie;
        public virtual int? Morphologie
        {
            get => _morphologie;
            set
            {
                if (!object.Equals(_morphologie, value))
                {
                    Entity.Morphologie = value;
                    _morphologie = value;
                }
            }
        }

        int? _grade;
        public virtual int? Grade
        {
            get => _grade;
            set
            {
                if (!object.Equals(_grade, value))
                {
                    Entity.Grade = value;
                    _grade = value;
                }
            }
        }

        int? _multifocalite;
        public virtual int? Multifocalite
        {
            get => _multifocalite;
            set
            {
                if (!object.Equals(_multifocalite, value))
                {
                    Entity.Multifocalite = value;
                    _multifocalite = value;
                }
            }
        }

        string _commentaires;
        public virtual string Commentaires
        {
            get => _commentaires;
            set
            {
                if (!object.Equals(_commentaires, value))
                {
                    Entity.Commentaires = value;
                    _commentaires = value;
                }
            }
        }

        int? _traitementInitial;
        public virtual int? TraitementInitial
        {
            get => _traitementInitial;
            set
            {
                if (!object.Equals(_traitementInitial, value))
                {
                    Entity.TraitementInitial = value;
                    _traitementInitial = value;
                }
            }
        }

        Patient _patient;
        public virtual Patient Patient
        {
            get => _patient;
            set
            {
                if (!object.Equals(_patient, value))
                {
                    _patient = value;
                    if (Entity.Patient == null) Entity.Patient = new ClinicalPatientData();
                    //_mapper.Map(_patient, Entity.Patient);
                }
            }
        }

        private System.Collections.ObjectModel.ObservableCollection<Treatment> _treatments = new System.Collections.ObjectModel.ObservableCollection<Treatment>();
        public virtual System.Collections.ObjectModel.ObservableCollection<Treatment> Treatments
        {
            get => _treatments;
            set
            {
                _treatments = value ?? new System.Collections.ObjectModel.ObservableCollection<Treatment>();
                //_mapper.Map(_treatments, Entity.Treatments);
            }
        }

        public static Expression<Func<Tumor, ICollection<Treatment>>> TreatmentsProperty => t => t.Treatments;

        private System.Collections.ObjectModel.ObservableCollection<MDM> _mdms = new System.Collections.ObjectModel.ObservableCollection<MDM>();
        public virtual System.Collections.ObjectModel.ObservableCollection<MDM> MDMs
        {
            get => _mdms;
            set
            {
                _mdms = value ?? new System.Collections.ObjectModel.ObservableCollection<MDM>();
                //_mapper.Map(_mdms, Entity.RelatedMDMs);
            }
        }
    }
}
