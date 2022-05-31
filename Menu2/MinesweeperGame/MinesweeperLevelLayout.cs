namespace Menu2.MinesweeperGame
{
    public static class MinesweeperLevelLayout
    {
        private static readonly int[] SideX = new int[]
        {
            8,10,20,10,16,18,20,24,30,36,100
        };
        private static readonly int[] SideY = new int[]
        {
            8,10,10,10,16,18,20,24,30,36,100
        };
        private static readonly int[] Count = new int[]
        {
            3,6,13,14,30,40,70,100,130,160,2222
        };

        public static int[] GetLevel(int lvl)
        {
            int[] layout = new int[3];
            switch (lvl)
            {
                case 1:
                    layout[0] = SideX[0];
                    layout[1] = SideY[0];
                    layout[2] = Count[0];
                    break;
                case 2:
                    layout[0] = SideX[1];
                    layout[1] = SideY[1];
                    layout[2] = Count[1];
                    break;
                case 3:
                    layout[0] = SideX[2];
                    layout[1] = SideY[2];
                    layout[2] = Count[2];
                    break;
                case 4:
                    layout[0] = SideX[3];
                    layout[1] = SideY[3];
                    layout[2] = Count[3];
                    break;
                case 5:
                    layout[0] = SideX[4];
                    layout[1] = SideY[4];
                    layout[2] = Count[4];
                    break;
                case 6:
                    layout[0] = SideX[5];
                    layout[1] = SideY[5];
                    layout[2] = Count[5];
                    break;
                case 7:
                    layout[0] = SideX[6];
                    layout[1] = SideY[6];
                    layout[2] = Count[6];
                    break;
                case 8:
                    layout[0] = SideX[7];
                    layout[1] = SideY[7];
                    layout[2] = Count[7];
                    break;
                case 9:
                    layout[0] = SideX[8];
                    layout[1] = SideY[8];
                    layout[2] = Count[8];
                    break;
                case 10:
                    layout[0] = SideX[9];
                    layout[1] = SideY[9];
                    layout[2] = Count[9];
                    break;
                default:
                    layout[0] = SideX[10];
                    layout[1] = SideY[10];
                    layout[2] = Count[10];
                    break;
            }
            return layout;
        }
    }
}