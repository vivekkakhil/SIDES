using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class UserDetail
    {
        public int UserDetailId { get; set; }
        public int? UserId { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyAdd1 { get; set; }
        public string? CompanyAdd2 { get; set; }
        public string? City { get; set; }
        public string? StateCode { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public string? WorkTelephone { get; set; }
        public string? WorkFax { get; set; }
        public int? QuestionId { get; set; }
        public string? Ans { get; set; }
    }
}
