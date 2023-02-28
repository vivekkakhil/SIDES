using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class Question
    {
        public int QuestionId { get; set; }
        public string? Question1 { get; set; }
        public string? IsActive { get; set; }
    }
}
