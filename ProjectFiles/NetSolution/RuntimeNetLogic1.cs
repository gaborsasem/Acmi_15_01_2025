#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.HMIProject;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using FTOptix.WebUI;
using FTOptix.Modbus;
using FTOptix.Retentivity;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        for (int i = 1; i <= 3; i++)
        {
            var mioWidgetMotore = InformationModel.Make<WidgetMotore>("Motore" + i);
            mioWidgetMotore.SetAlias("AliasMotore", Project.Current.Get<Motore>("Model/Motore" + i));
            Owner.Add(mioWidgetMotore);
        }
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
