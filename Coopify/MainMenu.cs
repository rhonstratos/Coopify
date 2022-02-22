namespace Coopify
{
    public partial class MainMenu : Form
    {
        private readonly Login parent;
        private Dashboard child_dash;
        private Inventory child_inven;
        private ReportBuilder child_report;
        public MainMenu(Login parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            mm_formclosing();
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
                if (fname.Contains("Dashboard"))
                    child_report.Dispose();
            }
            if (FormName.Equals("Inventory"))
            {
                if(fname.Contains("Dashboard"))
                    child_dash.Dispose();
                if(fname.Contains("ReportBuilder"))
                    child_report.Dispose();
                if (fname.Contains("Inventory"))
                    child_inven.Dispose();
            }
            if (FormName.Equals("ReportBuilder"))
            {
                if(fname.Contains("Inventory"))
                    child_inven.Dispose();
                if(fname.Contains("Dashboard"))
                    child_dash.Dispose();
                if (fname.Contains("ReportBuilder"))
                    child_report.Dispose();
            }
        }
        private void Dboard_ItemClick(object sender, EventArgs e)
        {
            click_dashboard();
        }
        private void Ivn_ItemClick(object sender, EventArgs e)
        {
            click_inventory();
        }
        private void Reportbuilder_ItemClick(object sender, EventArgs e)
        {
            click_report();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            mm_load();
        }

        private void mm_formclosing()
        {
            this.Dispose();
            parent.Show();
        }
        private void click_dashboard()
        {
            CloseChildExcept("Dashboard");
            child_dash = new();
            child_dash.MdiParent = this;
            child_dash.Show();
        }
        private void click_inventory()
        {
            CloseChildExcept("Inventory");
            child_inven = new();
            child_inven.MdiParent = this;
            child_inven.Show();
        }
        private void click_report()
        {
            CloseChildExcept("ReportBuilder");
            child_report = new();
            child_report.MdiParent = this;
            child_report.Show();
        }
        private void mm_load()
        {
            click_dashboard();
        }
    }
}