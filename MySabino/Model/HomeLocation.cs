using System;
using System.Collections.Generic;
namespace MySabinoRoad.Model
{
	public class HomeLocation
	{
		public IList<object> ChildLocations { get; set; }
		public object Image { get; set; }
		public object LocationTypeValue { get; set; }
		public object PrinterDevice { get; set; }
		public object ParentLocationId { get; set; }
		public object Name { get; set; }
		public bool IsActive { get; set; }
		public object LocationTypeValueId { get; set; }
		public GeoPoint GeoPoint { get; set; }
		public object GeoFence { get; set; }
		public string Street1 { get; set; }
		public string Street2 { get; set; }
		public string City { get; set; }
		public string County { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string PostalCode { get; set; }
		public object Barcode { get; set; }
		public object AssessorParcelId { get; set; }
		public DateTime StandardizeAttemptedDateTime { get; set; }
		public string StandardizeAttemptedServiceType { get; set; }
		public string StandardizeAttemptedResult { get; set; }
		public DateTime StandardizedDateTime { get; set; }
		public DateTime GeocodeAttemptedDateTime { get; set; }
		public string GeocodeAttemptedServiceType { get; set; }
		public string GeocodeAttemptedResult { get; set; }
		public DateTime GeocodedDateTime { get; set; }
		public object IsGeoPointLocked { get; set; }
		public object PrinterDeviceId { get; set; }
		public object ImageId { get; set; }
		public object SoftRoomThreshold { get; set; }
		public object FirmRoomThreshold { get; set; }
		public bool IsNamedLocation { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public object GeoFenceCoordinates { get; set; }
		public int Distance { get; set; }
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
