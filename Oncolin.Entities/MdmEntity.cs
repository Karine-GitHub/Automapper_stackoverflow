using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Oncolin.Entities
{
    public class MdmEntity : BaseEntity
    {
        public override int Id { get; set; }

        public virtual int? RealisationRCP { get; set; }

        public virtual int? LieuRCP { get; set; }

        public virtual int? IntituleRCP { get; set; }

        public virtual String Commentaires { get; set; }

        [JsonProperty(ItemTypeNameHandling = TypeNameHandling.Objects, ItemReferenceLoopHandling = ReferenceLoopHandling.Ignore)]
        public virtual ICollection<TumorEntity> DiscussedTumors { get; set; } = new Collection<TumorEntity>();

        public virtual Guid Identifier { get; set; }
    }
}
