using AutoMapper;
using Oncolin.Entities;
using Oncolin.Model.Oncology;
using AutoMapper.EquivalencyExpression;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Oncolin.Model
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<ClinicalPatientData, Patient>()
                .ForMember(d => d.ClinicalPatientId, opt => opt.MapFrom(x => x.Id))
                .ForMember(d => d.Commentaires, opt => opt.MapFrom(x => x.Commentaires))
                .ForMember(d => d.Pseudonyme, opt => opt.MapFrom(x => x.Pseudonyme))
                .ForMember(x => x.Tumors, opt => opt.MapFrom(x => x.Tumors));
            CreateMap<Patient, ClinicalPatientData>()
                .ForMember(d => d.Id, opt => opt.MapFrom(x => x.ClinicalPatientId))
                .ForMember(d => d.Commentaires, opt => opt.MapFrom(x => x.Commentaires))
                .ForMember(d => d.Pseudonyme, opt => opt.MapFrom(x => x.Pseudonyme))
                .ForMember(x => x.Tumors, opt => opt.MapFrom(x => x.Tumors));

            CreateMap<TumorEntity, Tumor>()
                .ForMember(x => x.MDMs, opt => opt.MapFrom(x => x.RelatedMDMs))
                .EqualityComparison((s, d) => s.Identifier == d.Identifier)
                .PreserveReferences();
            CreateMap<Tumor, TumorEntity>()
                .ForMember(x => x.RelatedMDMs, opt => opt.MapFrom(x => x.MDMs))
                .EqualityComparison((s, d) => s.Identifier == d.Identifier)
                .PreserveReferences();

            CreateMap<TreatmentEntity, Treatment>()
                .EqualityComparison((s, d) => s.Identifier == d.Identifier)
                .PreserveReferences();
            CreateMap<Treatment, TreatmentEntity>()
                .EqualityComparison((s, d) => s.Identifier == d.Identifier)
                .PreserveReferences();

            CreateMap<MdmEntity, MDM>()
                .EqualityComparison((s, d) => s.Identifier == d.Identifier)
                .PreserveReferences();
            CreateMap<MDM, MdmEntity>()
                .EqualityComparison((s, d) => s.Identifier == d.Identifier)
                .PreserveReferences();
        }
    }
}
