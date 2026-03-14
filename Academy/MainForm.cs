using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBtools;

namespace Academy
{
    public partial class MainForm : Form
    {
        DBtools.Connector connector;
        public MainForm()
        {
            InitializeComponent();
            connector = new DBtools.Connector("Data Source=LAPTOP-5H1KDVCM\\SQLEXPRESS;Initial Catalog=SPU_411_Import;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //connector = new DBtools.Connector("Data Source=LAPTOP-5H1KDVCM\\SQLEXPRESS;Initial Catalog=SPU_411_Import;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnet Failover=False");
            
           //toolStripStatusLabel.Text = $"Количество напрвлений обучения: {connector.Scalar("SELECT COUNT(*) FROM Directions)}";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDirections.DataSource = connector.Select("SELECT * FROM Directions");

            toolStripStatusLabel.Text = $"Количество напрвлений обучения: {dgvDirections.RowCount - 1}";
        }
    }
}
