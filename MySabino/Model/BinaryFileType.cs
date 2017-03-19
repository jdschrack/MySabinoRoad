namespace MySabinoRoad.Model
{
    public class BinaryFileType
    {
        public StorageEntityType StorageEntityType { get; set; }
        public bool IsSystem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconCssClass { get; set; }
        public int StorageEntityTypeId { get; set; }
        public bool AllowCaching { get; set; }
        public bool RequiresViewSecurity { get; set; }
        public object MaxWidth { get; set; }
        public object MaxHeight { get; set; }
        public int PreferredFormat { get; set; }
        public int PreferredResolution { get; set; }
        public int PreferredColorDepth { get; set; }
        public bool PreferredRequired { get; set; }
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