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

namespace manager
{
    public partial class Add : Form
    {
        int valueRoom;
        List<RoomModel> list;
        AddController controller;
        public Add()
        {
            controller = new AddController();
            list = new List<RoomModel>();
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            valueRoom = 0;
            tbPhong.Text = valueRoom.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(new RoomModel(valueRoom, "p" + valueRoom, Int32.Parse(tbDien.Text), Int32.Parse(tbNuoc.Text)));
            if (valueRoom <22)
            valueRoom++;
            tbPhong.Text = valueRoom.ToString();
            tbNuoc.Text = "";
            tbDien.Text = "";
            this.tbDien.Focus();
            //tbDien.Text = controller.getElectric("p" + valueRoom.ToString(), dateTimePicker1.Value.Month).ToString();
            //tbNuoc.Text = controller.getWater("p" + valueRoom.ToString(), dateTimePicker1.Value.Month).ToString();
            //if (valueRoom >)
            //{
            //    tbDien.Text = list[valueRoom].Elec.ToString();
            //    tbNuoc.Text = list[valueRoom].Water.ToString();
            //}
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valueRoom > 0)
                valueRoom--;
            tbPhong.Text = valueRoom.ToString();
            tbDien.Text = list[valueRoom].Elec.ToString();
            tbNuoc.Text = list[valueRoom].Water.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
                list.Add(new RoomModel(valueRoom, "p" + valueRoom, Int32.Parse(tbDien.Text), Int32.Parse(tbNuoc.Text)));
            
            controller.writeDb(list, dateTimePicker1.Value);

        }
    }
}
