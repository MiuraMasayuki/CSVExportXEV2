using System;
using Artech.Architecture.Common.Objects;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Objects;

namespace GXJ.Patterns.CSVExport
{
    public partial class CSVExportSettings
    {
		private static string MODEL_CACHE_PROPERTY
		{
			get { return String.Format("Model::{0}::Settings", CSVExportPattern.Definition.Name); }
		}

		public static CSVExportSettings Get(KBModel model)
		{
			PatternSettings current = PatternSettings.Get(model, CSVExportPattern.Definition);
			CSVExportSettings cached = model.GetPropertyValue<CSVExportSettings>(MODEL_CACHE_PROPERTY);

			if (cached == null || cached.VersionId != current.VersionId)
			{
				cached = new CSVExportSettings(current);
				cached.VersionId = current.VersionId;
				model.SilentSetPropertyValue(MODEL_CACHE_PROPERTY, cached);
			}

			return cached;
		}

		internal static void ResetCache(KBModel model)
		{
			model.ResetProperty(MODEL_CACHE_PROPERTY);
		}

		#region Properties

		private int m_VersionId = 0;

		internal int VersionId
		{
			get { return m_VersionId; }
			private set { m_VersionId = value; }
		}

		#endregion
	}

    public partial class CSVExportInstance
	{
		public CSVExportSettings Settings
		{
			get { return CSVExportSettings.Get(this.Model); }
		}
	}
}
