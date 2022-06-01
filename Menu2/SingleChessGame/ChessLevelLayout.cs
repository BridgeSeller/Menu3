using System;

namespace Menu2.SingleChessGame
{
    public static class ChessLevelLayout
    {
        private static readonly CoordinatePiece[][] Lvl1 = new[]
        {
            new[]
            {
                new CoordinatePiece(1,5,new SingleChessPiece('B')),
                new CoordinatePiece(2,4,new SingleChessPiece('Q')),
            },
            new[]
            {
                new CoordinatePiece(0,0,new SingleChessPiece('B')),
                new CoordinatePiece(4,4,new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(5,5,new SingleChessPiece('R')),
                new CoordinatePiece(5,6,new SingleChessPiece('N'))
            },
            new[]
            {
                new CoordinatePiece(5,3,new SingleChessPiece('N')),
                new CoordinatePiece(6,1,new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(2,2,new SingleChessPiece('Q')),
                new CoordinatePiece(3,3,new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(0,0,new SingleChessPiece('Q')),
                new CoordinatePiece(1,1,new SingleChessPiece('K'))
            },
            new[]
            {
                new CoordinatePiece(7,7,new SingleChessPiece('K')),
                new CoordinatePiece(6,6,new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(3,5,new SingleChessPiece('B')),
                new CoordinatePiece(1,7,new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(4,6,new SingleChessPiece('K')),
                new CoordinatePiece(5,6,new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(5,6,new SingleChessPiece('N')),
                new CoordinatePiece(7,4,new SingleChessPiece('Q'))
            }
        };

        private static readonly CoordinatePiece[][] Lvl2 = new[]
        {
            new[]
            {
                new CoordinatePiece(2, 2, new SingleChessPiece('B')),
                new CoordinatePiece(2, 4, new SingleChessPiece('N')),
                new CoordinatePiece(4, 3, new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(4,7,new SingleChessPiece('B')),
                new CoordinatePiece(3,6,new SingleChessPiece('Q')),
                new CoordinatePiece(4,5,new SingleChessPiece('K'))
            },
            new[]
            {
                new CoordinatePiece(3,1,new SingleChessPiece('K')),
                new CoordinatePiece(4,0,new SingleChessPiece('Q')),
                new CoordinatePiece(4,1,new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(0,4,new SingleChessPiece('N')),
                new CoordinatePiece(0,7,new SingleChessPiece('B')),
                new CoordinatePiece(3,7,new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(0,1,new SingleChessPiece('B')),
                new CoordinatePiece(2,2,new SingleChessPiece('N')),
                new CoordinatePiece(0,4,new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(2,5,new SingleChessPiece('B')),
                new CoordinatePiece(4,5,new SingleChessPiece('Q')),
                new CoordinatePiece(6,5,new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(0,1,new SingleChessPiece('Q')),
                new CoordinatePiece(5,6,new SingleChessPiece('Q')),
                new CoordinatePiece(2,6,new SingleChessPiece('N')),
            },
            new[]
            {
                new CoordinatePiece(5,5,new SingleChessPiece('B')),
                new CoordinatePiece(5,6,new SingleChessPiece('R')),
                new CoordinatePiece(6,6,new SingleChessPiece('K')),
            },
            new[]
            {
                new CoordinatePiece(0,5,new SingleChessPiece('B')),
                new CoordinatePiece(1,3,new SingleChessPiece('K')),
                new CoordinatePiece(2,3,new SingleChessPiece('R')),
            },
            new[]
            {
                new CoordinatePiece(3,0,new SingleChessPiece('N')),
                new CoordinatePiece(5,1,new SingleChessPiece('B')),
                new CoordinatePiece(7,2,new SingleChessPiece('Q')),
            },
        };

        private static readonly CoordinatePiece[][] Lvl3 = new[]
        {
            new[]
            {
                new CoordinatePiece(4, 7, new SingleChessPiece('N')),
                new CoordinatePiece(5, 5, new SingleChessPiece('Q')),
                new CoordinatePiece(6, 5, new SingleChessPiece('R')),
                new CoordinatePiece(6, 6, new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(3,4,new SingleChessPiece('Q')),
                new CoordinatePiece(2,5,new SingleChessPiece('N')),
                new CoordinatePiece(3,7,new SingleChessPiece('K')),
                new CoordinatePiece(2,6,new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(0,3,new SingleChessPiece('N')),
                new CoordinatePiece(0,6,new SingleChessPiece('Q')),
                new CoordinatePiece(1,5,new SingleChessPiece('R')),
                new CoordinatePiece(1,1,new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(1,4,new SingleChessPiece('N')),
                new CoordinatePiece(1,5,new SingleChessPiece('K')),
                new CoordinatePiece(4,7,new SingleChessPiece('N')),
                new CoordinatePiece(2,6,new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(2,6,new SingleChessPiece('N')),
                new CoordinatePiece(2,0,new SingleChessPiece('Q')),
                new CoordinatePiece(5,6,new SingleChessPiece('R')),
                new CoordinatePiece(4,7,new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(5,4,new SingleChessPiece('N')),
                new CoordinatePiece(4,2,new SingleChessPiece('Q')),
                new CoordinatePiece(2,4,new SingleChessPiece('B')),
                new CoordinatePiece(4,7,new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(2,2,new SingleChessPiece('N')),
                new CoordinatePiece(2,1,new SingleChessPiece('R')),
                new CoordinatePiece(1,2,new SingleChessPiece('R')),
                new CoordinatePiece(0,3,new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(1,4,new SingleChessPiece('K')),
                new CoordinatePiece(2,5,new SingleChessPiece('Q')),
                new CoordinatePiece(2,6,new SingleChessPiece('B')),
                new CoordinatePiece(7,1,new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(6,4,new SingleChessPiece('Q')),
                new CoordinatePiece(6,0,new SingleChessPiece('Q')),
                new CoordinatePiece(2,0,new SingleChessPiece('R')),
                new CoordinatePiece(3,3,new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(5,6,new SingleChessPiece('N')),
                new CoordinatePiece(6,5,new SingleChessPiece('N')),
                new CoordinatePiece(0,0,new SingleChessPiece('B')),
                new CoordinatePiece(7,7,new SingleChessPiece('Q'))
            },
        };

        private static readonly CoordinatePiece[][] Lvl4 = new[]
        {
            new[]
            {
                new CoordinatePiece(2, 2, new SingleChessPiece('R')),
                new CoordinatePiece(2, 4, new SingleChessPiece('R')),
                new CoordinatePiece(2, 5, new SingleChessPiece('N')),
                new CoordinatePiece(5, 5, new SingleChessPiece('R')),
                new CoordinatePiece(4, 6, new SingleChessPiece('N')),
            },
            new[]
            {
                new CoordinatePiece(7, 6, new SingleChessPiece('Q')),
                new CoordinatePiece(5, 6, new SingleChessPiece('N')),
                new CoordinatePiece(5, 5, new SingleChessPiece('K')),
                new CoordinatePiece(5, 4, new SingleChessPiece('B')),
                new CoordinatePiece(3, 5, new SingleChessPiece('R')),
            },
            new[]
            {
                new CoordinatePiece(5, 5, new SingleChessPiece('K')),
                new CoordinatePiece(6, 4, new SingleChessPiece('N')),
                new CoordinatePiece(7, 4, new SingleChessPiece('B')),
                new CoordinatePiece(6, 3, new SingleChessPiece('R')),
                new CoordinatePiece(7, 2, new SingleChessPiece('B')),
            },
            new[]
            {
                new CoordinatePiece(6, 1, new SingleChessPiece('B')),
                new CoordinatePiece(7, 1, new SingleChessPiece('K')),
                new CoordinatePiece(7, 2, new SingleChessPiece('Q')),
                new CoordinatePiece(6, 4, new SingleChessPiece('N')),
                new CoordinatePiece(6, 5, new SingleChessPiece('R')),
            },
            new[]
            {
                new CoordinatePiece(4, 0, new SingleChessPiece('R')),
                new CoordinatePiece(6, 0, new SingleChessPiece('R')),
                new CoordinatePiece(7, 1, new SingleChessPiece('N')),
                new CoordinatePiece(5, 2, new SingleChessPiece('B')),
                new CoordinatePiece(6, 5, new SingleChessPiece('R')),
            },
        };

        private static readonly CoordinatePiece[][] Lvl5 = new[]
        {
            new[]
            {
                new CoordinatePiece(6, 1, new SingleChessPiece('B')),
                new CoordinatePiece(6, 3, new SingleChessPiece('N')),
                new CoordinatePiece(6, 7, new SingleChessPiece('B')),
                new CoordinatePiece(7, 6, new SingleChessPiece('B')),
                new CoordinatePiece(4, 2, new SingleChessPiece('R')),
                new CoordinatePiece(3, 4, new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(0, 3, new SingleChessPiece('R')),
                new CoordinatePiece(0, 7, new SingleChessPiece('N')),
                new CoordinatePiece(2, 2, new SingleChessPiece('N')),
                new CoordinatePiece(2, 4, new SingleChessPiece('B')),
                new CoordinatePiece(1, 7, new SingleChessPiece('R')),
                new CoordinatePiece(4, 5, new SingleChessPiece('N'))
            },
            new[]
            {
                new CoordinatePiece(3, 5, new SingleChessPiece('R')),
                new CoordinatePiece(6, 7, new SingleChessPiece('N')),
                new CoordinatePiece(7, 5, new SingleChessPiece('N')),
                new CoordinatePiece(7, 4, new SingleChessPiece('N')),
                new CoordinatePiece(6, 3, new SingleChessPiece('K')),
                new CoordinatePiece(5, 3, new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(0, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 1, new SingleChessPiece('N')),
                new CoordinatePiece(6, 2, new SingleChessPiece('K')),
                new CoordinatePiece(1, 6, new SingleChessPiece('N')),
                new CoordinatePiece(0, 7, new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(0, 2, new SingleChessPiece('B')),
                new CoordinatePiece(0, 3, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 4, new SingleChessPiece('Q')),
                new CoordinatePiece(3, 4, new SingleChessPiece('N')),
                new CoordinatePiece(4, 6, new SingleChessPiece('N')),
                new CoordinatePiece(4, 7, new SingleChessPiece('B'))
            }
        };

        private static readonly CoordinatePiece[][] Lvl6 = new[]
        {
            new[]
            {
                new CoordinatePiece(2,0,new SingleChessPiece('N')),
                new CoordinatePiece(2,3,new SingleChessPiece('Q')),
                new CoordinatePiece(1,4,new SingleChessPiece('B')),
                new CoordinatePiece(3,2,new SingleChessPiece('B')),
                new CoordinatePiece(4,1,new SingleChessPiece('K')),
                new CoordinatePiece(5,1,new SingleChessPiece('N')),
                new CoordinatePiece(7,2,new SingleChessPiece('N'))
            },
            new[]
            {
                new CoordinatePiece(7,0,new SingleChessPiece('B')),
                new CoordinatePiece(3,2,new SingleChessPiece('B')),
                new CoordinatePiece(4,3,new SingleChessPiece('Q')),
                new CoordinatePiece(4,5,new SingleChessPiece('Q')),
                new CoordinatePiece(2,4,new SingleChessPiece('N')),
                new CoordinatePiece(0,5,new SingleChessPiece('B')),
                new CoordinatePiece(1,6,new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(2,1,new SingleChessPiece('R')),
                new CoordinatePiece(2,7,new SingleChessPiece('Q')),
                new CoordinatePiece(6,3,new SingleChessPiece('N')),
                new CoordinatePiece(6,6,new SingleChessPiece('R')),
                new CoordinatePiece(6,7,new SingleChessPiece('B')),
                new CoordinatePiece(7,5,new SingleChessPiece('Q')),
                new CoordinatePiece(7,7,new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(3,0,new SingleChessPiece('N')),
                new CoordinatePiece(3,1,new SingleChessPiece('Q')),
                new CoordinatePiece(1,1,new SingleChessPiece('N')),
                new CoordinatePiece(2,2,new SingleChessPiece('N')),
                new CoordinatePiece(3,2,new SingleChessPiece('Q')),
                new CoordinatePiece(0,3,new SingleChessPiece('N')),
                new CoordinatePiece(4,4,new SingleChessPiece('N'))
            },
            new[]
            {
                new CoordinatePiece(1,1,new SingleChessPiece('K')),
                new CoordinatePiece(2,2,new SingleChessPiece('R')),
                new CoordinatePiece(1,2,new SingleChessPiece('R')),
                new CoordinatePiece(0,3,new SingleChessPiece('R')),
                new CoordinatePiece(2,3,new SingleChessPiece('B')),
                new CoordinatePiece(3,3,new SingleChessPiece('R')),
                new CoordinatePiece(4,1,new SingleChessPiece('B'))
            }
        };

        private static readonly CoordinatePiece[][] Lvl7 = new[]
        {
            new[]
            {
                new CoordinatePiece(2, 5, new SingleChessPiece('R')),
                new CoordinatePiece(4, 7, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 6, new SingleChessPiece('B')),
                new CoordinatePiece(4, 5, new SingleChessPiece('B')),
                new CoordinatePiece(5, 4, new SingleChessPiece('Q')),
                new CoordinatePiece(5, 5, new SingleChessPiece('K')),
                new CoordinatePiece(5, 6, new SingleChessPiece('R')),
                new CoordinatePiece(6, 4, new SingleChessPiece('N'))
            },
            new[]
            {
                new CoordinatePiece(4, 2, new SingleChessPiece('N')),
                new CoordinatePiece(4, 3, new SingleChessPiece('R')),
                new CoordinatePiece(3, 4, new SingleChessPiece('R')),
                new CoordinatePiece(2, 5, new SingleChessPiece('Q')),
                new CoordinatePiece(5, 3, new SingleChessPiece('B')),
                new CoordinatePiece(5, 4, new SingleChessPiece('R')),
                new CoordinatePiece(5, 5, new SingleChessPiece('R')),
                new CoordinatePiece(5, 6, new SingleChessPiece('N'))
            },
            new[]
            {
                new CoordinatePiece(7, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(3, 0, new SingleChessPiece('B')),
                new CoordinatePiece(4, 1, new SingleChessPiece('B')),
                new CoordinatePiece(5, 2, new SingleChessPiece('R')),
                new CoordinatePiece(0, 2, new SingleChessPiece('B')),
                new CoordinatePiece(2, 2, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 3, new SingleChessPiece('Q')),
                new CoordinatePiece(5, 4, new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(3, 0, new SingleChessPiece('R')),
                new CoordinatePiece(4, 1, new SingleChessPiece('N')),
                new CoordinatePiece(1, 2, new SingleChessPiece('N')),
                new CoordinatePiece(2, 3, new SingleChessPiece('K')),
                new CoordinatePiece(3, 3, new SingleChessPiece('N')),
                new CoordinatePiece(3, 6, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 6, new SingleChessPiece('R')),
                new CoordinatePiece(5, 3, new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(0, 2, new SingleChessPiece('N')),
                new CoordinatePiece(0, 5, new SingleChessPiece('N')),
                new CoordinatePiece(0, 7, new SingleChessPiece('B')),
                new CoordinatePiece(1, 4, new SingleChessPiece('N')),
                new CoordinatePiece(1, 5, new SingleChessPiece('N')),
                new CoordinatePiece(2, 6, new SingleChessPiece('B')),
                new CoordinatePiece(4, 7, new SingleChessPiece('N')),
                new CoordinatePiece(6, 2, new SingleChessPiece('B'))
            }
        };

        private static readonly CoordinatePiece[][] Lvl8 = new[]
        {
            new[]
            {
                new CoordinatePiece(4, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 2, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 1, new SingleChessPiece('N')),
                new CoordinatePiece(2, 2, new SingleChessPiece('N')),
                new CoordinatePiece(0, 3, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 3, new SingleChessPiece('N')),
                new CoordinatePiece(4, 3, new SingleChessPiece('K')),
                new CoordinatePiece(3, 3, new SingleChessPiece('R')),
                new CoordinatePiece(2, 5, new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(2, 0, new SingleChessPiece('R')),
                new CoordinatePiece(3, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(6, 0, new SingleChessPiece('R')),
                new CoordinatePiece(4, 1, new SingleChessPiece('N')),
                new CoordinatePiece(5, 1, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 1, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 2, new SingleChessPiece('B')),
                new CoordinatePiece(7, 2, new SingleChessPiece('N')),
                new CoordinatePiece(1, 7, new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(0, 1, new SingleChessPiece('B')),
                new CoordinatePiece(0, 7, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 3, new SingleChessPiece('B')),
                new CoordinatePiece(2, 3, new SingleChessPiece('Q')),
                new CoordinatePiece(2, 5, new SingleChessPiece('Q')),
                new CoordinatePiece(3, 2, new SingleChessPiece('B')),
                new CoordinatePiece(3, 4, new SingleChessPiece('N')),
                new CoordinatePiece(6, 1, new SingleChessPiece('B')),
                new CoordinatePiece(6, 5, new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(1, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 1, new SingleChessPiece('R')),
                new CoordinatePiece(0, 2, new SingleChessPiece('N')),
                new CoordinatePiece(3, 2, new SingleChessPiece('N')),
                new CoordinatePiece(0, 3, new SingleChessPiece('N')),
                new CoordinatePiece(6, 6, new SingleChessPiece('B')),
                new CoordinatePiece(5, 7, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 7, new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(3, 3, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 3, new SingleChessPiece('B')),
                new CoordinatePiece(0, 4, new SingleChessPiece('N')),
                new CoordinatePiece(1, 5, new SingleChessPiece('B')),
                new CoordinatePiece(1, 6, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 6, new SingleChessPiece('B')),
                new CoordinatePiece(0, 7, new SingleChessPiece('R')),
                new CoordinatePiece(3, 7, new SingleChessPiece('Q')),
                new CoordinatePiece(6, 7, new SingleChessPiece('R'))
            }
        };

        private static readonly CoordinatePiece[][] Lvl9 = new[]
        {
            new[]
            {
                new CoordinatePiece(0, 1, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 1, new SingleChessPiece('R')),
                new CoordinatePiece(2, 2, new SingleChessPiece('N')),
                new CoordinatePiece(0, 3, new SingleChessPiece('R')),
                new CoordinatePiece(1, 4, new SingleChessPiece('B')),
                new CoordinatePiece(2, 4, new SingleChessPiece('B')),
                new CoordinatePiece(2, 5, new SingleChessPiece('N')),
                new CoordinatePiece(4, 5, new SingleChessPiece('N')),
                new CoordinatePiece(0, 7, new SingleChessPiece('N')),
                new CoordinatePiece(1, 7, new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(1, 2, new SingleChessPiece('B')),
                new CoordinatePiece(2, 3, new SingleChessPiece('B')),
                new CoordinatePiece(4, 3, new SingleChessPiece('B')),
                new CoordinatePiece(5, 4, new SingleChessPiece('B')),
                new CoordinatePiece(4, 5, new SingleChessPiece('B')),
                new CoordinatePiece(1, 6, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 6, new SingleChessPiece('K')),
                new CoordinatePiece(7, 6, new SingleChessPiece('N')),
                new CoordinatePiece(2, 7, new SingleChessPiece('Q')),
                new CoordinatePiece(5, 7, new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(2, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 1, new SingleChessPiece('N')),
                new CoordinatePiece(1, 2, new SingleChessPiece('R')),
                new CoordinatePiece(2, 2, new SingleChessPiece('N')),
                new CoordinatePiece(4, 2, new SingleChessPiece('Q')),
                new CoordinatePiece(0, 3, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 3, new SingleChessPiece('B')),
                new CoordinatePiece(3, 3, new SingleChessPiece('K')),
                new CoordinatePiece(2, 5, new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(0, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(0, 5, new SingleChessPiece('R')),
                new CoordinatePiece(7, 2, new SingleChessPiece('B')),
                new CoordinatePiece(1, 3, new SingleChessPiece('Q')),
                new CoordinatePiece(0, 5, new SingleChessPiece('R')),
                new CoordinatePiece(3, 5, new SingleChessPiece('B')),
                new CoordinatePiece(4, 5, new SingleChessPiece('N')),
                new CoordinatePiece(0, 6, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 6, new SingleChessPiece('Q')),
                new CoordinatePiece(2, 6, new SingleChessPiece('R'))
            },
            new[]
            {
                new CoordinatePiece(1, 0, new SingleChessPiece('B')),
                new CoordinatePiece(7, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 5, new SingleChessPiece('N')),
                new CoordinatePiece(5, 5, new SingleChessPiece('B')),
                new CoordinatePiece(2, 6, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 6, new SingleChessPiece('B')),
                new CoordinatePiece(7, 6, new SingleChessPiece('R')),
                new CoordinatePiece(5, 7, new SingleChessPiece('Q')),
                new CoordinatePiece(6, 7, new SingleChessPiece('N')),
                new CoordinatePiece(7, 7, new SingleChessPiece('R'))
            }
        };

        private static readonly CoordinatePiece[][] Lvl10 = new[]
        {
            new[]
            {
                new CoordinatePiece(6, 1, new SingleChessPiece('Q')),
                new CoordinatePiece(0, 2, new SingleChessPiece('Q')),
                new CoordinatePiece(0, 4, new SingleChessPiece('B')),
                new CoordinatePiece(3, 4, new SingleChessPiece('N')),
                new CoordinatePiece(7, 4, new SingleChessPiece('B')),
                new CoordinatePiece(3, 5, new SingleChessPiece('Q')),
                new CoordinatePiece(4, 5, new SingleChessPiece('B')),
                new CoordinatePiece(5, 5, new SingleChessPiece('N')),
                new CoordinatePiece(4, 6, new SingleChessPiece('N')),
                new CoordinatePiece(7, 6, new SingleChessPiece('R')),
                new CoordinatePiece(6, 7, new SingleChessPiece('N'))
            },
            new[]
            {
                new CoordinatePiece(1, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 1, new SingleChessPiece('R')),
                new CoordinatePiece(6, 1, new SingleChessPiece('R')),
                new CoordinatePiece(0, 2, new SingleChessPiece('N')),
                new CoordinatePiece(3, 2, new SingleChessPiece('N')),
                new CoordinatePiece(0, 3, new SingleChessPiece('N')),
                new CoordinatePiece(6, 6, new SingleChessPiece('B')),
                new CoordinatePiece(1, 7, new SingleChessPiece('R')),
                new CoordinatePiece(5, 7, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 7, new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(0, 0, new SingleChessPiece('N')),
                new CoordinatePiece(4, 1, new SingleChessPiece('R')),
                new CoordinatePiece(6, 1, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 1, new SingleChessPiece('Q')),
                new CoordinatePiece(3, 3, new SingleChessPiece('Q')),
                new CoordinatePiece(1, 4, new SingleChessPiece('R')),
                new CoordinatePiece(4, 4, new SingleChessPiece('B')),
                new CoordinatePiece(5, 4, new SingleChessPiece('R')),
                new CoordinatePiece(3, 5, new SingleChessPiece('K')),
                new CoordinatePiece(0, 6, new SingleChessPiece('R')),
                new CoordinatePiece(4, 6, new SingleChessPiece('B'))
            },
            new[]
            {
                new CoordinatePiece(0, 3, new SingleChessPiece('R')),
                new CoordinatePiece(1, 4, new SingleChessPiece('B')),
                new CoordinatePiece(7, 4, new SingleChessPiece('N')),
                new CoordinatePiece(3, 5, new SingleChessPiece('N')),
                new CoordinatePiece(2, 6, new SingleChessPiece('R')),
                new CoordinatePiece(4, 6, new SingleChessPiece('Q')),
                new CoordinatePiece(6, 6, new SingleChessPiece('B')),
                new CoordinatePiece(0, 7, new SingleChessPiece('N')),
                new CoordinatePiece(1, 7, new SingleChessPiece('R')),
                new CoordinatePiece(4, 7, new SingleChessPiece('R')),
                new CoordinatePiece(5, 7, new SingleChessPiece('Q'))
            },
            new[]
            {
                new CoordinatePiece(3, 0, new SingleChessPiece('R')),
                new CoordinatePiece(4, 0, new SingleChessPiece('B')),
                new CoordinatePiece(1, 1, new SingleChessPiece('R')),
                new CoordinatePiece(3, 1, new SingleChessPiece('B')),
                new CoordinatePiece(6, 1, new SingleChessPiece('R')),
                new CoordinatePiece(1, 3, new SingleChessPiece('B')),
                new CoordinatePiece(5, 3, new SingleChessPiece('B')),
                new CoordinatePiece(5, 5, new SingleChessPiece('Q')),
                new CoordinatePiece(6, 5, new SingleChessPiece('R')),
                new CoordinatePiece(1, 6, new SingleChessPiece('Q')),
                new CoordinatePiece(3, 6, new SingleChessPiece('Q'))
            }
        };

        private static readonly CoordinatePiece[][] Test = new[]
        {
            new[]
            {
                new CoordinatePiece(0, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(0, 7, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 0, new SingleChessPiece('Q')),
                new CoordinatePiece(7, 7, new SingleChessPiece('Q')),
            }
        };

        public static CoordinatePiece[] GetLevel(int lvl)
        {
            CoordinatePiece[] layout;
            Random rand = new Random();
            int n;
            switch (lvl)
            {
                case 1:
                    n = rand.Next(Lvl1.GetLength(0));
                    layout = Lvl1[n];
                    break;
                case 2:
                    n = rand.Next(Lvl2.GetLength(0));
                    layout = Lvl2[n];
                    break;
                case 3:
                    n = rand.Next(Lvl3.GetLength(0));
                    layout = Lvl3[n];
                    break;
                case 4:
                    n = rand.Next(Lvl4.GetLength(0));
                    layout = Lvl4[n];
                    break;
                case 5:
                    n = rand.Next(Lvl5.GetLength(0));
                    layout = Lvl5[n];
                    break;
                case 6:
                    n = rand.Next(Lvl6.GetLength(0));
                    layout = Lvl6[n];
                    break;
                case 7:
                    n = rand.Next(Lvl7.GetLength(0));
                    layout = Lvl7[n];
                    break;
                case 8:
                    n = rand.Next(Lvl8.GetLength(0));
                    layout = Lvl8[n];
                    break;
                case 9:
                    n = rand.Next(Lvl9.GetLength(0));
                    layout = Lvl9[n];
                    break;
                case 10:
                    n = rand.Next(Lvl10.GetLength(0));
                    layout = Lvl10[n];
                    break;
                default:
                    n = rand.Next(Test.GetLength(0));
                    layout = Test[n];
                    break;
            }
            return layout;
        }
    }
}