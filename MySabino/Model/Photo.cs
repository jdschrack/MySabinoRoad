﻿using System;

namespace MySabinoRoad.Model
{
	public class Photo
	{
		public BinaryFileType BinaryFileType { get; set; }
		public bool IsTemporary { get; set; }
		public bool IsSystem { get; set; }
		public int BinaryFileTypeId { get; set; }
		public string FileName { get; set; }
		public string MimeType { get; set; }
		public object Description { get; set; }
		public int StorageEntityTypeId { get; set; }
		public string Path { get; set; }
		public DateTime ContentLastModified { get; set; }
		public string Url { get; set; }
		public DateTime CreatedDateTime { get; set; }
		public DateTime ModifiedDateTime { get; set; }
		public int CreatedByPersonAliasId { get; set; }
		public int ModifiedByPersonAliasId { get; set; }
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