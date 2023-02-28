using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class ReasonForSeparation
    {
        public ReasonForSeparation()
        {
            QuestionAnswers = new HashSet<QuestionAnswer>();
        }

        public int ReasonForSeparationId { get; set; }
        public string ReasonName { get; set; } = null!;

        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
