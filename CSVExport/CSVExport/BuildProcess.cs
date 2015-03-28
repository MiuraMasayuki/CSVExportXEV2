using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;
using Artech.Architecture.Common.Objects;
using Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Parts;
using Artech.Packages.Patterns.Engine;
using Artech.Common.Properties;

namespace GXJ.Patterns.CSVExport
{
	public class CSVExportBuildProcess : PatternBuildProcess
	{
		public override void UpdateParentObject(KBObject parent, PatternInstance instance)
		{
			base.UpdateParentObject(parent, instance);
		}
		public override void BeforeGenerateObject(PatternInstance instance, InstanceObject instanceObject)
		{
			base.BeforeGenerateObject(instance, instanceObject);
		}

        //In order to modify IsMain property
        public override void BeforeSaveObjects(PatternInstance instance, InstanceObjects instanceObjects)
        {
            if (instanceObjects.GeneratedObjects == null)
			     return;

            foreach (KBObject kbObject in instanceObjects.GeneratedObjects)
            {
                if (kbObject.Name== instance.Parent.Name.Trim() +"CSVExportPr")
                {
                    bool b = true;
                    if (kbObject.IsPropertyDefault(Artech.Genexus.Common.Properties.PRC.MainProgram))
                        kbObject.SetPropertyValue(Artech.Genexus.Common.Properties.PRC.MainProgram, b);

                    if (kbObject.IsPropertyDefault(Artech.Genexus.Common.Properties.PRC.CallProtocol))
                        kbObject.SetPropertyValue(Artech.Genexus.Common.Properties.PRC.CallProtocol, Artech.Genexus.Common.Properties.PRC.CallProtocol_Values.CommandLine);
                }
                if (kbObject.Name == instance.Parent.Name.Trim() + "CSVExportBatchPr")
                {
                    bool b = true;
                    if (kbObject.IsPropertyDefault(Artech.Genexus.Common.Properties.PRC.MainProgram))
                        kbObject.SetPropertyValue(Artech.Genexus.Common.Properties.PRC.MainProgram, b);

                    if (kbObject.IsPropertyDefault(Artech.Genexus.Common.Properties.PRC.CallProtocol))
                        kbObject.SetPropertyValue(Artech.Genexus.Common.Properties.PRC.CallProtocol, Artech.Genexus.Common.Properties.PRC.CallProtocol_Values.CommandLine);
                }
            }
            
        }

	}
}
