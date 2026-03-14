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
            connector = new DBtools.Connector("Data Source=LAPTOP-5H1KDVCM\\SQLEXPRESS;Initial Catalog=SPU_411_DDL;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;Multi SubnetFailover=False");
        }
    }
}
