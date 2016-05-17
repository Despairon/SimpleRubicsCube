using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRubicsCube
{
    /*** this class represents Rubik's cube (obviously), that consists of structures that are the
     *   parts of a whole cube, and, of course, implemented functionallity ***/
    public class RubiksCube
    {
        public RubiksCube()
        {
            pieces = new Render.CubePiece[3, 3, 3];

            CubeSide frontSide;
            CubeSide middleSide;
            CubeSide farSide;

            frontSide.left.topPiece = new Render.CubePiece(  (int)colors.WHITE,  (int)sides.FRONT,
                                                             (int)colors.RED,    (int)sides.LEFT,
                                                             (int)colors.GREEN,  (int)sides.TOP,
                                                              1, 1, 0);
            frontSide.left.midPiece = new Render.CubePiece(  (int)colors.YELLOW, (int)sides.FRONT,
                                                             (int)colors.BLUE,   (int)sides.LEFT,
                                                             (int)colors.BLACK,  (int)sides.TOP,
                                                              1, 0, 0);
            frontSide.left.botPiece = new Render.CubePiece(  (int)colors.WHITE,  (int)sides.FRONT,
                                                             (int)colors.RED,    (int)sides.LEFT,
                                                             (int)colors.BLUE,   (int)sides.BOTTOM,
                                                              1, -1, 0);

            frontSide.middle.topPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.FRONT,
                                                             (int)colors.BLUE,   (int)sides.TOP,
                                                             (int)colors.BLACK,  (int)sides.BOTTOM,
                                                              0, 1, 0);
            frontSide.middle.midPiece = new Render.CubePiece((int)colors.GREEN,  (int)sides.FRONT,
                                                             (int)colors.BLACK,  (int)sides.TOP,
                                                             (int)colors.BLACK,  (int)sides.BOTTOM,
                                                              0, 0, 0);
            frontSide.middle.botPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.FRONT,
                                                             (int)colors.GREEN,  (int)sides.BOTTOM,
                                                             (int)colors.BLACK,  (int)sides.TOP,
                                                              0, -1, 0);

            frontSide.right.topPiece = new Render.CubePiece( (int)colors.BLUE,    (int)sides.FRONT,
                                                             (int)colors.YELLOW,  (int)sides.RIGHT,
                                                             (int)colors.ORANGE,  (int)sides.TOP,
                                                             -1, 1, 0);
            frontSide.right.midPiece = new Render.CubePiece( (int)colors.GREEN,   (int)sides.FRONT,
                                                             (int)colors.WHITE,   (int)sides.RIGHT,
                                                             (int)colors.BLACK,   (int)sides.TOP,
                                                             -1, 0, 0);
            frontSide.right.botPiece = new Render.CubePiece( (int)colors.WHITE,   (int)sides.FRONT,
                                                             (int)colors.GREEN,   (int)sides.RIGHT,
                                                             (int)colors.ORANGE,  (int)sides.BOTTOM,
                                                             -1, -1, 0);


            middleSide.left.topPiece = new Render.CubePiece((int)colors.YELLOW, (int)sides.LEFT,
                                                 (int)colors.GREEN, (int)sides.TOP,
                                                 (int)colors.BLACK, (int)sides.RIGHT,
                                                  1, 1, 1);
            middleSide.left.midPiece = new Render.CubePiece((int)colors.WHITE, (int)sides.LEFT,
                                                             (int)colors.BLACK, (int)sides.RIGHT,
                                                             (int)colors.BLACK, (int)sides.TOP,
                                                              1, 0, 1);
            middleSide.left.botPiece = new Render.CubePiece((int)colors.RED, (int)sides.LEFT,
                                                             (int)colors.BLUE, (int)sides.BOTTOM,
                                                             (int)colors.BLACK, (int)sides.RIGHT,
                                                              1, -1, 1);

            middleSide.middle.topPiece = new Render.CubePiece((int)colors.RED, (int)sides.TOP,
                                                             (int)colors.BLACK, (int)sides.BACK,
                                                             (int)colors.BLACK, (int)sides.BOTTOM,
                                                              0, 1, 1);
            middleSide.middle.midPiece = new Render.CubePiece((int)colors.BLACK, (int)sides.FRONT,
                                                             (int)colors.BLACK, (int)sides.TOP,
                                                             (int)colors.BLACK, (int)sides.BOTTOM,
                                                              0, 0, 1);
            middleSide.middle.botPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.BOTTOM,
                                                             (int)colors.BLACK, (int)sides.FRONT,
                                                             (int)colors.BLACK, (int)sides.TOP,
                                                              0, -1, 1);

            middleSide.right.topPiece = new Render.CubePiece((int)colors.YELLOW, (int)sides.RIGHT,
                                                             (int)colors.RED, (int)sides.TOP,
                                                             (int)colors.BLACK, (int)sides.LEFT,
                                                             -1, 1, 1);
            middleSide.right.midPiece = new Render.CubePiece((int)colors.YELLOW, (int)sides.RIGHT,
                                                             (int)colors.BLACK, (int)sides.FRONT,
                                                             (int)colors.BLACK, (int)sides.LEFT,
                                                             -1, 0, 1);
            middleSide.right.botPiece = new Render.CubePiece((int)colors.YELLOW, (int)sides.RIGHT,
                                                             (int)colors.ORANGE, (int)sides.BOTTOM,
                                                             (int)colors.ORANGE, (int)sides.LEFT,
                                                             -1, -1, 1);

            farSide.left.topPiece = new Render.CubePiece((int)colors.GREEN, (int)sides.LEFT,
                                                 (int)colors.YELLOW, (int)sides.TOP,
                                                 (int)colors.RED, (int)sides.BACK,
                                                  1, 1, 2);
            farSide.left.midPiece = new Render.CubePiece((int)colors.RED, (int)sides.LEFT,
                                                             (int)colors.GREEN, (int)sides.BACK,
                                                             (int)colors.BLACK, (int)sides.RIGHT,
                                                              1, 0, 2);
            farSide.left.botPiece = new Render.CubePiece((int)colors.BLUE, (int)sides.LEFT,
                                                             (int)colors.RED, (int)sides.BACK,
                                                             (int)colors.YELLOW, (int)sides.BOTTOM,
                                                              1, -1, 2);

            farSide.middle.topPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.BACK,
                                                             (int)colors.WHITE, (int)sides.TOP,
                                                             (int)colors.BLACK, (int)sides.FRONT,
                                                              0, 1, 2);
            farSide.middle.midPiece = new Render.CubePiece((int)colors.BLUE, (int)sides.BACK,
                                                             (int)colors.BLACK, (int)sides.FRONT,
                                                             (int)colors.BLACK, (int)sides.BOTTOM,
                                                              0, 0, 2);
            farSide.middle.botPiece = new Render.CubePiece((int)colors.RED, (int)sides.BACK,
                                                             (int)colors.WHITE, (int)sides.BOTTOM,
                                                             (int)colors.BLACK, (int)sides.FRONT,
                                                              0, -1, 2);

            farSide.right.topPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.BACK,
                                                             (int)colors.BLUE, (int)sides.RIGHT,
                                                             (int)colors.WHITE, (int)sides.TOP,
                                                             -1, 1, 2);
            farSide.right.midPiece = new Render.CubePiece((int)colors.WHITE, (int)sides.BACK,
                                                             (int)colors.BLUE, (int)sides.RIGHT,
                                                             (int)colors.BLACK, (int)sides.LEFT,
                                                             -1, 0, 2);
            farSide.right.botPiece = new Render.CubePiece((int)colors.ORANGE, (int)sides.BACK,
                                                             (int)colors.YELLOW, (int)sides.RIGHT,
                                                             (int)colors.GREEN, (int)sides.BOTTOM,
                                                             -1, -1, 2);


        }
        private Render.CubePiece[,,] pieces;

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
    }
}
