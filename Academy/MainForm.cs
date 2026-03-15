using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using DBtools;

namespace Academy
{
    public partial class MainForm : Form
    {
        Query[] queries =
        {
            new Query
                (
                "Students, Groups,Directors",
                "last_name,first_name, middle_name, group_name,direction_name",
                "[group]=group_id AND direction=direction_id"
                ),
            new Query
                (
                "Groups,Directions",
                "group_name,weekdays,start_time,start_date,direction_name",
                "direction=direction_id"
                ),
            new Query("Directions","*"),
            new Query("Disciplines","*"),
            new Query("Teachers","*"),
        };

        DBtools.Connector connector;
        public MainForm()
        {
            InitializeComponent();

           // AllocConsole();
            connector = new DBtools.Connector("Data Source=LAPTOP-5H1KDVCM\\SQLEXPRESS;Initial Catalog=SPU_411_Import;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            tabControl_SelectedIndexChanged(tabControl, null);
        }

        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($" {(sender as TabControl).SelectedIndex}\t{tabControl.SelectedTab.Text }");
            //dgvDirections.DataSource = connector.Select("SELECT * FROM Directions");
            //toolStripStatusLabel.Text = $"Количество напрвлений обучения: {dgvDirections.RowCount - 1}";
            //(sender as TabControl).SelectedTab.
            DataGridView dgv = (this.GetType().GetField($"dgv{tabControl.SelectedTab.Text}").GetValue(this) as DataGridView);
             dgv.DataSource =
                connector.Select($"SELECT * FROM { tabControl.SelectedTab.Text}");

             toolStripStatusLabel.Text = $"Количество записей: {dgv.RowCount - 1}";
        }
    }
}
