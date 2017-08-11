using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Master : Form
    {
        public Master()
        {
            //Connect to SQL
            InitializeComponent();
            Master_Control master_control = new Master_Control();
            dataGridView1.DataSource = master_control.show_master();
            //Control GUI
            bool control = false;
            show_control(control);
            city_code_text.Text = "";
            city_name_text.Text = "";

        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            Master_Control master_control = new Master_Control();
            master_control.new_insert_master(city_code_text.Text, city_name_text.Text);
            dataGridView1.DataSource = master_control.show_master();
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            bool control = true;
            show_control(control);
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            Master_Control master_control = new Master_Control();
            master_control.delete_master(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("選択されたデータは削除されました");
            dataGridView1.DataSource = master_control.show_master();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            bool control = false;
            show_control(control);
            city_code_text.Text = "";
            city_name_text.Text = "";

        }

        private void show_control(bool show_decision)
        {
            city_code_text.Visible = show_decision;
            city_name_text.Visible = show_decision;
            id_label.Visible = show_decision;
            name_label.Visible = show_decision;
            registration_button.Visible = show_decision;
            cancel_button.Visible = show_decision;
        }

        private void city_code_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void Master_FormClosing(object sender, FormClosingEventArgs e)
        {
            String selected_ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Master_Control master_control = new Master_Control();
            master_control.update_use_master(selected_ID);
            Form1 form1 = new Form1();
            form1.Refresh();
        }
    }




}
