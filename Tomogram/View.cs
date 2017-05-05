

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Drawing;
using System.Drawing.Imaging;
namespace Tomogram
{
    class View
    {
        int VBOtexture;
        Bitmap textureImage;

        public void generateTextureImage(int layerNumber,int _startTF, int _widthTF)
        {
            textureImage = new Bitmap(Bin.X, Bin.Y);
            for (int i = 0; i < Bin.X; ++i)
                for (int j = 0; j < Bin.Y; ++j)
                {
                    int pixelNumber = i + j * Bin.X + layerNumber * Bin.X * Bin.Y;
                    textureImage.SetPixel(i,j,TransferFunction(Bin.array[pixelNumber], _startTF,  _widthTF));
                }
        }

        public void drawTexture()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture);

            GL.Begin(BeginMode.Quads);
            GL.Color3(Color.White);
            GL.TexCoord2(0f, 0f);
            GL.Vertex2(0, 0);
            GL.TexCoord2(0f, 1f);
            GL.Vertex2(0f, Bin.Y);
            GL.TexCoord2(1f, 1f);
            GL.Vertex2(Bin.X, Bin.Y);
            GL.TexCoord2(1f, 0f);
            GL.Vertex2(Bin.X, 0f);
            GL.End();

            GL.Disable(EnableCap.Texture2D);
        }

        public void Load2DTexture()
        {
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture);
            BitmapData data = textureImage.LockBits
                (
                    new System.Drawing.Rectangle(0,0,textureImage.Width,textureImage.Height),
                    ImageLockMode.ReadOnly,
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb
                );
            GL.TexImage2D(TextureTarget.Texture2D,0,PixelInternalFormat.Rgba,
                data.Width, data.Height,0,OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);

            textureImage.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            ErrorCode Er = GL.GetError();
            string str = Er.ToString();
        }

        public int clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public void SetupView(int width, int height)
        {
            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Bin.X, 0, Bin.Y, -1, 1);
            GL.Viewport(0, 0, width, height);
        }

        Color TransferFunction(short value, int _startTF, int _widthTF)
        {
            int min = _startTF;
            int max = _startTF*10+_widthTF*100;
            int newVal = clamp((value - min) * 255 / (max - min), 0, 255);
            return Color.FromArgb(255, newVal, newVal, newVal);
        }

        public void DrawQuads(int layerNumber, int _startTF, int _widthTF)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin(BeginMode.Quads);
            for (int x_coord=0;x_coord<Bin.X-1;x_coord++)
                for (int y_coord = 0; y_coord < Bin.Y - 1; y_coord++)
                {
                    short value;
                    value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value, _startTF,  _widthTF));
                    GL.Vertex2(x_coord, y_coord);

                    value = Bin.array[x_coord+(y_coord+1)*Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value, _startTF, _widthTF));
                    GL.Vertex2(x_coord, y_coord + 1);

                    value = Bin.array[x_coord + 1 + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value, _startTF, _widthTF));
                    GL.Vertex2(x_coord + 1, y_coord + 1);

                    value = Bin.array[x_coord +1 + y_coord  * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value, _startTF, _widthTF));
                    GL.Vertex2(x_coord + 1, y_coord);
                }
            GL.End();
        }
        public void DrawQuadsStrip(int layerNumber, int _startTF, int _widthTF)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            /*GL.Begin(BeginMode.QuadStrip);
            short value;
            value = Bin.array[layerNumber * Bin.X * Bin.Y];
            GL.Color3(TransferFunction(value, _startTF, _widthTF));
            GL.Vertex2(0,0);

            value = Bin.array[ Bin.X + layerNumber * Bin.X * Bin.Y];
            GL.Color3(TransferFunction(value, _startTF, _widthTF));
            GL.Vertex2(0,1);

            value = Bin.array[1 + Bin.X + layerNumber * Bin.X * Bin.Y];
            GL.Color3(TransferFunction(value, _startTF, _widthTF));
            GL.Vertex2(1,1);

            value = Bin.array[1+layerNumber * Bin.X * Bin.Y];
            GL.Color3(TransferFunction(value, _startTF, _widthTF));
            GL.Vertex2(1,0);*/
            for (int x_coord = 1; x_coord < Bin.X - 1; x_coord++)
            {
                GL.Begin(BeginMode.QuadStrip);
                for (int y_coord = 1; y_coord < Bin.Y - 1; y_coord++)
                {
                    short value;
                    value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value, _startTF, _widthTF));
                    GL.Vertex2(x_coord, y_coord);

                    value = Bin.array[x_coord + 1 + (y_coord) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value, _startTF, _widthTF));
                    GL.Vertex2(x_coord+1, y_coord);
                }
                GL.End();
            }
        }
    }
}
