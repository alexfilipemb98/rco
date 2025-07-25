using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using GestaoTrabalhos.Forms;
using GestaoTrabalhos.Helpers;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace GestaoTrabalhos
{
	public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private IOverlaySplashScreenHandle _Overlay;

		public MainForm() => InitializeComponent();

		private async void accordionControl_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
		{
			try
			{
				string tag = e.Element.Tag?.ToString();

				switch (tag)
				{
					case "CLIENTES":
						navigationFrame.SelectedPage = npClientes;
						await xucClientesListView.LoadData();
						ribbonControl.ApplicationDocumentCaption = "Clientes";
						break;

					case "SERVICOS":
						navigationFrame.SelectedPage = npServicos;
						await xucServicosListView.LoadData();
						ribbonControl.ApplicationDocumentCaption = "Serviços";
						break;

					case "ARTIGOS":
						navigationFrame.SelectedPage = npArtigos;
						await xucArtigosListView.LoadData();
						ribbonControl.ApplicationDocumentCaption = "Artigos";
						break;

					case "TRABALHOS":
						navigationFrame.SelectedPage = npTrabalhos;
						await xucTrabalhosView.LoadData();
						ribbonControl.ApplicationDocumentCaption = "Trabalhos";
						break;

					case "PRINCIPAL":
						navigationFrame.SelectedPage = npPrincipal;
						ribbonControl.ApplicationDocumentCaption = "Dashboard";
						break;

					case "AGENDA":
						navigationFrame.SelectedPage = npAgenda;
						ribbonControl.ApplicationDocumentCaption = "Agenda";
						break;
				}
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
			finally
			{
				SplashScreenManager.CloseOverlayForm(_Overlay);
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			Version verssion = Assembly.GetExecutingAssembly().GetName().Version;
#if DEBUG
			bsiVersao.Caption = $"Versão: {verssion} (DEBUG!)";
			bsiVersao.Appearance.ForeColor = ForeColors.Critical;
#else
			lbsiVersao.Caption = $"v{verssion}";
			bsiVersao.Appearance.ForeColor = ForeColors.Information;
#endif
			bsiTime.Caption = $"Tempo: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";
			accordionControl.SelectedElement = aceAgenda;
			ribbonControl.ApplicationDocumentCaption = "Agenda";
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			bsiTime.Caption = $"Tempo: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";
		}

		private void frmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			try
			{
				System.Windows.Forms.DialogResult result = XtraMessageBox.Show("Deseja realmente sair ? ", "A Sair", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
				e.Cancel = result != System.Windows.Forms.DialogResult.Yes;
			}
			catch (Exception ex)
			{
				AppHelper.ErrorHelper(ex);
			}
		}

		private void navigationFrame_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
		{
			_Overlay =  SplashScreenManager.ShowOverlayForm(layoutControl1, true, true );
			Application.DoEvents();
			Task.Delay(250);

		}
	}
}
