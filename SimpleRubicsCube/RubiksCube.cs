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

            CubeRectangle frontSide;
            CubeRectangle middleSide;
            CubeRectangle farSide;
            

        }
        private Render.CubePiece[,,] pieces;

        /*** this structure represents cube's 3x3 side  ***/
        private struct CubeRectangle
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
