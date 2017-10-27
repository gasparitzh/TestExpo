/*
 * Created by Ranorex
 * User: hgasparitz
 * Date: 27.10.2017
 * Time: 13:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TestExpoDemo
{
    /// <summary>
    /// Description of DownloadTriaUsingCode.
    /// </summary>
    [TestModule("94523172-F9A9-4AE3-A99F-81BFCF8EAAC0", ModuleType.UserCode, 1)]
    public class DownloadTriaUsingCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DownloadTriaUsingCode()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 10.0;
            var repo = TestExpoDemoRepository.Instance;
            Report.Log(ReportLevel.Info, "Click", " Click  DownloadTrialButton", repo.TestAutomationForGUITestingRanore.DownloadTrialButtonInfo, new RecordItemIndex(0));
            repo.TestAutomationForGUITestingRanore.DownloadTrialButton.PerformClick();
            Report.Log(ReportLevel.Info, "WaitFor", "WaitForExist FirstnameField", repo.TestAutomationForGUITestingRanore.FormFirstNameInfo, new RecordItemIndex(1));
            repo.TestAutomationForGUITestingRanore.FormFirstNameInfo.WaitForExists(10000);
            Report.Log(ReportLevel.Info, "SetValue", "SetValue FirstnameField to 'Code'", repo.TestAutomationForGUITestingRanore.FormFirstNameInfo, new RecordItemIndex(2));
            repo.TestAutomationForGUITestingRanore.FormFirstName.TagValue = "Code";
            Report.Log(ReportLevel.Info, "SetValue", "SetValue LastnameField 'Tester' ", repo.TestAutomationForGUITestingRanore.FormLastNameInfo, new RecordItemIndex(3));
            repo.TestAutomationForGUITestingRanore.FormLastName.TagValue = "Tester";
            Report.Log(ReportLevel.Info, "SetValue", "SetValue EmailField 'code@tester.com", repo.TestAutomationForGUITestingRanore.FormEmailInfo, new RecordItemIndex(4));
            repo.TestAutomationForGUITestingRanore.FormEmail.TagValue = "code@tester.com";
            Report.Log(ReportLevel.Info, "Click", "Click RegisterButton", repo.TestAutomationForGUITestingRanore.RegisterInfo, new RecordItemIndex(5));
            repo.TestAutomationForGUITestingRanore.Register.PerformClick();
            Report.Log(ReportLevel.Info, "WaitFor", "WaitForExist TellUsMore", repo.TestAutomationForGUITestingRanore.TellUsMoreAboutYourselfInfo, new RecordItemIndex(6));
            repo.TestAutomationForGUITestingRanore.TellUsMoreAboutYourselfInfo.WaitForExists(10000);
            Report.Log(ReportLevel.Info, "Click", "Click IconExit", repo.TestAutomationForGUITestingRanore.IconExitInfo, new RecordItemIndex(6));
            repo.TestAutomationForGUITestingRanore.IconExit.PerformClick();
            
            

            
        }
    }
}
