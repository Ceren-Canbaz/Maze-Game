using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_oyunu
{
	public partial class Form1 : Form
	{
		System.Media.SoundPlayer startsound = new System.Media.SoundPlayer(@"C:\Windows\Media\Alarm10.wav");
		System.Media.SoundPlayer finishsound = new System.Media.SoundPlayer(@"C:\Windows\Media\Alarm05.wav");
		public Form1()
		{
			InitializeComponent();
			MovetoStart();
		}

		private void lblfinish_MouseEnter(object sender, EventArgs e)
		{
			finishsound.Play();
			//moues enter eventinde tıklamaya gerek yok mouse üstüne geldiği gibi aktif olur 
			MessageBox.Show("Helal");
			Close();
		}
		private void MovetoStart()
		{
			startsound.Play();
			//lokasyon verilirken point kullanılır
			Point startingPoint = panel1.Location;
			startingPoint.Offset(10, 10); //hem y için hem x için 10'ar birim hareket ettirdik.
			Cursor.Position = PointToScreen(startingPoint);
		}

		private void wall_MouseEnter(object sender, EventArgs e)
		{
			MovetoStart();
		}
	}
}
