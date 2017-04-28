

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;


namespace Tomogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        Bin bin = new Bin();
        View view = new View();
        bool loaded = false;
        int currentLayer=1;
        int frameCount=0;
        DateTime nextFPSUpdate = DateTime.Now.AddSeconds(1);
        bool needReload = false;
        bool Texture = true;
        bool Quad = false;
        public static int startTF = 0;
        public int widthTF = 4;

        void displayFPS()
        {
            if (DateTime.Now >= nextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps = {0})", frameCount);
                nextFPSUpdate = DateTime.Now.AddSeconds(1);
                frameCount = 0;
            }
            frameCount++;
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
            }
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (Quad)
                    view.DrawQuads(currentLayer,startTF,widthTF);
                else
                {
                    if (needReload)
                    {
                        view.generateTextureImage(currentLayer,startTF,widthTF);
                        view.Load2DTexture();
                        needReload = false;
                    }
                    view.drawTexture();
                }
                glControl1.SwapBuffers();

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            if (Quad)
                view.DrawQuads(currentLayer,startTF,widthTF);
            else
                needReload = true;
            glControl1.SwapBuffers();

            
        }

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

       
        private void glControl1_Load(object sender, EventArgs e)
        {
            Application.Idle+=Application_Idle;
        }

        private void quadsBottom_Click(object sender, EventArgs e)
        {
            Texture = !Texture;
            Quad = !Quad;
        }

        private void textureBotton_Click(object sender, EventArgs e)
        {
            Texture = !Texture;
            Quad = !Quad;
        }

        private void trackBarStartPoint_Scroll(object sender, EventArgs e)
        {
            startTF = trackBarStartPoint.Value;
            trackBar1_Scroll(sender,e);
        }

        private void trackBarWidthOfTF_Scroll(object sender, EventArgs e)
        {
            widthTF = trackBarWidthOfTF.Value;
            trackBar1_Scroll(sender, e);
        }

       



    }
}
