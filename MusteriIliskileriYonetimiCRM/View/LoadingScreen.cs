using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriIliskileriYonetimiCRM.View
{
    public partial class LoadingScreen : Form
    {
        Timer timer = new Timer();
        int sayac = 0;

        public LoadingScreen()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Sayac_Tick;
            timer.Start();
        }

        private void Sayac_Tick(object sender, EventArgs e)
        {
            sayac += 10;
            if(sayac > 50)
            {
                Form1.instance.ShowForm();
                this.Close();
            }
        }

      

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
