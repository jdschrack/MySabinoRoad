using System;
namespace MySabinoRoad.Model
{
	public class GroupRole
	{
		public bool IsSystem { get; set; }
		public int GroupTypeId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Order { get; set; }
		public object MaxCount { get; set; }
		public object MinCount { get; set; }
		public bool IsLeader { get; set; }
		public bool ReceiveRequirementsNotifications { get; set; }
		public bool CanView { get; set; }
		public bool CanEdit { get; set; }
		public object CreatedDateTime { get; set; }
		public object ModifiedDateTime { get; set; }
		public object CreatedByPersonAliasId { get; set; }
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
