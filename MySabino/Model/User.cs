namespace MySabinoRoad.Model
{
    public class User
    {
        public EntityType EntityType { get; set; }
        public int EntityTypeId { get; set; }
        public string UserName { get; set; }
        public bool IsConfirmed { get; set; }
        public string LastActivityDateTime { get; set; }
        public string LastLoginDateTime { get; set; }
        public string LastPasswordChangedDateTime { get; set; }
        public bool IsOnLine { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsPasswordChangeRequired { get; set; }
        public object LastLockedOutDateTime { get; set; }
        public object FailedPasswordAttemptCount { get; set; }
        public object FailedPasswordAttemptWindowStartDateTime { get; set; }
        public object LastPasswordExpirationWarningDateTime { get; set; }
        public object ApiKey { get; set; }
        public int PersonId { get; set; }
        public string ConfirmationCode { get; set; }
        public string ConfirmationCodeEncoded { get; set; }
        public string CreatedDateTime { get; set; }
        public string ModifiedDateTime { get; set; }
        public int CreatedByPersonAliasId { get; set; }
        public object ModifiedByPersonAliasId { get; set; }
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }
        public object Attributes { get; set; }
        public object AttributeValues { get; set; }
        public int Id { get; set; }
        public string Guid { get; set; }
        public object ForeignId { get; set; }
        public object ForeignGuid { get; set; }
        public object ForeignKey { get; set; }
    }
}