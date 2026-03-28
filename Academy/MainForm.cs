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
    public partial class MainForm : Form
    {
        DataGridView[] tables = null;
        Query[] queries =
        {
            new Query
                (
                "Students, Groups,Directions",
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

        string[] statusbarSignatures =
        {
            "Количество студентов ",
            "Количество групп ",
            "Количество направлений ",
            "Количество дисциплин ",
            "Количество преподавателей "
        };

        DBtools.Connector connector;
       ///////////////////
         Dictionary<string, int> d_direction=null;

        Dictionary<string, Dictionary<string, int>> d_trees = null;

        public MainForm()
        {
            InitializeComponent();
            tables = new DataGridView[] { dgvStudents, dgvGroups,dgvDirections , dgvDisciplines, dgvTeachers };
            //AllocConsole();
            connector = new DBtools.Connector("Data Source=LAPTOP-5H1KDVCM\\SQLEXPRESS;Initial Catalog=SPU_411_Import;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            tabControl_SelectedIndexChanged(tabControl, null);
            d_trees = new Dictionary<string, Dictionary<string, int>>();
            d_trees.Add(nameof(d_direction), d_direction);
            LoadDataToComboBox(cbGroupsDirection);
            LoadDataToComboBox(cbStudentsGroup);
            LoadDataToComboBox(cbStudentsDirection);
            LoadDataToComboBox(cbDisciplinesDirection);
            //LoadDataToComboBox(cbGroupDirection);
            LoadDataToComboBox(cbGroup);
            //LoadDataToComboBox(cbDisciplines);

        }

        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        void LoadDataToComboBox(ComboBox comboBox)
        {
            string table = comboBox.Name.Substring(Array.FindLastIndex<char>(comboBox.Name.ToCharArray(), Char.IsUpper)) + "s";
            string dictionary_name = $"d_{table}".ToLower();
            Console.WriteLine(table);
             d_trees[dictionary_name]= connector.LoadDictionary(table);
            foreach(KeyValuePair<string, int> i in d_trees[dictionary_name])
            {
                comboBox.Items.Add(i.Key);
            }
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($" {(sender as TabControl).SelectedIndex}\t{tabControl.SelectedTab.Text }");
            int i = tabControl.SelectedIndex;
            tables[i].DataSource = connector.Select(queries[i].ToString());
            toolStripStatusLabel.Text = $"{statusbarSignatures[i]}:{tables[i].RowCount - 1}";
        }

        private void cbGroupsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cbGroupsDirection.SelectedIndex !=-1)
            //tables[1].DataSource = connector.Select(queries[1].ToString() + $" AND directions={d_trees["d_directions"][cbGroupsDirection.SelectedItem.ToString()]}");
            int i = tabControl.SelectedIndex;
            tables[i].DataSource = connector.Select(queries[i].ToString());
            toolStripStatusLabel.Text = $"{statusbarSignatures[i]}: {tables[i].RowCount - 1}";
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbGroupsDirection.SelectedIndex != -1)
            //    tables[1].DataSource = connector.Select(queries[1].ToString() + $" AND directions={d_trees["d_directions"][cbGroupsDirection.SelectedItem.ToString()]}");

            if (cbGroup.SelectedIndex == -1)
            {
                RefreshCurrent();
            } 
            else
            {
                tables[1].DataSource = connector.Select
                 (
queries[1].ToString() + $" AND direction={d_trees["d_directions"][cbGroupsDirection.SelectedItem.ToString()]}"
                 );
            }
               
        }

        private void RefreshCurrent()
        {
            int currentTabIndex = tabControl.SelectedIndex;
            tables[currentTabIndex].DataSource = connector.Select(queries[currentTabIndex].ToString());
            toolStripStatusLabel.Text = $"{statusbarSignatures[currentTabIndex]}:" +
                $"{tables[currentTabIndex].RowCount - 1}";
        }

        //private void btnCliar_Click(object sender, EventArgs e)
        //{
           
        //    cbGroupsDirection.SelectedIndex = -1;
        //    cbStudentsGroup.SelectedIndex = -1;
        //    cbStudentsDirection.SelectedIndex = -1;
        //    cbDisciplinesDirection.SelectedIndex = -1;
        //    cbGroup.SelectedIndex = -1;

        //    RefreshCurrent();

        //    toolStripStatusLabel.Text = "Фильтры сброшены";
        //}

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            cbGroupsDirection.SelectedIndex = -1;
            cbStudentsGroup.SelectedIndex = -1;
            cbStudentsDirection.SelectedIndex = -1;
            cbDisciplinesDirection.SelectedIndex = -1;
            cbGroup.SelectedIndex = -1;

            RefreshCurrent();

            toolStripStatusLabel.Text = "Фильтры сброшены";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AddStudent addForm = new AddStudent(connector, d_trees["d_groups"]);

            // Показываем форму
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Если студент добавлен — обновляем таблицу студентов
                RefreshCurrent();
            }
        }


        ///////////////////////////////


    }
}
