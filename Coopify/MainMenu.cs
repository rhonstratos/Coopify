namespace Coopify
{
    public partial class MainMenu : Form
    {
        private readonly Login parent;
        private Dashboard child_dash = new();
        private Inventory child_inven = new();
        private ReportBuilder child_report = new();
        public MainMenu(Login parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            parent.Show();
        }
        private void CloseChildExcept(string FormName)
        {
            FormCollection fc = Application.OpenForms;
            List<string> fname = new();
            foreach (Form frm in fc)
                fname.Add(frm.Name);
            fname.Remove("Login");
            fname.Remove("MainMenu");

            if (FormName.Equals("Dashboard"))
            {
                if(fname.Contains("Inventory"))
                    child_inven.Dispose();
                if(fname.Contains("ReportBuilder"))
                    child_report.Dispose();
            }
            if (FormName.Equals("Inventory"))
            {
                if(fname.Contains("Dashboard"))
                    child_dash.Dispose();
                if(fname.Contains("ReportBuilder"))
                    child_report.Dispose();
            }
            if (FormName.Equals("ReportBuilder"))
            {
                if(fname.Contains("Inventory"))
                    child_inven.Dispose();
                if(fname.Contains("Dashboard"))
                    child_dash.Dispose();
            }
        }
        private void Dboard_ItemClick(object sender, EventArgs e)
        {
            CloseChildExcept("Dashboard");
            child_dash = new();
            child_dash.Show();
        }

        private void Ivn_ItemClick(object sender, EventArgs e)
        {
            CloseChildExcept("Inventory");
            child_inven = new();
            child_inven.Show();
        }

        private void Reportbuilder_ItemClick(object sender, EventArgs e)
        {
            CloseChildExcept("ReportBuilder");
            child_report = new();
            child_report.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            child_dash.Show();
        }
    }
}