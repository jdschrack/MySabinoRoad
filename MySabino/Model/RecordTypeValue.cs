using System;

namespace MySabinoRoad.Model
{
    public class RecordTypeValue
    {
        public bool IsSystem { get; set; }
        public int DefinedTypeId { get; set; }
        public int Order { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
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