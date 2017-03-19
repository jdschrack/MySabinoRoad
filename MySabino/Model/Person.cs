using System.Collections.Generic;

namespace MySabinoRoad.Model
{
    public class Person
    {
        public ConnectionStatusValue ConnectionStatusValue { get; set; }
        public MaritalStatusValue MaritalStatusValue { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public Photo Photo { get; set; }
        public object RecordStatusReasonValue { get; set; }
        public RecordStatusValue RecordStatusValue { get; set; }
        public RecordTypeValue RecordTypeValue { get; set; }
        public object ReviewReasonValue { get; set; }
        public object SuffixValue { get; set; }
        public object TitleValue { get; set; }
        public List<User> Users { get; set; }
        public bool IsSystem { get; set; }
        public int RecordTypeValueId { get; set; }
        public int RecordStatusValueId { get; set; }
        public object RecordStatusLastModifiedDateTime { get; set; }
        public object RecordStatusReasonValueId { get; set; }
        public int ConnectionStatusValueId { get; set; }
        public object ReviewReasonValueId { get; set; }
        public bool IsDeceased { get; set; }
        public object TitleValueId { get; set; }
        public string FirstName { get; set; }
        public string NickName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public object SuffixValueId { get; set; }
        public int PhotoId { get; set; }
        public int BirthDay { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public int Gender { get; set; }
        public int MaritalStatusValueId { get; set; }
        public string AnniversaryDate { get; set; }
        public object GraduationYear { get; set; }
        public object GivingGroupId { get; set; }
        public string GivingId { get; set; }
        public int GivingLeaderId { get; set; }
        public string Email { get; set; }
        public bool IsEmailActive { get; set; }
        public object EmailNote { get; set; }
        public int EmailPreference { get; set; }
        public object ReviewReasonNote { get; set; }
        public string InactiveReasonNote { get; set; }
        public string SystemNote { get; set; }
        public object ViewedCount { get; set; }
        public int PrimaryAliasId { get; set; }
        public string FullName { get; set; }
        public string BirthdayDayOfWeek { get; set; }
        public string BirthdayDayOfWeekShort { get; set; }
        public string BirthDate { get; set; }
        public int DaysUntilBirthday { get; set; }
        public int Age { get; set; }
        public string NextBirthDay { get; set; }
        public int DaysToBirthday { get; set; }
        public string NextAnniversary { get; set; }
        public object GradeOffset { get; set; }
        public object HasGraduated { get; set; }
        public string GradeFormatted { get; set; }
        public string CreatedDateTime { get; set; }
        public string ModifiedDateTime { get; set; }
        public int CreatedByPersonAliasId { get; set; }
        public int ModifiedByPersonAliasId { get; set; }
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }
        public object Attributes { get; set; }
        public object AttributeValues { get; set; }
        public int Id { get; set; }
        public string Guid { get; set; }
        public int ForeignId { get; set; }
        public object ForeignGuid { get; set; }
        public string ForeignKey { get; set; }
    }
}