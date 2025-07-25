namespace GestaoTrabalhos.Views.Gestao.Servicos
{
	partial class ServicosListView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.bbiBack = new DevExpress.XtraBars.BarButtonItem();
			this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
			this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
			this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
			this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
			this.npList = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.panelControl = new DevExpress.XtraEditors.PanelControl();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.servicosEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDuracao = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCusto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotas = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAtivo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDataCriacao = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDataAtualizacao = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmModoEdicao = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
			this.npEditor = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.xucServicosDetailView = new GestaoTrabalhos.Views.Gestao.Servicos.ServicosDetailView();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
			this.navigationFrame.SuspendLayout();
			this.npList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
			this.panelControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicosEntityBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).BeginInit();
			this.npEditor.SuspendLayout();
			this.SuspendLayout();
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar});
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiReload,
            this.bbiEdit,
            this.bbiNew,
            this.bbiDelete,
            this.bbiSave,
            this.bbiBack});
			this.barManager.MainMenu = this.bar;
			this.barManager.MaxItemId = 6;
			// 
			// bar
			// 
			this.bar.BarName = "Main menu";
			this.bar.DockCol = 0;
			this.bar.DockRow = 0;
			this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar.OptionsBar.AllowQuickCustomization = false;
			this.bar.OptionsBar.DrawBorder = false;
			this.bar.OptionsBar.DrawDragBorder = false;
			this.bar.OptionsBar.MultiLine = true;
			this.bar.OptionsBar.UseWholeRow = true;
			this.bar.Text = "Main menu";
			// 
			// bbiBack
			// 
			this.bbiBack.Caption = "Voltar";
			this.bbiBack.Id = 5;
			this.bbiBack.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources.undo;
			this.bbiBack.Name = "bbiBack";
			this.bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			this.bbiBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBack_ItemClick);
			// 
			// bbiReload
			// 
			this.bbiReload.Caption = "Atualizar";
			this.bbiReload.Id = 0;
			this.bbiReload.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources.actions_refresh;
			this.bbiReload.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
			this.bbiReload.Name = "bbiReload";
			this.bbiReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReload_ItemClick);
			// 
			// bbiSave
			// 
			this.bbiSave.Caption = "Guardar";
			this.bbiSave.Id = 4;
			this.bbiSave.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources.saveall;
			this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
			this.bbiSave.Name = "bbiSave";
			this.bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
			// 
			// bbiNew
			// 
			this.bbiNew.Caption = "Novo";
			this.bbiNew.Id = 2;
			this.bbiNew.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources._new;
			this.bbiNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
			this.bbiNew.Name = "bbiNew";
			this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
			// 
			// bbiEdit
			// 
			this.bbiEdit.Caption = "Editar";
			this.bbiEdit.Id = 1;
			this.bbiEdit.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources.actions_edit;
			this.bbiEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
			this.bbiEdit.Name = "bbiEdit";
			this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
			// 
			// bbiDelete
			// 
			this.bbiDelete.Caption = "Apagar";
			this.bbiDelete.Id = 3;
			this.bbiDelete.ImageOptions.SvgImage = global::GestaoTrabalhos.Properties.Resources.del;
			this.bbiDelete.Name = "bbiDelete";
			this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.barDockControlTop.Size = new System.Drawing.Size(923, 39);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 745);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.barDockControlBottom.Size = new System.Drawing.Size(923, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 706);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(923, 39);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 706);
			// 
			// popupMenu
			// 
			this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete)});
			this.popupMenu.Manager = this.barManager;
			this.popupMenu.Name = "popupMenu";
			// 
			// navigationFrame
			// 
			this.navigationFrame.Controls.Add(this.npList);
			this.navigationFrame.Controls.Add(this.npEditor);
			this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navigationFrame.Location = new System.Drawing.Point(0, 39);
			this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.navigationFrame.Name = "navigationFrame";
			this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npList,
            this.npEditor});
			this.navigationFrame.SelectedPage = this.npList;
			this.navigationFrame.Size = new System.Drawing.Size(923, 706);
			this.navigationFrame.TabIndex = 6;
			this.navigationFrame.Text = "navigationFrame1";
			this.navigationFrame.TransitionAnimationProperties.FrameInterval = 500;
			// 
			// npList
			// 
			this.npList.Caption = "npList";
			this.npList.Controls.Add(this.layoutControl);
			this.npList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.npList.Name = "npList";
			this.npList.Size = new System.Drawing.Size(923, 706);
			// 
			// layoutControl
			// 
			this.layoutControl.Controls.Add(this.panelControl);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Root = this.Root;
			this.layoutControl.Size = new System.Drawing.Size(923, 706);
			this.layoutControl.TabIndex = 4;
			this.layoutControl.Text = "layoutControl1";
			// 
			// panelControl
			// 
			this.panelControl.Controls.Add(this.gridControl);
			this.panelControl.Location = new System.Drawing.Point(9, 10);
			this.panelControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelControl.Name = "panelControl";
			this.panelControl.Size = new System.Drawing.Size(905, 686);
			this.panelControl.TabIndex = 4;
			// 
			// gridControl
			// 
			this.gridControl.DataSource = this.servicosEntityBindingSource;
			this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridControl.Location = new System.Drawing.Point(2, 2);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridControl.MenuManager = this.barManager;
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(901, 682);
			this.gridControl.TabIndex = 0;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// servicosEntityBindingSource
			// 
			this.servicosEntityBindingSource.DataSource = typeof(DataService.Entities.ServicosEntity);
			// 
			// gridView
			// 
			this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colNome,
            this.colDuracao,
            this.colCusto,
            this.colNotas,
            this.colAtivo,
            this.colId,
            this.colDataCriacao,
            this.colDataAtualizacao,
            this.colEmModoEdicao});
			this.gridView.DetailHeight = 431;
			this.gridView.GridControl = this.gridControl;
			this.gridView.Name = "gridView";
			this.gridView.OptionsBehavior.Editable = false;
			this.gridView.OptionsEditForm.PopupEditFormWidth = 933;
			this.gridView.OptionsView.ShowGroupPanel = false;
			this.gridView.OptionsView.ShowIndicator = false;
			this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
			// 
			// colCodigo
			// 
			this.colCodigo.FieldName = "Codigo";
			this.colCodigo.MinWidth = 23;
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.Visible = true;
			this.colCodigo.VisibleIndex = 0;
			this.colCodigo.Width = 183;
			// 
			// colNome
			// 
			this.colNome.FieldName = "Nome";
			this.colNome.MinWidth = 23;
			this.colNome.Name = "colNome";
			this.colNome.Visible = true;
			this.colNome.VisibleIndex = 1;
			this.colNome.Width = 336;
			// 
			// colDuracao
			// 
			this.colDuracao.FieldName = "Tempo";
			this.colDuracao.MinWidth = 23;
			this.colDuracao.Name = "colDuracao";
			this.colDuracao.Visible = true;
			this.colDuracao.VisibleIndex = 2;
			this.colDuracao.Width = 142;
			// 
			// colCusto
			// 
			this.colCusto.FieldName = "Custo";
			this.colCusto.MinWidth = 23;
			this.colCusto.Name = "colCusto";
			this.colCusto.Visible = true;
			this.colCusto.VisibleIndex = 3;
			this.colCusto.Width = 139;
			// 
			// colNotas
			// 
			this.colNotas.FieldName = "Notas";
			this.colNotas.MinWidth = 23;
			this.colNotas.Name = "colNotas";
			this.colNotas.Width = 187;
			// 
			// colAtivo
			// 
			this.colAtivo.FieldName = "Ativo";
			this.colAtivo.MinWidth = 23;
			this.colAtivo.Name = "colAtivo";
			this.colAtivo.Visible = true;
			this.colAtivo.VisibleIndex = 4;
			this.colAtivo.Width = 99;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 23;
			this.colId.Name = "colId";
			this.colId.Width = 85;
			// 
			// colDataCriacao
			// 
			this.colDataCriacao.FieldName = "DataCriacao";
			this.colDataCriacao.MinWidth = 23;
			this.colDataCriacao.Name = "colDataCriacao";
			this.colDataCriacao.Width = 85;
			// 
			// colDataAtualizacao
			// 
			this.colDataAtualizacao.FieldName = "DataAtualizacao";
			this.colDataAtualizacao.MinWidth = 23;
			this.colDataAtualizacao.Name = "colDataAtualizacao";
			this.colDataAtualizacao.Width = 85;
			// 
			// colEmModoEdicao
			// 
			this.colEmModoEdicao.FieldName = "EmModoEdicao";
			this.colEmModoEdicao.MinWidth = 23;
			this.colEmModoEdicao.Name = "colEmModoEdicao";
			this.colEmModoEdicao.Width = 93;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
			this.Root.Size = new System.Drawing.Size(923, 706);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem
			// 
			this.layoutControlItem.Control = this.panelControl;
			this.layoutControlItem.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem.Name = "layoutControlItem";
			this.layoutControlItem.Size = new System.Drawing.Size(911, 694);
			this.layoutControlItem.TextVisible = false;
			// 
			// npEditor
			// 
			this.npEditor.Caption = "npEditor";
			this.npEditor.Controls.Add(this.xucServicosDetailView);
			this.npEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.npEditor.Name = "npEditor";
			this.npEditor.Size = new System.Drawing.Size(923, 706);
			// 
			// xucServicosDetailView
			// 
			this.xucServicosDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xucServicosDetailView.Location = new System.Drawing.Point(0, 0);
			this.xucServicosDetailView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.xucServicosDetailView.Name = "xucServicosDetailView";
			this.xucServicosDetailView.Size = new System.Drawing.Size(923, 706);
			this.xucServicosDetailView.TabIndex = 0;
			// 
			// ServicosListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ServicosListView";
			this.Size = new System.Drawing.Size(923, 745);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
			this.navigationFrame.ResumeLayout(false);
			this.npList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
			this.panelControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicosEntityBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem)).EndInit();
			this.npEditor.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar bar;
		private DevExpress.XtraBars.BarButtonItem bbiBack;
		private DevExpress.XtraBars.BarButtonItem bbiReload;
		private DevExpress.XtraBars.BarButtonItem bbiSave;
		private DevExpress.XtraBars.BarButtonItem bbiNew;
		private DevExpress.XtraBars.BarButtonItem bbiEdit;
		private DevExpress.XtraBars.BarButtonItem bbiDelete;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.PopupMenu popupMenu;
		private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
		private DevExpress.XtraBars.Navigation.NavigationPage npList;
		private DevExpress.XtraLayout.LayoutControl layoutControl;
		private DevExpress.XtraEditors.PanelControl panelControl;
		private DevExpress.XtraGrid.GridControl gridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem;
		private DevExpress.XtraBars.Navigation.NavigationPage npEditor;
		private System.Windows.Forms.BindingSource servicosEntityBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
		private DevExpress.XtraGrid.Columns.GridColumn colNome;
		private DevExpress.XtraGrid.Columns.GridColumn colDuracao;
		private DevExpress.XtraGrid.Columns.GridColumn colCusto;
		private DevExpress.XtraGrid.Columns.GridColumn colNotas;
		private DevExpress.XtraGrid.Columns.GridColumn colAtivo;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colDataCriacao;
		private DevExpress.XtraGrid.Columns.GridColumn colDataAtualizacao;
		private DevExpress.XtraGrid.Columns.GridColumn colEmModoEdicao;
		private ServicosDetailView xucServicosDetailView;
	}
}
