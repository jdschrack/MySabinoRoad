using System;
using System.Collections.Generic;
namespace MySabinoRoad.Model
{
	public class Family
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IList<FamilyMember> FamilyMembers { get; set; }
		public HomeLocation HomeLocation { get; set; }
		public MainPhone MainPhone { get; set; }
	}

	public class FamilySearchResult
	{
		public bool IsSystem { get; set; }
		public object ParentGroupId { get; set; }
		public int GroupTypeId { get; set; }
		public int CampusId { get; set; }
		public object ScheduleId { get; set; }
		public string Name { get; set; }
		public object Description { get; set; }
		public bool IsSecurityRole { get; set; }
		public bool IsActive { get; set; }
		public int Order { get; set; }
		public object AllowGuests { get; set; }
		public object WelcomeSystemEmailId { get; set; }
		public object ExitSystemEmailId { get; set; }
		public object SyncDataViewId { get; set; }
		public object AddUserAccountsDuringSync { get; set; }
		public object MustMeetRequirementsToAddMember { get; set; }
		public bool IsPublic { get; set; }
		public object GroupCapacity { get; set; }
		public object RequiredSignatureDocumentTemplateId { get; set; }
		public object GroupType { get; set; }
		public object Campus { get; set; }
		public object Schedule { get; set; }
		public object WelcomeSystemEmail { get; set; }
		public object ExitSystemEmail { get; set; }
		public object SyncDataView { get; set; }
		public object RequiredSignatureDocumentTemplate { get; set; }
		public IList<object> Members { get; set; }
		public IList<object> GroupLocations { get; set; }
		public IList<object> GroupRequirements { get; set; }
		public DateTime CreatedDateTime { get; set; }
		public DateTime ModifiedDateTime { get; set; }
		public int CreatedByPersonAliasId { get; set; }
		public object ModifiedByPersonAliasId { get; set; }
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
