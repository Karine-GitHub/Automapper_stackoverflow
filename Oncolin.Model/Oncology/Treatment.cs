using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Oncolin.Entities;
using Oncolin.Model.Common;

namespace Oncolin.Model.Oncology
{
    public class Treatment : BaseProxyNotifyModel<Treatment, TreatmentEntity>
    {
        //public Treatment(IMapper mapper) : base(mapper) { }

        public override int Id { get { return IdRHCTraitement; } set { IdRHCTraitement = value; } }

        public Guid Identifier { get; set; }

        int _idRHCTraitement;
        public virtual int IdRHCTraitement
        {
            get => _idRHCTraitement;
            set
            {
                if (!Object.Equals(_idRHCTraitement, value))
                {
                    Entity.Id = value;
                    _idRHCTraitement = value;
                }
            }
        }
        int? _typeTraitement;
        public virtual int? TypeTraitement
        {
            get => _typeTraitement;
            set
            {
                if (!Object.Equals(_typeTraitement, value))
                {
                    Entity.TypeTraitement = value;
                    _typeTraitement = value;

                    /*
                    if (TreatedTumor != null)
                    {
                        TreatedTumor.RaisePropertyChanged(t => t.Treatments); // must be raised before reset PStade to null (otherwise the value is finally -2)
                        if (TreatedTumor.PStade.Equals(VariableValueConstants.NotApplicable)
                            || (!TreatedTumor.PStade_IsApplicable() && TreatedTumor.PStade.HasValue))
                        {
                            TreatedTumor.PStade = null;
                        }
                    }
                    */
                }
            }
        }

        int? _surveillance;
        public virtual int? Surveillance
        {
            get => _surveillance;
            set
            {
                if (!Object.Equals(_surveillance, value))
                {
                    Entity.Surveillance = value;
                    _surveillance = value;
                }
            }
        }

        int? _etablissementTraitement;
        public virtual int? EtablissementTraitement
        {
            get => _etablissementTraitement;
            set
            {
                if (!Object.Equals(_etablissementTraitement, value))
                {
                    Entity.EtablissementTraitement = value;
                    _etablissementTraitement = value;
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

        private Tumor _treatedTumor;
        public virtual Tumor TreatedTumor
        {
            get => _treatedTumor;
            set
            {
                if (!Object.Equals(_treatedTumor, value))
                {
                    _treatedTumor = value;
                    if (Entity.TreatedTumor == null) Entity.TreatedTumor = new TumorEntity();
                    //_mapper.Map(_treatedTumor, Entity.TreatedTumor);
                }
            }
        }
    }
}
