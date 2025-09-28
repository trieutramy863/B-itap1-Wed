using System;
using System.Windows.Forms;
using UniqueArtLib; // nhớ thêm reference tới UniqueArtLib.dll vào References của project

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // khởi tạo mặc định
            numGrid.Minimum = 3;
            numGrid.Value = 9;
            chkMirror.Checked = true;
            lblMeta.Text = "Ready";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ArtisticHashArt art = new ArtisticHashArt();
            art.InputText = txtInput.Text;
            art.GridSize = (int)numGrid.Value;
            art.Mirror = chkMirror.Checked;
            art.Author = Environment.UserName; // hoặc gán tên bạn

            string output = art.GenerateArt();

            try
            {
                rtbOutput.Font = new System.Drawing.Font("Consolas", 10F);
            }
            catch { /* nếu máy không có Consolas thì bỏ qua */ }

            rtbOutput.Text = output;
            lblMeta.Text = "Author: " + art.Author + "  |  " + art.Metadata;
        }
    }
}
