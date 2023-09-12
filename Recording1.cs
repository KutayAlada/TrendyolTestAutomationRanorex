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

namespace MyTest4
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("b2016347-22a4-4aa0-ad07-2d06473b2a8b", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest4Repository repository.
        /// </summary>
        public static MyTest4Repository repo = MyTest4Repository.Instance;

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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.trendyol.com/?gads=true&tyutm_source=google&tyutm_medium=cpc&tyutm_campaign=new_gl_trendyol_2_x:brand-pure-istanbul&gclid=Cj0KCQjwxuCnBhDLARIsAB-cq1rbCLBthwmxGIo42uTqhYLLFjjL47055CW0gazA2-z72Y8ppQ5IHU4aAucYEALw_wcB' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.trendyol.com/?gads=true&tyutm_source=google&tyutm_medium=cpc&tyutm_campaign=new_gl_trendyol_2_x:brand-pure-istanbul&gclid=Cj0KCQjwxuCnBhDLARIsAB-cq1rbCLBthwmxGIo42uTqhYLLFjjL47055CW0gazA2-z72Y8ppQ5IHU4aAucYEALw_wcB", "Chrome", "", false, false, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.GirişYap' at 13;10.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.GirişYapInfo, new RecordItemIndex(1));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.GirişYap.Click("13;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.LoginEmail' at 48;18.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LoginEmailInfo, new RecordItemIndex(2));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LoginEmail.Click("48;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'kutayalada2000{LControlKey down}{LMenu down}{Qkey}{LControlKey up}{LMenu up}gmail.com' with focus on 'EnTrendUEruenlerTuerkiyeninOnlineAl.LoginEmail'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LoginEmailInfo, new RecordItemIndex(3));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LoginEmail.PressKeys("kutayalada2000{LControlKey down}{LMenu down}{Qkey}{LControlKey up}{LMenu up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'EnTrendUEruenlerTuerkiyeninOnlineAl.LoginEmail'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LoginEmailInfo, new RecordItemIndex(4));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LoginEmail.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Edirne34' with focus on 'EnTrendUEruenlerTuerkiyeninOnlineAl'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SelfInfo, new RecordItemIndex(5));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Self.EnsureVisible();
            Keyboard.Press("Edirne34");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.GirişYap1' at 41;1.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.GirişYap1Info, new RecordItemIndex(6));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.GirişYap1.Click("41;1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.BrowsingGwHomepage' at 189;105.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.BrowsingGwHomepageInfo, new RecordItemIndex(7));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.BrowsingGwHomepage.Click("189;105");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.BrowsingGwHomepage' at 209;203.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.BrowsingGwHomepageInfo, new RecordItemIndex(8));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.BrowsingGwHomepage.Click("209;203");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Erkek'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.ErkekInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.ErkekInfo, "Valid", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.Erkek' at 33;20.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.ErkekInfo, new RecordItemIndex(10));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Erkek.Click("33;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl' at 187;255.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SelfInfo, new RecordItemIndex(11));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.Self.Click("187;255");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.TRENDYOLMANYeniSezonŞıklığı1' at 168;92.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.TRENDYOLMANYeniSezonŞıklığı1Info, new RecordItemIndex(12));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.TRENDYOLMANYeniSezonŞıklığı1.Click("168;92");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.TRENDYOLMANYeniSezonŞıklığı1' at 205;99.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.TRENDYOLMANYeniSezonŞıklığı1Info, new RecordItemIndex(13));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.TRENDYOLMANYeniSezonŞıklığı1.Click("205;99");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn11' at 18;24.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn11Info, new RecordItemIndex(14));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn11.Click("18;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn' at 36;20.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtnInfo, new RecordItemIndex(15));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn.Click("36;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn1' at 24;17.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn1Info, new RecordItemIndex(16));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn1.Click("24;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn2' at 16;21.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn2Info, new RecordItemIndex(17));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn2.Click("16;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn3' at 23;18.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn3Info, new RecordItemIndex(18));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn3.Click("23;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn4' at 28;19.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn4Info, new RecordItemIndex(19));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn4.Click("28;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn5' at 18;20.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn5Info, new RecordItemIndex(20));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn5.Click("18;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn6' at 33;28.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn6Info, new RecordItemIndex(21));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn6.Click("33;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn7' at 22;13.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn7Info, new RecordItemIndex(22));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn7.Click("22;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn8' at 15;15.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn8Info, new RecordItemIndex(23));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.FvrtBtn8.Click("15;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody' at 99;104.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBodyInfo, new RecordItemIndex(24));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody.Click("99;104");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkleInfo, new RecordItemIndex(25));
            Validate.Exists(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkleInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle' at 215;10.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkleInfo, new RecordItemIndex(26));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle.Click("215;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TRENDYOLMANLimitedEditionAntrasitEr.Pane' at 710;14.", repo.TRENDYOLMANLimitedEditionAntrasitEr.PaneInfo, new RecordItemIndex(27));
            repo.TRENDYOLMANLimitedEditionAntrasitEr.Pane.Click("710;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody1' at 116;163.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody1Info, new RecordItemIndex(28));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody1.Click("116;163");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1' at 229;14.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1Info, new RecordItemIndex(29));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1.Click("229;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TRENDYOLMANLimitedEditionAntrasitEr.Pane1' at 706;17.", repo.TRENDYOLMANLimitedEditionAntrasitEr.Pane1Info, new RecordItemIndex(30));
            repo.TRENDYOLMANLimitedEditionAntrasitEr.Pane1.Click("706;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody2'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody2Info, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody2Info, "Valid", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody2' at 115;138.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody2Info, new RecordItemIndex(32));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody2.Click("115;138");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1' at 218;11.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1Info, new RecordItemIndex(33));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1.Click("218;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TRENDYOLMANAntrasitErkekBasicRegula.Pane' at 710;13.", repo.TRENDYOLMANAntrasitErkekBasicRegula.PaneInfo, new RecordItemIndex(34));
            repo.TRENDYOLMANAntrasitErkekBasicRegula.Pane.Click("710;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody3' at 132;187.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody3Info, new RecordItemIndex(35));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody3.Click("132;187");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1Info, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1Info, "Valid", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1' at 215;10.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1Info, new RecordItemIndex(37));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1.Click("215;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TRENDYOLMANLimitedEditionAntrasitEr.Pane3' at 709;15.", repo.TRENDYOLMANLimitedEditionAntrasitEr.Pane3Info, new RecordItemIndex(38));
            repo.TRENDYOLMANLimitedEditionAntrasitEr.Pane3.Click("709;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody4' at 94;182.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody4Info, new RecordItemIndex(39));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody4.Click("94;182");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='add-to-basket-button-text') on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1Info, new RecordItemIndex(40));
            Validate.AttributeEqual(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1Info, "Class", "add-to-basket-button-text");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle' at 223;16.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkleInfo, new RecordItemIndex(41));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle.Click("223;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TRENDYOLMANLimitedEditionAntrasitEr.Pane4' at 707;15.", repo.TRENDYOLMANLimitedEditionAntrasitEr.Pane4Info, new RecordItemIndex(42));
            repo.TRENDYOLMANLimitedEditionAntrasitEr.Pane4.Click("707;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody9' at 107;153.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody9Info, new RecordItemIndex(43));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody9.Click("107;153");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.ProductDetailApp' at 1690;415.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.ProductDetailAppInfo, new RecordItemIndex(44));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.ProductDetailApp.Click("1690;415");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle' at 221;12.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkleInfo, new RecordItemIndex(45));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle.Click("221;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TRENDYOLMANIndigoErkekOversizeFitG.Pane' at 710;14.", repo.TRENDYOLMANIndigoErkekOversizeFitG.PaneInfo, new RecordItemIndex(46));
            repo.TRENDYOLMANIndigoErkekOversizeFitG.Pane.Click("710;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody5' at 106;142.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody5Info, new RecordItemIndex(47));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.PrdctCntnrWrppr.ImageOverlayBody5.Click("106;142");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1' at 220;17.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1Info, new RecordItemIndex(48));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.SepeteEkle1.Click("220;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TRENDYOLMANLimitedEditionAntrasitEr.Pane5' at 706;16.", repo.TRENDYOLMANLimitedEditionAntrasitEr.Pane5Info, new RecordItemIndex(49));
            repo.TRENDYOLMANLimitedEditionAntrasitEr.Pane5.Click("706;16");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
