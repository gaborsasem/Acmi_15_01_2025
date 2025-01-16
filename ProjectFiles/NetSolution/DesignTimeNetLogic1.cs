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
using FTOptix.Alarm;
using FTOptix.EventLogger;
using FTOptix.Store;
using FTOptix.SQLiteStore;
using FTOptix.DataLogger;
using FTOptix.ODBCStore;
using FTOptix.Recipe;
using FTOptix.OPCUAServer;
#endregion

public class DesignTimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void MioMetodo()
    {
        // Insert code to be executed by the method
        Log.Info("This is an info message");
        var testo = LogicObject.GetVariable("TestoMessaggio");
        Log.Info(testo.Value);
        
    }

    [ExportMethod]
    public void GeneraAllarmi()
    {
        var cartellaAllarmi = Project.Current.Get("Alarms/AllarmiScript");

        foreach (var item in cartellaAllarmi.Children)
        {
            item.Delete();
        }
        
        // Insert code to be executed by the method
        for (uint i = 0; i < 10; i++)
        {
            var mioAllarme = InformationModel.Make<DigitalAlarm>("Allarme" + i);
            mioAllarme.Message = "Allarme_" + i;
            mioAllarme.InputValueVariable.SetDynamicLink(Project.Current.GetVariable("Model/ArrayAllarme"), i, DynamicLinkMode.ReadWrite);
            cartellaAllarmi.Add(mioAllarme);
        }
        
    }
}
