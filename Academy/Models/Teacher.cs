using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Academy.Models
{
    internal class Teacher : Human
    {
        public Teacher
           (
           int id, string last_name, string first_name, string middle_name, string birth_date,
           string email, string phone, Image photo
           ) : base(id, last_name, first_name, middle_name, birth_date,
           email, phone, photo)
        {
            
        }
        //public override string GetNames()
        //{
        //    return $"teacher_id,{base.GetNames()},photo" ;
        //}
        public override string GetNames()
        {
            return base.GetNames(); 
        }
        public override string ToStringUpdatee()
        {
            return  base.ToStringUpdatee() ;
        }
        public string GetCondition()
        {
            return $"last_name=N'{last_name}' AND first_name=N'{first_name}' AND " +
                   $"middle_name=N'{middle_name}' AND birth_date='{birth_date}'";
        }
    }
}
