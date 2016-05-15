using System;
using System.Collections.Generic;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using System.Windows.Forms;

namespace SimpleRubicsCube
{
    enum colors { RED, BLUE, GREEN, WHITE, ORANGE, YELLOW }

    class Render
    {
        public Render(ref SimpleOpenGlControl canvas)
        {
            graphics = canvas;
            graphics.InitializeContexts();
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glClearColor(1, 1, 1, 1);
            Gl.glViewport(0, 0, graphics.Width, graphics.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)graphics.Width / (float)graphics.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
        }
        private SimpleOpenGlControl graphics;
        private static double i = 0;

        private void setColor(int color)
        {
            switch (color)
            {
                case (int)colors.BLUE:
                    Gl.glColor3d(0, 0, 1);
                    break;
                case (int)colors.GREEN:
                    Gl.glColor3d(0, 1, 0);
                    break;
                case (int)colors.ORANGE:
                    Gl.glColor3d(1, 0.62, 0);
                    break;
                case (int)colors.RED:
                    Gl.glColor3d(1, 0, 0);
                    break;
                case (int)colors.WHITE:
                    Gl.glColor3d(1, 1, 1);
                    break;
                case (int)colors.YELLOW:
                    Gl.glColor3d(1, 1, 0);
                    break;
            }

        }

        private void renderCamera()
        {
            Glu.gluLookAt(0.0, 0.0, -1.0,
                          0.0, 0.0, 0.0,
                          0.0, 1.0, 0.0);
        }

        private void drawCube(int faceColor, int sideColor)
        {

            Gl.glPushMatrix();
            Gl.glColor3d(0, 0, 0);
            Gl.glScaled(0.2,0.2,0.2);
            Gl.glRotated(-20,1,0,0);
            Gl.glRotated(i,0,1,0);
            Glut.glutWireCube(1.001); // to prevent Z-fighting we make wireCube 0.001 points larger
            Gl.glBegin(Gl.GL_TRIANGLES);

            /*** drawing face of a cube ***/

            setColor(faceColor);

            Gl.glVertex3d(-0.5, -0.5, 0.5);
            Gl.glVertex3d(-0.5, 0.5, 0.5);
            Gl.glVertex3d(0.5, -0.5, 0.5);

            Gl.glVertex3d(-0.5, 0.5, 0.5);
            Gl.glVertex3d(0.5, 0.5, 0.5);
            Gl.glVertex3d(0.5, -0.5, 0.5);

            /*** drawing side of a cube ***/

            Gl.glVertex3d(-0.5, -0.5, -0.5);
            Gl.glVertex3d(-0.5, 0.5, -0.5);
            Gl.glVertex3d(-0.5, -0.5, 0.5);

            Gl.glVertex3d(-0.5, 0.5, -0.5);
            Gl.glVertex3d(-0.5, 0.5, 0.5);
            Gl.glVertex3d(-0.5, -0.5, 0.5);

            Gl.glEnd();
            Gl.glPopMatrix();
            i+=0.5;
        }


        public void drawUpperSegment()
        {

        }

        public void drawMiddleSegment()
        {

        }

        public void drawLowerSegment()
        {

        }

        public void drawAll()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();

            renderCamera();
            drawCube((int)colors.BLUE,(int)colors.GREEN);

            Gl.glFlush();
            graphics.Invalidate();
        }
    }
}
