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

namespace ocherednoisolution
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("4576cead-a87e-45bc-a497-b2b64ac0965b", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ocherednoisolutionRepository repository.
        /// </summary>
        public static ocherednoisolutionRepository repo = ocherednoisolutionRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\Mineframe 7.0\\bin\\GeoTech.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\Mineframe 7.0\\bin\\GeoTech.exe", "", "C:\\Program Files (x86)\\Mineframe 7.0\\bin", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Информация.ButtonОК' at 37;10.", repo.Информация.ButtonОКInfo, new RecordItemIndex(1));
            repo.Информация.ButtonОК.Click("37;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Символ' at 34;10.", repo.GeoTech3D7ГеологияМаркшейде.СимволInfo, new RecordItemIndex(2));
            repo.GeoTech3D7ГеологияМаркшейде.Символ.Click("34;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech.СоздатьCtrlPlusN' at 63;13.", repo.GeoTech.СоздатьCtrlPlusNInfo, new RecordItemIndex(3));
            repo.GeoTech.СоздатьCtrlPlusN.Click("63;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D.SbtCreateProject' at 9;13.", repo.GeoTech3D.SbtCreateProjectInfo, new RecordItemIndex(4));
            repo.GeoTech3D.SbtCreateProject.Click("9;13");
            Delay.Milliseconds(200);
            
            // Ввод случайного именипроекта
            ReturnRandomString.inputNameOfProject();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D1.Применить' at 36;14.", repo.GeoTech3D1.ПрименитьInfo, new RecordItemIndex(6));
            repo.GeoTech3D1.Применить.Click("36;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.XminEdit' at 42;9.", repo.GEOTECH3D2.TabbedNotebook1.XminEditInfo, new RecordItemIndex(7));
            repo.GEOTECH3D2.TabbedNotebook1.XminEdit.Click("42;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1500' with focus on 'GEOTECH3D2.TabbedNotebook1.XminEdit'.", repo.GEOTECH3D2.TabbedNotebook1.XminEditInfo, new RecordItemIndex(8));
            repo.GEOTECH3D2.TabbedNotebook1.XminEdit.PressKeys("1500");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.XmaxEdit' at 43;11.", repo.GEOTECH3D2.TabbedNotebook1.XmaxEditInfo, new RecordItemIndex(9));
            repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit.Click("43;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '3500' with focus on 'GEOTECH3D2.TabbedNotebook1.XmaxEdit'.", repo.GEOTECH3D2.TabbedNotebook1.XmaxEditInfo, new RecordItemIndex(10));
            repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit.PressKeys("3500");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.YminEdit' at 37;10.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(11));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.Click("37;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-1200' with focus on 'GEOTECH3D2.TabbedNotebook1.YminEdit'.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(12));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.PressKeys("-1200");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.YmaxEdit' at 47;5.", repo.GEOTECH3D2.TabbedNotebook1.YmaxEditInfo, new RecordItemIndex(13));
            repo.GEOTECH3D2.TabbedNotebook1.YmaxEdit.Click("47;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '4000' with focus on 'GEOTECH3D2.TabbedNotebook1.YmaxEdit'.", repo.GEOTECH3D2.TabbedNotebook1.YmaxEditInfo, new RecordItemIndex(14));
            repo.GEOTECH3D2.TabbedNotebook1.YmaxEdit.PressKeys("4000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.ZminEdit' at 43;12.", repo.GEOTECH3D2.TabbedNotebook1.ZminEditInfo, new RecordItemIndex(15));
            repo.GEOTECH3D2.TabbedNotebook1.ZminEdit.Click("43;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100' with focus on 'GEOTECH3D2.TabbedNotebook1.ZminEdit'.", repo.GEOTECH3D2.TabbedNotebook1.ZminEditInfo, new RecordItemIndex(16));
            repo.GEOTECH3D2.TabbedNotebook1.ZminEdit.PressKeys("100");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.ZmaxEdit' at 29;6.", repo.GEOTECH3D2.TabbedNotebook1.ZmaxEditInfo, new RecordItemIndex(17));
            repo.GEOTECH3D2.TabbedNotebook1.ZmaxEdit.Click("29;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1000' with focus on 'GEOTECH3D2.TabbedNotebook1.ZmaxEdit'.", repo.GEOTECH3D2.TabbedNotebook1.ZmaxEditInfo, new RecordItemIndex(18));
            repo.GEOTECH3D2.TabbedNotebook1.ZmaxEdit.PressKeys("1000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.Выполнить' at 27;13.", repo.GEOTECH3D2.ВыполнитьInfo, new RecordItemIndex(19));
            repo.GEOTECH3D2.Выполнить.Click("27;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.SomeElement' at 14;12.", repo.GeoTech3D7ГеологияМаркшейде.SomeElementInfo, new RecordItemIndex(20));
            repo.GeoTech3D7ГеологияМаркшейде.SomeElement.Click("14;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 155;9.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(21));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.Click("155;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 155;9.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(22));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.Click("155;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 155;9.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(23));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.DoubleClick("155;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 155;9.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(24));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.Click("155;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 155;9.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(25));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.DoubleClick("155;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'qw'.", new RecordItemIndex(26));
            Keyboard.Press("qw");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'e'.", new RecordItemIndex(27));
            Keyboard.Press("e");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.PropOkBtn' at 35;13.", repo.GeoTech3D7ГеологияМаркшейде.PropOkBtnInfo, new RecordItemIndex(28));
            repo.GeoTech3D7ГеологияМаркшейде.PropOkBtn.Click("35;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Form65280' at 240;340.", repo.GeoTech3D7ГеологияМаркшейде.Form65280Info, new RecordItemIndex(29));
            repo.GeoTech3D7ГеологияМаркшейде.Form65280.Click("240;340");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.SomeElement1' at 6;15.", repo.GeoTech3D7ГеологияМаркшейде.SomeElement1Info, new RecordItemIndex(30));
            repo.GeoTech3D7ГеологияМаркшейде.SomeElement1.Click("6;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Действия' at 35;18.", repo.GeoTech3D7ГеологияМаркшейде.ДействияInfo, new RecordItemIndex(31));
            repo.GeoTech3D7ГеологияМаркшейде.Действия.Click("35;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech.ИмпортИзФайла' at 101;10.", repo.GeoTech.ИмпортИзФайлаInfo, new RecordItemIndex(32));
            repo.GeoTech.ИмпортИзФайла.Click("101;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.ComboBox1136' at 125;11.", repo.Открытие.ComboBox1136Info, new RecordItemIndex(33));
            repo.Открытие.ComboBox1136.Click("125;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ФайлыAutoCAD2004DXFAsteriskDxf' at 160;18.", repo.List1000.ФайлыAutoCAD2004DXFAsteriskDxfInfo, new RecordItemIndex(34));
            repo.List1000.ФайлыAutoCAD2004DXFAsteriskDxf.Click("160;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.SystemItemNameDisplay' at 98;16.", repo.Открытие.SystemItemNameDisplayInfo, new RecordItemIndex(35));
            repo.Открытие.SystemItemNameDisplay.Click("98;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.ButtonОткрыть' at 26;11.", repo.Открытие.ButtonОткрытьInfo, new RecordItemIndex(36));
            repo.Открытие.ButtonОткрыть.Click("26;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D3.Геодезические' at 29;13.", repo.GEOTECH3D3.ГеодезическиеInfo, new RecordItemIndex(37));
            repo.GEOTECH3D3.Геодезические.Click("29;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D3.Импорт' at 59;8.", repo.GEOTECH3D3.ИмпортInfo, new RecordItemIndex(38));
            repo.GEOTECH3D3.Импорт.Click("59;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D4.Продолжить' at 12;19.", repo.GEOTECH3D4.ПродолжитьInfo, new RecordItemIndex(39));
            repo.GEOTECH3D4.Продолжить.Click("12;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Form65280' at 307;336.", repo.GeoTech3D7ГеологияМаркшейде.Form65280Info, new RecordItemIndex(40));
            repo.GeoTech3D7ГеологияМаркшейде.Form65280.Click("307;336");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
