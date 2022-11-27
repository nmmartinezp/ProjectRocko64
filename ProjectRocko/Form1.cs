using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRocko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CargeList CtrlListMusic = new CargeList();
        CargeUb CtrlUbMusic = new CargeUb();

        private void prueba()
        {
            //List<string> carga = CtrlListMusic.ReadList();

            //for(int i = 0; i < carga.Count; i++)
            //{
            //    ListMusic.Items.Add(carga[i]);
            //}

            //string cargaUb = CtrlUbMusic.ReadUb();

            //ListMusic.Items.Add(cargaUb);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prueba();
        }
    }
}
