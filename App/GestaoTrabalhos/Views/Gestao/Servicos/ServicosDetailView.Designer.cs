namespace GestaoTrabalhos.Views.Gestao.Servicos
{
	partial class ServicosDetailView
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
			this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
			this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
			this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
			this.CodigoTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.NomeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.DataCriacaoDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.DataAtualizacaoDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.NotasTextEdit = new DevExpress.XtraEditors.MemoEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.ItemForDataCriacao = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForDataAtualizacao = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.ItemForNotas = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.ItemForNome = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
			this.servicosEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
			this.dataLayoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CodigoTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataCriacaoDateEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataCriacaoDateEdit.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataAtualizacaoDateEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataAtualizacaoDateEdit.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NotasTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDataCriacao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDataAtualizacao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForNotas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicosEntityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataLayoutControl
			// 
			this.dataLayoutControl.Controls.Add(this.spinEdit2);
			this.dataLayoutControl.Controls.Add(this.spinEdit1);
			this.dataLayoutControl.Controls.Add(this.toggleSwitch1);
			this.dataLayoutControl.Controls.Add(this.CodigoTextEdit);
			this.dataLayoutControl.Controls.Add(this.NomeTextEdit);
			this.dataLayoutControl.Controls.Add(this.IdTextEdit);
			this.dataLayoutControl.Controls.Add(this.DataCriacaoDateEdit);
			this.dataLayoutControl.Controls.Add(this.DataAtualizacaoDateEdit);
			this.dataLayoutControl.Controls.Add(this.NotasTextEdit);
			this.dataLayoutControl.DataSource = this.servicosEntityBindingSource;
			this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl.Location = new System.Drawing.Point(0, 0);
			this.dataLayoutControl.Name = "dataLayoutControl";
			this.dataLayoutControl.Root = this.Root;
			this.dataLayoutControl.Size = new System.Drawing.Size(858, 563);
			this.dataLayoutControl.TabIndex = 1;
			this.dataLayoutControl.Text = "dataLayoutControl1";
			// 
			// spinEdit2
			// 
			this.spinEdit2.CausesValidation = false;
			this.spinEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicosEntityBindingSource, "Custo", true));
			this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEdit2.Location = new System.Drawing.Point(514, 82);
			this.spinEdit2.Name = "spinEdit2";
			this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEdit2.Properties.MaskSettings.Set("mask", "c");
			this.spinEdit2.Properties.UseMaskAsDisplayFormat = true;
			this.spinEdit2.Size = new System.Drawing.Size(328, 28);
			this.spinEdit2.StyleController = this.dataLayoutControl;
			this.spinEdit2.TabIndex = 15;
			// 
			// spinEdit1
			// 
			this.spinEdit1.CausesValidation = false;
			this.spinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicosEntityBindingSource, "Duracao", true));
			this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEdit1.Location = new System.Drawing.Point(98, 82);
			this.spinEdit1.Name = "spinEdit1";
			this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spinEdit1.Properties.MaskSettings.Set("mask", "d");
			this.spinEdit1.Properties.UseMaskAsDisplayFormat = true;
			this.spinEdit1.Size = new System.Drawing.Size(328, 28);
			this.spinEdit1.StyleController = this.dataLayoutControl;
			this.spinEdit1.TabIndex = 14;
			// 
			// toggleSwitch1
			// 
			this.toggleSwitch1.AutoSizeInLayoutControl = true;
			this.toggleSwitch1.CausesValidation = false;
			this.toggleSwitch1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicosEntityBindingSource, "Ativo", true));
			this.toggleSwitch1.Location = new System.Drawing.Point(98, 116);
			this.toggleSwitch1.Name = "toggleSwitch1";
			this.toggleSwitch1.Properties.AutoWidth = true;
			this.toggleSwitch1.Properties.OffText = "Off";
			this.toggleSwitch1.Properties.OnText = "On";
			this.toggleSwitch1.Properties.ShowText = false;
			this.toggleSwitch1.Size = new System.Drawing.Size(47, 24);
			this.toggleSwitch1.StyleController = this.dataLayoutControl;
			this.toggleSwitch1.TabIndex = 13;
			// 
			// CodigoTextEdit
			// 
			this.CodigoTextEdit.CausesValidation = false;
			this.CodigoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicosEntityBindingSource, "Codigo", true));
			this.CodigoTextEdit.Location = new System.Drawing.Point(98, 48);
			this.CodigoTextEdit.Name = "CodigoTextEdit";
			this.CodigoTextEdit.Size = new System.Drawing.Size(189, 28);
			this.CodigoTextEdit.StyleController = this.dataLayoutControl;
			this.CodigoTextEdit.TabIndex = 12;
			// 
			// NomeTextEdit
			// 
			this.NomeTextEdit.CausesValidation = false;
			this.NomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicosEntityBindingSource, "Nome", true));
			this.NomeTextEdit.Location = new System.Drawing.Point(375, 48);
			this.NomeTextEdit.Name = "NomeTextEdit";
			this.NomeTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.NomeTextEdit.Properties.MaxLength = 150;
			this.NomeTextEdit.Size = new System.Drawing.Size(467, 28);
			this.NomeTextEdit.StyleController = this.dataLayoutControl;
			this.NomeTextEdit.TabIndex = 4;
			// 
			// IdTextEdit
			// 
			this.IdTextEdit.CausesValidation = false;
			this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicosEntityBindingSource, "Id", true));
			this.IdTextEdit.Location = new System.Drawing.Point(41, 519);
			this.IdTextEdit.Name = "IdTextEdit";
			this.IdTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.IdTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.IdTextEdit.Properties.MaskSettings.Set("mask", "N0");
			this.IdTextEdit.Properties.ReadOnly = true;
			this.IdTextEdit.Size = new System.Drawing.Size(135, 28);
			this.IdTextEdit.StyleController = this.dataLayoutControl;
			this.IdTextEdit.TabIndex = 9;
			// 
			// DataCriacaoDateEdit
			// 
			this.DataCriacaoDateEdit.CausesValidation = false;
			this.DataCriacaoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicosEntityBindingSource, "DataCriacao", true));
			this.DataCriacaoDateEdit.EditValue = null;
			this.DataCriacaoDateEdit.Location = new System.Drawing.Point(260, 519);
			this.DataCriacaoDateEdit.Name = "DataCriacaoDateEdit";
			this.DataCriacaoDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.DataCriacaoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DataCriacaoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DataCriacaoDateEdit.Properties.MaskSettings.Set("mask", "yyyy/MM/dd HH:mm:ss");
			this.DataCriacaoDateEdit.Properties.ReadOnly = true;
			this.DataCriacaoDateEdit.Properties.UseMaskAsDisplayFormat = true;
			this.DataCriacaoDateEdit.Size = new System.Drawing.Size(249, 28);
			this.DataCriacaoDateEdit.StyleController = this.dataLayoutControl;
			this.DataCriacaoDateEdit.TabIndex = 10;
			// 
			// DataAtualizacaoDateEdit
			// 
			this.DataAtualizacaoDateEdit.CausesValidation = false;
			this.DataAtualizacaoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicosEntityBindingSource, "DataAtualizacao", true));
			this.DataAtualizacaoDateEdit.EditValue = null;
			this.DataAtualizacaoDateEdit.Location = new System.Drawing.Point(612, 519);
			this.DataAtualizacaoDateEdit.Name = "DataAtualizacaoDateEdit";
			this.DataAtualizacaoDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.DataAtualizacaoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DataAtualizacaoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DataAtualizacaoDateEdit.Properties.MaskSettings.Set("mask", "yyyy/MM/dd HH:mm:ss");
			this.DataAtualizacaoDateEdit.Properties.ReadOnly = true;
			this.DataAtualizacaoDateEdit.Properties.UseMaskAsDisplayFormat = true;
			this.DataAtualizacaoDateEdit.Size = new System.Drawing.Size(230, 28);
			this.DataAtualizacaoDateEdit.StyleController = this.dataLayoutControl;
			this.DataAtualizacaoDateEdit.TabIndex = 11;
			// 
			// NotasTextEdit
			// 
			this.NotasTextEdit.CausesValidation = false;
			this.NotasTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicosEntityBindingSource, "Notas", true));
			this.NotasTextEdit.Location = new System.Drawing.Point(11, 191);
			this.NotasTextEdit.Name = "NotasTextEdit";
			this.NotasTextEdit.Size = new System.Drawing.Size(836, 277);
			this.NotasTextEdit.StyleController = this.dataLayoutControl;
			this.NotasTextEdit.TabIndex = 8;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.Root.Size = new System.Drawing.Size(858, 563);
			this.Root.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.AllowDrawBackground = false;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "autoGeneratedGroup0";
			this.layoutControlGroup1.Size = new System.Drawing.Size(848, 553);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
			this.layoutControlGroup2.ExpandButtonVisible = true;
			this.layoutControlGroup2.ExpandOnDoubleClick = true;
			this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDataCriacao,
            this.ItemForDataAtualizacao,
            this.ItemForId});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 469);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
			this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.layoutControlGroup2.Size = new System.Drawing.Size(848, 84);
			this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 5, 3);
			this.layoutControlGroup2.Text = "Detalhes";
			// 
			// ItemForDataCriacao
			// 
			this.ItemForDataCriacao.Control = this.DataCriacaoDateEdit;
			this.ItemForDataCriacao.Location = new System.Drawing.Point(166, 0);
			this.ItemForDataCriacao.Name = "ItemForDataCriacao";
			this.ItemForDataCriacao.Size = new System.Drawing.Size(333, 34);
			this.ItemForDataCriacao.Text = "Data Criacao";
			this.ItemForDataCriacao.TextSize = new System.Drawing.Size(62, 13);
			// 
			// ItemForDataAtualizacao
			// 
			this.ItemForDataAtualizacao.Control = this.DataAtualizacaoDateEdit;
			this.ItemForDataAtualizacao.Location = new System.Drawing.Point(499, 0);
			this.ItemForDataAtualizacao.Name = "ItemForDataAtualizacao";
			this.ItemForDataAtualizacao.Size = new System.Drawing.Size(333, 34);
			this.ItemForDataAtualizacao.Text = "Data Atualizacao";
			this.ItemForDataAtualizacao.TextSize = new System.Drawing.Size(81, 13);
			// 
			// ItemForId
			// 
			this.ItemForId.BestFitWeight = 50;
			this.ItemForId.Control = this.IdTextEdit;
			this.ItemForId.Location = new System.Drawing.Point(0, 0);
			this.ItemForId.Name = "ItemForId";
			this.ItemForId.Size = new System.Drawing.Size(166, 34);
			this.ItemForId.Text = "Id";
			this.ItemForId.TextSize = new System.Drawing.Size(9, 13);
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNotas});
			this.layoutControlGroup3.Location = new System.Drawing.Point(0, 146);
			this.layoutControlGroup3.Name = "layoutControlGroup3";
			this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup3.Size = new System.Drawing.Size(848, 323);
			this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 5, 3);
			this.layoutControlGroup3.Text = "Notas";
			// 
			// ItemForNotas
			// 
			this.ItemForNotas.Control = this.NotasTextEdit;
			this.ItemForNotas.Location = new System.Drawing.Point(0, 0);
			this.ItemForNotas.Name = "ItemForNotas";
			this.ItemForNotas.Size = new System.Drawing.Size(842, 283);
			this.ItemForNotas.Text = "Notas";
			this.ItemForNotas.TextVisible = false;
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
			this.layoutControlGroup4.ExpandButtonVisible = true;
			this.layoutControlGroup4.ExpandOnDoubleClick = true;
			this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup4.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNome,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
			this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup4.Name = "layoutControlGroup4";
			this.layoutControlGroup4.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
			this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.layoutControlGroup4.Size = new System.Drawing.Size(848, 146);
			this.layoutControlGroup4.Text = "Principal";
			// 
			// ItemForNome
			// 
			this.ItemForNome.Control = this.NomeTextEdit;
			this.ItemForNome.Location = new System.Drawing.Point(277, 0);
			this.ItemForNome.Name = "ItemForNome";
			this.ItemForNome.Size = new System.Drawing.Size(555, 34);
			this.ItemForNome.Text = "Nome";
			this.ItemForNome.TextSize = new System.Drawing.Size(66, 13);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.BestFitWeight = 50;
			this.layoutControlItem1.Control = this.CodigoTextEdit;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(277, 34);
			this.layoutControlItem1.Text = "Código";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.toggleSwitch1;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 68);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(135, 30);
			this.layoutControlItem2.Text = "Servico Ativo";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 13);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(135, 68);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(697, 30);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.spinEdit1;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(416, 34);
			this.layoutControlItem3.Text = "Duração (min)";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(66, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.spinEdit2;
			this.layoutControlItem4.Location = new System.Drawing.Point(416, 34);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(416, 34);
			this.layoutControlItem4.Text = "Custo (€)";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(66, 13);
			// 
			// dxErrorProvider
			// 
			this.dxErrorProvider.ContainerControl = this;
			// 
			// servicosEntityBindingSource
			// 
			this.servicosEntityBindingSource.DataSource = typeof(DataService.Entities.ServicosEntity);
			// 
			// xucServicosDetailView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataLayoutControl);
			this.Name = "xucServicosDetailView";
			this.Size = new System.Drawing.Size(858, 563);
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
			this.dataLayoutControl.ResumeLayout(false);
			this.dataLayoutControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CodigoTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataCriacaoDateEdit.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataCriacaoDateEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataAtualizacaoDateEdit.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataAtualizacaoDateEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NotasTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDataCriacao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDataAtualizacao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForNotas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicosEntityBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
		private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
		private DevExpress.XtraEditors.TextEdit CodigoTextEdit;
		private DevExpress.XtraEditors.TextEdit NomeTextEdit;
		private DevExpress.XtraEditors.TextEdit IdTextEdit;
		private DevExpress.XtraEditors.DateEdit DataCriacaoDateEdit;
		private DevExpress.XtraEditors.DateEdit DataAtualizacaoDateEdit;
		private DevExpress.XtraEditors.MemoEdit NotasTextEdit;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem ItemForDataCriacao;
		private DevExpress.XtraLayout.LayoutControlItem ItemForDataAtualizacao;
		private DevExpress.XtraLayout.LayoutControlItem ItemForId;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
		private DevExpress.XtraLayout.LayoutControlItem ItemForNotas;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.LayoutControlItem ItemForNome;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private System.Windows.Forms.BindingSource servicosEntityBindingSource;
		private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
		private DevExpress.XtraEditors.SpinEdit spinEdit2;
		private DevExpress.XtraEditors.SpinEdit spinEdit1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
	}
}
