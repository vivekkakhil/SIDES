using System;
using System.Collections.Generic;

namespace SIDES.EFCoreModels.ScafffoldEntities.Persistance
{
    public partial class AspnetMembership
    {
        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string Password { get; set; } = null!;
        public int PasswordFormat { get; set; }
        public string PasswordSalt { get; set; } = null!;
        public string? MobilePin { get; set; }
        public string? Email { get; set; }
        public string? LoweredEmail { get; set; }
        public string? PasswordQuestion { get; set; }
        public string? PasswordAnswer { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastPasswordChangedDate { get; set; }
        public DateTime LastLockoutDate { get; set; }
        public int FailedPasswordAttemptCount { get; set; }
        public DateTime FailedPasswordAttemptWindowStart { get; set; }
        public int FailedPasswordAnswerAttemptCount { get; set; }
        public DateTime FailedPasswordAnswerAttemptWindowStart { get; set; }
        public string? Comment { get; set; }
        public bool ExecutiveMenuYn { get; set; }
        public bool CreateUserYn { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? FaxNumber { get; set; }
        public string? JobTitle { get; set; }
        public bool? ViewAllSidesSi { get; set; }

        public virtual AspnetApplication Application { get; set; } = null!;
        public virtual AspnetUser User { get; set; } = null!;
    }
}
