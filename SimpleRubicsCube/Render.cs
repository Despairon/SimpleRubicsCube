using System;
using System.Collections.Generic;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using System.Windows.Forms;

namespace SimpleRubicsCube
{
    enum colors { RED, BLUE, GREEN, WHITE, ORANGE, YELLOW, BLACK }
    enum sides { FRONT, BACK, LEFT, RIGHT, TOP, BOTTOM }

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
                case (int)colors.BLACK:
                    Gl.glColor3d(0, 0, 0);
                    break;
            }

        }

        private void renderCamera()
        {
            Glu.gluLookAt(0.0, 0.0, -1.0,
                          0.0, 0.0, 0.0,
                          0.0, 1.0, 0.0);
        }



        private void drawFaceOfaCube(int side)
        {
            Gl.glPushMatrix();

            switch (side)
            {
                case (int)sides.FRONT:
                    Gl.glTranslated(0, 0, -1);
                    break;
                case (int)sides.BACK:
                    break;
                case (int)sides.LEFT:
                    Gl.glRotated(90,0,1,0);
                    break;
                case (int)sides.RIGHT:
                    Gl.glRotated(-90, 0, 1, 0);
                    break;
                case (int)sides.TOP:
                    Gl.glRotated(-90, 1, 0, 0);
                    break;
                case (int)sides.BOTTOM:
                    Gl.glRotated(90, 1, 0, 0);
                    break;
            }

            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glVertex3d(-0.5, -0.5, 0.5);
            Gl.glVertex3d(-0.5, 0.5, 0.5);
            Gl.glVertex3d(0.5, -0.5, 0.5);

            Gl.glVertex3d(-0.5, 0.5, 0.5);
            Gl.glVertex3d(0.5, 0.5, 0.5);
            Gl.glVertex3d(0.5, -0.5, 0.5);

            Gl.glEnd();

            Gl.glPopMatrix();
            
        }

        private void drawCube(int side1Color, int side2Color, int side3Color)
        {

            Gl.glPushMatrix();
            Gl.glColor3d(0, 0, 0);
            Gl.glScaled(0.2,0.2,0.2);
            Glut.glutWireCube(1.001); // to prevent Z-fighting we make wireCube 0.001 points larger         


            setColor(side1Color);
            drawFaceOfaCube((int)sides.FRONT);

            setColor(side2Color);
            drawFaceOfaCube((int)sides.LEFT);

            setColor(side3Color);
            drawFaceOfaCube((int)sides.TOP);

            setColor((int)colors.BLACK);
            drawFaceOfaCube((int)sides.BOTTOM);

            setColor((int)colors.BLACK);
            drawFaceOfaCube((int)sides.RIGHT);

            setColor((int)colors.BLACK);
            drawFaceOfaCube((int)sides.BACK);

            Gl.glPopMatrix();
        }



        public void drawAll()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();

            renderCamera();
            drawCube((int)colors.BLUE,(int)colors.GREEN, (int)colors.RED);

            Gl.glFlush();
            graphics.Invalidate();
        }


    }
}
