using System;
using AutoMapper;
using Oncolin.Entities;
using Oncolin.Model.Oncology;

namespace Oncolin.Model.Common
{
    public abstract class BaseProxyNotifyModel<TModel, TEntity> : BaseModel
        where TModel : class, IModel
        where TEntity : class, IEntity
    {
        //protected readonly IMapper _mapper = null;
        public TEntity Entity { get; set; } = Activator.CreateInstance(typeof(TEntity)) as TEntity;

        //public BaseProxyNotifyModel(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}
    }
}
