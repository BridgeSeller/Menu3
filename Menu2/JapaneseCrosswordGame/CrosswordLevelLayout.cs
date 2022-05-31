namespace Menu2.JapaneseCrosswordGame
{
    public static class CrosswordLevelLayout
    {
        private static readonly char[,] Hat = new char[,]
        {
            {' ', ' ', ' ', ' ', ' '},
            {' ', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', ' '},
            {'X', 'X', 'X', 'X', 'X'}
        };

        private static readonly char[,] Duck = new char[,]
        {
            {' ', 'X', ' ', ' ', ' '},
            {'X', 'X', ' ', ' ', ' '},
            {' ', 'X', 'X', 'X', 'X'},
            {' ', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', ' ', ' '}
        };

        private static readonly char[,] Tree = new char[,]
        {
            {' ', ' ', 'X', ' ', ' '},
            {' ', ' ', 'X', ' ', ' '},
            {' ', 'X', 'X', 'X', ' '},
            {'X', 'X', 'X', 'X', 'X'},
            {' ', ' ', 'X', ' ', ' '}
        };

        private static readonly char[,] Mushroom = new char[,]
        {
            {' ', ' ', 'X', ' ', ' '},
            {' ', 'X', ' ', 'X', ' '},
            {'X', 'X', 'X', 'X', 'X'},
            {' ', ' ', 'X', ' ', ' '},
            {' ', ' ', 'X', ' ', ' '}
        };

        private static readonly char[,] House = new char[,]
        {
            {' ', ' ', 'X', ' ', ' '},
            {' ', 'X', 'X', 'X', ' '},
            {'X', 'X', 'X', 'X', 'X'},
            {' ', 'X', ' ', 'X', ' '},
            {' ', 'X', ' ', 'X', ' '}
        };

        private static readonly char[,] Swan = new char[,]
        {
            {' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', 'X', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' '},
            {'X', 'X', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
            {' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' '}
        };

        private static readonly char[,] Monster = new char[,]
        {
            {' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', 'X', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X'}
        };

        private static readonly char[,] Yogi = new char[,]
        {
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', ' ', 'X', 'X', ' ', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' '},
            {' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' '},
            {' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' '},
            {'X', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' ', 'X'},
            {' ', 'X', 'X', 'X', ' ', ' ', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', 'X', 'X', 'X', 'X', ' ', ' ', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' '},
        };

        private static readonly char[,] Unicorn = new char[,]
        {
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' '},
            {' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' '},
            {'X', ' ', ' ', 'X', ' ', ' ', 'X', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', 'X', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', 'X', ' ', ' ', ' '}
        };

        private static readonly char[,] Panda = new char[,]
        {
            {'X', 'X', 'X', ' ', ' ', ' ', ' ', 'X', 'X', 'X'},
            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', ' ', 'X', ' ', 'X', ' ', 'X', ' '},
            {' ', ' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', 'X', ' ', 'X', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' '}
        };

        private static readonly char[,] BabyYoda = new char[,]
        {
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', 'X', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' ', ' '},
            {'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X'},
            {'X', ' ', ' ', ' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' ', ' ', ' ', 'X'},
            {' ', 'X', 'X', ' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' ', ' ', 'X', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', 'X', ' ', ' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' '},
            {' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' '},
            {' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' '},
            {'X', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', 'X'},
            {' ', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', 'X', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' '}
        };

        private static readonly char[,] Cat = new char[,]
        {
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', 'X', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' '},
            {'X', ' ', 'X', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', 'X', ' ', ' ', ' '},
            {'X', ' ', 'X', 'X', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', 'X', ' ', 'X', ' ', 'X', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', 'X', 'X', ' ', 'X', 'X', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', 'X', 'X', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' '}
        };

        private static readonly char[,] YinYang = new char[,]
        {
            {' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' '},
            {' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', 'X', ' '},
            {' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', 'X', 'X', 'X', ' ', 'X', ' '},
            {'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', 'X', 'X', 'X', ' ', ' ', 'X'},
            {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', 'X'},
            {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', 'X'},
            {'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
            {'X', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
            {'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
            {' ', 'X', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', 'X', ' '},
            {' ', 'X', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', 'X', ' '},
            {' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' '}
        };

        private static readonly char[,] Evening = new char[,]
        {
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' '},
            {' ', 'X', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' '},
            {' ', 'X', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' '},
            {' ', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', ' '},
        };

        private static readonly char[,] Android = new char[,]
        {

            {' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', 'X', 'X', 'X', 'X', ' ', 'X', 'X', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', 'X', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', 'X', ' ', ' '},
            {' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' '},
            {' ', 'X', 'X', 'X', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', 'X', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', 'X', ' ', ' ', 'X', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
        };
        
        private static readonly char[,] Test =  new char[,]
        {
            {'X','X','X',' ','X','X','X',' '},
            {' ','X',' ',' ','X',' ',' ',' '},
            {' ','X',' ',' ','X','X','X',' '},
            {' ','X',' ',' ','X',' ',' ',' '},
            {' ','X',' ',' ','X','X','X',' '},
            {' ',' ','X','X',' ','X','X','X'},
            {' ','X',' ',' ',' ',' ','X',' '},
            {' ',' ','X',' ',' ',' ','X',' '},
            {' ',' ',' ','X',' ',' ','X',' '},
            {' ','X','X',' ',' ',' ','X',' '},
        };

        public static bool[,] GetLevel(int lvl)
        {
            bool[,] layout;
            switch (lvl)
            {
                case 1:
                    // hat
                    layout = new bool[Hat.GetLength(0), Hat.GetLength(1)];
                    for (int i = 0; i != Hat.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Hat.GetLength(1); ++j)
                        {
                            if (Hat[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 2:
                    // duck
                    layout = new bool[Duck.GetLength(0), Duck.GetLength(1)];
                    for (int i = 0; i != Duck.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Duck.GetLength(1); ++j)
                        {
                            if (Duck[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 3:
                    // tree
                    layout = new bool[Tree.GetLength(0), Tree.GetLength(1)];
                    for (int i = 0; i != Tree.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Tree.GetLength(1); ++j)
                        {
                            if (Tree[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 4:
                    // mushroom
                    layout = new bool[Mushroom.GetLength(0), Mushroom.GetLength(1)];
                    for (int i = 0; i != Mushroom.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Mushroom.GetLength(1); ++j)
                        {
                            if (Mushroom[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 5:
                    // house
                    layout = new bool[House.GetLength(0), House.GetLength(1)];
                    for (int i = 0; i != House.GetLength(0); ++i)
                    {
                        for (int j = 0; j != House.GetLength(1); ++j)
                        {
                            if (House[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 6:
                    // panda
                    layout = new bool[Panda.GetLength(0), Panda.GetLength(1)];
                    for (int i = 0; i != Panda.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Panda.GetLength(1); ++j)
                        {
                            if (Panda[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 7:
                    // monster
                    layout = new bool[Monster.GetLength(0), Monster.GetLength(1)];
                    for (int i = 0; i != Monster.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Monster.GetLength(1); ++j)
                        {
                            if (Monster[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 8:
                    // unicorn
                    layout = new bool[Unicorn.GetLength(0), Unicorn.GetLength(1)];
                    for (int i = 0; i != Unicorn.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Unicorn.GetLength(1); ++j)
                        {
                            if (Unicorn[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 9:
                    // swan
                    layout = new bool[Swan.GetLength(0), Swan.GetLength(1)];
                    for (int i = 0; i != Swan.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Swan.GetLength(1); ++j)
                        {
                            if (Swan[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 10:
                    // yogi
                    layout = new bool[Yogi.GetLength(0), Yogi.GetLength(1)];
                    for (int i = 0; i != Yogi.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Yogi.GetLength(1); ++j)
                        {
                            if (Yogi[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 11:
                    // evening
                    layout = new bool[Evening.GetLength(0), Evening.GetLength(1)];
                    for (int i = 0; i != Evening.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Evening.GetLength(1); ++j)
                        {
                            if (Evening[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 12:
                    // cat
                    layout = new bool[Cat.GetLength(0), Cat.GetLength(1)];
                    for (int i = 0; i != Cat.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Cat.GetLength(1); ++j)
                        {
                            if (Cat[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 13:
                    // yin yang
                    layout = new bool[YinYang.GetLength(0), YinYang.GetLength(1)];
                    for (int i = 0; i != YinYang.GetLength(0); ++i)
                    {
                        for (int j = 0; j != YinYang.GetLength(1); ++j)
                        {
                            if (YinYang[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 14:
                    // baby yoda
                    layout = new bool[BabyYoda.GetLength(0), BabyYoda.GetLength(1)];
                    for (int i = 0; i != BabyYoda.GetLength(0); ++i)
                    {
                        for (int j = 0; j != BabyYoda.GetLength(1); ++j)
                        {
                            if (BabyYoda[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                case 15:
                    // android
                    layout = new bool[Android.GetLength(0), Android.GetLength(1)];
                    for (int i = 0; i != Android.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Android.GetLength(1); ++j)
                        {
                            if (Android[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
                
                default:
                    layout = new bool[Test.GetLength(0), Test.GetLength(1)];
                    for (int i = 0; i != Test.GetLength(0); ++i)
                    {
                        for (int j = 0; j != Test.GetLength(1); ++j)
                        {
                            if (Test[i, j] == 'X')
                            {
                                layout[i, j] = true;
                            }
                            else
                            {
                                layout[i, j] = false;
                            }
                        }
                    }
                    break;
            }
            
            return layout;
        }
    }
}