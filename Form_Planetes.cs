using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planetes
{
    public partial class Form_Planetes : Form
    {
        private bool glLoaded = false;

        private Planet planet = new Planet();

        public Form_Planetes()
        {
            InitializeComponent();
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            glLoaded = true;
            SetupViewport();
            GL.ClearColor(Color.White);
            GL.Enable(EnableCap.DepthTest);

            // Параметры освещения.
            var specularMatrix = new[] { 1.0f, 1.0f, 1.0f, 1.0f };
            var shininessMatrix = new[] { 50.0f };
            var whiteLight = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
            GL.ShadeModel(ShadingModel.Smooth);
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, specularMatrix);
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, shininessMatrix);
            GL.Light(LightName.Light0, LightParameter.Position, new Vector4(1.0f, 1.0f, 1.0f, 0.0f));
            GL.Light(LightName.Light0, LightParameter.Diffuse, whiteLight);
            GL.Light(LightName.Light0, LightParameter.Specular, whiteLight);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
        }

        private void glControl_Resize(object sender, EventArgs e)
        {
            if (!glLoaded)
                return;

            SetupViewport();
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            if (!glLoaded)
                return;
            
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 modelview = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);
            GL.Translate(0.0f, 0.0f, 5.0f);

            GL.Color3(Color.Blue);
            GL.PolygonMode(MaterialFace.Front, PolygonMode.Fill);
            planet.Draw(trackBar_levelOfDetail.Value);

            glControl.SwapBuffers();
        }

        private void SetupViewport()
        {
            var aspect = glControl.Width / (float)glControl.Height;

            GL.Viewport(0, 0, glControl.Width, glControl.Height);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, aspect, 1.0f, 100.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        private void trackBar_levelOfDetail_ValueChanged(object sender, EventArgs e)
        {
            glControl.Refresh();
        }
    }
}
