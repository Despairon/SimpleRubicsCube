using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRubicsCube
{
    /*** this class represents Rubik's cube (obviously), that consists of structures that are the
     *   parts of a whole cube, and, of course, a class has implemented functionallity ***/
    public abstract class RubiksCube
    {
        public static void buildCube()
        {
            cubeMatrix  = new Render.CubePiece[3, 3, 3];

            frontMatrix = new Render.CubePiece[3, 3];
            backMatrix  = new Render.CubePiece[3, 3];
            leftMatrix  = new Render.CubePiece[3, 3];
            rightMatrix = new Render.CubePiece[3, 3];
            topMatrix   = new Render.CubePiece[3, 3];
            botMatrix   = new Render.CubePiece[3, 3];

            CubeSide frontSide;
            CubeSide middleSide;
            CubeSide farSide;

            frontSide.left.topPiece = new Render.CubePiece((int)colors.WHITE, (int)sides.FRONT,
                                                             (int)colors.RED, (int)sides.LEFT,
                                                             (int)colors.GREEN, (int)sides.TOP,
                                                              1, 1, -1);
            frontSide.left.midPiece = new Render.CubePiece((int)colors.YELLOW, (int)sides.FRONT,
                                                             (int)colors.BLUE, (int)sides.LEFT,
                                                             (int)colors.BLACK, (int)sides.TOP,
                                                              1, 0, -1);
            frontSide.left.botPiece = new Render.CubePiece((int)colors.WHITE, (int)sides.FRONT,
                                                             (int)colors.RED, (int)sides.LEFT,
                                                             (int)colors.BLUE, (int)sides.BOTTOM,
                                                              1, -1, -1);

            frontSide.middle.topPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.FRONT,
                                                             (int)colors.BLUE, (int)sides.TOP,
                                                             (int)colors.BLACK, (int)sides.BOTTOM,
                                                              0, 1, -1);
            frontSide.middle.midPiece = new Render.CubePiece((int)colors.GREEN, (int)sides.FRONT,
                                                             (int)colors.BLACK, (int)sides.TOP,
                                                             (int)colors.BLACK, (int)sides.BOTTOM,
                                                              0, 0, -1);
            frontSide.middle.botPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.FRONT,
                                                             (int)colors.GREEN, (int)sides.BOTTOM,
                                                             (int)colors.BLACK, (int)sides.TOP,
                                                              0, -1, -1);

            frontSide.right.topPiece = new Render.CubePiece((int)colors.BLUE, (int)sides.FRONT,
                                                             (int)colors.YELLOW, (int)sides.RIGHT,
                                                             (int)colors.ORANGE, (int)sides.TOP,
                                                             -1, 1, -1);
            frontSide.right.midPiece = new Render.CubePiece((int)colors.GREEN, (int)sides.FRONT,
                                                             (int)colors.WHITE, (int)sides.RIGHT,
                                                             (int)colors.BLACK, (int)sides.TOP,
                                                             -1, 0, -1);
            frontSide.right.botPiece = new Render.CubePiece((int)colors.WHITE, (int)sides.FRONT,
                                                             (int)colors.GREEN, (int)sides.RIGHT,
                                                             (int)colors.ORANGE, (int)sides.BOTTOM,
                                                             -1, -1, -1);


            middleSide.left.topPiece = new Render.CubePiece((int)colors.YELLOW, (int)sides.LEFT,
                                                              (int)colors.GREEN, (int)sides.TOP,
                                                              (int)colors.BLACK, (int)sides.RIGHT,
                                                               1, 1, 0);
            middleSide.left.midPiece = new Render.CubePiece((int)colors.WHITE, (int)sides.LEFT,
                                                              (int)colors.BLACK, (int)sides.RIGHT,
                                                              (int)colors.BLACK, (int)sides.TOP,
                                                               1, 0, 0);
            middleSide.left.botPiece = new Render.CubePiece((int)colors.RED, (int)sides.LEFT,
                                                              (int)colors.BLUE, (int)sides.BOTTOM,
                                                              (int)colors.BLACK, (int)sides.RIGHT,
                                                               1, -1, 0);

            middleSide.middle.topPiece = new Render.CubePiece((int)colors.RED, (int)sides.TOP,
                                                              (int)colors.BLACK, (int)sides.BACK,
                                                              (int)colors.BLACK, (int)sides.BOTTOM,
                                                               0, 1, 0);
            middleSide.middle.midPiece = new Render.CubePiece((int)colors.BLACK, (int)sides.FRONT,
                                                              (int)colors.BLACK, (int)sides.TOP,
                                                              (int)colors.BLACK, (int)sides.BOTTOM,
                                                               0, 0, 0);
            middleSide.middle.botPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.BOTTOM,
                                                              (int)colors.BLACK, (int)sides.FRONT,
                                                              (int)colors.BLACK, (int)sides.TOP,
                                                               0, -1, 0);

            middleSide.right.topPiece = new Render.CubePiece((int)colors.YELLOW, (int)sides.RIGHT,
                                                              (int)colors.RED, (int)sides.TOP,
                                                              (int)colors.BLACK, (int)sides.LEFT,
                                                              -1, 1, 0);
            middleSide.right.midPiece = new Render.CubePiece((int)colors.YELLOW, (int)sides.RIGHT,
                                                              (int)colors.BLACK, (int)sides.FRONT,
                                                              (int)colors.BLACK, (int)sides.LEFT,
                                                              -1, 0, 0);
            middleSide.right.botPiece = new Render.CubePiece((int)colors.YELLOW, (int)sides.RIGHT,
                                                              (int)colors.ORANGE, (int)sides.BOTTOM,
                                                              (int)colors.ORANGE, (int)sides.LEFT,
                                                              -1, -1, 0);

            farSide.left.topPiece = new Render.CubePiece((int)colors.GREEN, (int)sides.LEFT,
                                                              (int)colors.YELLOW, (int)sides.TOP,
                                                              (int)colors.RED, (int)sides.BACK,
                                                               1, 1, 1);
            farSide.left.midPiece = new Render.CubePiece((int)colors.RED, (int)sides.LEFT,
                                                              (int)colors.GREEN, (int)sides.BACK,
                                                              (int)colors.BLACK, (int)sides.RIGHT,
                                                               1, 0, 1);
            farSide.left.botPiece = new Render.CubePiece((int)colors.BLUE, (int)sides.LEFT,
                                                              (int)colors.RED, (int)sides.BACK,
                                                              (int)colors.YELLOW, (int)sides.BOTTOM,
                                                               1, -1, 1);

            farSide.middle.topPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.BACK,
                                                              (int)colors.WHITE, (int)sides.TOP,
                                                              (int)colors.BLACK, (int)sides.FRONT,
                                                               0, 1, 1);
            farSide.middle.midPiece = new Render.CubePiece((int)colors.BLUE, (int)sides.BACK,
                                                              (int)colors.BLACK, (int)sides.FRONT,
                                                              (int)colors.BLACK, (int)sides.BOTTOM,
                                                               0, 0, 1);
            farSide.middle.botPiece = new Render.CubePiece((int)colors.RED, (int)sides.BACK,
                                                              (int)colors.WHITE, (int)sides.BOTTOM,
                                                              (int)colors.BLACK, (int)sides.FRONT,
                                                               0, -1, 1);

            farSide.right.topPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.BACK,
                                                              (int)colors.BLUE, (int)sides.RIGHT,
                                                              (int)colors.WHITE, (int)sides.TOP,
                                                              -1, 1, 1);
            farSide.right.midPiece = new Render.CubePiece((int)colors.WHITE, (int)sides.BACK,
                                                              (int)colors.BLUE, (int)sides.RIGHT,
                                                              (int)colors.BLACK, (int)sides.LEFT,
                                                              -1, 0, 1);
            farSide.right.botPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.BACK,
                                                              (int)colors.YELLOW, (int)sides.RIGHT,
                                                              (int)colors.GREEN, (int)sides.BOTTOM,
                                                              -1, -1, 1);

            cubeMatrix[0, 0, 0] = frontSide.left.topPiece; cubeMatrix[0, 1, 0] = frontSide.middle.topPiece; cubeMatrix[0, 2, 0] = frontSide.right.topPiece;
            cubeMatrix[0, 0, 1] = frontSide.left.midPiece; cubeMatrix[0, 1, 1] = frontSide.middle.midPiece; cubeMatrix[0, 2, 1] = frontSide.right.midPiece;
            cubeMatrix[0, 0, 2] = frontSide.left.botPiece; cubeMatrix[0, 1, 2] = frontSide.middle.botPiece; cubeMatrix[0, 2, 2] = frontSide.right.botPiece;

            cubeMatrix[1, 0, 0] = middleSide.left.topPiece; cubeMatrix[1, 1, 0] = middleSide.middle.topPiece; cubeMatrix[1, 2, 0] = middleSide.right.topPiece;
            cubeMatrix[1, 0, 1] = middleSide.left.midPiece; cubeMatrix[1, 1, 1] = middleSide.middle.midPiece; cubeMatrix[1, 2, 1] = middleSide.right.midPiece;
            cubeMatrix[1, 0, 2] = middleSide.left.botPiece; cubeMatrix[1, 1, 2] = middleSide.middle.botPiece; cubeMatrix[1, 2, 2] = middleSide.right.botPiece;

            cubeMatrix[2, 0, 0] = farSide.left.topPiece; cubeMatrix[2, 1, 0] = farSide.middle.topPiece; cubeMatrix[2, 2, 0] = farSide.right.topPiece;
            cubeMatrix[2, 0, 1] = farSide.left.midPiece; cubeMatrix[2, 1, 1] = farSide.middle.midPiece; cubeMatrix[2, 2, 1] = farSide.right.midPiece;
            cubeMatrix[2, 0, 2] = farSide.left.botPiece; cubeMatrix[2, 1, 2] = farSide.middle.botPiece; cubeMatrix[2, 2, 2] = farSide.right.botPiece;

            for (int i=0; i<3; i++)
                for (int j=0; j<3; j++)
                {
                    frontMatrix[i, j] = cubeMatrix[0,   i,  j];
                    backMatrix [i, j] = cubeMatrix[2,   i,  j];
                    leftMatrix [i, j] = cubeMatrix[2-i, 0,  j];
                    rightMatrix[i, j] = cubeMatrix[2-i, 2,  j];
                    topMatrix  [i, j] = cubeMatrix[2-i, j, 0];
                    botMatrix  [i, j] = cubeMatrix[2-i, j, 2];
                }

        }
        public static Render.CubePiece[,,] cubeMatrix   { get; private set; }

        public static Render.CubePiece[,]  frontMatrix  { get; private set; }
        public static Render.CubePiece[,]  backMatrix   { get; private set; }
        public static Render.CubePiece[,]  leftMatrix   { get; private set; }
        public static Render.CubePiece[,]  rightMatrix  { get; private set; }
        public static Render.CubePiece[,]  topMatrix    { get; private set; }
        public static Render.CubePiece[,]  botMatrix { get; private set; } 

        public static Main_form form { private get; set; }
        public  static bool isCubeRotating {   get; private set; } = false;
        public  static int rotatingDirection { get; private set; } = (int)directions.NONE;


        /*** this structure represents cube's 3x3 side  ***/
        private struct CubeSide
        {
            public Column left;
            public Column middle;
            public Column right;
            /*** this structure represents cube's 3x3 side's column of 3 pieces  ***/
            public struct Column
            {
                public Render.CubePiece topPiece;
                public Render.CubePiece midPiece;
                public Render.CubePiece botPiece;
            }
        }

        public static void startCubeRotating(int direction)
        {
            rotatingDirection = direction;
            isCubeRotating = true;
        }

        public static void stopCubeRotating()
        {
            rotatingDirection = (int)directions.NONE;
            isCubeRotating = false;
            form.Enabled = true;
        }

        public static void rotateCubeUp()
        {
            startCubeRotating((int)directions.UP);
        }

        public static void rotateCubeDown()
        {
            startCubeRotating((int)directions.DOWN);
        }

        public static void rotateCubeLeft()
        {
            startCubeRotating((int)directions.LEFT);
        }

        public static void rotateCubeRight()
        {
            startCubeRotating((int)directions.RIGHT);
        }
    }
}
