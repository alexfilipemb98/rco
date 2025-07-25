namespace GestaoTrabalhos
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.components = new System.ComponentModel.Container();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
			this.skinPaletteDropDownButtonItem2 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
			this.bsiTime = new DevExpress.XtraBars.BarStaticItem();
			this.bsiVersao = new DevExpress.XtraBars.BarStaticItem();
			this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.aceAgenda = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
			this.npClientes = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.xucClientesListView = new GestaoTrabalhos.Views.Gestao.Clientes.ClientesListView();
			this.npServicos = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.xucServicosListView = new GestaoTrabalhos.Views.Gestao.Servicos.ServicosListView();
			this.npPrincipal = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.xucPrincipalView = new GestaoTrabalhos.Views.Home.Principal.PrincipalView();
			this.npArtigos = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.xucArtigosListView = new GestaoTrabalhos.Views.Gestao.Artigos.ArtigosListView();
			this.npTrabalhos = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.xucTrabalhosView = new GestaoTrabalhos.Views.Home.Trabalhos.TrabalhosView();
			this.npAgenda = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.xucCalendarioView = new GestaoTrabalhos.Views.Home.Calendario.CalendarioView();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
			this.navigationFrame.SuspendLayout();
			this.npClientes.SuspendLayout();
			this.npServicos.SuspendLayout();
			this.npPrincipal.SuspendLayout();
			this.npArtigos.SuspendLayout();
			this.npTrabalhos.SuspendLayout();
			this.npAgenda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.ApplicationCaption = "Gestão de Trabalhos";
			this.ribbonControl.AutoUpdateMergedRibbons = DevExpress.Utils.DefaultBoolean.True;
			this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem2,
            this.bsiTime,
            this.bsiVersao});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MaxItemId = 11;
			this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.ribbonControl.MiniToolbars.Add(this.ribbonMiniToolbar1);
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
			this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
			this.ribbonControl.ShowPageKeyTipsMode = DevExpress.XtraBars.Ribbon.ShowPageKeyTipsMode.ShowOnMultiplePages;
			this.ribbonControl.ShowQatLocationSelector = false;
			this.ribbonControl.ShowToolbarCustomizeItem = false;
			this.ribbonControl.Size = new System.Drawing.Size(1065, 49);
			this.ribbonControl.StatusBar = this.ribbonStatusBar1;
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			// 
			// skinDropDownButtonItem1
			// 
			this.skinDropDownButtonItem1.Id = 6;
			this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
			// 
			// skinPaletteDropDownButtonItem2
			// 
			this.skinPaletteDropDownButtonItem2.Id = 8;
			this.skinPaletteDropDownButtonItem2.Name = "skinPaletteDropDownButtonItem2";
			// 
			// bsiTime
			// 
			this.bsiTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bsiTime.Caption = "<TIME>";
			this.bsiTime.Id = 9;
			this.bsiTime.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources.time;
			this.bsiTime.Name = "bsiTime";
			this.bsiTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// bsiVersao
			// 
			this.bsiVersao.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bsiVersao.Caption = "<VERSAO>";
			this.bsiVersao.Id = 10;
			this.bsiVersao.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources.attachments;
			this.bsiVersao.Name = "bsiVersao";
			this.bsiVersao.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// ribbonMiniToolbar1
			// 
			this.ribbonMiniToolbar1.ParentControl = this;
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.ItemLinks.Add(this.bsiTime);
			this.ribbonStatusBar1.ItemLinks.Add(this.bsiVersao);
			this.ribbonStatusBar1.ItemLinks.Add(this.skinDropDownButtonItem1);
			this.ribbonStatusBar1.ItemLinks.Add(this.skinPaletteDropDownButtonItem2);
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 671);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1065, 37);
			// 
			// accordionControlElement1
			// 
			this.accordionControlElement1.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources.Home;
			this.accordionControlElement1.Name = "accordionControlElement1";
			this.accordionControlElement1.Text = "Main";
			// 
			// accordionControlElement2
			// 
			this.accordionControlElement2.Name = "accordionControlElement2";
			this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement2.Tag = "TRABALHOS";
			this.accordionControlElement2.Text = "Trabalhos";
			// 
			// accordionControl
			// 
			this.accordionControl.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
			this.accordionControl.AllowItemSelection = true;
			this.accordionControl.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.aceAgenda,
            this.accordionControlElement7,
            this.accordionControlElement2,
            this.accordionControlElement3});
			this.accordionControl.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;
			this.accordionControl.Location = new System.Drawing.Point(0, 0);
			this.accordionControl.Name = "accordionControl";
			this.accordionControl.OptionsFooter.ActiveGroupDisplayMode = DevExpress.XtraBars.Navigation.ActiveGroupDisplayMode.GroupHeaderAndContent;
			this.accordionControl.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
			this.accordionControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
			this.accordionControl.SelectElementMode = DevExpress.XtraBars.Navigation.SelectElementMode.MouseDown;
			this.accordionControl.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
			this.accordionControl.Size = new System.Drawing.Size(202, 622);
			this.accordionControl.TabIndex = 2;
			this.accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			this.accordionControl.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.accordionControl_ElementClick);
			// 
			// aceAgenda
			// 
			this.aceAgenda.Name = "aceAgenda";
			this.aceAgenda.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.aceAgenda.Tag = "AGENDA";
			this.aceAgenda.Text = "Agenda";
			// 
			// accordionControlElement7
			// 
			this.accordionControlElement7.Name = "accordionControlElement7";
			this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement7.Tag = "PRINCIPAL";
			this.accordionControlElement7.Text = "Dashboard";
			// 
			// accordionControlElement3
			// 
			this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement4,
            this.accordionControlElement5,
            this.accordionControlElement6});
			this.accordionControlElement3.Expanded = true;
			this.accordionControlElement3.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources.EaseOfAccess;
			this.accordionControlElement3.Name = "accordionControlElement3";
			this.accordionControlElement3.Text = "Gestão";
			// 
			// accordionControlElement4
			// 
			this.accordionControlElement4.Name = "accordionControlElement4";
			this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement4.Tag = "ARTIGOS";
			this.accordionControlElement4.Text = "Artigos";
			// 
			// accordionControlElement5
			// 
			this.accordionControlElement5.Name = "accordionControlElement5";
			this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement5.Tag = "CLIENTES";
			this.accordionControlElement5.Text = "Clientes";
			// 
			// accordionControlElement6
			// 
			this.accordionControlElement6.Name = "accordionControlElement6";
			this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement6.Tag = "SERVICOS";
			this.accordionControlElement6.Text = "Servicos";
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.navigationFrame);
			this.panelControl1.Controls.Add(this.accordionControl);
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1065, 622);
			this.panelControl1.TabIndex = 4;
			// 
			// navigationFrame
			// 
			this.navigationFrame.Controls.Add(this.npClientes);
			this.navigationFrame.Controls.Add(this.npServicos);
			this.navigationFrame.Controls.Add(this.npPrincipal);
			this.navigationFrame.Controls.Add(this.npArtigos);
			this.navigationFrame.Controls.Add(this.npTrabalhos);
			this.navigationFrame.Controls.Add(this.npAgenda);
			this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navigationFrame.Location = new System.Drawing.Point(202, 0);
			this.navigationFrame.Name = "navigationFrame";
			this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npPrincipal,
            this.npClientes,
            this.npServicos,
            this.npArtigos,
            this.npTrabalhos,
            this.npAgenda});
			this.navigationFrame.SelectedPage = this.npAgenda;
			this.navigationFrame.Size = new System.Drawing.Size(863, 622);
			this.navigationFrame.TabIndex = 3;
			this.navigationFrame.Text = "navigationFrame1";
			this.navigationFrame.TransitionAnimationProperties.FrameInterval = 500;
			this.navigationFrame.SelectedPageChanging += new DevExpress.XtraBars.Navigation.SelectedPageChangingEventHandler(this.navigationFrame_SelectedPageChanging);
			// 
			// npClientes
			// 
			this.npClientes.Caption = "npClientes";
			this.npClientes.Controls.Add(this.xucClientesListView);
			this.npClientes.Name = "npClientes";
			this.npClientes.Size = new System.Drawing.Size(863, 622);
			// 
			// xucClientesListView
			// 
			this.xucClientesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xucClientesListView.Location = new System.Drawing.Point(0, 0);
			this.xucClientesListView.Name = "xucClientesListView";
			this.xucClientesListView.Size = new System.Drawing.Size(863, 622);
			this.xucClientesListView.TabIndex = 0;
			// 
			// npServicos
			// 
			this.npServicos.Caption = "npServicos";
			this.npServicos.Controls.Add(this.xucServicosListView);
			this.npServicos.Name = "npServicos";
			this.npServicos.Size = new System.Drawing.Size(863, 622);
			// 
			// xucServicosListView
			// 
			this.xucServicosListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xucServicosListView.Location = new System.Drawing.Point(0, 0);
			this.xucServicosListView.Name = "xucServicosListView";
			this.xucServicosListView.Size = new System.Drawing.Size(863, 622);
			this.xucServicosListView.TabIndex = 0;
			// 
			// npPrincipal
			// 
			this.npPrincipal.Controls.Add(this.xucPrincipalView);
			this.npPrincipal.Name = "npPrincipal";
			this.npPrincipal.Size = new System.Drawing.Size(863, 622);
			// 
			// xucPrincipalView
			// 
			this.xucPrincipalView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xucPrincipalView.Location = new System.Drawing.Point(0, 0);
			this.xucPrincipalView.Name = "xucPrincipalView";
			this.xucPrincipalView.Size = new System.Drawing.Size(863, 622);
			this.xucPrincipalView.TabIndex = 0;
			// 
			// npArtigos
			// 
			this.npArtigos.Caption = "npArtigos";
			this.npArtigos.Controls.Add(this.xucArtigosListView);
			this.npArtigos.Name = "npArtigos";
			this.npArtigos.Size = new System.Drawing.Size(863, 622);
			// 
			// xucArtigosListView
			// 
			this.xucArtigosListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xucArtigosListView.Location = new System.Drawing.Point(0, 0);
			this.xucArtigosListView.Name = "xucArtigosListView";
			this.xucArtigosListView.Size = new System.Drawing.Size(863, 622);
			this.xucArtigosListView.TabIndex = 0;
			// 
			// npTrabalhos
			// 
			this.npTrabalhos.Caption = "npTrabalhos";
			this.npTrabalhos.Controls.Add(this.xucTrabalhosView);
			this.npTrabalhos.Name = "npTrabalhos";
			this.npTrabalhos.Size = new System.Drawing.Size(863, 622);
			// 
			// xucTrabalhosView
			// 
			this.xucTrabalhosView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xucTrabalhosView.Location = new System.Drawing.Point(0, 0);
			this.xucTrabalhosView.Name = "xucTrabalhosView";
			this.xucTrabalhosView.Size = new System.Drawing.Size(863, 622);
			this.xucTrabalhosView.TabIndex = 0;
			// 
			// npAgenda
			// 
			this.npAgenda.Caption = "npAgenda";
			this.npAgenda.Controls.Add(this.xucCalendarioView);
			this.npAgenda.Name = "npAgenda";
			this.npAgenda.Size = new System.Drawing.Size(863, 622);
			// 
			// xucCalendarioView
			// 
			this.xucCalendarioView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xucCalendarioView.Location = new System.Drawing.Point(0, 0);
			this.xucCalendarioView.Name = "xucCalendarioView";
			this.xucCalendarioView.Size = new System.Drawing.Size(863, 622);
			this.xucCalendarioView.TabIndex = 0;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.panelControl1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 49);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(1065, 622);
			this.layoutControl1.TabIndex = 5;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1065, 622);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.panelControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(1065, 622);
			this.layoutControlItem1.TextVisible = false;
			// 
			// skinPaletteDropDownButtonItem1
			// 
			this.skinPaletteDropDownButtonItem1.Id = 4;
			this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1065, 708);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.ribbonControl);
			this.Name = "MainForm";
			this.Ribbon = this.ribbonControl;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
			this.navigationFrame.ResumeLayout(false);
			this.npClientes.ResumeLayout(false);
			this.npServicos.ResumeLayout(false);
			this.npPrincipal.ResumeLayout(false);
			this.npArtigos.ResumeLayout(false);
			this.npTrabalhos.ResumeLayout(false);
			this.npAgenda.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
		private DevExpress.XtraBars.Navigation.NavigationPage npClientes;
		private DevExpress.XtraBars.Navigation.NavigationPage npServicos;
		private Views.Gestao.Clientes.ClientesListView xucClientesListView;
		private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
		private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
		private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem2;
		private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
		private DevExpress.XtraBars.Navigation.NavigationPage npPrincipal;
		private DevExpress.XtraBars.BarStaticItem bsiTime;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
		private DevExpress.XtraBars.BarStaticItem bsiVersao;
		private System.Windows.Forms.Timer timer;
		private Views.Gestao.Servicos.ServicosListView xucServicosListView;
		private DevExpress.XtraBars.Navigation.NavigationPage npArtigos;
		private Views.Gestao.Artigos.ArtigosListView xucArtigosListView;
		private DevExpress.XtraBars.Navigation.NavigationPage npTrabalhos;
		private Views.Home.Trabalhos.TrabalhosView xucTrabalhosView;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
		private Views.Home.Principal.PrincipalView xucPrincipalView;
		private DevExpress.XtraBars.Navigation.AccordionControlElement aceAgenda;
		private DevExpress.XtraBars.Navigation.NavigationPage npAgenda;
		private Views.Home.Calendario.CalendarioView xucCalendarioView;
	}
}

