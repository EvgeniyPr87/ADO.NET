using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using DBtools;
using System.IO;

namespace Academy
{
    public partial class StudentForm : HumanForm
    {
        private Connector connector;
        private Dictionary<string, int> groups;
        private byte[] photoData;
        public StudentForm()
        {
            InitializeComponent();

            connector = new Connector(
                ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString
                );
            LoadGroups();
            //rtbLastName.Text = "Тупенко";
            //rtbFirstName.Text = "Петр";
            //rtbMiddleName.Text = "Алексеевич";

            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void LoadGroups()
        {
            groups = connector.LoadDictionary("Groups");
            if (groups != null)
            {
                cbStudentsGroup.Items.Clear();
                foreach (var group in groups)
                {
                    cbStudentsGroup.Items.Add(group.Key);
                }
            }
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите фотографию";
            openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                pictureBoxPhoto.Image = image;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    photoData = memoryStream.ToArray();
                }

            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //DBtools.Connector connector = new DBtools.
            //    Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);

            string selectedGroupName = cbStudentsGroup.SelectedItem.ToString();
            int groupId = groups[selectedGroupName];

            string photoValue = "NULL";
            if (photoData != null)
            {
                photoValue = "0x" + BitConverter.ToString(photoData).Replace("-", "");
            }

            connector.Insert($"INSERT Students (last_name, first_name, middle_name,birth_date, [group], photo ) VALUES (N'{rtbLastName.Text}', N'{rtbFirstName.Text}', N'{rtbMiddleName.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{groupId}, {photoValue})");
        }

       
    }
}
