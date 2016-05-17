using System.Collections.Generic;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace SimpleRubicsCube
{
    enum colors { RED, BLUE, GREEN, WHITE, ORANGE, YELLOW, BLACK }
    enum sides { FRONT, BACK, LEFT, RIGHT, TOP, BOTTOM }

    abstract public class Render
    {
        public static void init(ref SimpleOpenGlControl canvas)
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

            pieces = new List<CubePiece>(27);
        }
        private static SimpleOpenGlControl graphics;
        public static List<CubePiece> pieces;
        //private static double i = 0;


        public static void setColor(int color)
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
                    Gl.glColor3d(0.9, 0.9, 0.9);
                    break;
                case (int)colors.YELLOW:
                    Gl.glColor3d(1, 1, 0);
                    break;
                case (int)colors.BLACK:
                    Gl.glColor3d(0, 0, 0);
                    break;
            }

        }

        private static void renderCamera()
        {
            Glu.gluLookAt(0.0, 0.0, -1.0,
                          0.0, 0.0, 0.0,
                          0.0, 1.0, 0.0);
        }

        public static void drawAll()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();

            renderCamera();

            //Gl.glPushMatrix();
            //Gl.glRotated(i,1,0,0);


            foreach (var cube in pieces)
                cube.draw();

            //Gl.glPopMatrix();
            //i += 0.5;

            Gl.glFlush();
            graphics.Invalidate();
        }

        public class CubePiece
        {
            public CubePiece(int side1Color, int side2Color, int side3Color)
            {
                this.side1Color = side1Color;
                this.side2Color = side2Color;
                this.side3Color = side3Color;
                pieces.Add(this);
            }
            public int side1Color { get;}
            public int side2Color { get; }
            public int side3Color { get; }


            private void drawFace(int side)
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
                        Gl.glRotated(90, 0, 1, 0);
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

            public void draw()
            {

                Gl.glPushMatrix();
                Gl.glColor3d(0, 0, 0);
                Gl.glScaled(0.2, 0.2, 0.2);
                Glut.glutWireCube(1.001); // to prevent Z-fighting we make wireCube 0.001 points larger         


                setColor(side1Color);
                drawFace((int)sides.FRONT);

                setColor(side2Color);
                drawFace((int)sides.LEFT);

                setColor(side3Color);
                drawFace((int)sides.TOP);

                setColor((int)colors.BLACK);
                drawFace((int)sides.BOTTOM);

                setColor((int)colors.BLACK);
                drawFace((int)sides.RIGHT);

                setColor((int)colors.BLACK);
                drawFace((int)sides.BACK);

                Gl.glPopMatrix();
            }

        }

    }
}
