using System;
using System.Collections.Generic;

namespace MySabinoRoad.Model
{
	public class FamilyMember
	{
		public IList<object> GroupMemberRequirements { get; set; }
		public GroupRole GroupRole { get; set; }
		public Person Person { get; set; }
		public bool IsSystem { get; set; }
		public int GroupId { get; set; }
		public int PersonId { get; set; }
		public int GroupRoleId { get; set; }
		public object Note { get; set; }
		public int GroupMemberStatus { get; set; }
		public object GuestCount { get; set; }
		public DateTime DateTimeAdded { get; set; }
		public bool IsNotified { get; set; }
		public DateTime CreatedDateTime { get; set; }
		public DateTime ModifiedDateTime { get; set; }
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
