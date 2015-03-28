// Pattern Settings class for pattern CSVExport (GXJ)
// Generated on 2015/03/23 20:01:27 by PatternCodeGen

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Artech.Common.Collections;
using Artech.Common.Diagnostics;
using Artech.Architecture.Common.Objects;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Objects;

namespace GXJ.Patterns.CSVExport
{
	#region Settings class

	public partial class CSVExportSettings : ICSVExportSettingsElement
	{
		private readonly KBModel m_Model;
		protected string m_ElementName;
		private SettingsProcedureObjectForDownloadElement m_ProcedureObjectForDownload;
		private SettingsWebpanelObjectForDownloadElement m_WebpanelObjectForDownload;
		private SettingsProcedureObjectForBatchProcessElement m_ProcedureObjectForBatchProcess;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="CSVExportSettings"/> class.
		/// </summary>
		public CSVExportSettings(KBModel model)
		{
			m_Model = model;
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CSVExportSettings"/> class, loading its data from the specified Settings object.
		/// </summary>
		public CSVExportSettings(PatternSettings settings)
			: this(settings.Model)
		{
			LoadFrom(settings);
		}

		/// <summary>
		/// Initializes this instance of the <see cref="CSVExportSettings"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_ProcedureObjectForDownload = new SettingsProcedureObjectForDownloadElement();
			m_ProcedureObjectForDownload.Parent = this;
			m_WebpanelObjectForDownload = new SettingsWebpanelObjectForDownloadElement();
			m_WebpanelObjectForDownload.Parent = this;
			m_ProcedureObjectForBatchProcess = new SettingsProcedureObjectForBatchProcessElement();
			m_ProcedureObjectForBatchProcess.Parent = this;
		}

		#endregion

		#region Properties

		public KBModel Model
		{
			get { return m_Model; }
		}

		CSVExportSettings ICSVExportSettingsElement.Settings
		{
			get { return this; }
		}

		ICSVExportSettingsElement ICSVExportSettingsElement.Parent
		{
			get { return null; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		public SettingsProcedureObjectForDownloadElement ProcedureObjectForDownload
		{
			get { return m_ProcedureObjectForDownload; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_ProcedureObjectForDownload = value;
				m_ProcedureObjectForDownload.Parent = this;
			}
		}

		public SettingsWebpanelObjectForDownloadElement WebpanelObjectForDownload
		{
			get { return m_WebpanelObjectForDownload; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_WebpanelObjectForDownload = value;
				m_WebpanelObjectForDownload.Parent = this;
			}
		}

		public SettingsProcedureObjectForBatchProcessElement ProcedureObjectForBatchProcess
		{
			get { return m_ProcedureObjectForBatchProcess; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_ProcedureObjectForBatchProcess = value;
				m_ProcedureObjectForBatchProcess.Parent = this;
			}
		}

		#endregion

		#region Serialization

		private void LoadFrom(PatternSettings settings)
		{
			Initialize();
			LoadFrom(settings.PatternPart.RootElement);
		}

		public void SaveTo(PatternSettings settings)
		{
			SaveTo(settings.PatternPart.RootElement);
		}

		private string m_InternalPath;

		public string InternalPath
		{
			get { return m_InternalPath; }
			internal set { m_InternalPath = value; }
		}

		/// <summary>
		/// Loads the current <see cref="CSVExportSettings"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			InternalPath = element.InternalPath;
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Config")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Config"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "ProcedureObjectForDownload" :
					{
						SettingsProcedureObjectForDownloadElement procedureObjectForDownload = new SettingsProcedureObjectForDownloadElement();
						procedureObjectForDownload.LoadFrom(_childElement);
						ProcedureObjectForDownload = procedureObjectForDownload;
						break;
					}
					case "WebpanelObjectForDownload" :
					{
						SettingsWebpanelObjectForDownloadElement webpanelObjectForDownload = new SettingsWebpanelObjectForDownloadElement();
						webpanelObjectForDownload.LoadFrom(_childElement);
						WebpanelObjectForDownload = webpanelObjectForDownload;
						break;
					}
					case "ProcedureObjectForBatchProcess" :
					{
						SettingsProcedureObjectForBatchProcessElement procedureObjectForBatchProcess = new SettingsProcedureObjectForBatchProcessElement();
						procedureObjectForBatchProcess.LoadFrom(_childElement);
						ProcedureObjectForBatchProcess = procedureObjectForBatchProcess;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="CSVExportSettings"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Config")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Config"));

			element.Initialize();

			// Save element children.
			if (m_ProcedureObjectForDownload != null)
			{
				PatternInstanceElement procedureObjectForDownload = element.Children["ProcedureObjectForDownload"];
				m_ProcedureObjectForDownload.SaveTo(procedureObjectForDownload);
			}

			if (m_WebpanelObjectForDownload != null)
			{
				PatternInstanceElement webpanelObjectForDownload = element.Children["WebpanelObjectForDownload"];
				m_WebpanelObjectForDownload.SaveTo(webpanelObjectForDownload);
			}

			if (m_ProcedureObjectForBatchProcess != null)
			{
				PatternInstanceElement procedureObjectForBatchProcess = element.Children["ProcedureObjectForBatchProcess"];
				m_ProcedureObjectForBatchProcess.SaveTo(procedureObjectForBatchProcess);
			}
			InternalPath = element.InternalPath;
			element.Attributes.SilentResetProperty(PatternInstanceElement.IS_SERIALIZATION_PROPNAME);
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="CSVExportSettings"/>.
		/// </summary>
		public CSVExportSettings Clone()
		{
			CSVExportSettings clone = new CSVExportSettings(this.Model);
			clone.ProcedureObjectForDownload = this.ProcedureObjectForDownload.Clone();
			clone.WebpanelObjectForDownload = this.WebpanelObjectForDownload.Clone();
			clone.ProcedureObjectForBatchProcess = this.ProcedureObjectForBatchProcess.Clone();

			return clone;
		}

		ICSVExportSettingsElement ICSVExportSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the object in the hierarchy corresponding to the element.
		/// </summary>
		public TElement GetElement<TElement>(PatternInstanceElement element) where TElement : class
		{
			if (element == null)
				throw new ArgumentNullException("element");

			string elementPath = element.InternalPath;
			List<string> path = new List<string>(elementPath.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries));
			if (path.Count < 1 || path[0] != "Config")
				throw new PatternInstanceException(String.Format("Element with path {0} not found in settings", element.Path));

			path.RemoveAt(0);
			object obj = this.GetElement(path);
			if (obj != null && !(obj is TElement))
				throw new PatternInstanceException(String.Format("Element with path {0} is not of type {1}", elementPath, typeof(TElement).FullName));

			return (TElement)obj;
		}

		private static System.Text.RegularExpressions.Regex ms_Regex = new System.Text.RegularExpressions.Regex(@"(?<name>\w*)(\[(?<index>[0-9]+)\])?");

		internal static void ParseChildPath(string childPath, out string childName, out int childIndex)
		{
			System.Text.RegularExpressions.Match expressionMatch = ms_Regex.Match(childPath);

			childName = childPath;
			if (expressionMatch.Groups["name"].Length > 0)
				childName = expressionMatch.Groups["name"].Value;

			childIndex = 0;
			if (expressionMatch.Groups["index"].Length > 0)
			{
				if (Int32.TryParse(expressionMatch.Groups["index"].Value, out childIndex))
					childIndex--; // XPath index is 1-based, collection index is 0-based.
			}
		}

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName; int childIndex;
			CSVExportSettings.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "ProcedureObjectForDownload" :
				{
					if (ProcedureObjectForDownload != null)
						return ProcedureObjectForDownload.GetElement(path);
					else
						return null;
				}
				case "WebpanelObjectForDownload" :
				{
					if (WebpanelObjectForDownload != null)
						return WebpanelObjectForDownload.GetElement(path);
					else
						return null;
				}
				case "ProcedureObjectForBatchProcess" :
				{
					if (ProcedureObjectForBatchProcess != null)
						return ProcedureObjectForBatchProcess.GetElement(path);
					else
						return null;
				}
			}

			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "CSVExport Configuration";
		}

		#endregion
	}

	#endregion

	#region Element: ProcedureObjectForDownload

	public partial class SettingsProcedureObjectForDownloadElement : ICSVExportSettingsElement
	{
		protected string m_ElementName;
		private System.String m_ExportProcedureObjectName;
		private bool m_IsExportProcedureObjectNameDefault;
		private System.String m_ExportFileSeparator;
		private bool m_IsExportFileSeparatorDefault;
		private System.String m_ExportFileExtension;
		private bool m_IsExportFileExtensionDefault;
		private System.String m_ExportFileEncoding;
		private bool m_IsExportFileEncodingDefault;
		private System.String m_HTTPResponseHeaderContentType;
		private bool m_IsHTTPResponseHeaderContentTypeDefault;
		private System.String m_StartCode;
		private bool m_IsStartCodeDefault;
		private System.String m_WhereCode;
		private bool m_IsWhereCodeDefault;
		private System.String m_EndCode;
		private bool m_IsEndCodeDefault;
		private System.String m_SubCode;
		private bool m_IsSubCodeDefault;
		private System.String m_Delimiter;
		private bool m_IsDelimiterDefault;
		private System.Boolean m_ReplaceSeparatorValue;
		private bool m_IsReplaceSeparatorValueDefault;
		private System.String m_AlternativeValue;
		private bool m_IsAlternativeValueDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsProcedureObjectForDownloadElement"/> class.
		/// </summary>
		public SettingsProcedureObjectForDownloadElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsProcedureObjectForDownloadElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_ExportProcedureObjectName = "<Object>CSVExportPr";
			m_IsExportProcedureObjectNameDefault = true;
			m_ExportFileSeparator = ",";
			m_IsExportFileSeparatorDefault = true;
			m_ExportFileExtension = "csv";
			m_IsExportFileExtensionDefault = true;
			m_ExportFileEncoding = "shift_jis";
			m_IsExportFileEncodingDefault = true;
			m_HTTPResponseHeaderContentType = "text/csv";
			m_IsHTTPResponseHeaderContentTypeDefault = true;
			m_StartCode = "";
			m_IsStartCodeDefault = true;
			m_WhereCode = "";
			m_IsWhereCodeDefault = true;
			m_EndCode = "";
			m_IsEndCodeDefault = true;
			m_SubCode = "";
			m_IsSubCodeDefault = true;
			m_Delimiter = "";
			m_IsDelimiterDefault = true;
			m_ReplaceSeparatorValue = true;
			m_IsReplaceSeparatorValueDefault = true;
			m_AlternativeValue = "、";
			m_IsAlternativeValueDefault = true;
		}

		#endregion

		#region Properties

		private CSVExportSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsProcedureObjectForDownloadElement"/> belongs.
		/// </summary>
		public CSVExportSettings Settings
		{
			get { return ((ICSVExportSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public CSVExportSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportSettingsElement ICSVExportSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/// This is name of procedure object for export.
		/// </summary>
		public System.String ExportProcedureObjectName
		{
			get { return m_ExportProcedureObjectName; }
			set 
			{
				m_ExportProcedureObjectName = value;
				m_IsExportProcedureObjectNameDefault = false;
			}
		}

		/// <summary>
		/// This is separator of exported file.
		/// </summary>
		public System.String ExportFileSeparator
		{
			get { return m_ExportFileSeparator; }
			set 
			{
				m_ExportFileSeparator = value;
				m_IsExportFileSeparatorDefault = false;
			}
		}

		/// <summary>
		/// This is extension of exported file.
		/// </summary>
		public System.String ExportFileExtension
		{
			get { return m_ExportFileExtension; }
			set 
			{
				m_ExportFileExtension = value;
				m_IsExportFileExtensionDefault = false;
			}
		}

		/// <summary>
		/// This is Encoding of exported file.
		/// </summary>
		public System.String ExportFileEncoding
		{
			get { return m_ExportFileEncoding; }
			set 
			{
				m_ExportFileEncoding = value;
				m_IsExportFileEncodingDefault = false;
			}
		}

		/// <summary>
		/// This is Content-Type at respoonse header to downlod.
		/// </summary>
		public System.String HTTPResponseHeaderContentType
		{
			get { return m_HTTPResponseHeaderContentType; }
			set 
			{
				m_HTTPResponseHeaderContentType = value;
				m_IsHTTPResponseHeaderContentTypeDefault = false;
			}
		}

		/// <summary>
		/// Bigining code at the procedure
		/// </summary>
		public System.String StartCode
		{
			get { return m_StartCode; }
			set 
			{
				m_StartCode = value;
				m_IsStartCodeDefault = false;
			}
		}

		/// <summary>
		/// Inserted code to For each command
		/// </summary>
		public System.String WhereCode
		{
			get { return m_WhereCode; }
			set 
			{
				m_WhereCode = value;
				m_IsWhereCodeDefault = false;
			}
		}

		/// <summary>
		/// The code at the termination of procedure
		/// </summary>
		public System.String EndCode
		{
			get { return m_EndCode; }
			set 
			{
				m_EndCode = value;
				m_IsEndCodeDefault = false;
			}
		}

		/// <summary>
		/// The code at final section
		/// </summary>
		public System.String SubCode
		{
			get { return m_SubCode; }
			set 
			{
				m_SubCode = value;
				m_IsSubCodeDefault = false;
			}
		}

		/// <summary>
		/// delimiter of string
		/// </summary>
		public System.String Delimiter
		{
			get { return m_Delimiter; }
			set 
			{
				m_Delimiter = value;
				m_IsDelimiterDefault = false;
			}
		}

		/// <summary>
		/// if this value is 'true',the procedure replace string separator value to alternative value.
		/// </summary>
		public System.Boolean ReplaceSeparatorValue
		{
			get { return m_ReplaceSeparatorValue; }
			set 
			{
				m_ReplaceSeparatorValue = value;
				m_IsReplaceSeparatorValueDefault = false;
			}
		}

		/// <summary>
		/// AlternativeValue
		/// </summary>
		public System.String AlternativeValue
		{
			get { return m_AlternativeValue; }
			set 
			{
				m_AlternativeValue = value;
				m_IsAlternativeValueDefault = false;
			}
		}

		#endregion

		#region Serialization

		private string m_InternalPath;

		public string InternalPath
		{
			get { return m_InternalPath; }
			internal set { m_InternalPath = value; }
		}

		/// <summary>
		/// Loads the current <see cref="SettingsProcedureObjectForDownloadElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			InternalPath = element.InternalPath;
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ProcedureObjectForDownload")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "ProcedureObjectForDownload"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_ExportProcedureObjectName = element.Attributes.GetPropertyValue<System.String>("ExportProcedureObjectName");
			m_IsExportProcedureObjectNameDefault = element.Attributes.IsPropertyDefault("ExportProcedureObjectName");
			m_ExportFileSeparator = element.Attributes.GetPropertyValue<System.String>("ExportFileSeparator");
			m_IsExportFileSeparatorDefault = element.Attributes.IsPropertyDefault("ExportFileSeparator");
			m_ExportFileExtension = element.Attributes.GetPropertyValue<System.String>("ExportFileExtension");
			m_IsExportFileExtensionDefault = element.Attributes.IsPropertyDefault("ExportFileExtension");
			m_ExportFileEncoding = element.Attributes.GetPropertyValue<System.String>("ExportFileEncoding");
			m_IsExportFileEncodingDefault = element.Attributes.IsPropertyDefault("ExportFileEncoding");
			m_HTTPResponseHeaderContentType = element.Attributes.GetPropertyValue<System.String>("HTTPResponseHeaderContentType");
			m_IsHTTPResponseHeaderContentTypeDefault = element.Attributes.IsPropertyDefault("HTTPResponseHeaderContentType");
			m_StartCode = element.Attributes.GetPropertyValue<System.String>("StartCode");
			m_IsStartCodeDefault = element.Attributes.IsPropertyDefault("StartCode");
			m_WhereCode = element.Attributes.GetPropertyValue<System.String>("WhereCode");
			m_IsWhereCodeDefault = element.Attributes.IsPropertyDefault("WhereCode");
			m_EndCode = element.Attributes.GetPropertyValue<System.String>("EndCode");
			m_IsEndCodeDefault = element.Attributes.IsPropertyDefault("EndCode");
			m_SubCode = element.Attributes.GetPropertyValue<System.String>("SubCode");
			m_IsSubCodeDefault = element.Attributes.IsPropertyDefault("SubCode");
			m_Delimiter = element.Attributes.GetPropertyValue<System.String>("delimiter");
			m_IsDelimiterDefault = element.Attributes.IsPropertyDefault("delimiter");
			m_ReplaceSeparatorValue = element.Attributes.GetPropertyValue<System.Boolean>("ReplaceSeparatorValue");
			m_IsReplaceSeparatorValueDefault = element.Attributes.IsPropertyDefault("ReplaceSeparatorValue");
			m_AlternativeValue = element.Attributes.GetPropertyValue<System.String>("AlternativeValue");
			m_IsAlternativeValueDefault = element.Attributes.IsPropertyDefault("AlternativeValue");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsProcedureObjectForDownloadElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ProcedureObjectForDownload")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "ProcedureObjectForDownload"));

			element.Initialize();
			element.Attributes.SilentSetPropertyValue(PatternInstanceElement.IS_SERIALIZATION_PROPNAME, true);

			// Save attribute values.
			SaveAttribute(element, "ExportProcedureObjectName", m_ExportProcedureObjectName, m_IsExportProcedureObjectNameDefault);
			SaveAttribute(element, "ExportFileSeparator", m_ExportFileSeparator, m_IsExportFileSeparatorDefault);
			SaveAttribute(element, "ExportFileExtension", m_ExportFileExtension, m_IsExportFileExtensionDefault);
			SaveAttribute(element, "ExportFileEncoding", m_ExportFileEncoding, m_IsExportFileEncodingDefault);
			SaveAttribute(element, "HTTPResponseHeaderContentType", m_HTTPResponseHeaderContentType, m_IsHTTPResponseHeaderContentTypeDefault);
			SaveAttribute(element, "StartCode", m_StartCode, m_IsStartCodeDefault);
			SaveAttribute(element, "WhereCode", m_WhereCode, m_IsWhereCodeDefault);
			SaveAttribute(element, "EndCode", m_EndCode, m_IsEndCodeDefault);
			SaveAttribute(element, "SubCode", m_SubCode, m_IsSubCodeDefault);
			SaveAttribute(element, "delimiter", m_Delimiter, m_IsDelimiterDefault);
			SaveAttribute(element, "ReplaceSeparatorValue", m_ReplaceSeparatorValue, m_IsReplaceSeparatorValueDefault);
			SaveAttribute(element, "AlternativeValue", m_AlternativeValue, m_IsAlternativeValueDefault);

			Debug.Assert(m_ExportProcedureObjectName == element.Attributes.GetPropertyValue<System.String>("ExportProcedureObjectName"));
			Debug.Assert(m_ExportFileSeparator == element.Attributes.GetPropertyValue<System.String>("ExportFileSeparator"));
			Debug.Assert(m_ExportFileExtension == element.Attributes.GetPropertyValue<System.String>("ExportFileExtension"));
			Debug.Assert(m_ExportFileEncoding == element.Attributes.GetPropertyValue<System.String>("ExportFileEncoding"));
			Debug.Assert(m_HTTPResponseHeaderContentType == element.Attributes.GetPropertyValue<System.String>("HTTPResponseHeaderContentType"));
			Debug.Assert(m_StartCode == element.Attributes.GetPropertyValue<System.String>("StartCode"));
			Debug.Assert(m_WhereCode == element.Attributes.GetPropertyValue<System.String>("WhereCode"));
			Debug.Assert(m_EndCode == element.Attributes.GetPropertyValue<System.String>("EndCode"));
			Debug.Assert(m_SubCode == element.Attributes.GetPropertyValue<System.String>("SubCode"));
			Debug.Assert(m_Delimiter == element.Attributes.GetPropertyValue<System.String>("delimiter"));
			Debug.Assert(m_ReplaceSeparatorValue == element.Attributes.GetPropertyValue<System.Boolean>("ReplaceSeparatorValue"));
			Debug.Assert(m_AlternativeValue == element.Attributes.GetPropertyValue<System.String>("AlternativeValue"));
			InternalPath = element.InternalPath;
			element.Attributes.SilentResetProperty(PatternInstanceElement.IS_SERIALIZATION_PROPNAME);
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsProcedureObjectForDownloadElement"/>.
		/// </summary>
		public SettingsProcedureObjectForDownloadElement Clone()
		{
			SettingsProcedureObjectForDownloadElement clone = new SettingsProcedureObjectForDownloadElement();

			clone.ExportProcedureObjectName = this.ExportProcedureObjectName;
			clone.ExportFileSeparator = this.ExportFileSeparator;
			clone.ExportFileExtension = this.ExportFileExtension;
			clone.ExportFileEncoding = this.ExportFileEncoding;
			clone.HTTPResponseHeaderContentType = this.HTTPResponseHeaderContentType;
			clone.StartCode = this.StartCode;
			clone.WhereCode = this.WhereCode;
			clone.EndCode = this.EndCode;
			clone.SubCode = this.SubCode;
			clone.Delimiter = this.Delimiter;
			clone.ReplaceSeparatorValue = this.ReplaceSeparatorValue;
			clone.AlternativeValue = this.AlternativeValue;

			return clone;
		}

		ICSVExportSettingsElement ICSVExportSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Procedure for exporting and downloding CSV file";
		}

		#endregion
	}

	#endregion

	#region Element: WebpanelObjectForDownload

	public partial class SettingsWebpanelObjectForDownloadElement : ICSVExportSettingsElement
	{
		protected string m_ElementName;
		private System.String m_MenuObjectName;
		private bool m_IsMenuObjectNameDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsWebpanelObjectForDownloadElement"/> class.
		/// </summary>
		public SettingsWebpanelObjectForDownloadElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsWebpanelObjectForDownloadElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_MenuObjectName = "<Object>CSVExportMenu";
			m_IsMenuObjectNameDefault = true;
		}

		#endregion

		#region Properties

		private CSVExportSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsWebpanelObjectForDownloadElement"/> belongs.
		/// </summary>
		public CSVExportSettings Settings
		{
			get { return ((ICSVExportSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public CSVExportSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportSettingsElement ICSVExportSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/// This is name of menu calling the procedure object.
		/// </summary>
		public System.String MenuObjectName
		{
			get { return m_MenuObjectName; }
			set 
			{
				m_MenuObjectName = value;
				m_IsMenuObjectNameDefault = false;
			}
		}

		#endregion

		#region Serialization

		private string m_InternalPath;

		public string InternalPath
		{
			get { return m_InternalPath; }
			internal set { m_InternalPath = value; }
		}

		/// <summary>
		/// Loads the current <see cref="SettingsWebpanelObjectForDownloadElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			InternalPath = element.InternalPath;
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "WebpanelObjectForDownload")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "WebpanelObjectForDownload"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_MenuObjectName = element.Attributes.GetPropertyValue<System.String>("MenuObjectName");
			m_IsMenuObjectNameDefault = element.Attributes.IsPropertyDefault("MenuObjectName");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsWebpanelObjectForDownloadElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "WebpanelObjectForDownload")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "WebpanelObjectForDownload"));

			element.Initialize();
			element.Attributes.SilentSetPropertyValue(PatternInstanceElement.IS_SERIALIZATION_PROPNAME, true);

			// Save attribute values.
			SaveAttribute(element, "MenuObjectName", m_MenuObjectName, m_IsMenuObjectNameDefault);

			Debug.Assert(m_MenuObjectName == element.Attributes.GetPropertyValue<System.String>("MenuObjectName"));
			InternalPath = element.InternalPath;
			element.Attributes.SilentResetProperty(PatternInstanceElement.IS_SERIALIZATION_PROPNAME);
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsWebpanelObjectForDownloadElement"/>.
		/// </summary>
		public SettingsWebpanelObjectForDownloadElement Clone()
		{
			SettingsWebpanelObjectForDownloadElement clone = new SettingsWebpanelObjectForDownloadElement();

			clone.MenuObjectName = this.MenuObjectName;

			return clone;
		}

		ICSVExportSettingsElement ICSVExportSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Web panel for download test";
		}

		#endregion
	}

	#endregion

	#region Element: ProcedureObjectForBatchProcess

	public partial class SettingsProcedureObjectForBatchProcessElement : ICSVExportSettingsElement
	{
		protected string m_ElementName;
		private System.String m_ExportProcedureObjectName;
		private bool m_IsExportProcedureObjectNameDefault;
		private System.String m_ExportFileSeparator;
		private bool m_IsExportFileSeparatorDefault;
		private System.String m_ExportFileEncoding;
		private bool m_IsExportFileEncodingDefault;
		private System.String m_ReadINIfile;
		private bool m_IsReadINIfileDefault;
		private System.String m_INIFilePath;
		private bool m_IsINIFilePathDefault;
		private System.String m_INIFileName;
		private bool m_IsINIFileNameDefault;
		private System.String m_ExportedFilepath;
		private bool m_IsExportedFilepathDefault;
		private System.String m_ExportedFilename;
		private bool m_IsExportedFilenameDefault;
		private System.String m_StartCode;
		private bool m_IsStartCodeDefault;
		private System.String m_WhereCode;
		private bool m_IsWhereCodeDefault;
		private System.String m_EndCode;
		private bool m_IsEndCodeDefault;
		private System.String m_SubCode;
		private bool m_IsSubCodeDefault;
		private System.String m_Delimiter;
		private bool m_IsDelimiterDefault;
		private System.Boolean m_ReplaceSeparatorValue;
		private bool m_IsReplaceSeparatorValueDefault;
		private System.String m_AlternativeValue;
		private bool m_IsAlternativeValueDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsProcedureObjectForBatchProcessElement"/> class.
		/// </summary>
		public SettingsProcedureObjectForBatchProcessElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="SettingsProcedureObjectForBatchProcessElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_ExportProcedureObjectName = "<Object>CSVExportBatchPr";
			m_IsExportProcedureObjectNameDefault = true;
			m_ExportFileSeparator = ",";
			m_IsExportFileSeparatorDefault = true;
			m_ExportFileEncoding = "shift_jis";
			m_IsExportFileEncodingDefault = true;
			m_ReadINIfile = "true";
			m_IsReadINIfileDefault = true;
			m_INIFilePath = "";
			m_IsINIFilePathDefault = true;
			m_INIFileName = "<Object>.ini";
			m_IsINIFileNameDefault = true;
			m_ExportedFilepath = "";
			m_IsExportedFilepathDefault = true;
			m_ExportedFilename = "<Object>.csv";
			m_IsExportedFilenameDefault = true;
			m_StartCode = "";
			m_IsStartCodeDefault = true;
			m_WhereCode = "";
			m_IsWhereCodeDefault = true;
			m_EndCode = "";
			m_IsEndCodeDefault = true;
			m_SubCode = "";
			m_IsSubCodeDefault = true;
			m_Delimiter = "";
			m_IsDelimiterDefault = true;
			m_ReplaceSeparatorValue = true;
			m_IsReplaceSeparatorValueDefault = true;
			m_AlternativeValue = "、";
			m_IsAlternativeValueDefault = true;
		}

		#endregion

		#region Properties

		private CSVExportSettings m_Parent;

		/// <summary>
		/// Settings to which this <see cref="SettingsProcedureObjectForBatchProcessElement"/> belongs.
		/// </summary>
		public CSVExportSettings Settings
		{
			get { return ((ICSVExportSettingsElement)Parent).Settings; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public CSVExportSettings Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportSettingsElement ICSVExportSettingsElement.Parent
		{
			get { return this.Parent; }
		}

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
		}

		/// <summary>
		/// This is name of procedure object for export.
		/// </summary>
		public System.String ExportProcedureObjectName
		{
			get { return m_ExportProcedureObjectName; }
			set 
			{
				m_ExportProcedureObjectName = value;
				m_IsExportProcedureObjectNameDefault = false;
			}
		}

		/// <summary>
		/// This is separator of exported file.
		/// </summary>
		public System.String ExportFileSeparator
		{
			get { return m_ExportFileSeparator; }
			set 
			{
				m_ExportFileSeparator = value;
				m_IsExportFileSeparatorDefault = false;
			}
		}

		/// <summary>
		/// This is Encoding of exported file.
		/// </summary>
		public System.String ExportFileEncoding
		{
			get { return m_ExportFileEncoding; }
			set 
			{
				m_ExportFileEncoding = value;
				m_IsExportFileEncodingDefault = false;
			}
		}

		/// <summary>
		/// When this property is true, the procedure will read ini-file. 
		/// </summary>
		public System.String ReadINIfile
		{
			get { return m_ReadINIfile; }
			set 
			{
				m_ReadINIfile = value;
				m_IsReadINIfileDefault = false;
			}
		}

		/// <summary>
		/// INI-file path
		/// </summary>
		public System.String INIFilePath
		{
			get { return m_INIFilePath; }
			set 
			{
				m_INIFilePath = value;
				m_IsINIFilePathDefault = false;
			}
		}

		/// <summary>
		/// INI-file name
		/// </summary>
		public System.String INIFileName
		{
			get { return m_INIFileName; }
			set 
			{
				m_INIFileName = value;
				m_IsINIFileNameDefault = false;
			}
		}

		/// <summary>
		/// Exported File path
		/// </summary>
		public System.String ExportedFilepath
		{
			get { return m_ExportedFilepath; }
			set 
			{
				m_ExportedFilepath = value;
				m_IsExportedFilepathDefault = false;
			}
		}

		/// <summary>
		/// Exported File name
		/// </summary>
		public System.String ExportedFilename
		{
			get { return m_ExportedFilename; }
			set 
			{
				m_ExportedFilename = value;
				m_IsExportedFilenameDefault = false;
			}
		}

		/// <summary>
		/// Bigining code at the procedure
		/// </summary>
		public System.String StartCode
		{
			get { return m_StartCode; }
			set 
			{
				m_StartCode = value;
				m_IsStartCodeDefault = false;
			}
		}

		/// <summary>
		/// Inserted code to For each command
		/// </summary>
		public System.String WhereCode
		{
			get { return m_WhereCode; }
			set 
			{
				m_WhereCode = value;
				m_IsWhereCodeDefault = false;
			}
		}

		/// <summary>
		/// The code at the termination of procedure
		/// </summary>
		public System.String EndCode
		{
			get { return m_EndCode; }
			set 
			{
				m_EndCode = value;
				m_IsEndCodeDefault = false;
			}
		}

		/// <summary>
		/// The code at final section
		/// </summary>
		public System.String SubCode
		{
			get { return m_SubCode; }
			set 
			{
				m_SubCode = value;
				m_IsSubCodeDefault = false;
			}
		}

		/// <summary>
		/// delimiter of string
		/// </summary>
		public System.String Delimiter
		{
			get { return m_Delimiter; }
			set 
			{
				m_Delimiter = value;
				m_IsDelimiterDefault = false;
			}
		}

		/// <summary>
		/// if this value is 'true',the procedure replace string separator value to alternative value.
		/// </summary>
		public System.Boolean ReplaceSeparatorValue
		{
			get { return m_ReplaceSeparatorValue; }
			set 
			{
				m_ReplaceSeparatorValue = value;
				m_IsReplaceSeparatorValueDefault = false;
			}
		}

		/// <summary>
		/// AlternativeValue
		/// </summary>
		public System.String AlternativeValue
		{
			get { return m_AlternativeValue; }
			set 
			{
				m_AlternativeValue = value;
				m_IsAlternativeValueDefault = false;
			}
		}

		#endregion

		#region Serialization

		private string m_InternalPath;

		public string InternalPath
		{
			get { return m_InternalPath; }
			internal set { m_InternalPath = value; }
		}

		/// <summary>
		/// Loads the current <see cref="SettingsProcedureObjectForBatchProcessElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			InternalPath = element.InternalPath;
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ProcedureObjectForBatchProcess")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "ProcedureObjectForBatchProcess"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_ExportProcedureObjectName = element.Attributes.GetPropertyValue<System.String>("ExportProcedureObjectName");
			m_IsExportProcedureObjectNameDefault = element.Attributes.IsPropertyDefault("ExportProcedureObjectName");
			m_ExportFileSeparator = element.Attributes.GetPropertyValue<System.String>("ExportFileSeparator");
			m_IsExportFileSeparatorDefault = element.Attributes.IsPropertyDefault("ExportFileSeparator");
			m_ExportFileEncoding = element.Attributes.GetPropertyValue<System.String>("ExportFileEncoding");
			m_IsExportFileEncodingDefault = element.Attributes.IsPropertyDefault("ExportFileEncoding");
			m_ReadINIfile = element.Attributes.GetPropertyValue<System.String>("ReadINIfile");
			m_IsReadINIfileDefault = element.Attributes.IsPropertyDefault("ReadINIfile");
			m_INIFilePath = element.Attributes.GetPropertyValue<System.String>("INIFilePath");
			m_IsINIFilePathDefault = element.Attributes.IsPropertyDefault("INIFilePath");
			m_INIFileName = element.Attributes.GetPropertyValue<System.String>("INIFileName");
			m_IsINIFileNameDefault = element.Attributes.IsPropertyDefault("INIFileName");
			m_ExportedFilepath = element.Attributes.GetPropertyValue<System.String>("ExportedFilepath");
			m_IsExportedFilepathDefault = element.Attributes.IsPropertyDefault("ExportedFilepath");
			m_ExportedFilename = element.Attributes.GetPropertyValue<System.String>("ExportedFilename");
			m_IsExportedFilenameDefault = element.Attributes.IsPropertyDefault("ExportedFilename");
			m_StartCode = element.Attributes.GetPropertyValue<System.String>("StartCode");
			m_IsStartCodeDefault = element.Attributes.IsPropertyDefault("StartCode");
			m_WhereCode = element.Attributes.GetPropertyValue<System.String>("WhereCode");
			m_IsWhereCodeDefault = element.Attributes.IsPropertyDefault("WhereCode");
			m_EndCode = element.Attributes.GetPropertyValue<System.String>("EndCode");
			m_IsEndCodeDefault = element.Attributes.IsPropertyDefault("EndCode");
			m_SubCode = element.Attributes.GetPropertyValue<System.String>("SubCode");
			m_IsSubCodeDefault = element.Attributes.IsPropertyDefault("SubCode");
			m_Delimiter = element.Attributes.GetPropertyValue<System.String>("delimiter");
			m_IsDelimiterDefault = element.Attributes.IsPropertyDefault("delimiter");
			m_ReplaceSeparatorValue = element.Attributes.GetPropertyValue<System.Boolean>("ReplaceSeparatorValue");
			m_IsReplaceSeparatorValueDefault = element.Attributes.IsPropertyDefault("ReplaceSeparatorValue");
			m_AlternativeValue = element.Attributes.GetPropertyValue<System.String>("AlternativeValue");
			m_IsAlternativeValueDefault = element.Attributes.IsPropertyDefault("AlternativeValue");
		}

		/// <summary>
		/// Saves the current <see cref="SettingsProcedureObjectForBatchProcessElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "ProcedureObjectForBatchProcess")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "ProcedureObjectForBatchProcess"));

			element.Initialize();
			element.Attributes.SilentSetPropertyValue(PatternInstanceElement.IS_SERIALIZATION_PROPNAME, true);

			// Save attribute values.
			SaveAttribute(element, "ExportProcedureObjectName", m_ExportProcedureObjectName, m_IsExportProcedureObjectNameDefault);
			SaveAttribute(element, "ExportFileSeparator", m_ExportFileSeparator, m_IsExportFileSeparatorDefault);
			SaveAttribute(element, "ExportFileEncoding", m_ExportFileEncoding, m_IsExportFileEncodingDefault);
			SaveAttribute(element, "ReadINIfile", m_ReadINIfile, m_IsReadINIfileDefault);
			SaveAttribute(element, "INIFilePath", m_INIFilePath, m_IsINIFilePathDefault);
			SaveAttribute(element, "INIFileName", m_INIFileName, m_IsINIFileNameDefault);
			SaveAttribute(element, "ExportedFilepath", m_ExportedFilepath, m_IsExportedFilepathDefault);
			SaveAttribute(element, "ExportedFilename", m_ExportedFilename, m_IsExportedFilenameDefault);
			SaveAttribute(element, "StartCode", m_StartCode, m_IsStartCodeDefault);
			SaveAttribute(element, "WhereCode", m_WhereCode, m_IsWhereCodeDefault);
			SaveAttribute(element, "EndCode", m_EndCode, m_IsEndCodeDefault);
			SaveAttribute(element, "SubCode", m_SubCode, m_IsSubCodeDefault);
			SaveAttribute(element, "delimiter", m_Delimiter, m_IsDelimiterDefault);
			SaveAttribute(element, "ReplaceSeparatorValue", m_ReplaceSeparatorValue, m_IsReplaceSeparatorValueDefault);
			SaveAttribute(element, "AlternativeValue", m_AlternativeValue, m_IsAlternativeValueDefault);

			Debug.Assert(m_ExportProcedureObjectName == element.Attributes.GetPropertyValue<System.String>("ExportProcedureObjectName"));
			Debug.Assert(m_ExportFileSeparator == element.Attributes.GetPropertyValue<System.String>("ExportFileSeparator"));
			Debug.Assert(m_ExportFileEncoding == element.Attributes.GetPropertyValue<System.String>("ExportFileEncoding"));
			Debug.Assert(m_ReadINIfile == element.Attributes.GetPropertyValue<System.String>("ReadINIfile"));
			Debug.Assert(m_INIFilePath == element.Attributes.GetPropertyValue<System.String>("INIFilePath"));
			Debug.Assert(m_INIFileName == element.Attributes.GetPropertyValue<System.String>("INIFileName"));
			Debug.Assert(m_ExportedFilepath == element.Attributes.GetPropertyValue<System.String>("ExportedFilepath"));
			Debug.Assert(m_ExportedFilename == element.Attributes.GetPropertyValue<System.String>("ExportedFilename"));
			Debug.Assert(m_StartCode == element.Attributes.GetPropertyValue<System.String>("StartCode"));
			Debug.Assert(m_WhereCode == element.Attributes.GetPropertyValue<System.String>("WhereCode"));
			Debug.Assert(m_EndCode == element.Attributes.GetPropertyValue<System.String>("EndCode"));
			Debug.Assert(m_SubCode == element.Attributes.GetPropertyValue<System.String>("SubCode"));
			Debug.Assert(m_Delimiter == element.Attributes.GetPropertyValue<System.String>("delimiter"));
			Debug.Assert(m_ReplaceSeparatorValue == element.Attributes.GetPropertyValue<System.Boolean>("ReplaceSeparatorValue"));
			Debug.Assert(m_AlternativeValue == element.Attributes.GetPropertyValue<System.String>("AlternativeValue"));
			InternalPath = element.InternalPath;
			element.Attributes.SilentResetProperty(PatternInstanceElement.IS_SERIALIZATION_PROPNAME);
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="SettingsProcedureObjectForBatchProcessElement"/>.
		/// </summary>
		public SettingsProcedureObjectForBatchProcessElement Clone()
		{
			SettingsProcedureObjectForBatchProcessElement clone = new SettingsProcedureObjectForBatchProcessElement();

			clone.ExportProcedureObjectName = this.ExportProcedureObjectName;
			clone.ExportFileSeparator = this.ExportFileSeparator;
			clone.ExportFileEncoding = this.ExportFileEncoding;
			clone.ReadINIfile = this.ReadINIfile;
			clone.INIFilePath = this.INIFilePath;
			clone.INIFileName = this.INIFileName;
			clone.ExportedFilepath = this.ExportedFilepath;
			clone.ExportedFilename = this.ExportedFilename;
			clone.StartCode = this.StartCode;
			clone.WhereCode = this.WhereCode;
			clone.EndCode = this.EndCode;
			clone.SubCode = this.SubCode;
			clone.Delimiter = this.Delimiter;
			clone.ReplaceSeparatorValue = this.ReplaceSeparatorValue;
			clone.AlternativeValue = this.AlternativeValue;

			return clone;
		}

		ICSVExportSettingsElement ICSVExportSettingsElement.Clone()
		{
			return this.Clone();
		}

		#endregion

		#region Find Element

		/// <summary>
		/// Gets the element with the specified path, local to the current element (empty string means current one).
		/// </summary>
		internal object GetElement(List<string> path)
		{
			if (path.Count == 0)
				return this;

			string childName = path[0];
			throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName, this.GetType()));
		}

		#endregion

		#region Enumerations

		/// <summary>
		/// Possible values for the <see cref="ReadINIfile"/> property.
		/// </summary>
		public static class ReadINIfileValue
		{
			public const string True = "true";
			public const string False = "false";
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Procedure for For Batch Process";
		}

		#endregion
	}

	#endregion

	/// <summary>
	/// Base interface for all CSVExportSettings elements.
	/// </summary>
	public interface ICSVExportSettingsElement
	{
		CSVExportSettings Settings { get; }
		ICSVExportSettingsElement Parent { get; }
		ICSVExportSettingsElement Clone();
	}
}