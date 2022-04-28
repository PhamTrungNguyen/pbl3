using pbl3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.Admin.DuLieu
{
    public partial class TheLoai : UserControl
    {
        BindingSource genreList = new BindingSource();
        TheLoaiDAO theLoaiDAO = new TheLoaiDAO();
        public TheLoai()
        {
            InitializeComponent();
           
        }
        void LoadTheLoai()
        {
            dgvTheLoai.DataSource = theLoaiDAO.GetTheLoai();
       
           
        }
        private void btnTheLoaiThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTheLoaiThemXem_Click(object sender, EventArgs e)
        {
            LoadTheLoai();
           
        }
    }
}
