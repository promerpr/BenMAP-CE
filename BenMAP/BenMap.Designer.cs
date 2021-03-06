
using OxyPlot;
using OxyPlot.WindowsForms;

namespace BenMAP
{
	partial class BenMAP
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenMAP));
			this.SmallImageList = new System.Windows.Forms.ImageList(this.components);
			this.tipBallon = new System.Windows.Forms.ToolTip(this.components);
			this.tabCRFunctionResultGISShow = new System.Windows.Forms.TabPage();
			this.spCRFunction = new System.Windows.Forms.SplitContainer();
			this.olvCRFunctionResult = new BrightIdeasSoftware.ObjectListView();
			this.olvcEndPointGroup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn39 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn36 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvcDataSet = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn35 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn17 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn37 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn38 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn40 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn41 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn42 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn43 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn44 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn45 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn46 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn47 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn48 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn49 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn50 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn51 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn52 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.btSelectAttribute = new System.Windows.Forms.Button();
			this.btShowCRResult = new System.Windows.Forms.Button();
			this.cbCRAggregation = new System.Windows.Forms.ComboBox();
			this.lblRegion = new System.Windows.Forms.Label();
			this.picCRHelp = new System.Windows.Forms.PictureBox();
			this.rdbShowAllCR = new System.Windows.Forms.RadioButton();
			this.rdbShowActiveCR = new System.Windows.Forms.RadioButton();
			this.btShowIncidencePooling = new System.Windows.Forms.Button();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.appManager1 = new DotSpatial.Controls.AppManager();
			this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn18 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn19 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn20 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn21 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn22 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn23 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn24 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn25 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn26 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn27 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn28 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn29 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn30 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn31 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn32 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn33 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn34 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn53 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn54 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn55 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn56 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn57 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn58 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn59 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn60 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn61 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.rbShowAllIncidence = new System.Windows.Forms.RadioButton();
			this.rbShowAllAPV = new System.Windows.Forms.RadioButton();
			this.olvColumn62 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.trvSetting = new System.Windows.Forms.TreeView();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.tabCtlReport = new System.Windows.Forms.TabControl();
			this.tabPoolingIncidence = new System.Windows.Forms.TabPage();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.olvIncidence = new BrightIdeasSoftware.ObjectListView();
			this.olvColumn104 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn105 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn67 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn106 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn71 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn72 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn73 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn74 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn66 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn75 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn76 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn77 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn78 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn79 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn80 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn85 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn64 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn86 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn107 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn108 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn68 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbShowActiveIncidence = new System.Windows.Forms.RadioButton();
			this.rbIncidenceAll = new System.Windows.Forms.RadioButton();
			this.rbIncidenceOnlyOne = new System.Windows.Forms.RadioButton();
			this.cbIncidenceAggregation = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.btPoolingShowResult = new System.Windows.Forms.Button();
			this.btPoolingSelectAttribute = new System.Windows.Forms.Button();
			this.lblIncidence = new System.Windows.Forms.Label();
			this.cbPoolingWindowIncidence = new System.Windows.Forms.ComboBox();
			this.btShowDetailIncidence = new System.Windows.Forms.Button();
			this.tabAPVResultGISShow = new System.Windows.Forms.TabPage();
			this.spAPVResult = new System.Windows.Forms.SplitContainer();
			this.tlvAPVResult = new BrightIdeasSoftware.ObjectListView();
			this.olvColumn63 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn81 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn82 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn92 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn93 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn94 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn83 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn65 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.btShowDetailValuation = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbShowActiveAPV = new System.Windows.Forms.RadioButton();
			this.rbAPVAll = new System.Windows.Forms.RadioButton();
			this.rbAPVOnlyOne = new System.Windows.Forms.RadioButton();
			this.btnShowAPVResult = new System.Windows.Forms.Button();
			this.btAPVSelectAttribute = new System.Windows.Forms.Button();
			this.cbAPVAggregation = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblAPV = new System.Windows.Forms.Label();
			this.chbAPVAggregation = new System.Windows.Forms.CheckBox();
			this.cbPoolingWindowAPV = new System.Windows.Forms.ComboBox();
			this.lbIncidencePoolingMethod = new System.Windows.Forms.Label();
			this.tabAuditTrialReport = new System.Windows.Forms.TabPage();
			this.btShowAudit = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtExistingConfiguration = new System.Windows.Forms.TextBox();
			this.rbAuditFile = new System.Windows.Forms.RadioButton();
			this.rbAuditCurrent = new System.Windows.Forms.RadioButton();
			this.tabCtlMain = new System.Windows.Forms.TabControl();
			this.tabGIS = new System.Windows.Forms.TabPage();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.pnlLegend = new System.Windows.Forms.Panel();
			this.legend1 = new DotSpatial.Controls.Legend();
			this.panel3 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
			this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
			this.btnPan = new System.Windows.Forms.ToolStripButton();
			this.btnFullExtent = new System.Windows.Forms.ToolStripButton();
			this.btnIdentify = new System.Windows.Forms.ToolStripButton();
			this.tsbAttributes = new System.Windows.Forms.ToolStripButton();
			this.btnSelect = new System.Windows.Forms.ToolStripButton();
			this.tsbSelectByLocation = new System.Windows.Forms.ToolStripButton();
			this.btnClearSelection = new System.Windows.Forms.ToolStripButton();
			this.tsbPrintLayout = new System.Windows.Forms.ToolStripButton();
			this.tsbSaveShapefile = new System.Windows.Forms.ToolStripButton();
			this.tsbAddLayer = new System.Windows.Forms.ToolStripButton();
			this.tsbChangeProjection = new System.Windows.Forms.ToolStripButton();
			this.cboRegion = new System.Windows.Forms.ComboBox();
			this.mainMap = new DotSpatial.Controls.Map();
			this.tabData = new System.Windows.Forms.TabPage();
			this.spTable = new System.Windows.Forms.SplitContainer();
			this.OLVResultsShow = new BrightIdeasSoftware.ObjectListView();
			this.chbAllPercentiles = new System.Windows.Forms.CheckBox();
			this.label17 = new System.Windows.Forms.Label();
			this.numericUpDownResult = new System.Windows.Forms.NumericUpDown();
			this.btnResultShow = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnTableOutput = new System.Windows.Forms.Button();
			this.tabChart = new System.Windows.Forms.TabPage();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.btnSelectAll = new System.Windows.Forms.Button();
			this.cbGraph = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbChartXAxis = new System.Windows.Forms.ComboBox();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.textChartFilter = new System.Windows.Forms.TextBox();
			this.olvRegions = new BrightIdeasSoftware.ObjectListView();
			this.olvColumn99 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn69 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn70 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.btnApply = new System.Windows.Forms.Button();
			this.oxyPlotView = new OxyPlot.WindowsForms.PlotView();
			this.btnSaveChart = new System.Windows.Forms.Button();
			this.pnlChart = new System.Windows.Forms.Panel();
			this.tabATReport = new System.Windows.Forms.TabPage();
			this.lblAuditSearch = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbSearch = new System.Windows.Forms.RadioButton();
			this.rbFilter = new System.Windows.Forms.RadioButton();
			this.btnAuditTrailCollapse = new System.Windows.Forms.Button();
			this.btnAuditTrailExpand = new System.Windows.Forms.Button();
			this.textBoxFilterSimple = new System.Windows.Forms.TextBox();
			this.treeListView = new BrightIdeasSoftware.TreeListView();
			this.treeColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.btnAuditTrailOutput = new System.Windows.Forms.Button();
			this.btnPieTheme = new System.Windows.Forms.ToolStripButton();
			this.colorBlend = new WinControls.ColorBlendControl();
			this.colorBlend2 = new WinControls.ColorBlendControl();
			this.tabCRFunctionResultGISShow.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spCRFunction)).BeginInit();
			this.spCRFunction.Panel1.SuspendLayout();
			this.spCRFunction.Panel2.SuspendLayout();
			this.spCRFunction.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvCRFunctionResult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCRHelp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.tabCtlReport.SuspendLayout();
			this.tabPoolingIncidence.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvIncidence)).BeginInit();
			this.panel2.SuspendLayout();
			this.tabAPVResultGISShow.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spAPVResult)).BeginInit();
			this.spAPVResult.Panel1.SuspendLayout();
			this.spAPVResult.Panel2.SuspendLayout();
			this.spAPVResult.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tlvAPVResult)).BeginInit();
			this.panel1.SuspendLayout();
			this.tabAuditTrialReport.SuspendLayout();
			this.tabCtlMain.SuspendLayout();
			this.tabGIS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.pnlLegend.SuspendLayout();
			this.panel3.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tabData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spTable)).BeginInit();
			this.spTable.Panel1.SuspendLayout();
			this.spTable.Panel2.SuspendLayout();
			this.spTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OLVResultsShow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownResult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnResultShow)).BeginInit();
			this.btnResultShow.SuspendLayout();
			this.tabChart.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRegions)).BeginInit();
			this.tabATReport.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
			this.SuspendLayout();
			// 
			// SmallImageList
			// 
			this.SmallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallImageList.ImageStream")));
			this.SmallImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.SmallImageList.Images.SetKeyName(0, "yibu");
			this.SmallImageList.Images.SetKeyName(1, "Select");
			this.SmallImageList.Images.SetKeyName(2, "item");
			this.SmallImageList.Images.SetKeyName(3, "ready");
			this.SmallImageList.Images.SetKeyName(4, "blueball");
			this.SmallImageList.Images.SetKeyName(5, "unready");
			this.SmallImageList.Images.SetKeyName(6, "open");
			this.SmallImageList.Images.SetKeyName(7, "search");
			this.SmallImageList.Images.SetKeyName(8, "error");
			this.SmallImageList.Images.SetKeyName(9, "docold");
			this.SmallImageList.Images.SetKeyName(10, "group");
			this.SmallImageList.Images.SetKeyName(11, "step1");
			this.SmallImageList.Images.SetKeyName(12, "step2old");
			this.SmallImageList.Images.SetKeyName(13, "step3old");
			this.SmallImageList.Images.SetKeyName(14, "step4");
			this.SmallImageList.Images.SetKeyName(15, "step5");
			this.SmallImageList.Images.SetKeyName(16, "step6");
			this.SmallImageList.Images.SetKeyName(17, "step7");
			this.SmallImageList.Images.SetKeyName(18, "step8");
			this.SmallImageList.Images.SetKeyName(19, "step9");
			this.SmallImageList.Images.SetKeyName(20, "step10");
			this.SmallImageList.Images.SetKeyName(21, "docold");
			this.SmallImageList.Images.SetKeyName(22, "doc");
			this.SmallImageList.Images.SetKeyName(23, "docgrey");
			this.SmallImageList.Images.SetKeyName(24, "step2");
			this.SmallImageList.Images.SetKeyName(25, "step3");
			this.SmallImageList.Images.SetKeyName(26, "Audit.png");
			this.SmallImageList.Images.SetKeyName(27, "Chart.png");
			this.SmallImageList.Images.SetKeyName(28, "Data.png");
			this.SmallImageList.Images.SetKeyName(29, "Map.png");
			// 
			// tipBallon
			// 
			this.tipBallon.IsBalloon = true;
			// 
			// tabCRFunctionResultGISShow
			// 
			this.tabCRFunctionResultGISShow.Controls.Add(this.spCRFunction);
			this.tabCRFunctionResultGISShow.ImageIndex = 12;
			this.tabCRFunctionResultGISShow.Location = new System.Drawing.Point(4, 23);
			this.tabCRFunctionResultGISShow.Name = "tabCRFunctionResultGISShow";
			this.tabCRFunctionResultGISShow.Size = new System.Drawing.Size(657, 172);
			this.tabCRFunctionResultGISShow.TabIndex = 5;
			this.tabCRFunctionResultGISShow.Tag = "function";
			this.tabCRFunctionResultGISShow.Text = "Health Impact Results";
			this.tipBallon.SetToolTip(this.tabCRFunctionResultGISShow, "\r\n");
			this.tabCRFunctionResultGISShow.ToolTipText = "Double-click HIF or APV results below to display map/data/chart";
			this.tabCRFunctionResultGISShow.UseVisualStyleBackColor = true;
			// 
			// spCRFunction
			// 
			this.spCRFunction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spCRFunction.Location = new System.Drawing.Point(0, 0);
			this.spCRFunction.Margin = new System.Windows.Forms.Padding(0);
			this.spCRFunction.Name = "spCRFunction";
			this.spCRFunction.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spCRFunction.Panel1
			// 
			this.spCRFunction.Panel1.Controls.Add(this.olvCRFunctionResult);
			// 
			// spCRFunction.Panel2
			// 
			this.spCRFunction.Panel2.AutoScroll = true;
			this.spCRFunction.Panel2.Controls.Add(this.btSelectAttribute);
			this.spCRFunction.Panel2.Controls.Add(this.btShowCRResult);
			this.spCRFunction.Panel2.Controls.Add(this.cbCRAggregation);
			this.spCRFunction.Panel2.Controls.Add(this.lblRegion);
			this.spCRFunction.Panel2.Controls.Add(this.picCRHelp);
			this.spCRFunction.Panel2.Controls.Add(this.rdbShowAllCR);
			this.spCRFunction.Panel2.Controls.Add(this.rdbShowActiveCR);
			this.spCRFunction.Size = new System.Drawing.Size(657, 172);
			this.spCRFunction.SplitterDistance = 107;
			this.spCRFunction.SplitterWidth = 1;
			this.spCRFunction.TabIndex = 0;
			// 
			// olvCRFunctionResult
			// 
			this.olvCRFunctionResult.Alignment = System.Windows.Forms.ListViewAlignment.Left;
			this.olvCRFunctionResult.AllColumns.Add(this.olvcEndPointGroup);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn2);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn39);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn36);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn8);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn9);
			this.olvCRFunctionResult.AllColumns.Add(this.olvcDataSet);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn35);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn12);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn13);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn14);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn15);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn16);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn17);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn37);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn38);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn40);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn41);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn42);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn43);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn44);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn45);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn46);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn47);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn48);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn49);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn50);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn51);
			this.olvCRFunctionResult.AllColumns.Add(this.olvColumn52);
			this.olvCRFunctionResult.AllowColumnReorder = true;
			this.olvCRFunctionResult.AllowDrop = true;
			this.olvCRFunctionResult.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
			this.olvCRFunctionResult.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.olvCRFunctionResult.CellEditUseWholeCell = false;
			this.olvCRFunctionResult.CheckedAspectName = "";
			this.olvCRFunctionResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
						this.olvcEndPointGroup,
						this.olvColumn2,
						this.olvColumn39,
						this.olvColumn36,
						this.olvColumn8,
						this.olvColumn9,
						this.olvcDataSet,
						this.olvColumn35,
						this.olvColumn12,
						this.olvColumn13,
						this.olvColumn14,
						this.olvColumn15,
						this.olvColumn16,
						this.olvColumn17,
						this.olvColumn37,
						this.olvColumn38,
						this.olvColumn40,
						this.olvColumn41,
						this.olvColumn42,
						this.olvColumn43,
						this.olvColumn44,
						this.olvColumn45,
						this.olvColumn46,
						this.olvColumn47,
						this.olvColumn48,
						this.olvColumn49,
						this.olvColumn50,
						this.olvColumn51,
						this.olvColumn52});
			this.olvCRFunctionResult.CopySelectionOnControlC = false;
			this.olvCRFunctionResult.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvCRFunctionResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvCRFunctionResult.EmptyListMsg = "Health impact results will be displayed here";
			this.olvCRFunctionResult.EmptyListMsgFont = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
			this.olvCRFunctionResult.FullRowSelect = true;
			this.olvCRFunctionResult.HideSelection = false;
			this.olvCRFunctionResult.IsSimpleDragSource = true;
			this.olvCRFunctionResult.Location = new System.Drawing.Point(0, 0);
			this.olvCRFunctionResult.Margin = new System.Windows.Forms.Padding(0);
			this.olvCRFunctionResult.Name = "olvCRFunctionResult";
			this.olvCRFunctionResult.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
			this.olvCRFunctionResult.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.olvCRFunctionResult.OverlayText.BorderWidth = 2F;
			this.olvCRFunctionResult.OverlayText.Rotation = -20;
			this.olvCRFunctionResult.OverlayText.Text = "";
			this.olvCRFunctionResult.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvCRFunctionResult.ShowCommandMenuOnRightClick = true;
			this.olvCRFunctionResult.ShowGroups = false;
			this.olvCRFunctionResult.ShowImagesOnSubItems = true;
			this.olvCRFunctionResult.ShowItemCountOnGroups = true;
			this.olvCRFunctionResult.ShowItemToolTips = true;
			this.olvCRFunctionResult.Size = new System.Drawing.Size(657, 107);
			this.olvCRFunctionResult.SpaceBetweenGroups = 20;
			this.olvCRFunctionResult.TabIndex = 0;
			this.olvCRFunctionResult.Tag = "";
			this.olvCRFunctionResult.UseAlternatingBackColors = true;
			this.olvCRFunctionResult.UseCompatibleStateImageBehavior = false;
			this.olvCRFunctionResult.UseFiltering = true;
			this.olvCRFunctionResult.UseHotItem = true;
			this.olvCRFunctionResult.UseHyperlinks = true;
			this.olvCRFunctionResult.View = System.Windows.Forms.View.Details;
			this.olvCRFunctionResult.DragDrop += new System.Windows.Forms.DragEventHandler(this.olvCRFunctionResult_DragDrop);
			this.olvCRFunctionResult.DragLeave += new System.EventHandler(this.olvCRFunctionResult_DragLeave);
			this.olvCRFunctionResult.DoubleClick += new System.EventHandler(this.olvCRFunctionResult_DoubleClick);
			// 
			// olvcEndPointGroup
			// 
			this.olvcEndPointGroup.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.EndPointGroup";
			this.olvcEndPointGroup.IsEditable = false;
			this.olvcEndPointGroup.IsTileViewColumn = true;
			this.olvcEndPointGroup.MinimumWidth = 100;
			this.olvcEndPointGroup.Text = "Endpoint Group";
			this.olvcEndPointGroup.ToolTipText = "";
			this.olvcEndPointGroup.Width = 140;
			// 
			// olvColumn2
			// 
			this.olvColumn2.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.EndPoint";
			this.olvColumn2.IsEditable = false;
			this.olvColumn2.IsTileViewColumn = true;
			this.olvColumn2.MinimumWidth = 50;
			this.olvColumn2.Text = "Endpoint";
			this.olvColumn2.Width = 112;
			// 
			// olvColumn39
			// 
			this.olvColumn39.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Pollutant.PollutantName";
			this.olvColumn39.IsEditable = false;
			this.olvColumn39.Text = "Pollutant";
			this.olvColumn39.Width = 110;
			// 
			// olvColumn36
			// 
			this.olvColumn36.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Author";
			this.olvColumn36.IsEditable = false;
			this.olvColumn36.IsTileViewColumn = true;
			this.olvColumn36.Text = "Author";
			// 
			// olvColumn8
			// 
			this.olvColumn8.AspectName = "CRSelectFunction.StartAge";
			this.olvColumn8.IsEditable = false;
			this.olvColumn8.IsTileViewColumn = true;
			this.olvColumn8.Text = "Start Age";
			this.olvColumn8.Width = 70;
			// 
			// olvColumn9
			// 
			this.olvColumn9.AspectName = "CRSelectFunction.EndAge";
			this.olvColumn9.IsEditable = false;
			this.olvColumn9.IsTileViewColumn = true;
			this.olvColumn9.Text = "End Age";
			this.olvColumn9.Width = 70;
			// 
			// olvcDataSet
			// 
			this.olvcDataSet.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.DataSetName";
			this.olvcDataSet.IsEditable = false;
			this.olvcDataSet.Text = "Dataset Name";
			this.olvcDataSet.Width = 85;
			// 
			// olvColumn35
			// 
			this.olvColumn35.AspectName = "CRSelectFunction.GeographicAreaName";
			this.olvColumn35.IsEditable = false;
			this.olvColumn35.Text = "Geographic Area";
			this.olvColumn35.Width = 100;
			// 
			// olvColumn12
			// 
			this.olvColumn12.AspectName = "CRSelectFunction.Race";
			this.olvColumn12.IsEditable = false;
			this.olvColumn12.Text = "Race";
			// 
			// olvColumn13
			// 
			this.olvColumn13.AspectName = "CRSelectFunction.Ethnicity";
			this.olvColumn13.IsEditable = false;
			this.olvColumn13.Text = "Ethnicity";
			this.olvColumn13.Width = 78;
			// 
			// olvColumn14
			// 
			this.olvColumn14.AspectName = "CRSelectFunction.Gender";
			this.olvColumn14.IsEditable = false;
			this.olvColumn14.Text = "Gender";
			// 
			// olvColumn15
			// 
			this.olvColumn15.AspectName = "CRSelectFunction.IncidenceDataSetName";
			this.olvColumn15.IsEditable = false;
			this.olvColumn15.Text = "Incidence Dataset";
			this.olvColumn15.Width = 120;
			// 
			// olvColumn16
			// 
			this.olvColumn16.AspectName = "CRSelectFunction.PrevalenceDataSetName";
			this.olvColumn16.IsEditable = false;
			this.olvColumn16.Text = "Prevalence Dataset";
			this.olvColumn16.Width = 120;
			// 
			// olvColumn17
			// 
			this.olvColumn17.AspectName = "CRSelectFunction.VariableDataSetName";
			this.olvColumn17.IsEditable = false;
			this.olvColumn17.Text = "Variable Dataset";
			this.olvColumn17.Width = 120;
			// 
			// olvColumn37
			// 
			this.olvColumn37.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.strLocations";
			this.olvColumn37.IsEditable = false;
			this.olvColumn37.Text = "Study Location";
			this.olvColumn37.Width = 80;
			// 
			// olvColumn38
			// 
			this.olvColumn38.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Qualifier";
			this.olvColumn38.IsEditable = false;
			this.olvColumn38.Text = "Qualifier";
			this.olvColumn38.Width = 80;
			// 
			// olvColumn40
			// 
			this.olvColumn40.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Reference";
			this.olvColumn40.IsEditable = false;
			this.olvColumn40.Text = "Reference";
			this.olvColumn40.Width = 80;
			// 
			// olvColumn41
			// 
			this.olvColumn41.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Function";
			this.olvColumn41.IsEditable = false;
			this.olvColumn41.IsTileViewColumn = true;
			this.olvColumn41.Text = "Function";
			this.olvColumn41.Width = 80;
			// 
			// olvColumn42
			// 
			this.olvColumn42.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BaseLineIncidenceFunction";
			this.olvColumn42.IsEditable = false;
			this.olvColumn42.Text = "Baseline Incidence Function";
			this.olvColumn42.Width = 180;
			// 
			// olvColumn43
			// 
			this.olvColumn43.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BetaDistribution";
			this.olvColumn43.IsEditable = false;
			this.olvColumn43.Text = "Beta Distribution";
			this.olvColumn43.Width = 110;
			// 
			// olvColumn44
			// 
			this.olvColumn44.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Beta";
			this.olvColumn44.IsEditable = false;
			this.olvColumn44.Text = "Beta";
			// 
			// olvColumn45
			// 
			this.olvColumn45.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BetaParameter1";
			this.olvColumn45.IsEditable = false;
			this.olvColumn45.Text = "Beta Parameter 1";
			this.olvColumn45.Width = 110;
			// 
			// olvColumn46
			// 
			this.olvColumn46.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BetaParameter2";
			this.olvColumn46.IsEditable = false;
			this.olvColumn46.Text = "Beta Parameter 2";
			this.olvColumn46.Width = 110;
			// 
			// olvColumn47
			// 
			this.olvColumn47.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.AContantDescription";
			this.olvColumn47.IsEditable = false;
			this.olvColumn47.Text = "A Description";
			this.olvColumn47.Width = 140;
			// 
			// olvColumn48
			// 
			this.olvColumn48.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.AContantValue";
			this.olvColumn48.IsEditable = false;
			this.olvColumn48.Text = "A";
			this.olvColumn48.Width = 110;
			// 
			// olvColumn49
			// 
			this.olvColumn49.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BContantDescription";
			this.olvColumn49.IsEditable = false;
			this.olvColumn49.Text = "B Description";
			this.olvColumn49.Width = 140;
			// 
			// olvColumn50
			// 
			this.olvColumn50.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BContantValue";
			this.olvColumn50.IsEditable = false;
			this.olvColumn50.Text = "B";
			this.olvColumn50.Width = 110;
			// 
			// olvColumn51
			// 
			this.olvColumn51.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.CContantDescription";
			this.olvColumn51.IsEditable = false;
			this.olvColumn51.Text = "C Description";
			this.olvColumn51.Width = 140;
			// 
			// olvColumn52
			// 
			this.olvColumn52.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.CContantValue";
			this.olvColumn52.IsEditable = false;
			this.olvColumn52.Text = "C";
			this.olvColumn52.Width = 110;
			// 
			// btSelectAttribute
			// 
			this.btSelectAttribute.Location = new System.Drawing.Point(383, 32);
			this.btSelectAttribute.Name = "btSelectAttribute";
			this.btSelectAttribute.Size = new System.Drawing.Size(145, 23);
			this.btSelectAttribute.TabIndex = 4;
			this.btSelectAttribute.Text = "Select Result Fields";
			this.btSelectAttribute.UseCompatibleTextRendering = true;
			this.btSelectAttribute.UseVisualStyleBackColor = true;
			this.btSelectAttribute.Click += new System.EventHandler(this.btSelectAttribute_Click);
			// 
			// btShowCRResult
			// 
			this.btShowCRResult.Location = new System.Drawing.Point(532, 32);
			this.btShowCRResult.Name = "btShowCRResult";
			this.btShowCRResult.Size = new System.Drawing.Size(133, 23);
			this.btShowCRResult.TabIndex = 5;
			this.btShowCRResult.Text = "Show Results";
			this.btShowCRResult.UseVisualStyleBackColor = true;
			this.btShowCRResult.Click += new System.EventHandler(this.btShowCRResult_Click);
			// 
			// cbCRAggregation
			// 
			this.cbCRAggregation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCRAggregation.FormattingEnabled = true;
			this.cbCRAggregation.Location = new System.Drawing.Point(532, 3);
			this.cbCRAggregation.Name = "cbCRAggregation";
			this.cbCRAggregation.Size = new System.Drawing.Size(150, 22);
			this.cbCRAggregation.TabIndex = 3;
			this.cbCRAggregation.SelectedIndexChanged += new System.EventHandler(this.cbCRAggregation_SelectedIndexChanged);
			// 
			// lblRegion
			// 
			this.lblRegion.AutoSize = true;
			this.lblRegion.Location = new System.Drawing.Point(380, 6);
			this.lblRegion.Name = "lblRegion";
			this.lblRegion.Size = new System.Drawing.Size(143, 14);
			this.lblRegion.TabIndex = 2;
			this.lblRegion.Text = "Aggregation for raw data:";
			// 
			// picCRHelp
			// 
			this.picCRHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picCRHelp.BackgroundImage = global::BenMAP.Properties.Resources.help_16x16;
			this.picCRHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.picCRHelp.Location = new System.Drawing.Point(1756, 32);
			this.picCRHelp.Name = "picCRHelp";
			this.picCRHelp.Size = new System.Drawing.Size(20, 19);
			this.picCRHelp.TabIndex = 4;
			this.picCRHelp.TabStop = false;
			this.picCRHelp.Tag = "";
			this.toolTip1.SetToolTip(this.picCRHelp, "Double click datagrid to create result.\r\nIf you choose \'Create All\',GIS Map/Table" +
	"/Chart results will be created.\r\nIf you choose \'Active Study Only\',Only one acti" +
	"ve result will be created.");
			this.picCRHelp.Visible = false;
			this.picCRHelp.Click += new System.EventHandler(this.picCRHelp_Click);
			// 
			// rdbShowAllCR
			// 
			this.rdbShowAllCR.AutoSize = true;
			this.rdbShowAllCR.Checked = true;
			this.rdbShowAllCR.Location = new System.Drawing.Point(2, 4);
			this.rdbShowAllCR.Margin = new System.Windows.Forms.Padding(0);
			this.rdbShowAllCR.Name = "rdbShowAllCR";
			this.rdbShowAllCR.Size = new System.Drawing.Size(350, 18);
			this.rdbShowAllCR.TabIndex = 0;
			this.rdbShowAllCR.TabStop = true;
			this.rdbShowAllCR.Text = "Create map,data and chart (double-click the selected study)";
			this.rdbShowAllCR.UseVisualStyleBackColor = true;
			// 
			// rdbShowActiveCR
			// 
			this.rdbShowActiveCR.AutoSize = true;
			this.rdbShowActiveCR.Location = new System.Drawing.Point(1, 30);
			this.rdbShowActiveCR.Margin = new System.Windows.Forms.Padding(0);
			this.rdbShowActiveCR.Name = "rdbShowActiveCR";
			this.rdbShowActiveCR.Size = new System.Drawing.Size(239, 18);
			this.rdbShowActiveCR.TabIndex = 1;
			this.rdbShowActiveCR.Text = "Create data (table) for multiple studies";
			this.rdbShowActiveCR.UseVisualStyleBackColor = true;
			// 
			// btShowIncidencePooling
			// 
			this.btShowIncidencePooling.AutoSize = true;
			this.btShowIncidencePooling.Location = new System.Drawing.Point(91, -2);
			this.btShowIncidencePooling.Margin = new System.Windows.Forms.Padding(0);
			this.btShowIncidencePooling.Name = "btShowIncidencePooling";
			this.btShowIncidencePooling.Size = new System.Drawing.Size(178, 29);
			this.btShowIncidencePooling.TabIndex = 18;
			this.btShowIncidencePooling.Text = "Pooled Incidence Result";
			this.tipBallon.SetToolTip(this.btShowIncidencePooling, "Show Pooled Incidence Result.");
			this.btShowIncidencePooling.UseVisualStyleBackColor = true;
			this.btShowIncidencePooling.Visible = false;
			this.btShowIncidencePooling.Click += new System.EventHandler(this.btShowIncidencePooling_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.toolStripButton1.Image = global::BenMAP.Properties.Resources.magnifier_zoom_in;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(21, 20);
			this.toolStripButton1.ToolTipText = "Zoom in";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::BenMAP.Properties.Resources.magnifier_zoom_out;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(21, 20);
			this.toolStripButton2.ToolTipText = "Zoom out";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = global::BenMAP.Properties.Resources.pan_2;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(21, 20);
			this.toolStripButton3.Text = "Pan";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = global::BenMAP.Properties.Resources.globe_7;
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(21, 20);
			this.toolStripButton4.Text = "Full Extent";
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = global::BenMAP.Properties.Resources.chart4;
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(21, 20);
			this.toolStripButton5.Text = "toolStripButton1";
			this.toolStripButton5.ToolTipText = "Spatial analysis";
			// 
			// appManager1
			// 
			this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
			this.appManager1.DockManager = null;
			this.appManager1.HeaderControl = null;
			this.appManager1.Legend = null;
			this.appManager1.Map = null;
			this.appManager1.ProgressHandler = null;
			// 
			// olvColumn7
			// 
			this.olvColumn7.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.EndPoint";
			this.olvColumn7.DisplayIndex = 0;
			this.olvColumn7.IsEditable = false;
			this.olvColumn7.IsTileViewColumn = true;
			this.olvColumn7.MaximumWidth = 180;
			this.olvColumn7.MinimumWidth = 50;
			this.olvColumn7.Text = "EndPoint";
			this.olvColumn7.Width = 112;
			// 
			// olvColumn10
			// 
			this.olvColumn10.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.EndPointGroup";
			this.olvColumn10.DisplayIndex = 1;
			this.olvColumn10.IsEditable = false;
			this.olvColumn10.IsTileViewColumn = true;
			this.olvColumn10.MaximumWidth = 200;
			this.olvColumn10.MinimumWidth = 100;
			this.olvColumn10.Text = "Endpoint Group";
			this.olvColumn10.ToolTipText = "";
			this.olvColumn10.Width = 140;
			// 
			// olvColumn11
			// 
			this.olvColumn11.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.DataSetName";
			this.olvColumn11.DisplayIndex = 2;
			this.olvColumn11.IsEditable = false;
			this.olvColumn11.Text = "Dataset Name";
			this.olvColumn11.Width = 85;
			// 
			// olvColumn18
			// 
			this.olvColumn18.AspectName = "CRSelectFunction.StartAge";
			this.olvColumn18.DisplayIndex = 3;
			this.olvColumn18.IsEditable = false;
			this.olvColumn18.IsTileViewColumn = true;
			this.olvColumn18.Text = "Start Age";
			this.olvColumn18.Width = 70;
			// 
			// olvColumn19
			// 
			this.olvColumn19.AspectName = "CRSelectFunction.EndAge";
			this.olvColumn19.DisplayIndex = 4;
			this.olvColumn19.IsEditable = false;
			this.olvColumn19.IsTileViewColumn = true;
			this.olvColumn19.Text = "End Age";
			this.olvColumn19.Width = 70;
			// 
			// olvColumn20
			// 
			this.olvColumn20.AspectName = "CRSelectFunction.Race";
			this.olvColumn20.DisplayIndex = 5;
			this.olvColumn20.IsEditable = false;
			this.olvColumn20.Text = "Race";
			// 
			// olvColumn21
			// 
			this.olvColumn21.AspectName = "CRSelectFunction.Ethnicity";
			this.olvColumn21.DisplayIndex = 6;
			this.olvColumn21.IsEditable = false;
			this.olvColumn21.Text = "Ethnicity";
			this.olvColumn21.Width = 78;
			// 
			// olvColumn22
			// 
			this.olvColumn22.AspectName = "CRSelectFunction.Gender";
			this.olvColumn22.DisplayIndex = 7;
			this.olvColumn22.IsEditable = false;
			this.olvColumn22.Text = "Gender";
			// 
			// olvColumn23
			// 
			this.olvColumn23.AspectName = "CRSelectFunction.IncidenceDataSetName";
			this.olvColumn23.DisplayIndex = 8;
			this.olvColumn23.IsEditable = false;
			this.olvColumn23.Text = "Incidence Dataset";
			this.olvColumn23.Width = 120;
			// 
			// olvColumn24
			// 
			this.olvColumn24.AspectName = "CRSelectFunction.PrevalenceDataSetName";
			this.olvColumn24.DisplayIndex = 9;
			this.olvColumn24.IsEditable = false;
			this.olvColumn24.Text = "Prevalence Dataset";
			this.olvColumn24.Width = 120;
			// 
			// olvColumn25
			// 
			this.olvColumn25.AspectName = "CRSelectFunction.VariableDataSetName";
			this.olvColumn25.DisplayIndex = 10;
			this.olvColumn25.IsEditable = false;
			this.olvColumn25.Text = "Variable Dataset";
			this.olvColumn25.Width = 120;
			// 
			// olvColumn26
			// 
			this.olvColumn26.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Percentile";
			this.olvColumn26.DisplayIndex = 11;
			this.olvColumn26.IsEditable = false;
			this.olvColumn26.Text = "Percentile";
			this.olvColumn26.Width = 80;
			// 
			// olvColumn27
			// 
			this.olvColumn27.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Author";
			this.olvColumn27.DisplayIndex = 12;
			this.olvColumn27.IsEditable = false;
			this.olvColumn27.IsTileViewColumn = true;
			this.olvColumn27.Text = "Author";
			// 
			// olvColumn28
			// 
			this.olvColumn28.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Locations";
			this.olvColumn28.DisplayIndex = 13;
			this.olvColumn28.IsEditable = false;
			this.olvColumn28.Text = "Locations";
			this.olvColumn28.Width = 80;
			// 
			// olvColumn29
			// 
			this.olvColumn29.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Qualifier";
			this.olvColumn29.DisplayIndex = 14;
			this.olvColumn29.IsEditable = false;
			this.olvColumn29.Text = "Qualifier";
			this.olvColumn29.Width = 80;
			// 
			// olvColumn30
			// 
			this.olvColumn30.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.OtherPollutants";
			this.olvColumn30.DisplayIndex = 15;
			this.olvColumn30.IsEditable = false;
			this.olvColumn30.Text = "Other Pollutants";
			this.olvColumn30.Width = 110;
			// 
			// olvColumn31
			// 
			this.olvColumn31.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Reference";
			this.olvColumn31.DisplayIndex = 16;
			this.olvColumn31.IsEditable = false;
			this.olvColumn31.Text = "Reference";
			this.olvColumn31.Width = 80;
			// 
			// olvColumn32
			// 
			this.olvColumn32.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Function";
			this.olvColumn32.DisplayIndex = 17;
			this.olvColumn32.IsEditable = false;
			this.olvColumn32.IsTileViewColumn = true;
			this.olvColumn32.Text = "Function";
			this.olvColumn32.Width = 80;
			// 
			// olvColumn33
			// 
			this.olvColumn33.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BaseLineIncidenceFunction";
			this.olvColumn33.DisplayIndex = 18;
			this.olvColumn33.IsEditable = false;
			this.olvColumn33.Text = "Baseline Incidence Function";
			this.olvColumn33.Width = 180;
			// 
			// olvColumn34
			// 
			this.olvColumn34.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BetaDistribution";
			this.olvColumn34.DisplayIndex = 19;
			this.olvColumn34.IsEditable = false;
			this.olvColumn34.Text = "Beta Distribution";
			this.olvColumn34.Width = 110;
			// 
			// olvColumn53
			// 
			this.olvColumn53.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.Beta";
			this.olvColumn53.DisplayIndex = 20;
			this.olvColumn53.IsEditable = false;
			this.olvColumn53.Text = "Beta";
			// 
			// olvColumn54
			// 
			this.olvColumn54.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BetaParameter1";
			this.olvColumn54.DisplayIndex = 21;
			this.olvColumn54.IsEditable = false;
			this.olvColumn54.Text = "Beta Parameter 1";
			this.olvColumn54.Width = 110;
			// 
			// olvColumn55
			// 
			this.olvColumn55.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BetaParameter2";
			this.olvColumn55.DisplayIndex = 22;
			this.olvColumn55.IsEditable = false;
			this.olvColumn55.Text = "Beta Parameter 2";
			this.olvColumn55.Width = 110;
			// 
			// olvColumn56
			// 
			this.olvColumn56.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.AContantDescription";
			this.olvColumn56.DisplayIndex = 23;
			this.olvColumn56.IsEditable = false;
			this.olvColumn56.Text = "A Description";
			this.olvColumn56.Width = 140;
			// 
			// olvColumn57
			// 
			this.olvColumn57.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.AContantValue";
			this.olvColumn57.DisplayIndex = 24;
			this.olvColumn57.IsEditable = false;
			this.olvColumn57.Text = "A";
			this.olvColumn57.Width = 110;
			// 
			// olvColumn58
			// 
			this.olvColumn58.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BContantDescription";
			this.olvColumn58.DisplayIndex = 25;
			this.olvColumn58.IsEditable = false;
			this.olvColumn58.Text = "B Description";
			this.olvColumn58.Width = 140;
			// 
			// olvColumn59
			// 
			this.olvColumn59.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.BContantValue";
			this.olvColumn59.DisplayIndex = 26;
			this.olvColumn59.IsEditable = false;
			this.olvColumn59.Text = "B";
			this.olvColumn59.Width = 110;
			// 
			// olvColumn60
			// 
			this.olvColumn60.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.CContantDescription";
			this.olvColumn60.DisplayIndex = 27;
			this.olvColumn60.IsEditable = false;
			this.olvColumn60.Text = "C Description";
			this.olvColumn60.Width = 140;
			// 
			// olvColumn61
			// 
			this.olvColumn61.AspectName = "CRSelectFunction.BenMAPHealthImpactFunction.CContantValue";
			this.olvColumn61.DisplayIndex = 28;
			this.olvColumn61.IsEditable = false;
			this.olvColumn61.Text = "C";
			this.olvColumn61.Width = 110;
			// 
			// rbShowAllIncidence
			// 
			this.rbShowAllIncidence.AutoSize = true;
			this.rbShowAllIncidence.Checked = true;
			this.rbShowAllIncidence.Location = new System.Drawing.Point(3, 2);
			this.rbShowAllIncidence.Margin = new System.Windows.Forms.Padding(0);
			this.rbShowAllIncidence.Name = "rbShowAllIncidence";
			this.rbShowAllIncidence.Size = new System.Drawing.Size(172, 18);
			this.rbShowAllIncidence.TabIndex = 17;
			this.rbShowAllIncidence.TabStop = true;
			this.rbShowAllIncidence.Text = "Create map, data and chart";
			this.toolTip1.SetToolTip(this.rbShowAllIncidence, "Double-click the selected study");
			this.rbShowAllIncidence.UseVisualStyleBackColor = true;
			// 
			// rbShowAllAPV
			// 
			this.rbShowAllAPV.AutoSize = true;
			this.rbShowAllAPV.Checked = true;
			this.rbShowAllAPV.Location = new System.Drawing.Point(0, 1);
			this.rbShowAllAPV.Margin = new System.Windows.Forms.Padding(0);
			this.rbShowAllAPV.Name = "rbShowAllAPV";
			this.rbShowAllAPV.Size = new System.Drawing.Size(172, 18);
			this.rbShowAllAPV.TabIndex = 17;
			this.rbShowAllAPV.TabStop = true;
			this.rbShowAllAPV.Text = "Create map, data and chart";
			this.toolTip1.SetToolTip(this.rbShowAllAPV, "Double-click the selected study");
			this.rbShowAllAPV.UseVisualStyleBackColor = true;
			// 
			// olvColumn62
			// 
			this.olvColumn62.AspectName = "Key.ID";
			this.olvColumn62.DisplayIndex = 1;
			this.olvColumn62.IsEditable = false;
			this.olvColumn62.IsVisible = false;
			this.olvColumn62.Text = "MethodID";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
			this.splitContainer1.Panel1.Controls.Add(this.trvSetting);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new System.Drawing.Size(939, 692);
			this.splitContainer1.SplitterDistance = 270;
			this.splitContainer1.TabIndex = 0;
			// 
			// trvSetting
			// 
			this.trvSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.trvSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvSetting.HideSelection = false;
			this.trvSetting.ImageKey = "yibu.gif";
			this.trvSetting.ImageList = this.SmallImageList;
			this.trvSetting.Indent = 18;
			this.trvSetting.ItemHeight = 20;
			this.trvSetting.Location = new System.Drawing.Point(0, 15);
			this.trvSetting.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
			this.trvSetting.Name = "trvSetting";
			this.trvSetting.SelectedImageIndex = 1;
			this.trvSetting.ShowNodeToolTips = true;
			this.trvSetting.Size = new System.Drawing.Size(290, 668);
			this.trvSetting.TabIndex = 0;
			this.trvSetting.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.trvSetting_DrawNode);
			this.trvSetting.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvSetting_NodeMouseDoubleClick);
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.tabCtlReport);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer3.Panel2.Controls.Add(this.tabCtlMain);
			this.splitContainer3.Size = new System.Drawing.Size(665, 692);
			this.splitContainer3.SplitterDistance = 199;
			this.splitContainer3.SplitterWidth = 1;
			this.splitContainer3.TabIndex = 7;
			// 
			// tabCtlReport
			// 
			this.tabCtlReport.Controls.Add(this.tabCRFunctionResultGISShow);
			this.tabCtlReport.Controls.Add(this.tabPoolingIncidence);
			this.tabCtlReport.Controls.Add(this.tabAPVResultGISShow);
			this.tabCtlReport.Controls.Add(this.tabAuditTrialReport);
			this.tabCtlReport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCtlReport.ImageList = this.SmallImageList;
			this.tabCtlReport.Location = new System.Drawing.Point(0, 0);
			this.tabCtlReport.Margin = new System.Windows.Forms.Padding(0);
			this.tabCtlReport.Name = "tabCtlReport";
			this.tabCtlReport.SelectedIndex = 0;
			this.tabCtlReport.ShowToolTips = true;
			this.tabCtlReport.Size = new System.Drawing.Size(665, 199);
			this.tabCtlReport.TabIndex = 0;
			this.tabCtlReport.SelectedIndexChanged += new System.EventHandler(this.tabCtlReport_SelectedIndexChanged);
			// 
			// tabPoolingIncidence
			// 
			this.tabPoolingIncidence.Controls.Add(this.splitContainer5);
			this.tabPoolingIncidence.ImageIndex = 24;
			this.tabPoolingIncidence.Location = new System.Drawing.Point(4, 23);
			this.tabPoolingIncidence.Name = "tabPoolingIncidence";
			this.tabPoolingIncidence.Size = new System.Drawing.Size(657, 172);
			this.tabPoolingIncidence.TabIndex = 9;
			this.tabPoolingIncidence.Tag = "incidence";
			this.tabPoolingIncidence.Text = "Pooled Incidence Results";
			this.tabPoolingIncidence.ToolTipText = "Double-click HIF or APV results below to display map/data/chart";
			this.tabPoolingIncidence.UseVisualStyleBackColor = true;
			this.tabPoolingIncidence.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainMap_DragEnter);
			this.tabPoolingIncidence.DragLeave += new System.EventHandler(this.mainMap_DragLeave);
			// 
			// splitContainer5
			// 
			this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer5.Location = new System.Drawing.Point(0, 0);
			this.splitContainer5.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.Controls.Add(this.olvIncidence);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.AutoScroll = true;
			this.splitContainer5.Panel2.Controls.Add(this.panel2);
			this.splitContainer5.Panel2.Controls.Add(this.rbIncidenceAll);
			this.splitContainer5.Panel2.Controls.Add(this.rbIncidenceOnlyOne);
			this.splitContainer5.Panel2.Controls.Add(this.cbIncidenceAggregation);
			this.splitContainer5.Panel2.Controls.Add(this.label16);
			this.splitContainer5.Panel2.Controls.Add(this.btPoolingShowResult);
			this.splitContainer5.Panel2.Controls.Add(this.btPoolingSelectAttribute);
			this.splitContainer5.Panel2.Controls.Add(this.lblIncidence);
			this.splitContainer5.Panel2.Controls.Add(this.cbPoolingWindowIncidence);
			this.splitContainer5.Panel2.Controls.Add(this.btShowDetailIncidence);
			this.splitContainer5.Size = new System.Drawing.Size(657, 172);
			this.splitContainer5.SplitterDistance = 102;
			this.splitContainer5.SplitterWidth = 1;
			this.splitContainer5.TabIndex = 21;
			// 
			// olvIncidence
			// 
			this.olvIncidence.Alignment = System.Windows.Forms.ListViewAlignment.Left;
			this.olvIncidence.AllColumns.Add(this.olvColumn104);
			this.olvIncidence.AllColumns.Add(this.olvColumn105);
			this.olvIncidence.AllColumns.Add(this.olvColumn67);
			this.olvIncidence.AllColumns.Add(this.olvColumn106);
			this.olvIncidence.AllColumns.Add(this.olvColumn71);
			this.olvIncidence.AllColumns.Add(this.olvColumn72);
			this.olvIncidence.AllColumns.Add(this.olvColumn73);
			this.olvIncidence.AllColumns.Add(this.olvColumn74);
			this.olvIncidence.AllColumns.Add(this.olvColumn66);
			this.olvIncidence.AllColumns.Add(this.olvColumn75);
			this.olvIncidence.AllColumns.Add(this.olvColumn76);
			this.olvIncidence.AllColumns.Add(this.olvColumn77);
			this.olvIncidence.AllColumns.Add(this.olvColumn78);
			this.olvIncidence.AllColumns.Add(this.olvColumn79);
			this.olvIncidence.AllColumns.Add(this.olvColumn80);
			this.olvIncidence.AllColumns.Add(this.olvColumn85);
			this.olvIncidence.AllColumns.Add(this.olvColumn64);
			this.olvIncidence.AllColumns.Add(this.olvColumn86);
			this.olvIncidence.AllColumns.Add(this.olvColumn107);
			this.olvIncidence.AllColumns.Add(this.olvColumn108);
			this.olvIncidence.AllColumns.Add(this.olvColumn68);
			this.olvIncidence.AllowColumnReorder = true;
			this.olvIncidence.AllowDrop = true;
			this.olvIncidence.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
			this.olvIncidence.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.olvIncidence.CellEditUseWholeCell = false;
			this.olvIncidence.CheckedAspectName = "";
			this.olvIncidence.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
						this.olvColumn104,
						this.olvColumn105,
						this.olvColumn67,
						this.olvColumn106,
						this.olvColumn71,
						this.olvColumn72,
						this.olvColumn73,
						this.olvColumn74,
						this.olvColumn66,
						this.olvColumn75,
						this.olvColumn76,
						this.olvColumn77,
						this.olvColumn78,
						this.olvColumn79,
						this.olvColumn80,
						this.olvColumn85,
						this.olvColumn64,
						this.olvColumn86,
						this.olvColumn107,
						this.olvColumn108,
						this.olvColumn68});
			this.olvIncidence.CopySelectionOnControlC = false;
			this.olvIncidence.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvIncidence.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvIncidence.EmptyListMsg = "Pooled incidence results will be created here";
			this.olvIncidence.EmptyListMsgFont = new System.Drawing.Font("Calibri", 14.25F);
			this.olvIncidence.FullRowSelect = true;
			this.olvIncidence.HideSelection = false;
			this.olvIncidence.IsSimpleDragSource = true;
			this.olvIncidence.Location = new System.Drawing.Point(0, 0);
			this.olvIncidence.Margin = new System.Windows.Forms.Padding(0);
			this.olvIncidence.Name = "olvIncidence";
			this.olvIncidence.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
			this.olvIncidence.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.olvIncidence.OverlayText.BorderWidth = 2F;
			this.olvIncidence.OverlayText.Rotation = -20;
			this.olvIncidence.OverlayText.Text = "";
			this.olvIncidence.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvIncidence.ShowCommandMenuOnRightClick = true;
			this.olvIncidence.ShowGroups = false;
			this.olvIncidence.ShowImagesOnSubItems = true;
			this.olvIncidence.ShowItemCountOnGroups = true;
			this.olvIncidence.ShowItemToolTips = true;
			this.olvIncidence.Size = new System.Drawing.Size(657, 102);
			this.olvIncidence.SpaceBetweenGroups = 20;
			this.olvIncidence.TabIndex = 2;
			this.olvIncidence.Tag = "";
			this.olvIncidence.UseAlternatingBackColors = true;
			this.olvIncidence.UseCompatibleStateImageBehavior = false;
			this.olvIncidence.UseFiltering = true;
			this.olvIncidence.UseHotItem = true;
			this.olvIncidence.UseHyperlinks = true;
			this.olvIncidence.View = System.Windows.Forms.View.Details;
			this.olvIncidence.DragLeave += new System.EventHandler(this.tlvIncidence_DragLeave);
			this.olvIncidence.DoubleClick += new System.EventHandler(this.tlvIncidence_DoubleClick);
			this.olvIncidence.Validated += new System.EventHandler(this.olvIncidence_Validated);
			// 
			// olvColumn104
			// 
			this.olvColumn104.AspectName = "Value";
			this.olvColumn104.IsEditable = false;
			this.olvColumn104.Text = "Pooling Window Name";
			this.olvColumn104.Width = 139;
			// 
			// olvColumn105
			// 
			this.olvColumn105.AspectName = "Key.Name";
			this.olvColumn105.IsEditable = false;
			this.olvColumn105.Text = "Name";
			// 
			// olvColumn67
			// 
			this.olvColumn67.AspectName = "Key.Nickname";
			this.olvColumn67.IsEditable = false;
			this.olvColumn67.Text = "Nickname";
			// 
			// olvColumn106
			// 
			this.olvColumn106.AspectName = "Key.PoolingMethod";
			this.olvColumn106.IsEditable = false;
			this.olvColumn106.Text = "Pooling Method";
			this.olvColumn106.Width = 100;
			// 
			// olvColumn71
			// 
			this.olvColumn71.AspectName = "Key.EndPointGroup";
			this.olvColumn71.IsEditable = false;
			this.olvColumn71.IsTileViewColumn = true;
			this.olvColumn71.MinimumWidth = 100;
			this.olvColumn71.Text = "Endpoint Group";
			this.olvColumn71.ToolTipText = "";
			this.olvColumn71.Width = 140;
			// 
			// olvColumn72
			// 
			this.olvColumn72.AspectName = "Key.EndPoint";
			this.olvColumn72.IsEditable = false;
			this.olvColumn72.IsTileViewColumn = true;
			this.olvColumn72.MinimumWidth = 50;
			this.olvColumn72.Text = "Endpoint";
			this.olvColumn72.Width = 112;
			// 
			// olvColumn73
			// 
			this.olvColumn73.AspectName = "Key.Pollutant";
			this.olvColumn73.IsEditable = false;
			this.olvColumn73.Text = "Pollutant";
			this.olvColumn73.Width = 110;
			// 
			// olvColumn74
			// 
			this.olvColumn74.AspectName = "Key.Author";
			this.olvColumn74.IsEditable = false;
			this.olvColumn74.IsTileViewColumn = true;
			this.olvColumn74.Text = "Author";
			// 
			// olvColumn66
			// 
			this.olvColumn66.AspectName = "Key.AgeRange";
			this.olvColumn66.IsEditable = false;
			this.olvColumn66.Text = "Age Range";
			// 
			// olvColumn75
			// 
			this.olvColumn75.AspectName = "Key.StartAge";
			this.olvColumn75.IsEditable = false;
			this.olvColumn75.IsTileViewColumn = true;
			this.olvColumn75.Text = "Start Age";
			this.olvColumn75.Width = 70;
			// 
			// olvColumn76
			// 
			this.olvColumn76.AspectName = "Key.EndAge";
			this.olvColumn76.IsEditable = false;
			this.olvColumn76.IsTileViewColumn = true;
			this.olvColumn76.Text = "End Age";
			this.olvColumn76.Width = 70;
			// 
			// olvColumn77
			// 
			this.olvColumn77.AspectName = "Key.DataSet";
			this.olvColumn77.IsEditable = false;
			this.olvColumn77.Text = "Dataset";
			this.olvColumn77.Width = 85;
			// 
			// olvColumn78
			// 
			this.olvColumn78.AspectName = "Key.Race";
			this.olvColumn78.IsEditable = false;
			this.olvColumn78.Text = "Race";
			// 
			// olvColumn79
			// 
			this.olvColumn79.AspectName = "Key.Ethnicity";
			this.olvColumn79.IsEditable = false;
			this.olvColumn79.Text = "Ethnicity";
			this.olvColumn79.Width = 78;
			// 
			// olvColumn80
			// 
			this.olvColumn80.AspectName = "Key.Gender";
			this.olvColumn80.IsEditable = false;
			this.olvColumn80.Text = "Gender";
			// 
			// olvColumn85
			// 
			this.olvColumn85.AspectName = "Key.Location";
			this.olvColumn85.IsEditable = false;
			this.olvColumn85.Text = "Study Location";
			this.olvColumn85.Width = 80;
			// 
			// olvColumn64
			// 
			this.olvColumn64.AspectName = "Key.GeographicArea";
			this.olvColumn64.IsEditable = false;
			this.olvColumn64.Text = "Geographic Area";
			this.olvColumn64.Width = 80;
			// 
			// olvColumn86
			// 
			this.olvColumn86.AspectName = "Key.Qualifier";
			this.olvColumn86.IsEditable = false;
			this.olvColumn86.Text = "Qualifier";
			this.olvColumn86.Width = 80;
			// 
			// olvColumn107
			// 
			this.olvColumn107.AspectName = "Key.Function";
			this.olvColumn107.IsEditable = false;
			this.olvColumn107.Text = "Function";
			// 
			// olvColumn108
			// 
			this.olvColumn108.AspectName = "Key.Version";
			this.olvColumn108.IsEditable = false;
			this.olvColumn108.Text = "Version";
			// 
			// olvColumn68
			// 
			this.olvColumn68.AspectName = "Key.CountStudies";
			this.olvColumn68.IsEditable = false;
			this.olvColumn68.Text = "Count of Studies";
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.rbShowAllIncidence);
			this.panel2.Controls.Add(this.rbShowActiveIncidence);
			this.panel2.Location = new System.Drawing.Point(1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(247, 69);
			this.panel2.TabIndex = 30;
			// 
			// rbShowActiveIncidence
			// 
			this.rbShowActiveIncidence.AutoSize = true;
			this.rbShowActiveIncidence.Location = new System.Drawing.Point(3, 27);
			this.rbShowActiveIncidence.Margin = new System.Windows.Forms.Padding(0);
			this.rbShowActiveIncidence.Name = "rbShowActiveIncidence";
			this.rbShowActiveIncidence.Size = new System.Drawing.Size(239, 18);
			this.rbShowActiveIncidence.TabIndex = 16;
			this.rbShowActiveIncidence.Text = "Create data (table) for multiple studies";
			this.rbShowActiveIncidence.UseVisualStyleBackColor = true;
			// 
			// rbIncidenceAll
			// 
			this.rbIncidenceAll.AutoSize = true;
			this.rbIncidenceAll.Checked = true;
			this.rbIncidenceAll.Location = new System.Drawing.Point(261, 3);
			this.rbIncidenceAll.Name = "rbIncidenceAll";
			this.rbIncidenceAll.Size = new System.Drawing.Size(138, 18);
			this.rbIncidenceAll.TabIndex = 29;
			this.rbIncidenceAll.TabStop = true;
			this.rbIncidenceAll.Text = "All Pooling Windows";
			this.rbIncidenceAll.UseVisualStyleBackColor = true;
			// 
			// rbIncidenceOnlyOne
			// 
			this.rbIncidenceOnlyOne.AutoSize = true;
			this.rbIncidenceOnlyOne.Location = new System.Drawing.Point(260, 27);
			this.rbIncidenceOnlyOne.Name = "rbIncidenceOnlyOne";
			this.rbIncidenceOnlyOne.Size = new System.Drawing.Size(74, 18);
			this.rbIncidenceOnlyOne.TabIndex = 28;
			this.rbIncidenceOnlyOne.Text = "One Only";
			this.rbIncidenceOnlyOne.UseVisualStyleBackColor = true;
			this.rbIncidenceOnlyOne.CheckedChanged += new System.EventHandler(this.rbIncidenceOnlyOne_CheckedChanged);
			// 
			// cbIncidenceAggregation
			// 
			this.cbIncidenceAggregation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIncidenceAggregation.FormattingEnabled = true;
			this.cbIncidenceAggregation.Location = new System.Drawing.Point(545, 43);
			this.cbIncidenceAggregation.Name = "cbIncidenceAggregation";
			this.cbIncidenceAggregation.Size = new System.Drawing.Size(150, 22);
			this.cbIncidenceAggregation.TabIndex = 27;
			this.cbIncidenceAggregation.Visible = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(449, 54);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(74, 14);
			this.label16.TabIndex = 26;
			this.label16.Text = "Aggregation:";
			this.label16.Visible = false;
			// 
			// btPoolingShowResult
			// 
			this.btPoolingShowResult.Location = new System.Drawing.Point(416, 2);
			this.btPoolingShowResult.Name = "btPoolingShowResult";
			this.btPoolingShowResult.Size = new System.Drawing.Size(120, 23);
			this.btPoolingShowResult.TabIndex = 25;
			this.btPoolingShowResult.Text = "Show results";
			this.btPoolingShowResult.UseVisualStyleBackColor = true;
			this.btPoolingShowResult.Click += new System.EventHandler(this.btPoolingShowResult_Click);
			// 
			// btPoolingSelectAttribute
			// 
			this.btPoolingSelectAttribute.Location = new System.Drawing.Point(570, 2);
			this.btPoolingSelectAttribute.Name = "btPoolingSelectAttribute";
			this.btPoolingSelectAttribute.Size = new System.Drawing.Size(125, 23);
			this.btPoolingSelectAttribute.TabIndex = 24;
			this.btPoolingSelectAttribute.Text = "Column headers";
			this.btPoolingSelectAttribute.UseVisualStyleBackColor = true;
			this.btPoolingSelectAttribute.Click += new System.EventHandler(this.btPoolingSelectAttribute_Click);
			// 
			// lblIncidence
			// 
			this.lblIncidence.AutoSize = true;
			this.lblIncidence.Enabled = false;
			this.lblIncidence.Location = new System.Drawing.Point(414, 30);
			this.lblIncidence.Name = "lblIncidence";
			this.lblIncidence.Size = new System.Drawing.Size(97, 14);
			this.lblIncidence.TabIndex = 22;
			this.lblIncidence.Text = "Pooling window:";
			// 
			// cbPoolingWindowIncidence
			// 
			this.cbPoolingWindowIncidence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPoolingWindowIncidence.Enabled = false;
			this.cbPoolingWindowIncidence.FormattingEnabled = true;
			this.cbPoolingWindowIncidence.Location = new System.Drawing.Point(515, 27);
			this.cbPoolingWindowIncidence.Margin = new System.Windows.Forms.Padding(0);
			this.cbPoolingWindowIncidence.Name = "cbPoolingWindowIncidence";
			this.cbPoolingWindowIncidence.Size = new System.Drawing.Size(180, 22);
			this.cbPoolingWindowIncidence.TabIndex = 20;
			this.cbPoolingWindowIncidence.SelectedIndexChanged += new System.EventHandler(this.cbPoolingWindowIncidence_SelectedIndexChanged);
			// 
			// btShowDetailIncidence
			// 
			this.btShowDetailIncidence.Location = new System.Drawing.Point(291, 27);
			this.btShowDetailIncidence.Name = "btShowDetailIncidence";
			this.btShowDetailIncidence.Size = new System.Drawing.Size(108, 23);
			this.btShowDetailIncidence.TabIndex = 31;
			this.btShowDetailIncidence.Text = "Show aggregated";
			this.btShowDetailIncidence.UseVisualStyleBackColor = true;
			this.btShowDetailIncidence.Visible = false;
			this.btShowDetailIncidence.Click += new System.EventHandler(this.btShowDetailIncidence_Click);
			// 
			// tabAPVResultGISShow
			// 
			this.tabAPVResultGISShow.Controls.Add(this.spAPVResult);
			this.tabAPVResultGISShow.Controls.Add(this.lbIncidencePoolingMethod);
			this.tabAPVResultGISShow.ImageIndex = 13;
			this.tabAPVResultGISShow.Location = new System.Drawing.Point(4, 23);
			this.tabAPVResultGISShow.Name = "tabAPVResultGISShow";
			this.tabAPVResultGISShow.Size = new System.Drawing.Size(657, 172);
			this.tabAPVResultGISShow.TabIndex = 6;
			this.tabAPVResultGISShow.Tag = "apvx";
			this.tabAPVResultGISShow.Text = "Pooled Valuation Results";
			this.tabAPVResultGISShow.ToolTipText = "Double-click HIF or APV results below to display map/data/chart";
			this.tabAPVResultGISShow.UseVisualStyleBackColor = true;
			// 
			// spAPVResult
			// 
			this.spAPVResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spAPVResult.Location = new System.Drawing.Point(0, 0);
			this.spAPVResult.Margin = new System.Windows.Forms.Padding(0);
			this.spAPVResult.Name = "spAPVResult";
			this.spAPVResult.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spAPVResult.Panel1
			// 
			this.spAPVResult.Panel1.Controls.Add(this.tlvAPVResult);
			// 
			// spAPVResult.Panel2
			// 
			this.spAPVResult.Panel2.AutoScroll = true;
			this.spAPVResult.Panel2.Controls.Add(this.btShowDetailValuation);
			this.spAPVResult.Panel2.Controls.Add(this.panel1);
			this.spAPVResult.Panel2.Controls.Add(this.rbAPVAll);
			this.spAPVResult.Panel2.Controls.Add(this.rbAPVOnlyOne);
			this.spAPVResult.Panel2.Controls.Add(this.btnShowAPVResult);
			this.spAPVResult.Panel2.Controls.Add(this.btAPVSelectAttribute);
			this.spAPVResult.Panel2.Controls.Add(this.cbAPVAggregation);
			this.spAPVResult.Panel2.Controls.Add(this.label1);
			this.spAPVResult.Panel2.Controls.Add(this.lblAPV);
			this.spAPVResult.Panel2.Controls.Add(this.chbAPVAggregation);
			this.spAPVResult.Panel2.Controls.Add(this.btShowIncidencePooling);
			this.spAPVResult.Panel2.Controls.Add(this.cbPoolingWindowAPV);
			this.spAPVResult.Size = new System.Drawing.Size(657, 172);
			this.spAPVResult.SplitterDistance = 98;
			this.spAPVResult.SplitterWidth = 1;
			this.spAPVResult.TabIndex = 20;
			// 
			// tlvAPVResult
			// 
			this.tlvAPVResult.AllColumns.Add(this.olvColumn63);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn81);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn82);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn62);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn1);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn92);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn93);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn94);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn3);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn83);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn4);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn5);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn6);
			this.tlvAPVResult.AllColumns.Add(this.olvColumn65);
			this.tlvAPVResult.AllowColumnReorder = true;
			this.tlvAPVResult.AllowDrop = true;
			this.tlvAPVResult.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
			this.tlvAPVResult.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.tlvAPVResult.CellEditUseWholeCell = false;
			this.tlvAPVResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
						this.olvColumn63,
						this.olvColumn81,
						this.olvColumn82,
						this.olvColumn1,
						this.olvColumn92,
						this.olvColumn93,
						this.olvColumn94,
						this.olvColumn3,
						this.olvColumn83,
						this.olvColumn4,
						this.olvColumn5,
						this.olvColumn6,
						this.olvColumn65});
			this.tlvAPVResult.Cursor = System.Windows.Forms.Cursors.Default;
			this.tlvAPVResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlvAPVResult.EmptyListMsg = "Pooled valuation results will be created here";
			this.tlvAPVResult.EmptyListMsgFont = new System.Drawing.Font("Calibri", 14.25F);
			this.tlvAPVResult.FullRowSelect = true;
			this.tlvAPVResult.HideSelection = false;
			this.tlvAPVResult.IsSimpleDragSource = true;
			this.tlvAPVResult.IsSimpleDropSink = true;
			this.tlvAPVResult.Location = new System.Drawing.Point(0, 0);
			this.tlvAPVResult.Margin = new System.Windows.Forms.Padding(0);
			this.tlvAPVResult.Name = "tlvAPVResult";
			this.tlvAPVResult.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.tlvAPVResult.ShowCommandMenuOnRightClick = true;
			this.tlvAPVResult.ShowGroups = false;
			this.tlvAPVResult.ShowImagesOnSubItems = true;
			this.tlvAPVResult.ShowItemToolTips = true;
			this.tlvAPVResult.Size = new System.Drawing.Size(657, 98);
			this.tlvAPVResult.TabIndex = 15;
			this.tlvAPVResult.UseAlternatingBackColors = true;
			this.tlvAPVResult.UseCompatibleStateImageBehavior = false;
			this.tlvAPVResult.UseFiltering = true;
			this.tlvAPVResult.UseHotItem = true;
			this.tlvAPVResult.View = System.Windows.Forms.View.Details;
			this.tlvAPVResult.DragLeave += new System.EventHandler(this.tlvAPVResult_DragLeave);
			this.tlvAPVResult.DoubleClick += new System.EventHandler(this.tlvAPVResult_DoubleClick);
			this.tlvAPVResult.Validated += new System.EventHandler(this.tlvAPVResult_Validated);
			// 
			// olvColumn63
			// 
			this.olvColumn63.AspectName = "Value";
			this.olvColumn63.Text = "Pooling Window Name";
			this.olvColumn63.Width = 137;
			// 
			// olvColumn81
			// 
			this.olvColumn81.AspectName = "Key.Name";
			this.olvColumn81.IsEditable = false;
			this.olvColumn81.Text = "Name";
			// 
			// olvColumn82
			// 
			this.olvColumn82.AspectName = "Key.Nickname";
			this.olvColumn82.IsEditable = false;
			this.olvColumn82.Text = "Nickname";
			// 
			// olvColumn1
			// 
			this.olvColumn1.AspectName = "Key.PoolingMethod";
			this.olvColumn1.IsEditable = false;
			this.olvColumn1.Text = "Pooling Method";
			this.olvColumn1.Width = 115;
			// 
			// olvColumn92
			// 
			this.olvColumn92.AspectName = "Key.EndPointGroup";
			this.olvColumn92.IsEditable = false;
			this.olvColumn92.Text = "Endpoint Group";
			this.olvColumn92.Width = 100;
			// 
			// olvColumn93
			// 
			this.olvColumn93.AspectName = "Key.EndPoint";
			this.olvColumn93.IsEditable = false;
			this.olvColumn93.Text = "Endpoint";
			// 
			// olvColumn94
			// 
			this.olvColumn94.AspectName = "Key.Author";
			this.olvColumn94.IsEditable = false;
			this.olvColumn94.Text = "Author";
			// 
			// olvColumn3
			// 
			this.olvColumn3.AspectName = "Key.Qualifier";
			this.olvColumn3.IsEditable = false;
			this.olvColumn3.Text = "Qualifier";
			this.olvColumn3.Width = 180;
			// 
			// olvColumn83
			// 
			this.olvColumn83.AspectName = "Key.AgeRange";
			this.olvColumn83.IsEditable = false;
			this.olvColumn83.Text = "Age Range";
			// 
			// olvColumn4
			// 
			this.olvColumn4.AspectName = "Key.StartAge";
			this.olvColumn4.IsEditable = false;
			this.olvColumn4.Text = "Start Age";
			// 
			// olvColumn5
			// 
			this.olvColumn5.AspectName = "Key.EndAge";
			this.olvColumn5.IsEditable = false;
			this.olvColumn5.Text = "End Age";
			// 
			// olvColumn6
			// 
			this.olvColumn6.AspectName = "Key.Function";
			this.olvColumn6.IsEditable = false;
			this.olvColumn6.Text = "Function";
			this.olvColumn6.Width = 180;
			// 
			// olvColumn65
			// 
			this.olvColumn65.AspectName = "Key.GeographicArea";
			this.olvColumn65.IsEditable = false;
			this.olvColumn65.Text = "Geographic Area";
			// 
			// btShowDetailValuation
			// 
			this.btShowDetailValuation.Location = new System.Drawing.Point(288, 22);
			this.btShowDetailValuation.Name = "btShowDetailValuation";
			this.btShowDetailValuation.Size = new System.Drawing.Size(115, 23);
			this.btShowDetailValuation.TabIndex = 33;
			this.btShowDetailValuation.Text = "Show aggregated";
			this.btShowDetailValuation.UseVisualStyleBackColor = true;
			this.btShowDetailValuation.Visible = false;
			this.btShowDetailValuation.Click += new System.EventHandler(this.btShowDetailValuation_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbShowAllAPV);
			this.panel1.Controls.Add(this.rbShowActiveAPV);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(237, 71);
			this.panel1.TabIndex = 32;
			// 
			// rbShowActiveAPV
			// 
			this.rbShowActiveAPV.AutoSize = true;
			this.rbShowActiveAPV.Location = new System.Drawing.Point(0, 26);
			this.rbShowActiveAPV.Margin = new System.Windows.Forms.Padding(0);
			this.rbShowActiveAPV.Name = "rbShowActiveAPV";
			this.rbShowActiveAPV.Size = new System.Drawing.Size(239, 18);
			this.rbShowActiveAPV.TabIndex = 16;
			this.rbShowActiveAPV.Text = "Create data (table) for multiple studies";
			this.rbShowActiveAPV.UseVisualStyleBackColor = true;
			// 
			// rbAPVAll
			// 
			this.rbAPVAll.AutoSize = true;
			this.rbAPVAll.Checked = true;
			this.rbAPVAll.Location = new System.Drawing.Point(245, 2);
			this.rbAPVAll.Name = "rbAPVAll";
			this.rbAPVAll.Size = new System.Drawing.Size(138, 18);
			this.rbAPVAll.TabIndex = 31;
			this.rbAPVAll.TabStop = true;
			this.rbAPVAll.Text = "All Pooling Windows";
			this.rbAPVAll.UseVisualStyleBackColor = true;
			// 
			// rbAPVOnlyOne
			// 
			this.rbAPVOnlyOne.AutoSize = true;
			this.rbAPVOnlyOne.Location = new System.Drawing.Point(246, 26);
			this.rbAPVOnlyOne.Name = "rbAPVOnlyOne";
			this.rbAPVOnlyOne.Size = new System.Drawing.Size(74, 18);
			this.rbAPVOnlyOne.TabIndex = 30;
			this.rbAPVOnlyOne.Text = "One Only";
			this.rbAPVOnlyOne.UseVisualStyleBackColor = true;
			this.rbAPVOnlyOne.CheckedChanged += new System.EventHandler(this.rbAPVOnlyOne_CheckedChanged);
			// 
			// btnShowAPVResult
			// 
			this.btnShowAPVResult.Location = new System.Drawing.Point(422, 0);
			this.btnShowAPVResult.Name = "btnShowAPVResult";
			this.btnShowAPVResult.Size = new System.Drawing.Size(113, 23);
			this.btnShowAPVResult.TabIndex = 25;
			this.btnShowAPVResult.Text = "Show results";
			this.btnShowAPVResult.UseVisualStyleBackColor = true;
			this.btnShowAPVResult.Click += new System.EventHandler(this.btnShowAPVResult_Click);
			// 
			// btAPVSelectAttribute
			// 
			this.btAPVSelectAttribute.Location = new System.Drawing.Point(569, 0);
			this.btAPVSelectAttribute.Name = "btAPVSelectAttribute";
			this.btAPVSelectAttribute.Size = new System.Drawing.Size(128, 23);
			this.btAPVSelectAttribute.TabIndex = 24;
			this.btAPVSelectAttribute.Text = "Column headers";
			this.btAPVSelectAttribute.UseVisualStyleBackColor = true;
			this.btAPVSelectAttribute.Click += new System.EventHandler(this.btAPVSelectAttribute_Click);
			// 
			// cbAPVAggregation
			// 
			this.cbAPVAggregation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAPVAggregation.FormattingEnabled = true;
			this.cbAPVAggregation.Location = new System.Drawing.Point(541, 41);
			this.cbAPVAggregation.Name = "cbAPVAggregation";
			this.cbAPVAggregation.Size = new System.Drawing.Size(150, 22);
			this.cbAPVAggregation.TabIndex = 23;
			this.cbAPVAggregation.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(461, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 14);
			this.label1.TabIndex = 22;
			this.label1.Text = "Aggregation:";
			this.label1.Visible = false;
			// 
			// lblAPV
			// 
			this.lblAPV.AutoSize = true;
			this.lblAPV.Enabled = false;
			this.lblAPV.Location = new System.Drawing.Point(417, 27);
			this.lblAPV.Name = "lblAPV";
			this.lblAPV.Size = new System.Drawing.Size(97, 14);
			this.lblAPV.TabIndex = 22;
			this.lblAPV.Text = "Pooling window:";
			// 
			// chbAPVAggregation
			// 
			this.chbAPVAggregation.AutoSize = true;
			this.chbAPVAggregation.Location = new System.Drawing.Point(126, 5);
			this.chbAPVAggregation.Margin = new System.Windows.Forms.Padding(0);
			this.chbAPVAggregation.Name = "chbAPVAggregation";
			this.chbAPVAggregation.Size = new System.Drawing.Size(90, 18);
			this.chbAPVAggregation.TabIndex = 21;
			this.chbAPVAggregation.Text = "Aggregation";
			this.chbAPVAggregation.UseVisualStyleBackColor = true;
			this.chbAPVAggregation.Visible = false;
			// 
			// cbPoolingWindowAPV
			// 
			this.cbPoolingWindowAPV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPoolingWindowAPV.Enabled = false;
			this.cbPoolingWindowAPV.FormattingEnabled = true;
			this.cbPoolingWindowAPV.Location = new System.Drawing.Point(517, 25);
			this.cbPoolingWindowAPV.Margin = new System.Windows.Forms.Padding(0);
			this.cbPoolingWindowAPV.Name = "cbPoolingWindowAPV";
			this.cbPoolingWindowAPV.Size = new System.Drawing.Size(179, 22);
			this.cbPoolingWindowAPV.TabIndex = 20;
			this.cbPoolingWindowAPV.SelectedIndexChanged += new System.EventHandler(this.cbPoolingWindowAPV_SelectedIndexChanged);
			// 
			// lbIncidencePoolingMethod
			// 
			this.lbIncidencePoolingMethod.AutoSize = true;
			this.lbIncidencePoolingMethod.Location = new System.Drawing.Point(371, 130);
			this.lbIncidencePoolingMethod.Name = "lbIncidencePoolingMethod";
			this.lbIncidencePoolingMethod.Size = new System.Drawing.Size(0, 14);
			this.lbIncidencePoolingMethod.TabIndex = 19;
			// 
			// tabAuditTrialReport
			// 
			this.tabAuditTrialReport.AutoScroll = true;
			this.tabAuditTrialReport.Controls.Add(this.btShowAudit);
			this.tabAuditTrialReport.Controls.Add(this.btnBrowse);
			this.tabAuditTrialReport.Controls.Add(this.txtExistingConfiguration);
			this.tabAuditTrialReport.Controls.Add(this.rbAuditFile);
			this.tabAuditTrialReport.Controls.Add(this.rbAuditCurrent);
			this.tabAuditTrialReport.Location = new System.Drawing.Point(4, 23);
			this.tabAuditTrialReport.Name = "tabAuditTrialReport";
			this.tabAuditTrialReport.Size = new System.Drawing.Size(657, 172);
			this.tabAuditTrialReport.TabIndex = 8;
			this.tabAuditTrialReport.Tag = "audit";
			this.tabAuditTrialReport.Text = "Audit Trail Report";
			this.tabAuditTrialReport.UseVisualStyleBackColor = true;
			// 
			// btShowAudit
			// 
			this.btShowAudit.Location = new System.Drawing.Point(360, 78);
			this.btShowAudit.Name = "btShowAudit";
			this.btShowAudit.Size = new System.Drawing.Size(75, 27);
			this.btShowAudit.TabIndex = 5;
			this.btShowAudit.Text = "OK";
			this.btShowAudit.UseVisualStyleBackColor = true;
			this.btShowAudit.Click += new System.EventHandler(this.btShowAudit_Click);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Enabled = false;
			this.btnBrowse.Image = global::BenMAP.Properties.Resources.folder_add;
			this.btnBrowse.Location = new System.Drawing.Point(297, 79);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(39, 27);
			this.btnBrowse.TabIndex = 4;
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtExistingConfiguration
			// 
			this.txtExistingConfiguration.Enabled = false;
			this.txtExistingConfiguration.Location = new System.Drawing.Point(42, 82);
			this.txtExistingConfiguration.Name = "txtExistingConfiguration";
			this.txtExistingConfiguration.Size = new System.Drawing.Size(249, 22);
			this.txtExistingConfiguration.TabIndex = 3;
			// 
			// rbAuditFile
			// 
			this.rbAuditFile.AutoSize = true;
			this.rbAuditFile.Location = new System.Drawing.Point(42, 50);
			this.rbAuditFile.Name = "rbAuditFile";
			this.rbAuditFile.Size = new System.Drawing.Size(551, 18);
			this.rbAuditFile.TabIndex = 1;
			this.rbAuditFile.Text = "Audit Trail Reports (Created from *.aqgx files, *.cfgx files, *.cfgrx files, *.ap" +
"vx files and *.apvrx files)";
			this.rbAuditFile.UseVisualStyleBackColor = true;
			this.rbAuditFile.Click += new System.EventHandler(this.rbAuditFile_Click);
			// 
			// rbAuditCurrent
			// 
			this.rbAuditCurrent.AutoSize = true;
			this.rbAuditCurrent.Checked = true;
			this.rbAuditCurrent.Location = new System.Drawing.Point(42, 19);
			this.rbAuditCurrent.Name = "rbAuditCurrent";
			this.rbAuditCurrent.Size = new System.Drawing.Size(162, 18);
			this.rbAuditCurrent.TabIndex = 0;
			this.rbAuditCurrent.TabStop = true;
			this.rbAuditCurrent.Text = "Current Audit Trail Report";
			this.rbAuditCurrent.UseVisualStyleBackColor = true;
			this.rbAuditCurrent.CheckedChanged += new System.EventHandler(this.rbAuditCurrent_CheckedChanged);
			// 
			// tabCtlMain
			// 
			this.tabCtlMain.Controls.Add(this.tabGIS);
			this.tabCtlMain.Controls.Add(this.tabData);
			this.tabCtlMain.Controls.Add(this.tabChart);
			this.tabCtlMain.Controls.Add(this.tabATReport);
			this.tabCtlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCtlMain.ImageList = this.SmallImageList;
			this.tabCtlMain.Location = new System.Drawing.Point(0, 0);
			this.tabCtlMain.Name = "tabCtlMain";
			this.tabCtlMain.SelectedIndex = 0;
			this.tabCtlMain.Size = new System.Drawing.Size(665, 492);
			this.tabCtlMain.TabIndex = 0;
			// 
			// tabGIS
			// 
			this.tabGIS.BackColor = System.Drawing.Color.Silver;
			this.tabGIS.Controls.Add(this.splitContainer2);
			this.tabGIS.ImageIndex = 29;
			this.tabGIS.Location = new System.Drawing.Point(4, 23);
			this.tabGIS.Name = "tabGIS";
			this.tabGIS.Padding = new System.Windows.Forms.Padding(3);
			this.tabGIS.Size = new System.Drawing.Size(657, 465);
			this.tabGIS.TabIndex = 0;
			this.tabGIS.Tag = "GIS map to be created here";
			this.tabGIS.Text = "GIS Map";
			// 
			// splitContainer2
			// 
			this.splitContainer2.BackColor = System.Drawing.Color.White;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer2.Location = new System.Drawing.Point(3, 3);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer2.MinimumSize = new System.Drawing.Size(50, 400);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.AutoScroll = true;
			this.splitContainer2.Panel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
			this.splitContainer2.Panel1.AutoScrollMinSize = new System.Drawing.Size(10, 10);
			this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer2.Panel1.Controls.Add(this.pnlLegend);
			this.splitContainer2.Panel1.Controls.Add(this.panel3);
			this.splitContainer2.Panel1.Controls.Add(this.cboRegion);
			this.splitContainer2.Panel1MinSize = 45;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
			this.splitContainer2.Panel2.Controls.Add(this.mainMap);
			this.splitContainer2.Size = new System.Drawing.Size(651, 459);
			this.splitContainer2.SplitterDistance = 264;
			this.splitContainer2.SplitterWidth = 5;
			this.splitContainer2.TabIndex = 7;
			// 
			// pnlLegend
			// 
			this.pnlLegend.Controls.Add(this.legend1);
			this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLegend.Location = new System.Drawing.Point(45, 0);
			this.pnlLegend.Name = "pnlLegend";
			this.pnlLegend.Size = new System.Drawing.Size(219, 459);
			this.pnlLegend.TabIndex = 8;
			// 
			// legend1
			// 
			this.legend1.BackColor = System.Drawing.SystemColors.Window;
			this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, -5, 219, 459);
			this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 220, 450);
			this.legend1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.legend1.HorizontalScrollEnabled = true;
			this.legend1.Indentation = 8;
			this.legend1.IsInitialized = false;
			this.legend1.Location = new System.Drawing.Point(0, 0);
			this.legend1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.legend1.MinimumSize = new System.Drawing.Size(0, 6);
			this.legend1.Name = "legend1";
			this.legend1.ProgressHandler = null;
			this.legend1.ResetOnResize = true;
			this.legend1.SelectionFontColor = System.Drawing.Color.Black;
			this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
			this.legend1.Size = new System.Drawing.Size(219, 459);
			this.legend1.TabIndex = 0;
			this.legend1.Text = "legend1";
			this.legend1.UseLegendForSelection = true;
			this.legend1.VerticalScrollEnabled = true;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.Controls.Add(this.toolStrip1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.MinimumSize = new System.Drawing.Size(33, 456);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(45, 459);
			this.panel3.TabIndex = 7;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.btnZoomIn,
						this.btnZoomOut,
						this.btnPan,
						this.btnFullExtent,
						this.btnIdentify,
						this.tsbAttributes,
						this.btnSelect,
						this.tsbSelectByLocation,
						this.btnClearSelection,
						this.tsbPrintLayout,
						this.tsbSaveShapefile,
						this.tsbAddLayer,
						this.tsbChangeProjection});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.MaximumSize = new System.Drawing.Size(50, 500);
			this.toolStrip1.MinimumSize = new System.Drawing.Size(50, 300);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
			this.toolStrip1.Size = new System.Drawing.Size(50, 459);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 0;
			// 
			// btnZoomIn
			// 
			this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnZoomIn.Image = global::BenMAP.Properties.Resources.zoom_in;
			this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnZoomIn.Name = "btnZoomIn";
			this.btnZoomIn.Size = new System.Drawing.Size(27, 28);
			this.btnZoomIn.Text = "toolStripButton1";
			this.btnZoomIn.ToolTipText = "Zoom In";
			this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
			// 
			// btnZoomOut
			// 
			this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnZoomOut.Image = global::BenMAP.Properties.Resources.zoom_out;
			this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnZoomOut.Name = "btnZoomOut";
			this.btnZoomOut.Size = new System.Drawing.Size(27, 28);
			this.btnZoomOut.Text = "toolStripButton2";
			this.btnZoomOut.ToolTipText = "Zoom Out";
			this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
			// 
			// btnPan
			// 
			this.btnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPan.Image = global::BenMAP.Properties.Resources.pan;
			this.btnPan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPan.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
			this.btnPan.Name = "btnPan";
			this.btnPan.Size = new System.Drawing.Size(27, 28);
			this.btnPan.Text = "toolStripButton3";
			this.btnPan.ToolTipText = "Pan";
			this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
			// 
			// btnFullExtent
			// 
			this.btnFullExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFullExtent.Image = global::BenMAP.Properties.Resources.zoom_extent;
			this.btnFullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFullExtent.Name = "btnFullExtent";
			this.btnFullExtent.Size = new System.Drawing.Size(27, 28);
			this.btnFullExtent.Text = "toolStripButton4";
			this.btnFullExtent.ToolTipText = "Zoom to Full Extent";
			this.btnFullExtent.Click += new System.EventHandler(this.btnFullExtent_Click);
			// 
			// btnIdentify
			// 
			this.btnIdentify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnIdentify.Image = global::BenMAP.Properties.Resources.info;
			this.btnIdentify.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnIdentify.Name = "btnIdentify";
			this.btnIdentify.Size = new System.Drawing.Size(27, 28);
			this.btnIdentify.Text = "Identify";
			this.btnIdentify.ToolTipText = "Identify Features";
			this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
			// 
			// tsbAttributes
			// 
			this.tsbAttributes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAttributes.Image = global::BenMAP.Properties.Resources.attributes_display;
			this.tsbAttributes.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAttributes.Name = "tsbAttributes";
			this.tsbAttributes.Size = new System.Drawing.Size(27, 28);
			this.tsbAttributes.Text = "Attribute Table";
			this.tsbAttributes.Click += new System.EventHandler(this.btnShowHideAttributeTable_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSelect.Image = global::BenMAP.Properties.Resources.select;
			this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(27, 28);
			this.btnSelect.Text = "toolStripButton6";
			this.btnSelect.ToolTipText = "Select Features";
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// tsbSelectByLocation
			// 
			this.tsbSelectByLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSelectByLocation.Image = global::BenMAP.Properties.Resources.select_by_location;
			this.tsbSelectByLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSelectByLocation.Name = "tsbSelectByLocation";
			this.tsbSelectByLocation.Size = new System.Drawing.Size(27, 28);
			this.tsbSelectByLocation.Text = "Select By Location";
			this.tsbSelectByLocation.Click += new System.EventHandler(this.tsbSelectByLocation_Click);
			// 
			// btnClearSelection
			// 
			this.btnClearSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnClearSelection.Image = global::BenMAP.Properties.Resources.clear_selection;
			this.btnClearSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClearSelection.Name = "btnClearSelection";
			this.btnClearSelection.Size = new System.Drawing.Size(27, 28);
			this.btnClearSelection.ToolTipText = "Clear Selection";
			this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
			// 
			// tsbPrintLayout
			// 
			this.tsbPrintLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPrintLayout.Image = global::BenMAP.Properties.Resources.printer_32x32;
			this.tsbPrintLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPrintLayout.Name = "tsbPrintLayout";
			this.tsbPrintLayout.Size = new System.Drawing.Size(27, 28);
			this.tsbPrintLayout.Tag = "";
			this.tsbPrintLayout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tsbPrintLayout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tsbPrintLayout.ToolTipText = "Prepare Print Layout";
			this.tsbPrintLayout.Click += new System.EventHandler(this.tsbPrintLayout_Click);
			// 
			// tsbSaveShapefile
			// 
			this.tsbSaveShapefile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSaveShapefile.Image = global::BenMAP.Properties.Resources.save1;
			this.tsbSaveShapefile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSaveShapefile.Name = "tsbSaveShapefile";
			this.tsbSaveShapefile.Size = new System.Drawing.Size(27, 28);
			this.tsbSaveShapefile.Tag = "";
			this.tsbSaveShapefile.Text = "Save shapefile";
			this.tsbSaveShapefile.ToolTipText = "Save Shapefile";
			this.tsbSaveShapefile.Click += new System.EventHandler(this.tsbSaveShapefile_Click);
			// 
			// tsbAddLayer
			// 
			this.tsbAddLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAddLayer.Image = global::BenMAP.Properties.Resources.layer_add;
			this.tsbAddLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAddLayer.Name = "tsbAddLayer";
			this.tsbAddLayer.Size = new System.Drawing.Size(27, 28);
			this.tsbAddLayer.Text = "Add Layer";
			this.tsbAddLayer.Click += new System.EventHandler(this.tsbAddLayer_Click);
			// 
			// tsbChangeProjection
			// 
			this.tsbChangeProjection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbChangeProjection.Image = global::BenMAP.Properties.Resources.refreshTheme;
			this.tsbChangeProjection.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbChangeProjection.Name = "tsbChangeProjection";
			this.tsbChangeProjection.Size = new System.Drawing.Size(27, 28);
			this.tsbChangeProjection.Text = "change projection to setup projection";
			this.tsbChangeProjection.ToolTipText = "Change Projection to Setup Projection";
			this.tsbChangeProjection.Click += new System.EventHandler(this.tsbChangeProjection_Click);
			// 
			// cboRegion
			// 
			this.cboRegion.FormattingEnabled = true;
			this.cboRegion.Location = new System.Drawing.Point(59, 23);
			this.cboRegion.Name = "cboRegion";
			this.cboRegion.Size = new System.Drawing.Size(121, 22);
			this.cboRegion.TabIndex = 0;
			this.cboRegion.Visible = false;
			this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
			// 
			// mainMap
			// 
			this.mainMap.AllowDrop = true;
			this.mainMap.BackColor = System.Drawing.Color.White;
			this.mainMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mainMap.CollisionDetection = false;
			this.mainMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainMap.ExtendBuffer = false;
			this.mainMap.FunctionMode = DotSpatial.Controls.FunctionMode.None;
			this.mainMap.IsBusy = false;
			this.mainMap.IsZoomedToMaxExtent = false;
			this.mainMap.Legend = this.legend1;
			this.mainMap.Location = new System.Drawing.Point(0, 0);
			this.mainMap.Margin = new System.Windows.Forms.Padding(0);
			this.mainMap.Name = "mainMap";
			this.mainMap.ProgressHandler = null;
			this.mainMap.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
			this.mainMap.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
			this.mainMap.RedrawLayersWhileResizing = false;
			this.mainMap.SelectionEnabled = true;
			this.mainMap.Size = new System.Drawing.Size(382, 459);
			this.mainMap.TabIndex = 0;
			this.mainMap.Tag = "GIS map will be created here.";
			this.mainMap.ZoomOutFartherThanMaxExtent = false;
			this.mainMap.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainMap_DragEnter);
			this.mainMap.DragLeave += new System.EventHandler(this.mainMap_DragLeave);
			// 
			// tabData
			// 
			this.tabData.Controls.Add(this.spTable);
			this.tabData.ImageIndex = 28;
			this.tabData.Location = new System.Drawing.Point(4, 23);
			this.tabData.Name = "tabData";
			this.tabData.Size = new System.Drawing.Size(657, 465);
			this.tabData.TabIndex = 1;
			this.tabData.Text = "Data";
			this.tabData.UseVisualStyleBackColor = true;
			// 
			// spTable
			// 
			this.spTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spTable.Location = new System.Drawing.Point(0, 0);
			this.spTable.Margin = new System.Windows.Forms.Padding(0);
			this.spTable.Name = "spTable";
			this.spTable.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spTable.Panel1
			// 
			this.spTable.Panel1.Controls.Add(this.OLVResultsShow);
			// 
			// spTable.Panel2
			// 
			this.spTable.Panel2.Controls.Add(this.chbAllPercentiles);
			this.spTable.Panel2.Controls.Add(this.label17);
			this.spTable.Panel2.Controls.Add(this.numericUpDownResult);
			this.spTable.Panel2.Controls.Add(this.btnResultShow);
			this.spTable.Panel2.Controls.Add(this.btnTableOutput);
			this.spTable.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.spTable_Panel2_Paint);
			this.spTable.Size = new System.Drawing.Size(657, 465);
			this.spTable.SplitterDistance = 419;
			this.spTable.SplitterWidth = 1;
			this.spTable.TabIndex = 0;
			// 
			// OLVResultsShow
			// 
			this.OLVResultsShow.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.OLVResultsShow.AllowColumnReorder = true;
			this.OLVResultsShow.AllowDrop = true;
			this.OLVResultsShow.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
			this.OLVResultsShow.BackColor = System.Drawing.Color.White;
			this.OLVResultsShow.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.OLVResultsShow.CellEditUseWholeCell = false;
			this.OLVResultsShow.CheckedAspectName = "";
			this.OLVResultsShow.CopySelectionOnControlC = false;
			this.OLVResultsShow.Cursor = System.Windows.Forms.Cursors.Default;
			this.OLVResultsShow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OLVResultsShow.EmptyListMsg = "Shift click several studies and then click \"Show Results\"  ";
			this.OLVResultsShow.EmptyListMsgFont = new System.Drawing.Font("Calibri", 14.25F);
			this.OLVResultsShow.FullRowSelect = true;
			this.OLVResultsShow.HideSelection = false;
			this.OLVResultsShow.Location = new System.Drawing.Point(0, 0);
			this.OLVResultsShow.MultiSelect = false;
			this.OLVResultsShow.Name = "OLVResultsShow";
			this.OLVResultsShow.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
			this.OLVResultsShow.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.OLVResultsShow.OverlayText.BorderWidth = 2F;
			this.OLVResultsShow.OverlayText.Rotation = -20;
			this.OLVResultsShow.OverlayText.Text = "";
			this.OLVResultsShow.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.OLVResultsShow.ShowCommandMenuOnRightClick = true;
			this.OLVResultsShow.ShowGroups = false;
			this.OLVResultsShow.ShowImagesOnSubItems = true;
			this.OLVResultsShow.ShowItemCountOnGroups = true;
			this.OLVResultsShow.ShowItemToolTips = true;
			this.OLVResultsShow.Size = new System.Drawing.Size(657, 419);
			this.OLVResultsShow.SpaceBetweenGroups = 20;
			this.OLVResultsShow.TabIndex = 5;
			this.OLVResultsShow.UseAlternatingBackColors = true;
			this.OLVResultsShow.UseCompatibleStateImageBehavior = false;
			this.OLVResultsShow.UseFiltering = true;
			this.OLVResultsShow.UseHotItem = true;
			this.OLVResultsShow.UseHyperlinks = true;
			this.OLVResultsShow.View = System.Windows.Forms.View.Details;
			this.OLVResultsShow.BeforeSorting += new System.EventHandler<BrightIdeasSoftware.BeforeSortingEventArgs>(this.OLVResultsShow_BeforeSorting);
			this.OLVResultsShow.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OLVResultsShow_ColumnClick);
			// 
			// chbAllPercentiles
			// 
			this.chbAllPercentiles.AutoSize = true;
			this.chbAllPercentiles.Location = new System.Drawing.Point(465, 9);
			this.chbAllPercentiles.Name = "chbAllPercentiles";
			this.chbAllPercentiles.Size = new System.Drawing.Size(104, 18);
			this.chbAllPercentiles.TabIndex = 6;
			this.chbAllPercentiles.Text = "All Percentiles";
			this.chbAllPercentiles.UseVisualStyleBackColor = true;
			this.chbAllPercentiles.CheckedChanged += new System.EventHandler(this.chbAllPercentiles_CheckedChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(237, 9);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(149, 14);
			this.label17.TabIndex = 5;
			this.label17.Text = "Digits After Decimal Point:";
			// 
			// numericUpDownResult
			// 
			this.numericUpDownResult.Location = new System.Drawing.Point(396, 5);
			this.numericUpDownResult.Maximum = new decimal(new int[] {
						8,
						0,
						0,
						0});
			this.numericUpDownResult.Name = "numericUpDownResult";
			this.numericUpDownResult.Size = new System.Drawing.Size(53, 22);
			this.numericUpDownResult.TabIndex = 4;
			this.numericUpDownResult.Value = new decimal(new int[] {
						4,
						0,
						0,
						0});
			this.numericUpDownResult.ValueChanged += new System.EventHandler(this.numericUpDownResult_ValueChanged);
			// 
			// btnResultShow
			// 
			this.btnResultShow.AddNewItem = null;
			this.btnResultShow.BackColor = System.Drawing.Color.White;
			this.btnResultShow.CountItem = this.bindingNavigatorCountItem;
			this.btnResultShow.DeleteItem = null;
			this.btnResultShow.Dock = System.Windows.Forms.DockStyle.None;
			this.btnResultShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.bindingNavigatorMoveFirstItem,
						this.bindingNavigatorMovePreviousItem,
						this.bindingNavigatorSeparator,
						this.bindingNavigatorPositionItem,
						this.bindingNavigatorCountItem,
						this.bindingNavigatorSeparator1,
						this.bindingNavigatorMoveNextItem,
						this.bindingNavigatorMoveLastItem,
						this.bindingNavigatorSeparator2});
			this.btnResultShow.Location = new System.Drawing.Point(11, 4);
			this.btnResultShow.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.btnResultShow.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.btnResultShow.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.btnResultShow.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.btnResultShow.Name = "btnResultShow";
			this.btnResultShow.PositionItem = this.bindingNavigatorPositionItem;
			this.btnResultShow.Size = new System.Drawing.Size(209, 25);
			this.btnResultShow.TabIndex = 3;
			this.btnResultShow.Text = "bindingNavigator1";
			this.btnResultShow.RefreshItems += new System.EventHandler(this.btnResultShow_RefreshItems);
			this.btnResultShow.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnResultShow_ItemClicked);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of Pages";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move to first page";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move to previous page";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Î»ÖÃ";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Tag = "Input page number and then press ¡°enter¡±";
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current page";
			this.bindingNavigatorPositionItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindingNavigatorPositionItem_KeyDown);
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move to next page";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move to last page";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnTableOutput
			// 
			this.btnTableOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTableOutput.Location = new System.Drawing.Point(575, 2);
			this.btnTableOutput.Name = "btnTableOutput";
			this.btnTableOutput.Size = new System.Drawing.Size(75, 27);
			this.btnTableOutput.TabIndex = 1;
			this.btnTableOutput.Text = "Export...";
			this.btnTableOutput.UseVisualStyleBackColor = true;
			this.btnTableOutput.Click += new System.EventHandler(this.btnTableOutput_Click);
			// 
			// tabChart
			// 
			this.tabChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabChart.Controls.Add(this.splitContainer4);
			this.tabChart.Controls.Add(this.btnSaveChart);
			this.tabChart.Controls.Add(this.pnlChart);
			this.tabChart.ImageIndex = 27;
			this.tabChart.Location = new System.Drawing.Point(4, 23);
			this.tabChart.Name = "tabChart";
			this.tabChart.Size = new System.Drawing.Size(657, 465);
			this.tabChart.TabIndex = 3;
			this.tabChart.Text = "Chart";
			this.tabChart.UseVisualStyleBackColor = true;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.btnSelectAll);
			this.splitContainer4.Panel1.Controls.Add(this.cbGraph);
			this.splitContainer4.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer4.Panel1.Controls.Add(this.groupBox9);
			this.splitContainer4.Panel1.Controls.Add(this.olvRegions);
			this.splitContainer4.Panel1.Controls.Add(this.btnApply);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.oxyPlotView);
			this.splitContainer4.Size = new System.Drawing.Size(657, 465);
			this.splitContainer4.SplitterDistance = 156;
			this.splitContainer4.TabIndex = 7;
			// 
			// btnSelectAll
			// 
			this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectAll.Location = new System.Drawing.Point(8, 325);
			this.btnSelectAll.Name = "btnSelectAll";
			this.btnSelectAll.Size = new System.Drawing.Size(141, 23);
			this.btnSelectAll.TabIndex = 32;
			this.btnSelectAll.Text = "Select All";
			this.btnSelectAll.UseVisualStyleBackColor = true;
			this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
			// 
			// cbGraph
			// 
			this.cbGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.cbGraph.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGraph.DropDownWidth = 200;
			this.cbGraph.FormattingEnabled = true;
			this.cbGraph.Items.AddRange(new object[] {
						"Bar Graph",
						"Cumulative Distribution Functions"});
			this.cbGraph.Location = new System.Drawing.Point(5, 3);
			this.cbGraph.Name = "cbGraph";
			this.cbGraph.Size = new System.Drawing.Size(149, 22);
			this.cbGraph.TabIndex = 31;
			this.cbGraph.SelectedIndexChanged += new System.EventHandler(this.cbGraph_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cbChartXAxis);
			this.groupBox1.Location = new System.Drawing.Point(5, 354);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(147, 49);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select X Axis";
			// 
			// cbChartXAxis
			// 
			this.cbChartXAxis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbChartXAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbChartXAxis.FormattingEnabled = true;
			this.cbChartXAxis.Location = new System.Drawing.Point(3, 18);
			this.cbChartXAxis.Name = "cbChartXAxis";
			this.cbChartXAxis.Size = new System.Drawing.Size(141, 22);
			this.cbChartXAxis.TabIndex = 29;
			this.cbChartXAxis.SelectedIndexChanged += new System.EventHandler(this.cbChartXAxis_SelectedIndexChanged);
			// 
			// groupBox9
			// 
			this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox9.Controls.Add(this.textChartFilter);
			this.groupBox9.Location = new System.Drawing.Point(5, 409);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(77, 48);
			this.groupBox9.TabIndex = 28;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Filter";
			// 
			// textChartFilter
			// 
			this.textChartFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textChartFilter.Location = new System.Drawing.Point(3, 18);
			this.textChartFilter.Name = "textChartFilter";
			this.textChartFilter.Size = new System.Drawing.Size(71, 22);
			this.textChartFilter.TabIndex = 0;
			this.textChartFilter.TextChanged += new System.EventHandler(this.textChartFilter_TextChanged);
			// 
			// olvRegions
			// 
			this.olvRegions.AllColumns.Add(this.olvColumn99);
			this.olvRegions.AllColumns.Add(this.olvColumn69);
			this.olvRegions.AllColumns.Add(this.olvColumn70);
			this.olvRegions.AllowColumnReorder = true;
			this.olvRegions.AllowDrop = true;
			this.olvRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.olvRegions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.olvRegions.CellEditUseWholeCell = false;
			this.olvRegions.CheckBoxes = true;
			this.olvRegions.CheckedAspectName = "";
			this.olvRegions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
						this.olvColumn99,
						this.olvColumn69,
						this.olvColumn70});
			this.olvRegions.CopySelectionOnControlC = false;
			this.olvRegions.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvRegions.EmptyListMsg = "Region List";
			this.olvRegions.EmptyListMsgFont = new System.Drawing.Font("Calibri", 14.25F);
			this.olvRegions.FullRowSelect = true;
			this.olvRegions.HideSelection = false;
			this.olvRegions.Location = new System.Drawing.Point(5, 31);
			this.olvRegions.MultiSelect = false;
			this.olvRegions.Name = "olvRegions";
			this.olvRegions.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
			this.olvRegions.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.olvRegions.OverlayText.BorderWidth = 2F;
			this.olvRegions.OverlayText.Rotation = -20;
			this.olvRegions.OverlayText.Text = "";
			this.olvRegions.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvRegions.ShowCommandMenuOnRightClick = true;
			this.olvRegions.ShowGroups = false;
			this.olvRegions.ShowImagesOnSubItems = true;
			this.olvRegions.ShowItemCountOnGroups = true;
			this.olvRegions.ShowItemToolTips = true;
			this.olvRegions.Size = new System.Drawing.Size(149, 288);
			this.olvRegions.SpaceBetweenGroups = 20;
			this.olvRegions.TabIndex = 2;
			this.olvRegions.UseAlternatingBackColors = true;
			this.olvRegions.UseCompatibleStateImageBehavior = false;
			this.olvRegions.UseFiltering = true;
			this.olvRegions.UseHotItem = true;
			this.olvRegions.UseHyperlinks = true;
			this.olvRegions.View = System.Windows.Forms.View.Details;
			// 
			// olvColumn99
			// 
			this.olvColumn99.AspectName = "RegionName";
			this.olvColumn99.IsEditable = false;
			this.olvColumn99.Text = "Region Name";
			this.olvColumn99.Width = 85;
			// 
			// olvColumn69
			// 
			this.olvColumn69.AspectName = "Col";
			this.olvColumn69.IsEditable = false;
			this.olvColumn69.Text = "Col";
			this.olvColumn69.Width = 32;
			// 
			// olvColumn70
			// 
			this.olvColumn70.AspectName = "Row";
			this.olvColumn70.IsEditable = false;
			this.olvColumn70.Text = "Row";
			// 
			// btnApply
			// 
			this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApply.Location = new System.Drawing.Point(194, 502);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(63, 42);
			this.btnApply.TabIndex = 0;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// oxyPlotView
			// 
			this.oxyPlotView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.oxyPlotView.Location = new System.Drawing.Point(0, 35);
			this.oxyPlotView.Name = "oxyPlotView";
			this.oxyPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
			this.oxyPlotView.Size = new System.Drawing.Size(497, 430);
			this.oxyPlotView.TabIndex = 0;
			this.oxyPlotView.Text = "plot1";
			this.oxyPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
			this.oxyPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.oxyPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
			// 
			// btnSaveChart
			// 
			this.btnSaveChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveChart.Location = new System.Drawing.Point(581, 537);
			this.btnSaveChart.Name = "btnSaveChart";
			this.btnSaveChart.Size = new System.Drawing.Size(75, 27);
			this.btnSaveChart.TabIndex = 4;
			this.btnSaveChart.Text = "Output";
			this.btnSaveChart.UseVisualStyleBackColor = true;
			this.btnSaveChart.Click += new System.EventHandler(this.btnSaveChart_Click);
			// 
			// pnlChart
			// 
			this.pnlChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlChart.Location = new System.Drawing.Point(0, 0);
			this.pnlChart.Name = "pnlChart";
			this.pnlChart.Size = new System.Drawing.Size(475, 369);
			this.pnlChart.TabIndex = 5;
			// 
			// tabATReport
			// 
			this.tabATReport.Controls.Add(this.lblAuditSearch);
			this.tabATReport.Controls.Add(this.btnNext);
			this.tabATReport.Controls.Add(this.groupBox2);
			this.tabATReport.Controls.Add(this.btnAuditTrailCollapse);
			this.tabATReport.Controls.Add(this.btnAuditTrailExpand);
			this.tabATReport.Controls.Add(this.textBoxFilterSimple);
			this.tabATReport.Controls.Add(this.treeListView);
			this.tabATReport.Controls.Add(this.btnAuditTrailOutput);
			this.tabATReport.ImageIndex = 26;
			this.tabATReport.Location = new System.Drawing.Point(4, 23);
			this.tabATReport.Name = "tabATReport";
			this.tabATReport.Padding = new System.Windows.Forms.Padding(3);
			this.tabATReport.Size = new System.Drawing.Size(657, 465);
			this.tabATReport.TabIndex = 4;
			this.tabATReport.Text = "Audit Trail Report";
			this.tabATReport.UseVisualStyleBackColor = true;
			// 
			// lblAuditSearch
			// 
			this.lblAuditSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAuditSearch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAuditSearch.Location = new System.Drawing.Point(-76, 430);
			this.lblAuditSearch.Name = "lblAuditSearch";
			this.lblAuditSearch.Size = new System.Drawing.Size(94, 27);
			this.lblAuditSearch.TabIndex = 21;
			this.lblAuditSearch.Text = "Search Results";
			this.lblAuditSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAuditSearch.Visible = false;
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Location = new System.Drawing.Point(270, 430);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(82, 27);
			this.btnNext.TabIndex = 0;
			this.btnNext.Text = "Next";
			this.btnNext.Visible = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox2.Controls.Add(this.rbSearch);
			this.groupBox2.Controls.Add(this.rbFilter);
			this.groupBox2.Location = new System.Drawing.Point(18, 430);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(130, 27);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			// 
			// rbSearch
			// 
			this.rbSearch.AutoSize = true;
			this.rbSearch.Location = new System.Drawing.Point(6, 3);
			this.rbSearch.Name = "rbSearch";
			this.rbSearch.Size = new System.Drawing.Size(61, 18);
			this.rbSearch.TabIndex = 1;
			this.rbSearch.Text = "Search";
			this.rbSearch.UseVisualStyleBackColor = true;
			this.rbSearch.CheckedChanged += new System.EventHandler(this.rbSearch_CheckedChanged);
			// 
			// rbFilter
			// 
			this.rbFilter.AutoSize = true;
			this.rbFilter.Checked = true;
			this.rbFilter.Location = new System.Drawing.Point(73, 3);
			this.rbFilter.Name = "rbFilter";
			this.rbFilter.Size = new System.Drawing.Size(54, 18);
			this.rbFilter.TabIndex = 0;
			this.rbFilter.TabStop = true;
			this.rbFilter.Text = "Filter";
			this.rbFilter.UseVisualStyleBackColor = true;
			this.rbFilter.CheckedChanged += new System.EventHandler(this.rbFilter_CheckedChanged);
			// 
			// btnAuditTrailCollapse
			// 
			this.btnAuditTrailCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAuditTrailCollapse.Location = new System.Drawing.Point(470, 430);
			this.btnAuditTrailCollapse.Name = "btnAuditTrailCollapse";
			this.btnAuditTrailCollapse.Size = new System.Drawing.Size(82, 27);
			this.btnAuditTrailCollapse.TabIndex = 19;
			this.btnAuditTrailCollapse.Text = "Collapse All";
			this.btnAuditTrailCollapse.UseVisualStyleBackColor = true;
			this.btnAuditTrailCollapse.Click += new System.EventHandler(this.btnAuditTrailCollapse_Click);
			// 
			// btnAuditTrailExpand
			// 
			this.btnAuditTrailExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAuditTrailExpand.Enabled = false;
			this.btnAuditTrailExpand.Location = new System.Drawing.Point(382, 430);
			this.btnAuditTrailExpand.Name = "btnAuditTrailExpand";
			this.btnAuditTrailExpand.Size = new System.Drawing.Size(82, 27);
			this.btnAuditTrailExpand.TabIndex = 18;
			this.btnAuditTrailExpand.Text = "Expand All";
			this.btnAuditTrailExpand.UseVisualStyleBackColor = true;
			this.btnAuditTrailExpand.Click += new System.EventHandler(this.btnAuditTrailExpand_Click);
			// 
			// textBoxFilterSimple
			// 
			this.textBoxFilterSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFilterSimple.Location = new System.Drawing.Point(154, 432);
			this.textBoxFilterSimple.Name = "textBoxFilterSimple";
			this.textBoxFilterSimple.Size = new System.Drawing.Size(109, 22);
			this.textBoxFilterSimple.TabIndex = 15;
			this.textBoxFilterSimple.TextChanged += new System.EventHandler(this.textBoxFilterSimple_TextChanged);
			this.textBoxFilterSimple.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilterSimple_KeyDown);
			// 
			// treeListView
			// 
			this.treeListView.AllColumns.Add(this.treeColumnName);
			this.treeListView.AllowColumnReorder = true;
			this.treeListView.AllowDrop = true;
			this.treeListView.AlternateRowBackColor = System.Drawing.Color.White;
			this.treeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.treeListView.CellEditUseWholeCell = false;
			this.treeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
						this.treeColumnName});
			this.treeListView.Cursor = System.Windows.Forms.Cursors.Default;
			this.treeListView.EmptyListMsg = "";
			this.treeListView.EmptyListMsgFont = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeListView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeListView.FullRowSelect = true;
			this.treeListView.HideSelection = false;
			this.treeListView.IsSimpleDragSource = true;
			this.treeListView.IsSimpleDropSink = true;
			this.treeListView.Location = new System.Drawing.Point(3, 6);
			this.treeListView.Name = "treeListView";
			this.treeListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.treeListView.ShowCommandMenuOnRightClick = true;
			this.treeListView.ShowGroups = false;
			this.treeListView.ShowImagesOnSubItems = true;
			this.treeListView.ShowItemToolTips = true;
			this.treeListView.Size = new System.Drawing.Size(651, 419);
			this.treeListView.TabIndex = 17;
			this.treeListView.UseCompatibleStateImageBehavior = false;
			this.treeListView.UseFiltering = true;
			this.treeListView.UseHotItem = true;
			this.treeListView.View = System.Windows.Forms.View.Details;
			this.treeListView.VirtualMode = true;
			// 
			// treeColumnName
			// 
			this.treeColumnName.AspectName = "Text";
			this.treeColumnName.IsTileViewColumn = true;
			this.treeColumnName.Text = "Name";
			this.treeColumnName.UseInitialLetterForGroup = true;
			this.treeColumnName.Width = 617;
			this.treeColumnName.WordWrap = true;
			// 
			// btnAuditTrailOutput
			// 
			this.btnAuditTrailOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAuditTrailOutput.Location = new System.Drawing.Point(573, 430);
			this.btnAuditTrailOutput.Name = "btnAuditTrailOutput";
			this.btnAuditTrailOutput.Size = new System.Drawing.Size(75, 27);
			this.btnAuditTrailOutput.TabIndex = 1;
			this.btnAuditTrailOutput.Text = "Export...";
			this.btnAuditTrailOutput.UseVisualStyleBackColor = true;
			this.btnAuditTrailOutput.Click += new System.EventHandler(this.btnAuditTrailOutput_Click);
			// 
			// btnPieTheme
			// 
			this.btnPieTheme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPieTheme.Image = global::BenMAP.Properties.Resources.tableView1;
			this.btnPieTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPieTheme.Name = "btnPieTheme";
			this.btnPieTheme.Size = new System.Drawing.Size(30, 28);
			this.btnPieTheme.Text = "Pie Theme";
			this.btnPieTheme.Visible = false;
			this.btnPieTheme.Click += new System.EventHandler(this.btnPieTheme_Click);
			// 
			// colorBlend
			// 
			this.colorBlend.ColorArray = new System.Drawing.Color[] {
				System.Drawing.Color.Blue,
				System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
				System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
				System.Drawing.Color.Yellow,
				System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
				System.Drawing.Color.Red};
			this.colorBlend.Location = new System.Drawing.Point(0, 0);
			this.colorBlend.Margin = new System.Windows.Forms.Padding(4);
			this.colorBlend.Name = "colorBlend";
			this.colorBlend.Size = new System.Drawing.Size(194, 50);
			this.colorBlend.TabIndex = 0;
			this.colorBlend.ValueArray = new double[] {
				0D,
				0D,
				0D,
				0D,
				0D,
				0D};
			// 
			// colorBlend2
			// 
			this.colorBlend2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.colorBlend2.ColorArray = new System.Drawing.Color[] {
				System.Drawing.Color.Blue,
				System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
				System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
				System.Drawing.Color.Yellow,
				System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
				System.Drawing.Color.Red};
			this.colorBlend2.Location = new System.Drawing.Point(0, 0);
			this.colorBlend2.Margin = new System.Windows.Forms.Padding(4);
			this.colorBlend2.Name = "colorBlend2";
			this.colorBlend2.Size = new System.Drawing.Size(194, 50);
			this.colorBlend2.TabIndex = 0;
			this.colorBlend2.ValueArray = new double[] {
				0D,
				0D,
				0D,
				0D,
				0D,
				0D};
			// 
			// BenMAP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(939, 692);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BenMAP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BenMAP";
			this.Load += new System.EventHandler(this.BenMAP_Load);
			this.Shown += new System.EventHandler(this.BenMAP_Shown);
			this.tabCRFunctionResultGISShow.ResumeLayout(false);
			this.spCRFunction.Panel1.ResumeLayout(false);
			this.spCRFunction.Panel2.ResumeLayout(false);
			this.spCRFunction.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spCRFunction)).EndInit();
			this.spCRFunction.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvCRFunctionResult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCRHelp)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.tabCtlReport.ResumeLayout(false);
			this.tabPoolingIncidence.ResumeLayout(false);
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel2.ResumeLayout(false);
			this.splitContainer5.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
			this.splitContainer5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvIncidence)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabAPVResultGISShow.ResumeLayout(false);
			this.tabAPVResultGISShow.PerformLayout();
			this.spAPVResult.Panel1.ResumeLayout(false);
			this.spAPVResult.Panel2.ResumeLayout(false);
			this.spAPVResult.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spAPVResult)).EndInit();
			this.spAPVResult.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tlvAPVResult)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabAuditTrialReport.ResumeLayout(false);
			this.tabAuditTrialReport.PerformLayout();
			this.tabCtlMain.ResumeLayout(false);
			this.tabGIS.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.pnlLegend.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabData.ResumeLayout(false);
			this.spTable.Panel1.ResumeLayout(false);
			this.spTable.Panel2.ResumeLayout(false);
			this.spTable.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spTable)).EndInit();
			this.spTable.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.OLVResultsShow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownResult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnResultShow)).EndInit();
			this.btnResultShow.ResumeLayout(false);
			this.btnResultShow.PerformLayout();
			this.tabChart.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRegions)).EndInit();
			this.tabATReport.ResumeLayout(false);
			this.tabATReport.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeListView)).EndInit();
			this.ResumeLayout(false);

		}


		private System.Windows.Forms.ImageList SmallImageList;
		private System.Windows.Forms.ToolTip tipBallon;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView trvSetting;
		public System.Windows.Forms.TabControl tabCtlReport;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private DotSpatial.Controls.AppManager appManager1;
		private System.Windows.Forms.TabControl tabCtlMain;
		private System.Windows.Forms.TabPage tabGIS;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private DotSpatial.Controls.Legend legend1;
		private System.Windows.Forms.TabPage tabData;
		private System.Windows.Forms.Button btnTableOutput;
		private System.Windows.Forms.TabPage tabChart;
		private OxyPlot.WindowsForms.PlotView oxyPlotView;
		// private ZedGraph.ZedGraphControl zedGraphCtl2; // temporary use for CDF ZED
		private System.Windows.Forms.Button btnSaveChart;
		private System.Windows.Forms.Panel pnlChart;
		private System.Windows.Forms.TabPage tabCRFunctionResultGISShow;
		private System.Windows.Forms.TabPage tabAPVResultGISShow;
		private BrightIdeasSoftware.ObjectListView olvCRFunctionResult;
		private BrightIdeasSoftware.OLVColumn olvColumn2;
		private BrightIdeasSoftware.OLVColumn olvcEndPointGroup;
		private BrightIdeasSoftware.OLVColumn olvcDataSet;
		private BrightIdeasSoftware.OLVColumn olvColumn8;
		private BrightIdeasSoftware.OLVColumn olvColumn9;
		private BrightIdeasSoftware.OLVColumn olvColumn12;
		private BrightIdeasSoftware.OLVColumn olvColumn13;
		private BrightIdeasSoftware.OLVColumn olvColumn14;
		private BrightIdeasSoftware.OLVColumn olvColumn15;
		private BrightIdeasSoftware.OLVColumn olvColumn16;
		private BrightIdeasSoftware.OLVColumn olvColumn17;
		private BrightIdeasSoftware.OLVColumn olvColumn36;
		private BrightIdeasSoftware.OLVColumn olvColumn37;
		private BrightIdeasSoftware.OLVColumn olvColumn38;
		private BrightIdeasSoftware.OLVColumn olvColumn39;
		private BrightIdeasSoftware.OLVColumn olvColumn40;
		private BrightIdeasSoftware.OLVColumn olvColumn41;
		private BrightIdeasSoftware.OLVColumn olvColumn42;
		private BrightIdeasSoftware.OLVColumn olvColumn43;
		private BrightIdeasSoftware.OLVColumn olvColumn44;
		private BrightIdeasSoftware.OLVColumn olvColumn45;
		private BrightIdeasSoftware.OLVColumn olvColumn46;
		private BrightIdeasSoftware.OLVColumn olvColumn47;
		private BrightIdeasSoftware.OLVColumn olvColumn48;
		private BrightIdeasSoftware.OLVColumn olvColumn49;
		private BrightIdeasSoftware.OLVColumn olvColumn50;
		private BrightIdeasSoftware.OLVColumn olvColumn51;
		private BrightIdeasSoftware.OLVColumn olvColumn52;
		private BrightIdeasSoftware.ObjectListView tlvAPVResult;
		private BrightIdeasSoftware.OLVColumn olvColumn1;
		private BrightIdeasSoftware.OLVColumn olvColumn3;
		private BrightIdeasSoftware.OLVColumn olvColumn4;
		private BrightIdeasSoftware.OLVColumn olvColumn5;
		private BrightIdeasSoftware.OLVColumn olvColumn6;
		private BrightIdeasSoftware.ObjectListView OLVResultsShow;
		private BrightIdeasSoftware.OLVColumn olvColumn7;
		private BrightIdeasSoftware.OLVColumn olvColumn10;
		private BrightIdeasSoftware.OLVColumn olvColumn11;
		private BrightIdeasSoftware.OLVColumn olvColumn18;
		private BrightIdeasSoftware.OLVColumn olvColumn19;
		private BrightIdeasSoftware.OLVColumn olvColumn20;
		private BrightIdeasSoftware.OLVColumn olvColumn21;
		private BrightIdeasSoftware.OLVColumn olvColumn22;
		private BrightIdeasSoftware.OLVColumn olvColumn23;
		private BrightIdeasSoftware.OLVColumn olvColumn24;
		private BrightIdeasSoftware.OLVColumn olvColumn25;
		private BrightIdeasSoftware.OLVColumn olvColumn26;
		private BrightIdeasSoftware.OLVColumn olvColumn27;
		private BrightIdeasSoftware.OLVColumn olvColumn28;
		private BrightIdeasSoftware.OLVColumn olvColumn29;
		private BrightIdeasSoftware.OLVColumn olvColumn30;
		private BrightIdeasSoftware.OLVColumn olvColumn31;
		private BrightIdeasSoftware.OLVColumn olvColumn32;
		private BrightIdeasSoftware.OLVColumn olvColumn33;
		private BrightIdeasSoftware.OLVColumn olvColumn34;
		private BrightIdeasSoftware.OLVColumn olvColumn53;
		private BrightIdeasSoftware.OLVColumn olvColumn54;
		private BrightIdeasSoftware.OLVColumn olvColumn55;
		private BrightIdeasSoftware.OLVColumn olvColumn56;
		private BrightIdeasSoftware.OLVColumn olvColumn57;
		private BrightIdeasSoftware.OLVColumn olvColumn58;
		private BrightIdeasSoftware.OLVColumn olvColumn59;
		private BrightIdeasSoftware.OLVColumn olvColumn60;
		private BrightIdeasSoftware.OLVColumn olvColumn61;
		private System.Windows.Forms.BindingNavigator btnResultShow;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.RadioButton rdbShowAllCR;
		private System.Windows.Forms.RadioButton rdbShowActiveCR;
		private System.Windows.Forms.Button btShowIncidencePooling;
		private System.Windows.Forms.RadioButton rbShowAllAPV;
		private System.Windows.Forms.RadioButton rbShowActiveAPV;
		private BrightIdeasSoftware.OLVColumn olvColumn62;
		private System.Windows.Forms.Label lbIncidencePoolingMethod;
		private System.Windows.Forms.TabPage tabAuditTrialReport;
		private System.Windows.Forms.RadioButton rbAuditFile;
		private System.Windows.Forms.RadioButton rbAuditCurrent;
		private System.Windows.Forms.Button btShowAudit;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtExistingConfiguration;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.TabPage tabATReport;
		private BrightIdeasSoftware.ObjectListView olvRegions;
		private BrightIdeasSoftware.OLVColumn olvColumn99;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.TextBox textChartFilter;
		private BrightIdeasSoftware.OLVColumn olvColumn69;
		private BrightIdeasSoftware.OLVColumn olvColumn70;
		private System.Windows.Forms.ComboBox cbPoolingWindowAPV;
		private System.Windows.Forms.CheckBox chbAPVAggregation;
		private System.Windows.Forms.SplitContainer spAPVResult;
		private System.Windows.Forms.SplitContainer spCRFunction;
		private System.Windows.Forms.SplitContainer spTable;
		private System.Windows.Forms.PictureBox picCRHelp;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnAuditTrailOutput;
		private System.Windows.Forms.ComboBox cbCRAggregation;
		private System.Windows.Forms.Label lblRegion;
		private System.Windows.Forms.ComboBox cbAPVAggregation;
		private System.Windows.Forms.Label lblAPV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btShowCRResult;
		private System.Windows.Forms.Button btSelectAttribute;
		private System.Windows.Forms.Button btAPVSelectAttribute;
		private System.Windows.Forms.Button btnShowAPVResult;
		private System.Windows.Forms.TabPage tabPoolingIncidence;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.Button btPoolingShowResult;
		private System.Windows.Forms.Button btPoolingSelectAttribute;
		private System.Windows.Forms.Label lblIncidence;
		private System.Windows.Forms.RadioButton rbShowAllIncidence;
		private System.Windows.Forms.RadioButton rbShowActiveIncidence;
		private System.Windows.Forms.ComboBox cbPoolingWindowIncidence;
		private System.Windows.Forms.ComboBox cbIncidenceAggregation;
		private System.Windows.Forms.Label label16;
		private WinControls.ColorBlendControl colorBlend;
		private WinControls.ColorBlendControl colorBlend2;
		private System.Windows.Forms.RadioButton rbIncidenceAll;
		private System.Windows.Forms.RadioButton rbIncidenceOnlyOne;
		private System.Windows.Forms.RadioButton rbAPVAll;
		private System.Windows.Forms.RadioButton rbAPVOnlyOne;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.NumericUpDown numericUpDownResult;
		private BrightIdeasSoftware.OLVColumn olvColumn92;
		private BrightIdeasSoftware.OLVColumn olvColumn93;
		private BrightIdeasSoftware.OLVColumn olvColumn94;
		private System.Windows.Forms.Button btShowDetailIncidence;
		private System.Windows.Forms.Button btShowDetailValuation;
		private BrightIdeasSoftware.ObjectListView olvIncidence;
		private BrightIdeasSoftware.OLVColumn olvColumn71;
		private BrightIdeasSoftware.OLVColumn olvColumn72;
		private BrightIdeasSoftware.OLVColumn olvColumn73;
		private BrightIdeasSoftware.OLVColumn olvColumn74;
		private BrightIdeasSoftware.OLVColumn olvColumn75;
		private BrightIdeasSoftware.OLVColumn olvColumn76;
		private BrightIdeasSoftware.OLVColumn olvColumn77;
		private BrightIdeasSoftware.OLVColumn olvColumn78;
		private BrightIdeasSoftware.OLVColumn olvColumn79;
		private BrightIdeasSoftware.OLVColumn olvColumn80;
		private BrightIdeasSoftware.OLVColumn olvColumn85;
		private BrightIdeasSoftware.OLVColumn olvColumn86;
		private BrightIdeasSoftware.OLVColumn olvColumn104;
		private BrightIdeasSoftware.OLVColumn olvColumn105;
		private BrightIdeasSoftware.OLVColumn olvColumn106;
		private BrightIdeasSoftware.OLVColumn olvColumn107;
		private BrightIdeasSoftware.OLVColumn olvColumn108;
		private BrightIdeasSoftware.OLVColumn olvColumn63;
		private BrightIdeasSoftware.OLVColumn olvColumn81;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbChartXAxis;
		private System.Windows.Forms.ComboBox cbGraph;
		private System.Windows.Forms.Button btnSelectAll;
		private System.Windows.Forms.ComboBox cboRegion;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ToolStripButton btnZoomIn;
		private System.Windows.Forms.ToolStripButton btnZoomOut;
		private System.Windows.Forms.ToolStripButton btnPan;
		private System.Windows.Forms.ToolStripButton btnFullExtent;
		private System.Windows.Forms.ToolStripButton btnIdentify;
		private System.Windows.Forms.ToolStripButton btnPieTheme;
		private System.Windows.Forms.ToolStripButton tsbSaveShapefile;
		private System.Windows.Forms.ToolStripButton tsbPrintLayout;
		private System.Windows.Forms.ToolStripButton tsbChangeProjection;
		private System.Windows.Forms.ToolStripButton tsbAddLayer;
		private System.Windows.Forms.ToolStripButton tsbAttributes;
		private System.Windows.Forms.TextBox textBoxFilterSimple;
		private BrightIdeasSoftware.TreeListView treeListView;
		private BrightIdeasSoftware.OLVColumn treeColumnName;
		private System.Windows.Forms.ToolStripButton tsbSelectByLocation;
		private System.Windows.Forms.ToolStripButton btnSelect;
		private System.Windows.Forms.ToolStripButton btnClearSelection;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private BrightIdeasSoftware.OLVColumn olvColumn35;
		private BrightIdeasSoftware.OLVColumn olvColumn64;
		private BrightIdeasSoftware.OLVColumn olvColumn65;
		private DotSpatial.Controls.Map mainMap;
		private System.Windows.Forms.Panel pnlLegend;
		private System.Windows.Forms.Button btnAuditTrailExpand;
		private System.Windows.Forms.Button btnAuditTrailCollapse;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbSearch;
		private System.Windows.Forms.RadioButton rbFilter;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label lblAuditSearch;
		private BrightIdeasSoftware.OLVColumn olvColumn66;
		private BrightIdeasSoftware.OLVColumn olvColumn67;
		private BrightIdeasSoftware.OLVColumn olvColumn68;
		private BrightIdeasSoftware.OLVColumn olvColumn82;
		private BrightIdeasSoftware.OLVColumn olvColumn83;
		private System.Windows.Forms.CheckBox chbAllPercentiles;
	}
}