using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WeatherApp
{
    public partial class MasterForm : Form
    {
        private MasterController master_controller = new MasterController();

        public MasterForm()
        {
            InitializeComponent();
            //Connect to SQLite and bind data
            MasterGridView.DataSource = master_controller.show_master();
            //Setting Not Sort
            foreach (DataGridViewColumn d in MasterGridView.Columns)
            {
                d.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Control GUI
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MasterGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MasterGridView.AllowUserToAddRows = false;
            MasterGridView.MultiSelect = false;
            MasterGridView.ReadOnly = true;
            //Headers are Unvisible
            MasterGridView.ColumnHeadersVisible = false;
            // ID Row is Unvisible
            MasterGridView.Columns[0].Visible = false;        
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            MasterGridView.DataSource = master_controller.show_search_data(Search_Text.Text);
        }

        private void Search_Text_KeyDown(object sender, KeyEventArgs e)
        {
            MasterGridView.DataSource = master_controller.show_search_data(Search_Text.Text);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            String selected_id = "";
            if (MasterGridView.SelectedRows.Count <= 0)
            {
                this.Close();
                return;
            }
            else
            {
                selected_id = MasterGridView.CurrentRow.Cells[0].Value.ToString();
            }
            master_controller.update_use_master(selected_id);
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Text_Enter(object sender, EventArgs e)
        {
            this.Search_Text.SelectAll();
        }

        private void Search_Text_Click(object sender, EventArgs e)
        {
            this.Search_Text.SelectAll();
        }
    }
}
