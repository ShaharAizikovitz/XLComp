using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI;
using NPOI.SS.UserModel;
using System.IO;
using System.Threading;
using Compare;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        
        string _p1, _p2;
        

        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void btn_openFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Excel files(*.xls)|*.xls|(*.xlsx)|*.xlsx|All files(*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog2.FileName == openFileDialog1.FileName)
                    MessageBox.Show("Error! file path already exist!/nChoose another file");

                else
                {
                    this.txtbx_source.Text = openFileDialog1.FileName;
                    _p1 = openFileDialog1.FileName;
                }
            }
        }

        private void btn_openFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog()
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Excel files(*.xls)|*.xls|(*.xlsx)|*.xlsx|All files(*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog2.FileName == openFileDialog1.FileName)
                    MessageBox.Show("Error! file path already exist!/nChoose another file");

                else
                {
                    this.txtBx_copy.Text = openFileDialog2.FileName;
                    _p2 = openFileDialog2.FileName;
                }
            }
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            Compare.Comprae compare = new Compare.Comprae();
            if (this._p1 != null && this._p2 != null)
            {
                compare.compare(_p1, _p2);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
