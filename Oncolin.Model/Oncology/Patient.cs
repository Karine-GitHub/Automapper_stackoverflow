using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Oncolin.Entities;
using System;

namespace Oncolin.Model.Oncology
{
    public class Patient : BaseModel
    {
        public IMapper _mapper { get; set; }

        ClinicalPatientData _clinicalData = new ClinicalPatientData();

        public override int Id
        {
            get { return ClinicalPatientId; }
            set { ClinicalPatientId = value; }
        }

        string _pseudonyme;
        public virtual string Pseudonyme
        {
            get => _pseudonyme;
            set
            {
                if (!object.Equals(_pseudonyme, value))
                {
                    _clinicalData.Pseudonyme = value;
                    _pseudonyme = value;
                }
            }
        }

        int _clinicalPatientId;
        /// <summary>
        /// ClinicalPatientId
        /// </summary>
        public virtual int ClinicalPatientId
        {
            get => _clinicalPatientId;
            set
            {
                if (!object.Equals(_clinicalPatientId, value))
                {
                    _clinicalData.Id = value;
                    _clinicalPatientId = value;
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
                    _commentaires = value;
                    _clinicalData.Commentaires = value;
                }
            }
        }

        private System.Collections.ObjectModel.ObservableCollection<Tumor> _tumors = new System.Collections.ObjectModel.ObservableCollection<Tumor>();
        public virtual System.Collections.ObjectModel.ObservableCollection<Tumor> Tumors
        {
            get => _tumors;
            set
            {
                _tumors = value ?? new System.Collections.ObjectModel.ObservableCollection<Tumor>();
                //_mapper.Map(_tumors, _clinicalData.Tumors);
            }
        }
    }
}
