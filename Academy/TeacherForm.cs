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

namespace Academy
{
    public partial class TeacherForm : HumanForm
    {
        public TeacherForm()
        {
            InitializeComponent();
        }
        public TeacherForm(int id) : this()
        {
            DataTable data = DataBase.Connector.Select("*", "Teachers", $"teacher_id={id}");

            if (data.Rows.Count > 0)
            {
                labelID.Text = $"ID: {id}";
                rtbLastName.Text = data.Rows[0]["last_name"].ToString();
                rtbFirstName.Text = data.Rows[0]["first_name"].ToString();
                rtbMiddleName.Text = data.Rows[0]["middle_name"].ToString();
                dtpBirthDate.Value = Convert.ToDateTime(data.Rows[0]["birth_date"].ToString());
                rtbEmail.Text = data.Rows[0]["email"].ToString();
                rtbPhone.Text = data.Rows[0]["phone"].ToString();
                pictureBoxPhoto.Image = DataBase.Connector.DownloadPhoto(id, "Teachers", "photo");
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int id = labelID.Text.Split(':').Last() == "" ? 0 : Convert.ToInt32(labelID.Text.Split(':').Last());

            if (id == 0)
            {
                int nextId = DataBase.Connector.GetNextPrimaryKey("Teachers");
                string insertQuery = $"INSERT INTO Teachers (teacher_id, last_name, first_name, middle_name, birth_date, email, phone) VALUES ({nextId}, N'{rtbLastName.Text}', N'{rtbFirstName.Text}', N'{rtbMiddleName.Text}', N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}', N'{rtbEmail.Text}', N'{rtbPhone.Text}')";

                DataBase.Connector.ExecuteNonQuery(insertQuery);
                id = nextId;
                if (pictureBoxPhoto.Image != null)
                {
                    Academy.Models.Teacher tempTeacher = new Academy.Models.Teacher(id, "", "", "", "", "", "", pictureBoxPhoto.Image);
                    DataBase.Connector.UploadPhoto(tempTeacher.SerializePhoto(), id, "photo", "Teachers");
                }
            }
            else
            {
                string updateQuery = $@"UPDATE Teachers SET 
                                last_name = N'{rtbLastName.Text}', 
                                first_name = N'{rtbFirstName.Text}', 
                                middle_name = N'{rtbMiddleName.Text}', 
                                birth_date = N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}', 
                                email = N'{rtbEmail.Text}', 
                                phone = N'{rtbPhone.Text}' 
                                WHERE teacher_id = {id}";
                DataBase.Connector.ExecuteNonQuery(updateQuery);

                if (pictureBoxPhoto.Image != null)
                {
                    Academy.Models.Teacher tempTeacher = new Academy.Models.Teacher(id, "", "", "", "", "", "", pictureBoxPhoto.Image);
                    DataBase.Connector.UploadPhoto(tempTeacher.SerializePhoto(), id, "photo", "Teachers");
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}