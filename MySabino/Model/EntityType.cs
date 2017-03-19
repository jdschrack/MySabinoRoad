namespace MySabinoRoad.Model
{
    public class EntityType
    {
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public string FriendlyName { get; set; }
        public bool IsEntity { get; set; }
        public bool IsSecured { get; set; }
        public bool IsCommon { get; set; }
        public object SingleValueFieldTypeId { get; set; }
        public object MultiValueFieldTypeId { get; set; }
        public int Id { get; set; }
        public string Guid { get; set; }
        public object ForeignId { get; set; }
        public object ForeignGuid { get; set; }
        public object ForeignKey { get; set; }
    }
}