// Pattern object constants for pattern CSVExport (GXJ)
// Generated on 2015/03/23 20:01:28 by PatternCodeGen

using System;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Definition;
using Artech.Packages.Patterns.Engine;

namespace GXJ.Patterns.CSVExport
{
	/// <summary>
	/// Objects created by the CSVExport pattern.
	/// </summary>
	public static class CSVExportObject
	{
		/// <summary>
		/// CSVExportPr object (2 part templates).
		/// </summary>
		public static PatternObject CSVExportPr
		{
			get { return GetPatternObject("CSVExportPr"); }
		}

		/// <summary>
		/// CSVExportMenu object (2 part templates).
		/// </summary>
		public static PatternObject CSVExportMenu
		{
			get { return GetPatternObject("CSVExportMenu"); }
		}

		/// <summary>
		/// CSVExportBatchPr object (2 part templates).
		/// </summary>
		public static PatternObject CSVExportBatchPr
		{
			get { return GetPatternObject("CSVExportBatchPr"); }
		}

		private static PatternDefinition PatternDefinition
		{
			get
			{
				PatternDefinition definition = PatternEngine.GetPatternDefinition("CSVExport");
				if (definition == null)
					throw new PatternDefinitionException(String.Format("Pattern definition '{0}' not found.", "CSVExport"));

				return definition;
			}
		}

		private static PatternObject GetPatternObject(string id)
		{
			PatternObject patternObject = PatternDefinition.GetPatternObject(id);
			if (patternObject == null)
				throw new PatternDefinitionException(String.Format("Object '{0}' not found in definition of pattern '{1}'", id, "CSVExport"));

			return patternObject;
		}
	}

	public static class InstanceElements
	{
		public const string Instance = "Instance";
		public const string ProcedureObjectForDownload = "ProcedureObjectForDownload";
		public const string Attributes = "Attributes";
		public const string Attribute = "Attribute";
		public const string Order = "Order";
		public const string OrderAttribute = "OrderAttribute";
		public const string Variable = "Variable";
		public const string WebpanelObjectForDownload = "WebpanelObjectForDownload";
		public const string ProcedureObjectForBatchProcess = "ProcedureObjectForBatchProcess";
	}

	public static class InstanceChildren
	{
		public static class Instance
		{
			public const string ProcedureObjectForDownload = "ProcedureObjectForDownload";
			public const string WebpanelObjectForDownload = "WebpanelObjectForDownload";
			public const string ProcedureObjectForBatchProcess = "ProcedureObjectForBatchProcess";
		}

		public static class ProcedureObjectForDownload
		{
			public const string Attributes = "Attributes";
			public const string Order = "Order";
		}

		public static class Attributes
		{
			public const string Attribute = "Attribute";
			public const string Variable = "variable";
		}

		public static class Order
		{
			public const string Attribute = "attribute";
		}

		public static class ProcedureObjectForBatchProcess
		{
			public const string Attributes = "Attributes";
			public const string Order = "Order";
		}

	}

	public static class InstanceAttributes
	{
		public static class ProcedureObjectForDownload
		{
			public const string ExportProcedureObjectName = "ExportProcedureObjectName";
			public const string ExportFileSeparator = "ExportFileSeparator";
			public const string ExportFileExtension = "ExportFileExtension";
			public const string ExportFileEncoding = "ExportFileEncoding";
			public const string HTTPResponseHeaderContentType = "HTTPResponseHeaderContentType";
			public const string StartCode = "StartCode";
			public const string WhereCode = "WhereCode";
			public const string EndCode = "EndCode";
			public const string SubCode = "SubCode";
			public const string Delimiter = "delimiter";
			public const string ReplaceSeparatorValue = "ReplaceSeparatorValue";
			public const string AlternativeValue = "AlternativeValue";
		}

		public static class Attribute
		{
			public const string _Attribute = "attribute";
			public const string _AttributeReference = "attributeReference";
		}

		public static class OrderAttribute
		{
			public const string Attribute = "attribute";
			public const string AttributeReference = "attributeReference";
			public const string Ascending = "ascending";
		}

		public static class Variable
		{
			public const string Name = "name";
			public const string Domain = "domain";
			public const string DomainReference = "domainReference";
			public const string AssignmentCode = "AssignmentCode";
		}

		public static class WebpanelObjectForDownload
		{
			public const string MenuObjectName = "MenuObjectName";
		}

		public static class ProcedureObjectForBatchProcess
		{
			public const string ExportProcedureObjectName = "ExportProcedureObjectName";
			public const string ExportFileSeparator = "ExportFileSeparator";
			public const string ExportFileEncoding = "ExportFileEncoding";
			public const string ReadINIfile = "ReadINIfile";
			public const string INIFilePath = "INIFilePath";
			public const string INIFileName = "INIFileName";
			public const string ExportedFilepath = "ExportedFilepath";
			public const string ExportedFilename = "ExportedFilename";
			public const string StartCode = "StartCode";
			public const string WhereCode = "WhereCode";
			public const string EndCode = "EndCode";
			public const string SubCode = "SubCode";
			public const string Delimiter = "delimiter";
			public const string ReplaceSeparatorValue = "ReplaceSeparatorValue";
			public const string AlternativeValue = "AlternativeValue";
		}

	}

	public static class SettingsElements
	{
		public const string Config = "Config";
		public const string ProcedureObjectForDownload = "ProcedureObjectForDownload";
		public const string WebpanelObjectForDownload = "WebpanelObjectForDownload";
		public const string ProcedureObjectForBatchProcess = "ProcedureObjectForBatchProcess";
	}

	public static class SettingsChildren
	{
		public static class Config
		{
			public const string ProcedureObjectForDownload = "ProcedureObjectForDownload";
			public const string WebpanelObjectForDownload = "WebpanelObjectForDownload";
			public const string ProcedureObjectForBatchProcess = "ProcedureObjectForBatchProcess";
		}

	}

	public static class SettingsAttributes
	{
		public static class ProcedureObjectForDownload
		{
			public const string ExportProcedureObjectName = "ExportProcedureObjectName";
			public const string ExportFileSeparator = "ExportFileSeparator";
			public const string ExportFileExtension = "ExportFileExtension";
			public const string ExportFileEncoding = "ExportFileEncoding";
			public const string HTTPResponseHeaderContentType = "HTTPResponseHeaderContentType";
			public const string StartCode = "StartCode";
			public const string WhereCode = "WhereCode";
			public const string EndCode = "EndCode";
			public const string SubCode = "SubCode";
			public const string Delimiter = "delimiter";
			public const string ReplaceSeparatorValue = "ReplaceSeparatorValue";
			public const string AlternativeValue = "AlternativeValue";
		}

		public static class WebpanelObjectForDownload
		{
			public const string MenuObjectName = "MenuObjectName";
		}

		public static class ProcedureObjectForBatchProcess
		{
			public const string ExportProcedureObjectName = "ExportProcedureObjectName";
			public const string ExportFileSeparator = "ExportFileSeparator";
			public const string ExportFileEncoding = "ExportFileEncoding";
			public const string ReadINIfile = "ReadINIfile";
			public const string INIFilePath = "INIFilePath";
			public const string INIFileName = "INIFileName";
			public const string ExportedFilepath = "ExportedFilepath";
			public const string ExportedFilename = "ExportedFilename";
			public const string StartCode = "StartCode";
			public const string WhereCode = "WhereCode";
			public const string EndCode = "EndCode";
			public const string SubCode = "SubCode";
			public const string Delimiter = "delimiter";
			public const string ReplaceSeparatorValue = "ReplaceSeparatorValue";
			public const string AlternativeValue = "AlternativeValue";
		}

	}
}