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

public class RuntimeNetLogic2 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void MioMetodo(string testo)
    {
        Log.Info(testo);
    }
}
