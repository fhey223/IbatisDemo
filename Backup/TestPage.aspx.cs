using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLLService;
using Model;

namespace IbatisDemo01
{
    public partial class TestPage : System.Web.UI.Page
    {
        private ClassesService service = new ClassesService();
        private Calsses calsses = new Calsses();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
              //  BindData();
            }
        }
        public void BindData() 
        {
            gdv_list.DataSource = service.GetAllClasses();
            gdv_list.DataBind();
        }

        protected void btn_sbyid_Click(object sender, EventArgs e)
        {
            int classes_id;
            if (Int32.TryParse(txt_tj.Text, out classes_id))
            {
                calsses = service.GetClassesByid(Convert.ToInt32(txt_tj.Text));
                if (calsses == null)
                {
                    txt_name.Visible = true;
                    txt_name.Text = "查询的实体不存在！！";
                }
                else
                {
                    lab_id.Visible = true;
                    txt_deci.Visible = true;
                    txt_name.Visible = true;
                    lab_id.Text = calsses.Id.ToString();
                    txt_name.Text = "名称：" + calsses.Name;
                    txt_deci.Text = "描述：" + calsses.Description;
                }
            }
            else 
            {
                txt_name.Visible = true;
                txt_name.Text = "请先输入正确的编号！！";
            }
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            calsses.Name = "吴庭智初学者课堂";
            calsses.Description = "IbatisNet课程第一章";
            service.AddClaases(calsses);
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            if (lab_id.Text == "编号:")
            {
                txt_name.Visible = true;
                txt_name.Text = "请先输入条件获取实体后再修改！！";
            }
            else 
            {
                calsses.Id = Convert.ToInt32(lab_id.Text);
                calsses.Name = txt_name.Text;
                calsses.Description = txt_deci.Text;
                service.UpdateClasses(calsses);
                lab_id.Visible = false;
                txt_deci.Visible = false;
                txt_name.Text = "修改成功！！";
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            if (lab_id.Text == "编号:")
            {
                txt_name.Visible = true;
                txt_name.Text = "请先输入条件获取实体后再删除！！";
            }
            else
            {
             
                service.DeleteClasses(Convert.ToInt32(lab_id.Text));
                lab_id.Visible = false;
                txt_deci.Visible = false;
                txt_name.Text = "删除成功！！";
            }
        }
    }
}