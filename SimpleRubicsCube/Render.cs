﻿using System.Collections.Generic;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using System;
using System.Windows.Forms;

namespace SimpleRubicsCube
{
    public enum colors
    {
        BLACK = 0,
        RED = 1,
        BLUE = 2,
        GREEN = 4,
        WHITE = 8,
        ORANGE = 16,
        YELLOW = 32,
    }

    public enum sides
    {
        NONE = 0,
        FRONT = 1,
        BACK = 2,
        LEFT = 4,
        RIGHT = 8,
        TOP = 16,
        BOTTOM = 32
    }

    public enum directions
    {
        NONE = 0,
        UP = 1,
        DOWN = 2,
        LEFT = 4,
        RIGHT = 8
    }

    abstract public class Render
    {
        unsafe public static void init(ref SimpleOpenGlControl canvas)
        {
            graphics = canvas;
            graphics.InitializeContexts();
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glClearColor(0.94f, 0.94f, 0.94f, 1);
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

        private static double rotationAngleX = 0;
        private static double rotationAngleY = 0;

        private static Quaternion rotationQuatX = new Quaternion(1, 0, 0, rotationAngleX);
        private static Quaternion rotationQuatY = new Quaternion(0, 1, 0, rotationAngleY);

        private static float[] modelView = new float[16];

        private static int rotationTics = 0; // one rotation is done in 100 tics

        private static double rotationAngle
        {
            set
            {
                
                switch (RubiksCube.rotatingDirection)
                {
                    case (int)directions.UP:
                        rotationAngleX += value;
                        break;
                    case (int)directions.DOWN:
                        rotationAngleX -= value;
                        break;
                    case (int)directions.LEFT:
                        rotationAngleY -= value;
                        break;
                    case (int)directions.RIGHT:
                        rotationAngleY += value;
                        break;
                    default: break;
                }

                rotationQuatX = new Quaternion(1, 0, 0, rotationAngleX);
                rotationQuatY = new Quaternion(0, 1, 0, rotationAngleY);
            }
        }


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
                    Gl.glColor3d(1, 0.30, 0);
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


            if (RubiksCube.isCubeRotating)
            {
                rotationAngle = (float)9 / (float)10;
                rotationTics++;
                if (rotationTics == 100)
                {
                    RubiksCube.stopCubeRotating();
                    rotationTics = 0;
                    rotationAngleX = 0;
                    rotationAngleY = 0;
                    //Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, modelView);
                }
                
            }

            double[] rotationMatrixX = new double[16];
            double[] rotationMatrixY = new double[16];

            rotationQuatX.createMatrix(ref rotationMatrixX);
            rotationQuatY.createMatrix(ref rotationMatrixY);

            Gl.glMultMatrixd(rotationMatrixX);
            Gl.glMultMatrixd(rotationMatrixY);

            foreach (var piece in pieces)
                piece.draw();


            Gl.glFlush();
            graphics.Invalidate();
        }

        public class CubePiece
        {
            public CubePiece(int side1Color, int side1,
                             int side2Color, int side2,
                             int side3Color, int side3,
                             double x, double y, double z)
            {
                this.side1Color = side1Color;
                this.side1 = side1;
                this.side2Color = side2Color;
                this.side2 = side2;
                this.side3Color = side3Color;
                this.side3 = side3;
                this.x = x;
                this.y = y;
                this.z = z;
                pieces.Add(this);
            }
            public int side1Color { get;}
            public int side2Color { get; }
            public int side3Color { get; }
            public int side1 { get; }
            public int side2 { get; }
            public int side3 { get; }
            public double x { get; }
            public double y { get; }
            public double z { get; }

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
                Gl.glScaled(0.15, 0.15, 0.15);
                Gl.glTranslated(x,y,z);
                Glut.glutWireCube(1.001); // to prevent Z-fighting we make wireCube 0.001 points larger         

                setColor(side1Color);
                drawFace(side1);

                setColor(side2Color);
                drawFace(side2);

                setColor(side3Color);
                drawFace(side3);

                foreach (int i in Enum.GetValues(typeof(sides)))
                    if (i != side1 && i != side2 && i != side3)
                    {
                        setColor((int)colors.BLACK);
                        drawFace(i);
                    }

                Gl.glPopMatrix();
            }

        }

    }
}
