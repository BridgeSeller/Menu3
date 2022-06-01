namespace Menu2.SudokuGame
{
    public static class SudokuLevelLayout
    {
        private static readonly int[] Size = new int[]
        {
            3,4,5,4,5,9,9,9,9,9,16
        };
        private static readonly int[] Count = new int[]
        {
            3,4,8,6,9,13,20,25,30,40,60
        };

        public static int[] GetLevel(int lvl)
        {
            int[] layout = new int[3];
            switch (lvl)
            {
                case 1:
                    layout[0] = Size[0];
                    layout[1] = Count[0];
                    break;
                case 2:
                    layout[0] = Size[1];
                    layout[1] = Count[1];
                    break;
                case 3:
                    layout[0] = Size[2];
                    layout[1] = Count[2];
                    break;
                case 4:
                    layout[0] = Size[3];
                    layout[1] = Count[3];
                    break;
                case 5:
                    layout[0] = Size[4];
                    layout[1] = Count[4];
                    break;
                case 6:
                    layout[0] = Size[5];
                    layout[1] = Count[5];
                    break;
                case 7:
                    layout[0] = Size[6];
                    layout[1] = Count[6];
                    break;
                case 8:
                    layout[0] = Size[7];
                    layout[1] = Count[7];
                    break;
                case 9:
                    layout[0] = Size[8];
                    layout[1] = Count[8];
                    break;
                case 10:
                    layout[0] = Size[9];
                    layout[1] = Count[9];
                    break;
                default:
                    layout[0] = Size[10];
                    layout[1] = Count[10];
                    break;
            }
            return layout;
        }
    }
}