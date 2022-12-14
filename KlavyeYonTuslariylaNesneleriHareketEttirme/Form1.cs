using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlavyeYonTuslariylaNesneleriHareketEttirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X; //sağ ve sol koordinatlar 
            int y = pictureBox1.Location.Y; //aşağı ve yukarı koordinatlar

            // + ve - değerlerinin sebebi grafik ekseninde x ve y koordinatlarıında sağ-sol ve yukarı-aşağı taraflaraa doğru değerlerin artış ve azalış miktarına göre konumlandırılmalarıdır.

            if (e.KeyCode == Keys.Right && x < 880)
            {
                x += 5; 
            }

            if (e.KeyCode == Keys.Left && x > 0)
            {
                x -= 5;
            }
            if (e.KeyCode == Keys.Up && x > 0)
            {
                y -= 5;
            }

            if (e.KeyCode == Keys.Down && x < 880)
            {
                y += 5;
            }

            pictureBox1.Location = new Point(x, y); //x ve y koordinatları
        }
    }
}
