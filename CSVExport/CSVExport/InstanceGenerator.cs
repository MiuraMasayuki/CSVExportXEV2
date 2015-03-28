using System;
using System.Collections.Generic;
using System.Diagnostics;

using Artech.Architecture.Common.Descriptors;
using Artech.Architecture.Common.Objects;
using Artech.Architecture.Common.Packages;
using Artech.Common.Collections;
using Artech.Common.Helpers.Language;
using Artech.Common.Properties;
using Artech.Genexus.Common;
using Artech.Genexus.Common.Objects;
using Gx = Artech.Genexus.Common.Objects;
using Artech.Genexus.Common.Parts;
using Artech.Genexus.Common.Parts.Structure;
using Artech.Packages.Patterns;
using Artech.Packages.Patterns.Custom;
using Artech.Packages.Patterns.Objects;

namespace GXJ.Patterns.CSVExport
{
	internal class CSVExportInstanceGenerator : DefaultInstanceGenerator
	{
		public override void Generate(KBObject baseObject, PatternInstance instance)
		{
			CSVExportInstance myInstance = new CSVExportInstance(baseObject.Model);

			Generate(baseObject, myInstance);
			myInstance.SaveTo(instance);
		}

		public override bool GetDependencies(IList<KBObjectDescriptor> dependencies)
		{
			dependencies.Add(PackageManager.Manager.GetKBObjectDescriptor(ObjClass.Transaction));
			dependencies.Add(PackageManager.Manager.GetKBObjectDescriptor(ObjClass.Table));
			dependencies.Add(PackageManager.Manager.GetKBObjectDescriptor(ObjClass.Attribute));
			return true;
		}

		#region Instance Generation

		private void Generate(KBObject baseObject, CSVExportInstance instance)
		{
            /* Procedure Object for download  */
            //If we wants to generate optional object when users apply pattern, we need to initialize optional instance value, when an instance is generated.
            //オプショナルのdownloadプロシージャパネルを、インスタンス作成時は手動で初期化する
            if (instance.ProcedureObjectForDownload == null)
            {
                instance.ProcedureObjectForDownload = new ProcedureObjectForDownloadElement();
                if (instance.ProcedureObjectForDownload.ExportProcedureObjectName == null)
                    instance.ProcedureObjectForDownload.ExportProcedureObjectName = "";
            }

            //Copying setting values to the instance value.
            instance.ProcedureObjectForDownload.ExportProcedureObjectName = Format(instance.Settings.ProcedureObjectForDownload.ExportProcedureObjectName, baseObject.Name);
            instance.ProcedureObjectForDownload.StartCode = Format(instance.Settings.ProcedureObjectForDownload.StartCode, baseObject.Name);
            instance.ProcedureObjectForDownload.EndCode = Format(instance.Settings.ProcedureObjectForDownload.EndCode, baseObject.Name);
            instance.ProcedureObjectForDownload.Delimiter = instance.Settings.ProcedureObjectForDownload.Delimiter;

            //Copying Attribute from structure of applied transaction object to the instance
            Transaction tran = Transaction.Get(baseObject.Model, baseObject.Name);
            if (tran != null)
            {
                foreach (Artech.Genexus.Common.Objects.Attribute trnAtt in tran.Structure.Root.Attributes)
                {
                    AttributeElement AE = new AttributeElement();
                    AE.Attribute = trnAtt;
                    instance.ProcedureObjectForDownload.Attributes.Add(AE);
                }
                //Copying Attribute to the instance order section
                foreach (Artech.Genexus.Common.Objects.Attribute trnAtt in tran.Structure.Root.FullLevelKey)
                {
                    OrderAttributeElement AE2 = new OrderAttributeElement();
                    AE2.Attribute = trnAtt;
                    instance.ProcedureObjectForDownload.Order.Add(AE2);
                }
            }


            /* Webpanel for Test  */
            //If we wants to generate optional object when users apply pattern, we need to initialize optional instance value, when an instance is generated.
            //オプショナルのWEBパネルを、インスタンス作成時は手動で初期化する
            if (instance.WebpanelObjectForDownload == null)
            {
                instance.WebpanelObjectForDownload = new WebpanelObjectForDownloadElement();
                if (instance.WebpanelObjectForDownload.MenuObjectName == null)
                    instance.WebpanelObjectForDownload.MenuObjectName = "";
                instance.WebpanelObjectForDownload.MenuObjectName = Format(instance.Settings.WebpanelObjectForDownload.MenuObjectName, baseObject.Name);
            }
            else
            {
                instance.WebpanelObjectForDownload.MenuObjectName = Format(instance.Settings.WebpanelObjectForDownload.MenuObjectName, baseObject.Name);
            }

            /* Procedure Object for Batch Process  */
            //If we wants to generate optional object when users apply pattern, we need to initialize optional instance value, when an instance is generated.
            //オプショナルのBatch用プロシージャパネルを、インスタンス作成時は手動で初期化する
            if (instance.ProcedureObjectForBatchProcess == null)
            {
                instance.ProcedureObjectForBatchProcess = new ProcedureObjectForBatchProcessElement();
                if (instance.ProcedureObjectForBatchProcess.ExportProcedureObjectName == null)
                    instance.ProcedureObjectForBatchProcess.ExportProcedureObjectName = "";
            }

            //Copying setting values to the instance value.
            instance.ProcedureObjectForBatchProcess.ExportProcedureObjectName = Format(instance.Settings.ProcedureObjectForBatchProcess.ExportProcedureObjectName, baseObject.Name);
            instance.ProcedureObjectForBatchProcess.StartCode = Format(instance.Settings.ProcedureObjectForBatchProcess.StartCode, baseObject.Name);
            instance.ProcedureObjectForBatchProcess.EndCode = Format(instance.Settings.ProcedureObjectForBatchProcess.EndCode, baseObject.Name);
            instance.ProcedureObjectForBatchProcess.Delimiter = instance.Settings.ProcedureObjectForBatchProcess.Delimiter;

            instance.ProcedureObjectForBatchProcess.INIFileName = Format(instance.Settings.ProcedureObjectForBatchProcess.INIFileName, baseObject.Name);
            instance.ProcedureObjectForBatchProcess.ExportedFilename = Format(instance.Settings.ProcedureObjectForBatchProcess.ExportedFilename, baseObject.Name);

            //Copying Attribute from structure of applied transaction object to the instance
            //Transaction tran = Transaction.Get(baseObject.Model, baseObject.Name);
            if (tran != null)
            {
                foreach (Artech.Genexus.Common.Objects.Attribute trnAtt in tran.Structure.Root.Attributes)
                {
                    AttributeElement AE = new AttributeElement();
                    AE.Attribute = trnAtt;
                    instance.ProcedureObjectForBatchProcess.Attributes.Add(AE);
                }
                //Copying Attribute to the instance order section
                foreach (Artech.Genexus.Common.Objects.Attribute trnAtt in tran.Structure.Root.FullLevelKey)
                {
                    OrderAttributeElement AE2 = new OrderAttributeElement();
                    AE2.Attribute = trnAtt;
                    instance.ProcedureObjectForBatchProcess.Order.Add(AE2);
                }
            }
        }

		public static string Format(string formatStr, string obj)
		{
			return formatStr.Replace("<Object>", obj);
		}

		#endregion
	}
}
