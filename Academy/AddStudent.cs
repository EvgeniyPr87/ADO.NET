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
using System.Data.SqlClient;

namespace Academy
{
    public partial class AddStudent : Form
    {
        private Connector connector;
        private Dictionary<string, int> groups;
        private MainForm mainForm;
        //public AddStudent()
        //{
        //    InitializeComponent();
        //}
        public AddStudent(Connector connector,Dictionary<string, int> groups)
        {
            InitializeComponent();
            this.connector = connector;
            this.groups = groups;

            cbGroupSelect.Items.Clear();
            foreach (KeyValuePair<string, int> group in groups)
            {
                cbGroupSelect.Items.Add(group.Key);
            }



        }

        private void LoadGroups()
        {

        }
    }

   
}
