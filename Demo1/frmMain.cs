using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

using Assignment2_DangNgocYenNhi_2190994_DTO;

namespace Demo1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BindingSource bs = new BindingSource();      
        private PerfumeBLL per_bs = new PerfumeBLL();
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            bs.DataSource = per_bs.getAllPerfume().Tables[0];
            dgv_sp.DataSource = bs;
           cbx_status.DataSource = bs;
            cbx_status.DisplayMember = "p_status";
            cbx_status.ValueMember = "p_status";

        }

        private void btn1_add_Click(object sender, EventArgs e)
        {
            //1. lấy giá trị
            int IdPerfume = Int32.Parse(txt_Id.Text);
            string NamePerfume = txt_Name.Text;
            //combo box
            string Status = cbx_status.SelectedValue.ToString();
            int Price = Int32.Parse(txt_Price.Text);
            //datetime picker
            DateTime Datein = dpx_Date.Value;

            //2. tao DTO
            DTO_Perfume per_dto = new DTO_Perfume()
            {
                IdPerfume = IdPerfume,
                NamePerfume = NamePerfume,
                Status = Status,
                DateIn = Datein
            };

            //3. call bus --> insert into db
            bool result = per_bs.createPerfume(per_dto);
            if (result)
            {
                MessageBox.Show("Create Successfully!!");
            }
            else
            {
                MessageBox.Show("Create Failed!!");
            }

            //4. load refresh to grid
            bs.DataSource = per_bs.getAllPerfume().Tables[0];
            dgv_sp.DataSource = bs;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            //1. lấy giá trị
            int IdPerfume = Int32.Parse(txt_Id.Text);
            string NamePerfume = txt_Name.Text;
            //combo box
            string Status = cbx_status.SelectedValue.ToString();
            //datetime picker
            int Price = Int32.Parse(txt_Price.Text);
            //datetime picker
            DateTime Datein = dpx_Date.Value;

            //2. tao DTO
            DTO_Perfume per_dto = new DTO_Perfume()
            {
                IdPerfume = IdPerfume,
                NamePerfume = NamePerfume,
                Status = Status,
                DateIn = Datein
            };

            //3. call bus --> update into db
            bool result = per_bs.updatePerfume(per_dto);
            if (result)
            {
                MessageBox.Show("Update Successfully!!");
            }
            else
            {
                MessageBox.Show( "Update Fail!!");
            }

            //4. load refresh to grid
            bs.DataSource = per_bs.getAllPerfume().Tables[0];
            dgv_sp.DataSource = bs;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int IdPerfume = int.Parse(txt_Id.Text);
            bool result = per_bs.deletePerfume(IdPerfume);
            if (result)
            {
                MessageBox.Show("Delete Successfully!!");
            }
            else
            {
                MessageBox.Show("Delete Fail!!");
            }
            bs.DataSource = per_bs.getAllPerfume().Tables[0];
            dgv_sp.DataSource = bs;
        }

        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}