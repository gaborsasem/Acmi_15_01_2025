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

public class CambioColoreRettangolo : BaseNetLogic
{
    private IUAVariable variabilePLC;

    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        variabilePLC = Project.Current.GetVariable("Model/ColoreRettangolo");
        variabilePLC.VariableChange += VariabilePLC_VariableChange;
        cambioColore(variabilePLC.Value);
    }

    private void VariabilePLC_VariableChange(object sender, VariableChangeEventArgs e)
    {
        cambioColore(e.NewValue);
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        variabilePLC.VariableChange -= VariabilePLC_VariableChange;
    }

    public void cambioColore(int codiceColore)
    {
        var mioRettangolo = Owner.Get<Rectangle>("Rectangle23");

        switch (codiceColore)
        {
            case 0:
                mioRettangolo.FillColor = Colors.Red;
                break;
            case 1:
                mioRettangolo.FillColor = Colors.Lime;
                break;
            case 2:
                mioRettangolo.FillColor = Colors.Yellow;
                break;
            default:
                mioRettangolo.FillColor = Colors.Gray;
                break;
        }
        
    }
}
