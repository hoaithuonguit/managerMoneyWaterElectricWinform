using manager.Controller;
using manager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel;

namespace manager
{
    public partial class Form1 : Form
    {
        public MainController controller;
        public Form1()
        {
            controller = new MainController();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.GetAllValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add m = new Add();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            app.Application exapp = new app.Application();
            app.Workbook ebook = exapp.Workbooks.Add(app.XlWBATemplate.xlWBATWorksheet);
            app.Worksheet exSheet = (app.Worksheet)ebook.Worksheets[1];
            exSheet.Activate();
            exSheet.Name = "DLDN";
            List<CSVModel> ls = new List<CSVModel>();
            ls = controller.CSVExport();
            int j = 1;
            for (int i = 0; i< ls.Count; i++)
            {
                
                {
                    String a1merge = "A" + j.ToString() + ":B" + j.ToString();
                    exSheet.Range[a1merge].Merge();
                    app.Range r = exSheet.Cells[j,1];
                    r.Value = ls[i].RoomName;
                    a1merge = "C" + j.ToString() + ":D" + j.ToString();
                    exSheet.Range[a1merge].Merge();
                    app.Range r1 = exSheet.Cells[j, 3];
                    r1.Value = DateTime.Now;
                    r1.Columns.AutoFit();
                   a1merge = "A" + (j+1).ToString() + ":B" + (j + 1).ToString();
                    exSheet.Range[a1merge].Merge();
                    app.Range r2 = exSheet.Cells[j + 1, 1];
                    r2.Value = "Điện";
                    a1merge = "C" + (j + 1).ToString() + ":D" + (j + 1).ToString();
                    exSheet.Range[a1merge].Merge();
                    app.Range r3 = exSheet.Cells[j + 1, 3];
                    r3.Value = "Nước";

                    app.Range r4 = exSheet.Cells[j + 2, 1];
                    r4.Value = "Cũ: " + ls[i].OldElect.ToString();
                    app.Range r5 = exSheet.Cells[j + 2, 2];
                    r5.Value = "Mới: " + ls[i].NewElect.ToString();

                    app.Range r6 = exSheet.Cells[j + 2, 3];
                    r6.Value = "Cũ: " + ls[i].OldWater.ToString();
                    app.Range r7 = exSheet.Cells[j + 2, 4];
                    r7.Value = "Mới: " + ls[i].NewWater.ToString();
                    a1merge = "A" + (j + 3).ToString() + ":B" + (j + 3).ToString();
                    exSheet.Range[a1merge].Merge();
                    app.Range r8 = exSheet.Cells[j + 3, 1];
                    r8.Value = ls[i].TotalElect.ToString() + " x 3000 = " + ls[i].MoneyElect.ToString();

                    a1merge = "C" + (j + 3).ToString() + ":D" + (j + 3).ToString();
                    exSheet.Range[a1merge].Merge();
                    app.Range r9 = exSheet.Cells[j + 3, 3];
                    r9.Value = ls[i].TotalWater.ToString() + " x 5000 = " + ls[i].MoneyWater.ToString();
                    a1merge = "A" + (j + 4).ToString() + ":D" + (j + 4).ToString();
                    exSheet.Range[a1merge].Merge();
                  
                    a1merge = "A" + (j + 5).ToString() + ":D" + (j + 5).ToString();
                    exSheet.Range[a1merge].Merge();
                    app.Range r0 = exSheet.Cells[j + 5, 1];
                    r0.Value = "Tổng cộng = " + ls[i].Total.ToString();
                    a1merge = "A" + j.ToString() + ":D" + (j + 5).ToString();

                    app.Borders borders = exSheet.Range[a1merge].Borders;
                    borders.LineStyle = app.XlLineStyle.xlContinuous;
                    borders.Weight = 2d;
                    exSheet.Range[a1merge].HorizontalAlignment = 3;
                    exSheet.Range[a1merge].VerticalAlignment = 3;
                    //var b = exSheet.Range[a1merge];
                    //b.BorderAround2(app.XlLineStyle.xlContinuous, app.XlBorderWeight.xlMedium, app.XlColorIndex.xlColorIndexAutomatic, app.XlColorIndex.xlColorIndexAutomatic);
                }
                j += 7;
            }
            //app.Range r = (app.Range)exSheet.Cells[1, 1];
            //r.Value = "Demo excel value";
            //r.Columns.AutoFit();
            exapp.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.GetAllValuesByTime(datetimepicker.Value.Month);
        }
    }
}
