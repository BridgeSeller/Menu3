using System;
using System.Text;

namespace Menu2.SudokuGame
{
    /// <summary>
    /// Класс-генератор случайных досок для судоку
    /// </summary>
    public class SudokuBoardGenerator
    {
        // Таблица двоичных значений 
        private static readonly int[] BinaryNr = 
        {
            0x1,
            0x2,
            0x4,
            0x8,
            0x10,
            0x20,
            0x40,
            0x80,
            0x100,
            0x200,
            0x400,
            0x800,
            0x1000,
            0x2000,
            0x4000,
            0x8000,
            0x10000,
            0x20000,
            0x40000,
            0x80000,
            0x100000,
            0x200000,
            0x400000,
            0x800000,
            0x1000000,
            0x2000000,
            0x4000000,
            0x8000000,
            0x10000000,
            0x20000000,
            0x40000000
        };
        
        // Генератор случайных чисел
        private readonly Random _rand;
        // Данные доски судоку(в двоисном формате)
        private readonly int[,] _boardData;
        // Таблица, указывающая на завершенность указанного поля
        // true - у данного поля одно возможное значение
        // false - у данного поля несколько возможных значений
        private readonly bool[,] _checkerBoard;
        // Сторона таблицы (ее размер)
        private readonly int _size;
        // Флажок
        // True - при генерации будут учитываться сектора доски
        // False - не будут
        private readonly bool _flag;
        
        // Вспомогательный массив
        // Объявляем здесь, чтобы далее не тратить ресурсы на выделение памяти
        private readonly int[] _possValues;
        
        /// <summary>
        /// Конструктор<br/>
        /// Инициализирует все необходимые значения
        /// </summary>
        /// <param name="size">длина стороны доски</param>
        /// <exception cref="ArgumentOutOfRangeException">если аргумент меньше 1 или больше 31</exception>
        public SudokuBoardGenerator(int size)
        {
            if (size < 1 || size > 31) throw new ArgumentOutOfRangeException();

            _rand = new Random();
            _size = size;
            _boardData = new int[_size, _size];
            _checkerBoard = new bool[_size, _size];
            _possValues = new int[_size];

            int s = 0;
            for (int i = 0; i != _size; ++i)
            {
                s |= BinaryNr[i];
            }
            
            for (int i = 0; i != _size; ++i)
            {
                for (int j = 0; j != _size; ++j)
                {
                    _checkerBoard[i, j] = false;
                    _boardData[i, j] = s;
                }
            }
            _flag = Math.Ceiling(Math.Sqrt(_size)) - Math.Sqrt(_size) < 0.0000001;
        }
        
        /// <summary>
        /// Возвращает длину стороны доски
        /// </summary>
        /// <returns>size</returns>
        public int GetSize()
        {
            return _size;
        }
        
        /// <summary>
        /// Возвращает копиб текущей доски
        /// </summary>
        /// <returns>int[,]</returns>
        public int[,] GetBoard()
        {
            return (int[,]) _boardData.Clone();
        }
        
        /// <summary>
        /// Считает количество возможных значений для указанного поля доски
        /// </summary>
        /// <param name="x">координата X</param>
        /// <param name="y">координата Y</param>
        /// <returns>количество S значений</returns>
        private int NrOfPossibleValues(int x, int y)
        {
            int a = _boardData[x, y];
            int s = 0;
            for (int i = 0; i != _size; ++i)
            {
                if ((a & 1) == 1) ++s;
                a >>= 1;
            }
            return s;
        }
        /// <summary>
        /// Возвращает одно случайное значение из возможных для указанного поля
        /// </summary>
        /// <param name="x">координата X</param>
        /// <param name="y">координата Y</param>
        /// <returns>двоичное представление одного из возможных чисел</returns>
        private int GetValueFromCurrent(int x, int y)
        {
            int length = NrOfPossibleValues(x,y);
            int ptr = 0;
            int a = _boardData[x, y];
            for (int i = 0; i != _size; ++i)
            {
                if ((a & 1) == 1)
                {
                    _possValues[ptr++]=BinaryNr[i];
                }
                a >>= 1;
            }
            return _possValues[_rand.Next(length)];
        }
        /// <summary>
        /// Возвращает целочисленное преобразованное значение текущей ячейки<br/>
        /// Работает некорректно, если у ячейки несколько возможных значений
        /// </summary>
        /// <param name="x">координата X</param>
        /// <param name="y">координата Y</param>
        /// <returns>число, хранящееся в указанной ячейке</returns>
        private int GetIntFromCurrent(int x, int y)
        {
            int a = _boardData[x, y];
            for (int i = 0; i != _size; ++i)
            {
                if ((a & 1) == 1)
                {
                    return i;
                }
                a >>= 1;
            }
            return 0;
        }
        /// <summary>
        /// Исключает число nr из возможных для всех ячеек в строке Y
        /// </summary>
        /// <param name="y">координата Y</param>
        /// <param name="nr">двоичное представление числа</param>
        private void MarkLine(int y, int nr)
        {
            nr = -nr;
            --nr;
            for (int i = 0; i != _size; ++i)
            {
                if (NrOfPossibleValues(i, y) == 1) continue;
                _boardData[i, y] &= nr;
            }

        }
        /// <summary>
        /// Исключает число nr из возможных для всех ячеек в столбце X
        /// </summary>
        /// <param name="x">координата X</param>
        /// <param name="nr">двоичное представление числа</param>
        private void MarkCol(int x, int nr)
        {
            nr = -nr;
            --nr;
            for (int i = 0; i != _size; ++i)
            {
                if(NrOfPossibleValues(x,i) == 1) continue;
                _boardData[x, i] &= nr;
            }
        }
        /// <summary>
        /// Исключает число nr из возможных для всех ячеек в секторе, к которому принадлежит ячейка (x,y)
        /// </summary>
        /// <param name="x">координата X ячейки</param>
        /// <param name="y">координата Y ячейки</param>
        /// <param name="nr">двоичное представление числа</param>
        private void MarkSector(int x, int y, int nr)
        {
            nr = -nr;
            --nr;
            
            int sideX = (int) Math.Sqrt(_size);

            int xs = x / sideX;
            int ys = y / sideX;
            int ik,jk;

            for (int i = 0; i != sideX; ++i)
            {
                ik = i + sideX * xs;
                for (int j = 0; j != sideX; ++j)
                {
                    jk = j + sideX * ys;
                    if(NrOfPossibleValues(jk, ik) == 1) continue;
                    _boardData[jk,ik] &= nr;
                }
            }
        }
        /// <summary>
        /// Метод, проверяющий корректность доски
        /// </summary>
        /// <returns>
        /// true если доска завершена верно<br/>
        /// false в противном случае
        /// </returns>
        private bool CheckBoard()
        {
            foreach (bool i in _checkerBoard)
            {
                if (!i) return false;
            }

            for (int index = 0; index != _size; ++index)
            {
                if (!CheckCol(index)) return false;
                if (!CheckLine(index)) return false;
                if (_flag)
                    if(!CheckSector(index)) return false;
            }
            return true;
        }
        /// <summary>
        /// Метод, генерирующий доску судоку<br/>
        /// Может вернуть некорректно построенную доску
        /// </summary>
        public void GenerateBoard()
        {
            int x = _rand.Next(_size);
            int y = _rand.Next(_size);
            int n = _size * _size;
            
            for (int cnt = 0; cnt != n; ++cnt)
            {
                int nr = GetValueFromCurrent(x,y);

                MarkLine(y, nr);
                MarkCol(x, nr);
                if (_flag)
                {
                    MarkSector( y,x, nr);
                }
                
                _boardData[x, y] ^= _boardData[x,y];
                _boardData[x, y] |= nr;
                _checkerBoard[x, y] = true;


                int i;
                int j;
                for (i = 0; i != _size; ++i)
                {
                    for (j = 0; j != _size; ++j)
                    {
                        if (_checkerBoard[x, y])
                        {
                            x = i;
                            y = j;
                        }
                        else if (NrOfPossibleValues(i,j) < NrOfPossibleValues(x, y))
                        {
                            if (!_checkerBoard[i, j])
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Метод, генерирующий доску судоку<br/>
        /// Всегда возвращает коррктно построенную доску, но выполняется неопределенное количество времени
        /// </summary>
        public void GenerateStable()
        {
            do
            {
                Clear();
                GenerateBoard();
            } while (!CheckBoard());
        }
        /// <summary>
        /// Метод, очищающий текущую доску и восстанавливающий все значения по-умолчанию.<br/>
        /// Подготавливает генератор к повторному запуску
        /// </summary>
        public void Clear()
        {
            int s = 0;
            for (int i = 0; i != _size; ++i)
            {
                s |= BinaryNr[i];
            }
            
            for (int i = 0; i != _size; ++i)
            {
                for (int j = 0; j != _size; ++j)
                {
                    _checkerBoard[i, j] = false;
                    _boardData[i, j] = s;
                }
            }
        }
        /// <summary>
        /// Возвращает преобразованную на основе текущей доску для судоку
        /// </summary>
        /// <returns>int[,]</returns>
        public int[,] ToFullSudokuBoard()
        {
            int[,] board = new int[_size, _size];
            for (int i = 0; i != _size; ++i)
            {
                for (int j = 0; j != _size; ++j)
                {
                    board[i,j] = GetIntFromCurrent(i,j)+1;
                }
            }

            return board;
        }
        /// <summary>
        /// Метод ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i != _size; ++i)
            {
                for (int j = 0; j != _size; ++j)
                {
                    builder.Append('|');
                    builder.Append(GetIntFromCurrent(i,j)+1);
                }

                builder.Append('|');
                builder.AppendLine();
            }

            return builder.ToString();
        }
        
        /// <summary>
        /// Проеверяет корректность строки Y
        /// </summary>
        /// <param name="y">координата Y</param>
        /// <returns></returns>
        private bool CheckLine(int y)
        {
            int value = 0;
            for (int i = 0; i != _size; ++i)
            {
                value ^= _boardData[i, y];
            }
            for (int i = 0; i != _size; ++i)
            {
                if ((value & 1) != 1)
                {
                    return false;
                }
                value >>= 1;
            }

            return true;

        }
        /// <summary>
        /// Проеверяет корректность столбца X
        /// </summary>
        /// <param name="x">координата Ч</param>
        /// <returns></returns>
        private bool CheckCol(int x)
        {
            int value = 0;
            for (int i = 0; i != _size; ++i)
            {
                value ^= _boardData[x, i];
            }
            for (int i = 0; i != _size; ++i)
            {
                if ((value & 1) != 1)
                {
                    return false;
                }
                value >>= 1;
            }

            return true;
        }
        /// <summary>
        /// Проверяет корректность сектора с индексом index
        /// </summary>
        /// <param name="index">индекс сектора</param>
        /// <returns></returns>
        private bool CheckSector(int index)
        {
            int sideX = (int) Math.Sqrt(_size);

            int x = index % sideX;
            int y = index / sideX;

            int value = 0;
            for (int i = 0; i != sideX; ++i)
            {
                for (int j = 0; j != sideX; ++j)
                {
                    value ^= _boardData[j + sideX * y, i + sideX * x];
                }
            }

            for (int i = 0; i != _size; ++i)
            {
                if ((value & 1) != 1)
                {
                    return false;
                }
                value >>= 1;
            }

            return true;
        }
    }
}