// Pattern Instance class for pattern CSVExport (GXJ)
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
	#region Instance class

	public partial class CSVExportInstance : ICSVExportInstanceElement
	{
		private readonly KBModel m_Model;
		private int m_Id;
		private string m_Name;
		protected string m_ElementName;
		private ProcedureObjectForDownloadElement m_ProcedureObjectForDownload;
		private WebpanelObjectForDownloadElement m_WebpanelObjectForDownload;
		private ProcedureObjectForBatchProcessElement m_ProcedureObjectForBatchProcess;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="CSVExportInstance"/> class.
		/// </summary>
		public CSVExportInstance(KBModel model)
		{
			m_Model = model;
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CSVExportInstance"/> class, loading its data from the specified Instance object.
		/// </summary>
		public CSVExportInstance(PatternInstance instance)
			: this(instance.Model)
		{
			LoadFrom(instance);
		}

		/// <summary>
		/// Initializes this instance of the <see cref="CSVExportInstance"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_ProcedureObjectForDownload = null;
			m_WebpanelObjectForDownload = null;
			m_ProcedureObjectForBatchProcess = null;
		}

		#endregion

		#region Properties

		public KBModel Model
		{
			get { return m_Model; }
		}

		public int Id
		{
			get { return m_Id; }
		}

		public string Name
		{
			get { return m_Name; }
			internal set { m_Name = value; }
		}

		private Artech.Genexus.Common.Objects.Transaction m_ParentObject;

		public Artech.Genexus.Common.Objects.Transaction ParentObject
		{
			get { return m_ParentObject; }
			private set { m_ParentObject = value; }
		}

		CSVExportInstance ICSVExportInstanceElement.Instance
		{
			get { return this; }
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Parent
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

		public ProcedureObjectForDownloadElement ProcedureObjectForDownload
		{
			get { return m_ProcedureObjectForDownload; }
			set
			{
				m_ProcedureObjectForDownload = value;
				m_ProcedureObjectForDownload.Parent = this;
			}
		}

		public WebpanelObjectForDownloadElement WebpanelObjectForDownload
		{
			get { return m_WebpanelObjectForDownload; }
			set
			{
				m_WebpanelObjectForDownload = value;
				m_WebpanelObjectForDownload.Parent = this;
			}
		}

		public ProcedureObjectForBatchProcessElement ProcedureObjectForBatchProcess
		{
			get { return m_ProcedureObjectForBatchProcess; }
			set
			{
				m_ProcedureObjectForBatchProcess = value;
				m_ProcedureObjectForBatchProcess.Parent = this;
			}
		}

		#endregion

		#region Serialization

		private void LoadFrom(PatternInstance instance)
		{
			Initialize();
			m_Id = instance.Id;
			m_Name = instance.Name;
			LoadFrom(instance.PatternPart.RootElement);
			ParentObject = (Artech.Genexus.Common.Objects.Transaction)instance.KBObject;
		}

		public void SaveTo(PatternInstance instance)
		{
			SaveTo(instance.PatternPart.RootElement);
		}

		private string m_InternalPath;

		public string InternalPath
		{
			get { return m_InternalPath; }
			internal set { m_InternalPath = value; }
		}

		/// <summary>
		/// Loads the current <see cref="CSVExportInstance"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			InternalPath = element.InternalPath;
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Instance")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Instance"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "ProcedureObjectForDownload" :
					{
						ProcedureObjectForDownloadElement procedureObjectForDownload = new ProcedureObjectForDownloadElement();
						procedureObjectForDownload.LoadFrom(_childElement);
						ProcedureObjectForDownload = procedureObjectForDownload;
						break;
					}
					case "WebpanelObjectForDownload" :
					{
						WebpanelObjectForDownloadElement webpanelObjectForDownload = new WebpanelObjectForDownloadElement();
						webpanelObjectForDownload.LoadFrom(_childElement);
						WebpanelObjectForDownload = webpanelObjectForDownload;
						break;
					}
					case "ProcedureObjectForBatchProcess" :
					{
						ProcedureObjectForBatchProcessElement procedureObjectForBatchProcess = new ProcedureObjectForBatchProcessElement();
						procedureObjectForBatchProcess.LoadFrom(_childElement);
						ProcedureObjectForBatchProcess = procedureObjectForBatchProcess;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="CSVExportInstance"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Instance")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Instance"));

			element.Initialize();

			// Save element children.
			if (m_ProcedureObjectForDownload != null)
			{
				PatternInstanceElement procedureObjectForDownload = element.Children.AddNewElement("ProcedureObjectForDownload");
				m_ProcedureObjectForDownload.SaveTo(procedureObjectForDownload);
			}

			if (m_WebpanelObjectForDownload != null)
			{
				PatternInstanceElement webpanelObjectForDownload = element.Children.AddNewElement("WebpanelObjectForDownload");
				m_WebpanelObjectForDownload.SaveTo(webpanelObjectForDownload);
			}

			if (m_ProcedureObjectForBatchProcess != null)
			{
				PatternInstanceElement procedureObjectForBatchProcess = element.Children.AddNewElement("ProcedureObjectForBatchProcess");
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
		/// Clones the current <see cref="CSVExportInstance"/>.
		/// </summary>
		public CSVExportInstance Clone()
		{
			CSVExportInstance clone = new CSVExportInstance(this.Model);
			if (ProcedureObjectForDownload != null)
				clone.ProcedureObjectForDownload = this.ProcedureObjectForDownload.Clone();
			if (WebpanelObjectForDownload != null)
				clone.WebpanelObjectForDownload = this.WebpanelObjectForDownload.Clone();
			if (ProcedureObjectForBatchProcess != null)
				clone.ProcedureObjectForBatchProcess = this.ProcedureObjectForBatchProcess.Clone();

			return clone;
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Clone()
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
			if (path.Count < 1 || path[0] != "instance")
				throw new PatternInstanceException(String.Format("Element with path {0} not found in instance", element.Path));

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
			CSVExportInstance.ParseChildPath(path[0], out childName, out childIndex);

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
			return "CSVExport Pattern Instance";
		}

		#endregion
	}

	#endregion

	#region Element: ProcedureObjectForDownload

	public partial class ProcedureObjectForDownloadElement : ICSVExportInstanceElement
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
		private AttributesElement m_Attributes;
		private OrderElement m_Order;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="ProcedureObjectForDownloadElement"/> class.
		/// </summary>
		public ProcedureObjectForDownloadElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="ProcedureObjectForDownloadElement"/> class, setting all its members to their default values.
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
			m_Attributes = new AttributesElement();
			m_Attributes.Parent = this;
			m_Order = new OrderElement();
			m_Order.Parent = this;
			m_Order.ElementName = "Order";
		}

		#endregion

		#region Properties

		private CSVExportInstance m_Parent;

		/// <summary>
		/// Instance to which this <see cref="ProcedureObjectForDownloadElement"/> belongs.
		/// </summary>
		public CSVExportInstance Instance
		{
			get { return ((ICSVExportInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public CSVExportInstance Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Parent
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

		public AttributesElement Attributes
		{
			get { return m_Attributes; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Attributes = value;
				m_Attributes.Parent = this;
			}
		}

		public OrderElement Order
		{
			get { return m_Order; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="OrderAttributeElement"/> and adds it to the <see cref="Order"/> collection.
		/// </summary>
		public OrderAttributeElement AddOrderAttribute()
		{
			OrderAttributeElement orderAttributeElement = new OrderAttributeElement();
			m_Order.Add(orderAttributeElement);
			return orderAttributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="OrderAttributeElement"/> and adds it to the <see cref="Order"/> collection.
		/// The OrderAttributeElement is initialized with the specified value.
		/// </summary>
		public OrderAttributeElement AddOrderAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			OrderAttributeElement orderAttributeElement = new OrderAttributeElement(attribute);
			m_Order.Add(orderAttributeElement);
			return orderAttributeElement;
		}

		/// <summary>
		/// Finds the <see cref="OrderAttributeElement"/> in the <see cref="Order"/> collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no orderAttributeElement is found, null is returned.
		/// </summary>
		public OrderAttributeElement FindOrderAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return Order.Find(delegate (OrderAttributeElement orderAttributeElement) { return orderAttributeElement.Attribute == attribute; });
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
		/// Loads the current <see cref="ProcedureObjectForDownloadElement"/> with the information present in the specified element.
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

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "Attributes" :
					{
						AttributesElement attributes = new AttributesElement();
						attributes.LoadFrom(_childElement);
						Attributes = attributes;
						break;
					}
					case "Order" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							OrderAttributeElement orderAttributeElement = new OrderAttributeElement();
							orderAttributeElement.LoadFrom(_childElementItem);
							Order.Add(orderAttributeElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="ProcedureObjectForDownloadElement"/> information to the specified element.
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

			// Save element children.
			if (m_Attributes != null)
			{
				PatternInstanceElement attributes = element.Children["Attributes"];
				m_Attributes.SaveTo(attributes);
			}

			if (m_Order != null)
			{
				foreach (OrderAttributeElement _item in Order)
				{
					PatternInstanceElement child = element.Children["Order"].Children.AddNewElement("attribute");
					_item.SaveTo(child);
				}
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
		/// Clones the current <see cref="ProcedureObjectForDownloadElement"/>.
		/// </summary>
		public ProcedureObjectForDownloadElement Clone()
		{
			ProcedureObjectForDownloadElement clone = new ProcedureObjectForDownloadElement();

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
			clone.Attributes = this.Attributes.Clone();
			foreach (OrderAttributeElement orderAttributeElement in this.Order)
				clone.Order.Add(orderAttributeElement.Clone());

			return clone;
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Clone()
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

			string childName; int childIndex;
			CSVExportInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "Attributes" :
				{
					if (Attributes != null)
						return Attributes.GetElement(path);
					else
						return null;
				}
				case "Order" :
				{
					if (path.Count == 0)
						return Order;

					string itemName; int itemIndex;
					CSVExportInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "attribute")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Order != null && itemIndex >= 0 && itemIndex < Order.Count)
						return Order[itemIndex].GetElement(path);
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
			return "Procedure for exporting and downloding CSV file";
		}

		#endregion
	}

	#endregion

	#region Element: Attributes

	public partial class AttributesElement : IEnumerable<ICSVExportInstanceElement>, ICSVExportInstanceElement
	{
		protected string m_ElementName;
		private Artech.Common.Collections.BaseCollection<ICSVExportInstanceElement> m_Items;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="AttributesElement"/> class.
		/// </summary>
		public AttributesElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="AttributesElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Items = new Artech.Common.Collections.BaseCollection<ICSVExportInstanceElement>();
			m_Items.ItemAdded += new EventHandler<CollectionItemEventArgs<ICSVExportInstanceElement>>(Items_ItemAdded);
		}

		#endregion

		#region Properties

		private ICSVExportInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="AttributesElement"/> belongs.
		/// </summary>
		public CSVExportInstance Instance
		{
			get { return ((ICSVExportInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public ICSVExportInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Parent
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

		public Artech.Common.Collections.IBaseCollection<AttributeElement> Attributes
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<AttributeElement> tmpAttributes = new Artech.Common.Collections.BaseCollection<AttributeElement>();
				foreach (ICSVExportInstanceElement obj in m_Items)
					if (obj is AttributeElement)
						tmpAttributes.Add((AttributeElement)obj);

				return tmpAttributes.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<VariableElement> Variables
		{
			get 
			{
				Artech.Common.Collections.IBaseCollection<VariableElement> tmpVariables = new Artech.Common.Collections.BaseCollection<VariableElement>();
				foreach (ICSVExportInstanceElement obj in m_Items)
					if (obj is VariableElement)
						tmpVariables.Add((VariableElement)obj);

				return tmpVariables.AsReadOnly();
			}
		}

		public Artech.Common.Collections.IBaseCollection<ICSVExportInstanceElement> Items
		{
			get { return m_Items; }
		}

		public IEnumerator<ICSVExportInstanceElement> GetEnumerator()
		{
			return m_Items.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)m_Items).GetEnumerator();
		}

		#endregion

		#region Helper methods

		public void Add(ICSVExportInstanceElement item)
		{
			m_Items.Add(item);
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// </summary>
		public AttributeElement AddAttribute()
		{
			AttributeElement attributeElement = new AttributeElement();
			m_Items.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="AttributeElement"/> and adds it to the <see cref="Attributes"/> collection.
		/// The AttributeElement is initialized with the specified value.
		/// </summary>
		public AttributeElement AddAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			AttributeElement attributeElement = new AttributeElement(attribute);
			m_Items.Add(attributeElement);
			return attributeElement;
		}

		/// <summary>
		/// Finds the <see cref="AttributeElement"/> in the <see cref="Attributes"/> collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no attributeElement is found, null is returned.
		/// </summary>
		public AttributeElement FindAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return Attributes.Find(delegate (AttributeElement attributeElement) { return attributeElement.Attribute == attribute; });
		}

		private void Attributes_ItemAdded(object sender, CollectionItemEventArgs<AttributeElement> e)
		{
			e.Data.Parent = this;
		}

		/// <summary>
		/// Creates a new <see cref="VariableElement"/> and adds it to the <see cref="Variables"/> collection.
		/// </summary>
		public VariableElement AddVariable()
		{
			VariableElement variableElement = new VariableElement();
			m_Items.Add(variableElement);
			return variableElement;
		}

		/// <summary>
		/// Creates a new <see cref="VariableElement"/> and adds it to the <see cref="Variables"/> collection.
		/// The VariableElement is initialized with the specified value.
		/// </summary>
		public VariableElement AddVariable(System.String name)
		{
			VariableElement variableElement = new VariableElement(name);
			m_Items.Add(variableElement);
			return variableElement;
		}

		/// <summary>
		/// Finds the <see cref="VariableElement"/> in the <see cref="Variables"/> collection that has the specified value in its <see cref="Name"/> property.
		/// If no variableElement is found, null is returned.
		/// </summary>
		public VariableElement FindVariable(System.String name)
		{
			return Variables.Find(delegate (VariableElement variableElement) { return variableElement.Name == name; });
		}

		private void Variables_ItemAdded(object sender, CollectionItemEventArgs<VariableElement> e)
		{
			e.Data.Parent = this;
		}

		private void Items_ItemAdded(object sender, CollectionItemEventArgs<ICSVExportInstanceElement> e)
		{
			if (e.Data is AttributeElement)
				((AttributeElement)e.Data).Parent = this;
			else if (e.Data is VariableElement)
				((VariableElement)e.Data).Parent = this;
			else
				throw new PatternInstanceException(String.Format("An object of an unexpected type {0} was added as child of {1}.", e.Data.GetType(), this.GetType()));
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
		/// Loads the current <see cref="AttributesElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			InternalPath = element.InternalPath;
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Attributes")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Attributes"));

			Initialize();
			m_ElementName = element.Name;

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "Attribute" :
					{
						AttributeElement attribute = new AttributeElement();
						attribute.LoadFrom(_childElement);
						Add(attribute);
						break;
					}
					case "variable" :
					{
						VariableElement variable = new VariableElement();
						variable.LoadFrom(_childElement);
						Add(variable);
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="AttributesElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Attributes")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Attributes"));

			element.Initialize();

			// Save element children.
			foreach (ICSVExportInstanceElement _obj in m_Items)
			{
				if (_obj is AttributeElement)
				{
					PatternInstanceElement attribute = element.Children.AddNewElement("Attribute");
					((AttributeElement)_obj).SaveTo(attribute);
				}
				else if (_obj is VariableElement)
				{
					PatternInstanceElement variable = element.Children.AddNewElement("variable");
					((VariableElement)_obj).SaveTo(variable);
				}
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
		/// Clones the current <see cref="AttributesElement"/>.
		/// </summary>
		public AttributesElement Clone()
		{
			AttributesElement clone = new AttributesElement();
			foreach (ICSVExportInstanceElement element in this)
				clone.Add(element.Clone());

			return clone;
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Clone()
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

			string childName; int childIndex;
			CSVExportInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "Attribute" :
				{
					if (Attributes != null && childIndex >= 0 && childIndex < Attributes.Count)
						return Attributes[childIndex].GetElement(path);
					else
						return null;
				}
				case "variable" :
				{
					if (Variables != null && childIndex >= 0 && childIndex < Variables.Count)
						return Variables[childIndex].GetElement(path);
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
			return "Attributes";
		}

		#endregion
	}

	#endregion

	#region Element: Attribute

	public partial class AttributeElement : ICSVExportInstanceElement
	{
		protected string m_ElementName;
		private Artech.Genexus.Common.Objects.Attribute m_Attribute;
		private KBObjectReference m_AttributeReference;
		private bool m_IsAttributeDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="AttributeElement"/> class.
		/// </summary>
		public AttributeElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AttributeElement"/> class, setting its <see cref="Attribute"/> property to the specified value.
		/// </summary>
		public AttributeElement(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			Initialize();
			Attribute = attribute;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="AttributeElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Attribute = null;
			m_AttributeReference = null;
			m_IsAttributeDefault = true;
		}

		#endregion

		#region Properties

		private AttributesElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="AttributeElement"/> belongs.
		/// </summary>
		public CSVExportInstance Instance
		{
			get { return ((ICSVExportInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public AttributesElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Parent
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
		/// Attribute that represents the transaction. (For example: CustomerName for Customer).
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute Attribute
		{
			get
			{
				if (m_Attribute == null && m_AttributeReference != null)
					m_Attribute = (Artech.Genexus.Common.Objects.Attribute)m_AttributeReference.GetKBObject(Instance.Model);

				return m_Attribute;
			}

			set 
			{
				m_Attribute = value;
				m_AttributeReference = (value != null ? new KBObjectReference(value) : null);
				m_IsAttributeDefault = false;
			}
		}

		/// <summary>
		/// Attribute name.
		/// </summary>
		public string AttributeName
		{
			get { return (Attribute != null ? Attribute.Name : null); }
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
		/// Loads the current <see cref="AttributeElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			InternalPath = element.InternalPath;
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Attribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Attribute"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_AttributeReference = element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference");
			m_IsAttributeDefault = element.Attributes.IsPropertyDefault("attribute");
		}

		/// <summary>
		/// Saves the current <see cref="AttributeElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Attribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Attribute"));

			element.Initialize();
			element.Attributes.SilentSetPropertyValue(PatternInstanceElement.IS_SERIALIZATION_PROPNAME, true);

			// Save attribute values.
			SaveAttribute(element, "attributeReference", m_AttributeReference, m_IsAttributeDefault);

			Debug.Assert(m_AttributeReference == element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference"));
			InternalPath = element.InternalPath;
			element.Attributes.SilentResetProperty(PatternInstanceElement.IS_SERIALIZATION_PROPNAME);
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="AttributeElement"/>.
		/// </summary>
		public AttributeElement Clone()
		{
			AttributeElement clone = new AttributeElement();

			clone.Attribute = this.Attribute;

			return clone;
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Clone()
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
			return String.Format(CultureInfo.CurrentCulture, "{0}", AttributeName);
		}

		#endregion
	}

	#endregion

	#region Element: Order

	public partial class OrderElement : Artech.Common.Collections.BaseCollection<OrderAttributeElement>
	{
		protected string m_ElementName;

		#region Construction

		internal OrderElement()
		{
			Initialize();
		}

		private void Initialize()
		{
			m_ElementName = "<Unknown>";
			ItemAdded += new EventHandler<CollectionItemEventArgs<OrderAttributeElement>>(Collection_ItemAdded);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The element's name in the pattern instance.
		/// </summary>
		internal string ElementName
		{
			get { return m_ElementName; }
			set { m_ElementName = value; }
		}

		#endregion

		#region Parent Element

		private ICSVExportInstanceElement m_Parent;

		/// <summary>
		/// Parent Element.
		/// </summary>
		public ICSVExportInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		private void Collection_ItemAdded(object sender, CollectionItemEventArgs<OrderAttributeElement> e)
		{
			if (Parent == null)
				throw new PatternInstanceException("Parent of OrderElement must be set before adding elements.");

			e.Data.Parent = this.Parent;
		}

		#endregion

		#region Collection methods

		/// <summary>
		/// Finds the <see cref="OrderAttributeElement"/> in the collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no OrderAttribute is found, <b>null</b> is returned.
		/// </summary>
		public OrderAttributeElement FindOrderAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return this.Find(delegate (OrderAttributeElement attributeItem) { return attributeItem.Attribute == attribute; });
		}

		#endregion

		#region Basic methods

		public override string ToString()
		{
			return "Order";
		}

		#endregion
	}

	#endregion

	#region Element: OrderAttribute

	public partial class OrderAttributeElement : ICSVExportInstanceElement
	{
		protected string m_ElementName;
		private Artech.Genexus.Common.Objects.Attribute m_Attribute;
		private KBObjectReference m_AttributeReference;
		private bool m_IsAttributeDefault;
		private System.Boolean m_Ascending;
		private bool m_IsAscendingDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="OrderAttributeElement"/> class.
		/// </summary>
		public OrderAttributeElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="OrderAttributeElement"/> class, setting its <see cref="Attribute"/> property to the specified value.
		/// </summary>
		public OrderAttributeElement(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			Initialize();
			Attribute = attribute;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="OrderAttributeElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Attribute = null;
			m_AttributeReference = null;
			m_IsAttributeDefault = true;
			m_Ascending = true;
			m_IsAscendingDefault = true;
		}

		#endregion

		#region Properties

		private ICSVExportInstanceElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="OrderAttributeElement"/> belongs.
		/// </summary>
		public CSVExportInstance Instance
		{
			get { return ((ICSVExportInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public ICSVExportInstanceElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Parent
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
		/// Attribute.
		/// </summary>
		public Artech.Genexus.Common.Objects.Attribute Attribute
		{
			get
			{
				if (m_Attribute == null && m_AttributeReference != null)
					m_Attribute = (Artech.Genexus.Common.Objects.Attribute)m_AttributeReference.GetKBObject(Instance.Model);

				return m_Attribute;
			}

			set 
			{
				m_Attribute = value;
				m_AttributeReference = (value != null ? new KBObjectReference(value) : null);
				m_IsAttributeDefault = false;
			}
		}

		/// <summary>
		/// Attribute name.
		/// </summary>
		public string AttributeName
		{
			get { return (Attribute != null ? Attribute.Name : null); }
		}

		/// <summary>
		/// Ascending Order.
		/// </summary>
		public System.Boolean Ascending
		{
			get { return m_Ascending; }
			set 
			{
				m_Ascending = value;
				m_IsAscendingDefault = false;
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
		/// Loads the current <see cref="OrderAttributeElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			InternalPath = element.InternalPath;
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "OrderAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "OrderAttribute"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_AttributeReference = element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference");
			m_IsAttributeDefault = element.Attributes.IsPropertyDefault("attribute");
			m_Ascending = element.Attributes.GetPropertyValue<System.Boolean>("ascending");
			m_IsAscendingDefault = element.Attributes.IsPropertyDefault("ascending");
		}

		/// <summary>
		/// Saves the current <see cref="OrderAttributeElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "OrderAttribute")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "OrderAttribute"));

			element.Initialize();
			element.Attributes.SilentSetPropertyValue(PatternInstanceElement.IS_SERIALIZATION_PROPNAME, true);

			// Save attribute values.
			SaveAttribute(element, "attributeReference", m_AttributeReference, m_IsAttributeDefault);
			SaveAttribute(element, "ascending", m_Ascending, m_IsAscendingDefault);

			Debug.Assert(m_AttributeReference == element.Attributes.GetPropertyValue<KBObjectReference>("attributeReference"));
			Debug.Assert(m_Ascending == element.Attributes.GetPropertyValue<System.Boolean>("ascending"));
			InternalPath = element.InternalPath;
			element.Attributes.SilentResetProperty(PatternInstanceElement.IS_SERIALIZATION_PROPNAME);
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="OrderAttributeElement"/>.
		/// </summary>
		public OrderAttributeElement Clone()
		{
			OrderAttributeElement clone = new OrderAttributeElement();

			clone.Attribute = this.Attribute;
			clone.Ascending = this.Ascending;

			return clone;
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Clone()
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
			return String.Format(CultureInfo.CurrentCulture, "{0}", AttributeName);
		}

		#endregion
	}

	#endregion

	#region Element: Variable

	public partial class VariableElement : ICSVExportInstanceElement
	{
		protected string m_ElementName;
		private System.String m_Name;
		private bool m_IsNameDefault;
		private Artech.Genexus.Common.Objects.Domain m_Domain;
		private KBObjectReference m_DomainReference;
		private bool m_IsDomainDefault;
		private System.String m_AssignmentCode;
		private bool m_IsAssignmentCodeDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="VariableElement"/> class.
		/// </summary>
		public VariableElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="VariableElement"/> class, setting its <see cref="Name"/> property to the specified value.
		/// </summary>
		public VariableElement(System.String name)
		{
			Initialize();
			Name = name;
		}

		/// <summary>
		/// Initializes this instance of the <see cref="VariableElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_Name = "";
			m_IsNameDefault = true;
			m_Domain = null;
			m_DomainReference = null;
			m_IsDomainDefault = true;
			m_AssignmentCode = "";
			m_IsAssignmentCodeDefault = true;
		}

		#endregion

		#region Properties

		private AttributesElement m_Parent;

		/// <summary>
		/// Instance to which this <see cref="VariableElement"/> belongs.
		/// </summary>
		public CSVExportInstance Instance
		{
			get { return ((ICSVExportInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public AttributesElement Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Parent
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
		/// Variable name.
		/// </summary>
		public System.String Name
		{
			get { return m_Name; }
			set 
			{
				m_Name = value;
				m_IsNameDefault = false;
			}
		}

		/// <summary>
		/// Domain on which the variable is based.
		/// </summary>
		public Artech.Genexus.Common.Objects.Domain Domain
		{
			get
			{
				if (m_Domain == null && m_DomainReference != null)
					m_Domain = (Artech.Genexus.Common.Objects.Domain)m_DomainReference.GetKBObject(Instance.Model);

				return m_Domain;
			}

			set 
			{
				m_Domain = value;
				m_DomainReference = (value != null ? new KBObjectReference(value) : null);
				m_IsDomainDefault = false;
			}
		}

		/// <summary>
		/// Domain name.
		/// </summary>
		public string DomainName
		{
			get { return (Domain != null ? Domain.Name : null); }
		}

		/// <summary>
		/// Code used to export
		/// </summary>
		public System.String AssignmentCode
		{
			get { return m_AssignmentCode; }
			set 
			{
				m_AssignmentCode = value;
				m_IsAssignmentCodeDefault = false;
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
		/// Loads the current <see cref="VariableElement"/> with the information present in the specified element.
		/// </summary>
		internal void LoadFrom(PatternInstanceElement element)
		{
			InternalPath = element.InternalPath;
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Variable")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be loaded from elements of type '{1}'", GetType().FullName, "Variable"));

			Initialize();
			m_ElementName = element.Name;

			// Load attribute values.
			m_Name = element.Attributes.GetPropertyValue<System.String>("name");
			m_IsNameDefault = element.Attributes.IsPropertyDefault("name");
			m_DomainReference = element.Attributes.GetPropertyValue<KBObjectReference>("domainReference");
			m_IsDomainDefault = element.Attributes.IsPropertyDefault("domain");
			m_AssignmentCode = element.Attributes.GetPropertyValue<System.String>("AssignmentCode");
			m_IsAssignmentCodeDefault = element.Attributes.IsPropertyDefault("AssignmentCode");
		}

		/// <summary>
		/// Saves the current <see cref="VariableElement"/> information to the specified element.
		/// </summary>
		internal void SaveTo(PatternInstanceElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");

			if (element.Type != "Variable")
				throw new PatternInstanceException(String.Format("Objects of class '{0}' can only be saved to elements of type '{1}'", GetType().FullName, "Variable"));

			element.Initialize();
			element.Attributes.SilentSetPropertyValue(PatternInstanceElement.IS_SERIALIZATION_PROPNAME, true);

			// Save attribute values.
			SaveAttribute(element, "name", m_Name, m_IsNameDefault);
			SaveAttribute(element, "domainReference", m_DomainReference, m_IsDomainDefault);
			SaveAttribute(element, "AssignmentCode", m_AssignmentCode, m_IsAssignmentCodeDefault);

			Debug.Assert(m_Name == element.Attributes.GetPropertyValue<System.String>("name"));
			Debug.Assert(m_DomainReference == element.Attributes.GetPropertyValue<KBObjectReference>("domainReference"));
			Debug.Assert(m_AssignmentCode == element.Attributes.GetPropertyValue<System.String>("AssignmentCode"));
			InternalPath = element.InternalPath;
			element.Attributes.SilentResetProperty(PatternInstanceElement.IS_SERIALIZATION_PROPNAME);
		}

		private void SaveAttribute(PatternInstanceElement element, string attName, object attValue, bool isAttDefault)
		{
			if (!isAttDefault && attValue != null)
				element.Attributes[attName] = attValue;
		}

		/// <summary>
		/// Clones the current <see cref="VariableElement"/>.
		/// </summary>
		public VariableElement Clone()
		{
			VariableElement clone = new VariableElement();

			clone.Name = this.Name;
			clone.Domain = this.Domain;
			clone.AssignmentCode = this.AssignmentCode;

			return clone;
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Clone()
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
			return String.Format(CultureInfo.CurrentCulture, "{0}", Name);
		}

		#endregion
	}

	#endregion

	#region Element: WebpanelObjectForDownload

	public partial class WebpanelObjectForDownloadElement : ICSVExportInstanceElement
	{
		protected string m_ElementName;
		private System.String m_MenuObjectName;
		private bool m_IsMenuObjectNameDefault;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="WebpanelObjectForDownloadElement"/> class.
		/// </summary>
		public WebpanelObjectForDownloadElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="WebpanelObjectForDownloadElement"/> class, setting all its members to their default values.
		/// </summary>
		public void Initialize()
		{
			m_ElementName = "<Unknown>";
			m_MenuObjectName = "<Object>CSVExportMenu";
			m_IsMenuObjectNameDefault = true;
		}

		#endregion

		#region Properties

		private CSVExportInstance m_Parent;

		/// <summary>
		/// Instance to which this <see cref="WebpanelObjectForDownloadElement"/> belongs.
		/// </summary>
		public CSVExportInstance Instance
		{
			get { return ((ICSVExportInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public CSVExportInstance Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Parent
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
		/// Loads the current <see cref="WebpanelObjectForDownloadElement"/> with the information present in the specified element.
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
		/// Saves the current <see cref="WebpanelObjectForDownloadElement"/> information to the specified element.
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
		/// Clones the current <see cref="WebpanelObjectForDownloadElement"/>.
		/// </summary>
		public WebpanelObjectForDownloadElement Clone()
		{
			WebpanelObjectForDownloadElement clone = new WebpanelObjectForDownloadElement();

			clone.MenuObjectName = this.MenuObjectName;

			return clone;
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Clone()
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

	public partial class ProcedureObjectForBatchProcessElement : ICSVExportInstanceElement
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
		private AttributesElement m_Attributes;
		private OrderElement m_Order;

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="ProcedureObjectForBatchProcessElement"/> class.
		/// </summary>
		public ProcedureObjectForBatchProcessElement()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this instance of the <see cref="ProcedureObjectForBatchProcessElement"/> class, setting all its members to their default values.
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
			m_Attributes = new AttributesElement();
			m_Attributes.Parent = this;
			m_Order = new OrderElement();
			m_Order.Parent = this;
			m_Order.ElementName = "Order";
		}

		#endregion

		#region Properties

		private CSVExportInstance m_Parent;

		/// <summary>
		/// Instance to which this <see cref="ProcedureObjectForBatchProcessElement"/> belongs.
		/// </summary>
		public CSVExportInstance Instance
		{
			get { return ((ICSVExportInstanceElement)Parent).Instance; }
		}

		/// <summary>
		/// Parent Element.
		/// </summary>
		public CSVExportInstance Parent
		{
			get { return m_Parent; }
			internal set { m_Parent = value; }
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Parent
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

		public AttributesElement Attributes
		{
			get { return m_Attributes; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("value");

				m_Attributes = value;
				m_Attributes.Parent = this;
			}
		}

		public OrderElement Order
		{
			get { return m_Order; }
		}

		#endregion

		#region Helper methods

		/// <summary>
		/// Creates a new <see cref="OrderAttributeElement"/> and adds it to the <see cref="Order"/> collection.
		/// </summary>
		public OrderAttributeElement AddOrderAttribute()
		{
			OrderAttributeElement orderAttributeElement = new OrderAttributeElement();
			m_Order.Add(orderAttributeElement);
			return orderAttributeElement;
		}

		/// <summary>
		/// Creates a new <see cref="OrderAttributeElement"/> and adds it to the <see cref="Order"/> collection.
		/// The OrderAttributeElement is initialized with the specified value.
		/// </summary>
		public OrderAttributeElement AddOrderAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			OrderAttributeElement orderAttributeElement = new OrderAttributeElement(attribute);
			m_Order.Add(orderAttributeElement);
			return orderAttributeElement;
		}

		/// <summary>
		/// Finds the <see cref="OrderAttributeElement"/> in the <see cref="Order"/> collection that has the specified value in its <see cref="Attribute"/> property.
		/// If no orderAttributeElement is found, null is returned.
		/// </summary>
		public OrderAttributeElement FindOrderAttribute(Artech.Genexus.Common.Objects.Attribute attribute)
		{
			return Order.Find(delegate (OrderAttributeElement orderAttributeElement) { return orderAttributeElement.Attribute == attribute; });
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
		/// Loads the current <see cref="ProcedureObjectForBatchProcessElement"/> with the information present in the specified element.
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

			// Load child elements.
			foreach (PatternInstanceElement _childElement in element.Children)
			{
				switch (_childElement.Name)
				{
					case "Attributes" :
					{
						AttributesElement attributes = new AttributesElement();
						attributes.LoadFrom(_childElement);
						Attributes = attributes;
						break;
					}
					case "Order" :
					{
						foreach (PatternInstanceElement _childElementItem in _childElement.Children)
						{
							OrderAttributeElement orderAttributeElement = new OrderAttributeElement();
							orderAttributeElement.LoadFrom(_childElementItem);
							Order.Add(orderAttributeElement);
						}
						break;
					}
				}
			}
		}

		/// <summary>
		/// Saves the current <see cref="ProcedureObjectForBatchProcessElement"/> information to the specified element.
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

			// Save element children.
			if (m_Attributes != null)
			{
				PatternInstanceElement attributes = element.Children["Attributes"];
				m_Attributes.SaveTo(attributes);
			}

			if (m_Order != null)
			{
				foreach (OrderAttributeElement _item in Order)
				{
					PatternInstanceElement child = element.Children["Order"].Children.AddNewElement("attribute");
					_item.SaveTo(child);
				}
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
		/// Clones the current <see cref="ProcedureObjectForBatchProcessElement"/>.
		/// </summary>
		public ProcedureObjectForBatchProcessElement Clone()
		{
			ProcedureObjectForBatchProcessElement clone = new ProcedureObjectForBatchProcessElement();

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
			clone.Attributes = this.Attributes.Clone();
			foreach (OrderAttributeElement orderAttributeElement in this.Order)
				clone.Order.Add(orderAttributeElement.Clone());

			return clone;
		}

		ICSVExportInstanceElement ICSVExportInstanceElement.Clone()
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

			string childName; int childIndex;
			CSVExportInstance.ParseChildPath(path[0], out childName, out childIndex);

			path.RemoveAt(0);
			switch (childName)
			{
				case "Attributes" :
				{
					if (Attributes != null)
						return Attributes.GetElement(path);
					else
						return null;
				}
				case "Order" :
				{
					if (path.Count == 0)
						return Order;

					string itemName; int itemIndex;
					CSVExportInstance.ParseChildPath(path[0], out itemName, out itemIndex);
					if (itemName != "attribute")
						throw new PatternInstanceException(String.Format("Child '{0}' not found in '{1}'.", childName + "/" + itemName, this.GetType()));

					path.RemoveAt(0);

					if (Order != null && itemIndex >= 0 && itemIndex < Order.Count)
						return Order[itemIndex].GetElement(path);
					else
						return null;
				}
			}

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
			return "Procedure for Batch Process";
		}

		#endregion
	}

	#endregion

	/// <summary>
	/// Base interface for all CSVExportInstance elements.
	/// </summary>
	public interface ICSVExportInstanceElement
	{
		CSVExportInstance Instance { get; }
		ICSVExportInstanceElement Parent { get; }
		ICSVExportInstanceElement Clone();
	}
}