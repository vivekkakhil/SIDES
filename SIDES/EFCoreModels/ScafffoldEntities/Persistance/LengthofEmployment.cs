using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class LengthofEmployment
    {
        public LengthofEmployment()
        {
            QuestionAnswers = new HashSet<QuestionAnswer>();
        }

        public int LengthofEmploymentId { get; set; }
        public string LengthofEmploymentName { get; set; } = null!;

        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
