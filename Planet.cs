using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetes
{
    public class Planet
    {
        private const float x = 0.525731112119133606f;
        private const float z = 0.850650808352039932f;
        private static Vector3[] vdata =
        {
            new Vector3(-x, 0.0f, z),
            new Vector3(x, 0.0f, z),
            new Vector3(-x, 0.0f, -z),
            new Vector3(x, 0.0f, -z),
            new Vector3(0.0f, z, x),
            new Vector3(0.0f, z, -x),
            new Vector3(0.0f, -z, x),
            new Vector3(0.0f, -z, -x),
            new Vector3(z, x, 0.0f),
            new Vector3(-z, x, 0.0f),
            new Vector3(z, -x, 0.0f),
            new Vector3(-z, -x, 0.0f)
        };
        private static int[,] tindices =
        {
            {1, 4, 0}, {4, 9, 0}, {4, 5, 9}, {8, 5, 4}, {1, 8, 4},
            {1, 10, 8}, {10, 3, 8}, {8, 3, 5}, {3, 2, 5}, {3, 7, 2},
            {3, 10, 7}, {10, 6, 7}, {6, 11, 7}, {6, 0, 11}, {6, 1, 0},
            {10, 1, 6}, {11, 0, 9}, {2, 11, 9}, {5, 2, 9}, {11, 2, 7}
        };

        public void Draw(int quality)
        {
            for (int i = 0; i < 20; i++)
                Subdivine(vdata[tindices[i, 0]], vdata[tindices[i, 1]], vdata[tindices[i, 2]], quality);
        }
 
        private void Subdivine(Vector3 v1, Vector3 v2, Vector3 v3, int depth) 
        {
            if (depth <= 0)
                DrawTriangle(v1, v2, v3);
            else
            {
                var v12 = new Vector3();
                var v23 = new Vector3();
                var v31 = new Vector3();

                for (int i = 0; i < 3; i++)
                {
                    v12[i] = (v1[i] + v2[i]) / 2.0f;
                    v23[i] = (v2[i] + v3[i]) / 2.0f;
                    v31[i] = (v3[i] + v1[i]) / 2.0f;
                }
                v12 = Vector3.Normalize(v12);
                v23 = Vector3.Normalize(v23);
                v31 = Vector3.Normalize(v31);

                depth--;
                Subdivine(v1, v12, v31, depth);
                Subdivine(v2, v23, v12, depth);
                Subdivine(v3, v31, v23, depth);
                Subdivine(v12, v23, v31, depth);
            }
        }

        private void DrawTriangle(Vector3 v1, Vector3 v2, Vector3 v3)
        {
            GL.Begin(PrimitiveType.Triangles);

            GL.Normal3(v1);
            GL.Vertex3(v1);
            GL.Normal3(v2);
            GL.Vertex3(v2);
            GL.Normal3(v3);
            GL.Vertex3(v3);

            GL.End();
        }
    }
}
