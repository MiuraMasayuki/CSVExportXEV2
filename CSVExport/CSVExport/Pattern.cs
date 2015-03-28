using System;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Objects;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;
using Artech.Packages.Patterns.Definition;

[assembly: PatternImplementation(typeof(GXJ.Patterns.CSVExport.CSVExportPattern))]

namespace GXJ.Patterns.CSVExport
{
	public class CSVExportPattern : PatternImplementation
	{
		public static Guid Id
		{
            get { return new Guid("e1310617-3283-4c67-b7b8-d56226dd580b"); }
		}

		public static PatternDefinition Definition
		{
			get { return PatternEngine.GetPatternDefinition(Id); }
		}

		public override IDefaultInstanceGenerator GetInstanceGenerator()
		{
			return new CSVExportInstanceGenerator();
		}

        public override IPatternBuildProcess GetBuildProcess()
        {
            return new CSVExportBuildProcess();
        }
/*
        public override IPatternDeleteProcess GetDeleteProcess()
        {
        }

        public override IPatternImportHelper GetImportHelper()
        {
        }

        public override IPatternValidator GetInstanceValidator()
        {
        }

        public override IPatternVersionAdapter GetInstanceVersionAdapter()
        {
        }

        public override IPatternValidator GetSettingsValidator()
        {
        }

        public override IPatternVersionAdapter GetSettingsVersionAdapter()
        {
        }
*/
	}
}
