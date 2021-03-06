﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace TestExpoDemo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DownloadTrial recording.
    /// </summary>
    [TestModule("cede34c5-b676-4a71-b9b2-44941f104e5c", ModuleType.Recording, 1)]
    public partial class DownloadTrial : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestExpoDemoRepository repository.
        /// </summary>
        public static TestExpoDemoRepository repo = TestExpoDemoRepository.Instance;

        static DownloadTrial instance = new DownloadTrial();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DownloadTrial()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DownloadTrial Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestAutomationForGUITestingRanore.DownloadTrialButton' at 146;23.", repo.TestAutomationForGUITestingRanore.DownloadTrialButtonInfo, new RecordItemIndex(0));
            repo.TestAutomationForGUITestingRanore.DownloadTrialButton.Click("146;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestAutomationForGUITestingRanore.FormFirstName' at 76;20.", repo.TestAutomationForGUITestingRanore.FormFirstNameInfo, new RecordItemIndex(1));
            repo.TestAutomationForGUITestingRanore.FormFirstName.Click("76;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Code' with focus on 'TestAutomationForGUITestingRanore.FormFirstName'.", repo.TestAutomationForGUITestingRanore.FormFirstNameInfo, new RecordItemIndex(2));
            repo.TestAutomationForGUITestingRanore.FormFirstName.PressKeys("Code");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestAutomationForGUITestingRanore.FormLastName' at 63;22.", repo.TestAutomationForGUITestingRanore.FormLastNameInfo, new RecordItemIndex(3));
            repo.TestAutomationForGUITestingRanore.FormLastName.Click("63;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Tester' with focus on 'TestAutomationForGUITestingRanore.FormLastName'.", repo.TestAutomationForGUITestingRanore.FormLastNameInfo, new RecordItemIndex(4));
            repo.TestAutomationForGUITestingRanore.FormLastName.PressKeys("Tester");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestAutomationForGUITestingRanore.FormEmail' at 90;22.", repo.TestAutomationForGUITestingRanore.FormEmailInfo, new RecordItemIndex(5));
            repo.TestAutomationForGUITestingRanore.FormEmail.Click("90;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'code@test.com' with focus on 'TestAutomationForGUITestingRanore.FormEmail'.", repo.TestAutomationForGUITestingRanore.FormEmailInfo, new RecordItemIndex(6));
            repo.TestAutomationForGUITestingRanore.FormEmail.PressKeys("code@test.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestAutomationForGUITestingRanore.Register' at 99;18.", repo.TestAutomationForGUITestingRanore.RegisterInfo, new RecordItemIndex(7));
            repo.TestAutomationForGUITestingRanore.Register.Click("99;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestAutomationForGUITestingRanore.IconExit' at 12;7.", repo.TestAutomationForGUITestingRanore.IconExitInfo, new RecordItemIndex(8));
            repo.TestAutomationForGUITestingRanore.IconExit.Click("12;7");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
