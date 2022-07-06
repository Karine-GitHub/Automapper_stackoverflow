using AutoMapper;
using Oncolin.Entities;
using Oncolin.Model.Common;
using System;

namespace Oncolin.Model.Oncology
{
    public class MDM : BaseProxyNotifyModel<MDM, MdmEntity>
    {
        //public MDM(IMapper mapper) : base(mapper) { }

        public override int Id { get { return IdRHCRCP; } set { IdRHCRCP = value; } }

        public Guid Identifier { get; set; }

        int _idRHCRCP;
        public virtual int IdRHCRCP
        {
            get => _idRHCRCP;
            set
            {
                if (!Object.Equals(_idRHCRCP, value))
                {
                    Entity.Id = value;
                    _idRHCRCP = value;
                }
            }
        }

        int? _realisationRCP;
        public virtual int? RealisationRCP
        {
            get => _realisationRCP;
            set
            {
                if (!Object.Equals(_realisationRCP, value))
                {
                    Entity.RealisationRCP = value;
                    _realisationRCP = value;
                }
            }
        }

        int? _lieuRCP;
        public virtual int? LieuRCP
        {
            get => _lieuRCP;
            set
            {
                if (!Object.Equals(_lieuRCP, value))
                {
                    Entity.LieuRCP = value;
                    _lieuRCP = value;
                }
            }
        }

        int? _intituleRCP;
        public virtual int? IntituleRCP
        {
            get => _intituleRCP;
            set
            {
                if (!Object.Equals(_intituleRCP, value))
                {
                    Entity.IntituleRCP = value;
                    _intituleRCP = value;
                }
            }
        }

        String _commentaires;
        public virtual String Commentaires
        {
            get => _commentaires;
            set
            {
                if (!Object.Equals(_commentaires, value))
                {
                    Entity.Commentaires = value;
                    _commentaires = value;
                }
            }
        }

        private System.Collections.ObjectModel.ObservableCollection<Tumor> _discussedTumors = new System.Collections.ObjectModel.ObservableCollection<Tumor>();
        public virtual System.Collections.ObjectModel.ObservableCollection<Tumor> DiscussedTumors
        {
            get => _discussedTumors; 
            set
            {
                _discussedTumors = value ?? new System.Collections.ObjectModel.ObservableCollection<Tumor>();
                //_mapper.Map(_discussedTumors, Entity.DiscussedTumors);
            }
        }
    }
}
