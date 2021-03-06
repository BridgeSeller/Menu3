using System;
using System.Text;
using Menu2.Additional_classes;

namespace Menu2.SudokuGame
{
    /**
 * <summary>
 * Доска для игры в судоку.
 * </summary>
 * <remarks>
 * _size<br/>
 * _boardData
 * </remarks>
 */
    public class SudokuBoard
    {
        // Размер доски
        private int _size;

        // Данные доски
        private int[,]? _boardData;

        /**
     * <summary>
     * Создает новую доску с пустыми значениями.
     * </summary>
     */
        private void CreateBoard()
        {
            _boardData = new int[_size, _size];
            for (int i = 0; i != _size * _size; ++i)
            {
                _boardData[i % _size, i / _size] = 0;
            }
        }

        /**
     * <summary>
     * Создает новую доску указанного размера с пустыми значениями.
     * </summary>
     * <param name="a">размер доски</param>
     */
        private void CreateBoard(int a)
        {
            _boardData = new int[a, a];
            _size = a;
            for (int i = 0; i != _size * _size; ++i)
            {
                _boardData[i % _size, i / _size] = 0;
            }
        }

        /**
     * <summary>
     * Конструктор по умолчанию.
     * </summary>
     */
        public SudokuBoard()
        {
            _size = 0;
            _boardData = null;
        }

        /**
     * <summary>
     * Конструктор.
     * </summary>
     * <param name="a">размер доски</param>
     * <exception cref="ArgumentOutOfRangeException">если передан неверный аргумент</exception>
     */
        public SudokuBoard(int a)
        {
            if (a < 1) throw new ArgumentOutOfRangeException();
            this.CreateBoard(a);
        }

        /**
     * <summary>
     * Конструктор копирования.
     * </summary>
     * <param name="sb">копируемая доска</param>
     * <exception cref="ArgumentNullException">если передаваемая доска не инициализирована</exception>
     */
        public SudokuBoard(SudokuBoard sb)
        {
            if (sb._boardData == null) throw new ArgumentNullException();
            _size = sb._size;
            _boardData = (int[,]) sb._boardData.Clone();
        }

        /**
     * <summary>
     * Конструктор, принимающий двумерный массив и создающий доску на его основе.
     * </summary>
     * <param name="values">двумерный массив значений</param>
     * <exception cref="ArgumentException">если передан неквадратный массив</exception>
     */
        public SudokuBoard(int[,] values)
        {
            if (values.GetLength(0) != values.GetLength(1)) throw new ArgumentException();
            _size = values.GetLength(0);
            _boardData = values;
        }

        /**
     * <summary>
     * Возвращает индекс поля по его координатам.
     * </summary>
     * <param name="x">координата x</param>
     * <param name="y">координата y</param>
     * <exception cref="ArgumentOutOfRangeException">если передаваемые аргументы неверны</exception>
     * <returns>index</returns>
     */
        public int GetCellIndex(int x, int y)
        {
            if (x < 0 || x >= _size) throw new ArgumentOutOfRangeException();
            if (y < 0 || y >= _size) throw new ArgumentOutOfRangeException();
            return x + (y * _size);
        }

        /**
     * <summary>
     * Возвращает координату X поля по его индексу.
     * </summary>
     * <param name="index">индекс поля</param>
     * <exception cref="ArgumentOutOfRangeException">если передаваемые аргументы неверны</exception>
     * <returns>X</returns>
     */
        public int GetCellXByIndex(int index)
        {
            if (index < 0 || index >= _size * _size) throw new ArgumentOutOfRangeException();
            return index % _size;
        }

        /**
     * <summary>
     * Возвращает координату Y поля по его индексу.
     * </summary>
     * <param name="index">индекс поля</param>
     * <exception cref="ArgumentOutOfRangeException">если передаваемые аргументы неверны</exception>
     * <returns>Y</returns>
     */
        public int GetCellYByIndex(int index)
        {
            if (index < 0 || index >= _size * _size) throw new ArgumentOutOfRangeException();
            return index / _size;
        }

        /**
     * <summary>
     * Создает новую доску указанного размера.
     * </summary>
     * <param name="a">размер новой доски</param>
     * <exception cref="ArgumentOutOfRangeException">если передан неверный аргумент</exception>
     */
        public void RecreateBoard(int a)
        {
            if (a < 1) throw new ArgumentOutOfRangeException();
            CreateBoard(a);
        }

        /// <summary>
        /// Создает новую доску указанного размера
        /// </summary>
        /// <param name="x">размер доски</param>
        /// <param name="y"> -- </param>
        /// <exception cref="ArgumentOutOfRangeException">если переданные аргументы меньше 1</exception>
        public void RecreateBoard(int x, int y)
        {
            if (x < 1) throw new ArgumentOutOfRangeException();
            if (y < 1) throw new ArgumentOutOfRangeException();
            CreateBoard(x);
        }

        /**
     * <summary>
     * Возвращает размер доски
     * </summary>
     * <returns>_size</returns>
     */
        public int GetSize()
        {
            return _size;
        }

        /// <summary>
        /// Возвращает количество клеток доски
        /// </summary>
        /// <returns>количество клеток доски</returns>
        public int GetCount()
        {
            return _size * _size;
        }

        /// <summary>
        /// Возвращает сторону X
        /// </summary>
        /// <returns>длина стороны X</returns>
        public int GetXSide()
        {
            return _size;
        }

        /// <summary>
        /// Возвращает сторону Y
        /// </summary>
        /// <returns>длина стороны Y</returns>
        public int GetYSide()
        {
            return _size;
        }

        /**
     * <summary>
     * Возвращает доску
     * </summary>
     * <returns>_boardData</returns>
     */
        public int[,]? GetBoard()
        {
            return _boardData;
        }

        /**
     * <summary>
     * Метод ToString
     * </summary>
     * <example>
     * <code>
     * |1|2|<br/>
     * |2|1|
     * </code>
     * </example>
     * <returns>String</returns>
     * <exception cref="NullReferenceException">если доска не инициализирована</exception>
     */
        public override string ToString()
        {
            if (_boardData == null) throw new NullReferenceException();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i != _size; ++i)
            {
                for (int j = 0; j != _size; ++j)
                {
                    builder.Append('|');
                    if (_boardData[i, j] == 0)
                        builder.Append(' ');
                    else
                        builder.Append(_boardData[i, j]);
                }

                builder.Append('|');
                builder.AppendLine();
            }

            return builder.ToString();
        }

        /**
     * <summary>
     * Заполняет доску случайными значениями
     * </summary>
     * <exception cref="NullReferenceException">если доска не инициализирована</exception>
     */

        public void RandomFillBoard()
        {
            RandomFillBoard(_size);
        }
        public void RandomFillBoard(int a)
        {
            SudokuBoardGenerator generator = new SudokuBoardGenerator(_size);
            generator.GenerateStable();
            _boardData = generator.ToFullSudokuBoard();

            RandomBoardFiller boardFiller = new RandomBoardFiller(_size, _size);
            boardFiller.Generate(a);
            bool[,] mask = boardFiller.GetBoard();

            for (int i = 0; i != _size; ++i)
            {
                for (int j = 0; j != _size; ++j)
                {
                    if (mask[i, j])
                    {
                        _boardData[i, j] = 0;
                    }
                }
            }
        }

        /**
     * <summary>
     * Устанавливает значение поля
     * </summary>
     * <param name="index">индекс поля</param>
     * <param name="val">значение</param>
     * <exception cref="NullReferenceException">если доска не инициализирована</exception>
     * <exception cref="ArgumentOutOfRangeException">если задан неверный индекс</exception>
     * <exception cref="ArgumentException">если задано неверное значение</exception>
     */
        public void SetCell(int index, int val)
        {
            if (_boardData == null) throw new NullReferenceException();
            if (index < 0 || index >= _size * _size) throw new ArgumentOutOfRangeException();
            if (val < 0 || val > _size) throw new ArgumentException();
            _boardData[index % _size, index / _size] = val;
        }

        /**
     * <summary>
     * Устанавливает значение поля
     * </summary>
     * <param name="x">X координата поля</param>
     * <param name="y">Y координата поля</param>
     * <param name="val">значение</param>
     * <exception cref="NullReferenceException">если доска не инициализирована</exception>
     * <exception cref="ArgumentOutOfRangeException">если заданы неверные координаты</exception>
     * <exception cref="ArgumentException">если задано неверное значение</exception>
     */
        public void SetCell(int x, int y, int val)
        {
            if (_boardData == null) throw new NullReferenceException();
            if (x < 0 || x >= _size) throw new ArgumentOutOfRangeException();
            if (y < 0 || y >= _size) throw new ArgumentOutOfRangeException();
            if (val < 0 || val > _size) throw new ArgumentException();
            _boardData[x, y] = val;
        }

        /**
     * <summary>
     * Возвращает значение поля
     * </summary>
     * <param name="x">X координата поля</param>
     * <param name="y">Y координата поля</param>
     * <exception cref="NullReferenceException">если доска не инициализирована</exception>
     * <exception cref="ArgumentOutOfRangeException">если заданы неверные координаты</exception>
     * <returns>Значение поля по координатам x, y</returns>
     */
        public int GetCell(int x, int y)
        {
            if (_boardData == null) throw new NullReferenceException();
            if (x < 0 || x >= _size) throw new ArgumentOutOfRangeException();
            if (y < 0 || y >= _size) throw new ArgumentOutOfRangeException();
            return _boardData[x, y];
        }

        /**
     * <summary>
     * Возвращает значение поля
     * </summary>
     * <param name="index">индекс поля</param>
     * <exception cref="NullReferenceException">если доска не инициализирована</exception>
     * <exception cref="ArgumentOutOfRangeException">если задан неверный индекс</exception>
     * <returns>Значение поля по его индексу</returns>
     */
        public int GetCell(int index)
        {
            if (_boardData == null) throw new NullReferenceException();
            if (index < 0 || index >= _size * _size) throw new ArgumentOutOfRangeException();
            return _boardData[index % _size, index / _size];
        }

        /**
     * <summary>
     * Проверяет завершенность строки
     * </summary>
     * <param name="y">номер строки</param>
     */
        private bool CheckLine(int y)
        {
            int[] currArray = new int[_size];
            for (int i = 0; i != _size; ++i)
            {
                int value = _boardData![i, y];
                if (value == 0) return false;
                ++currArray[value - 1];
            }

            foreach (int i in currArray)
            {
                if (i != 1) return false;
            }

            return true;
        }

        /**
     * <summary>
     * Проверяет завершенность столбца
     * </summary>
     * <param name="x">номер столбца</param>
     */
        private bool CheckColumn(int x)
        {
            byte[] currArray = new byte[_size];
            for (int i = 0; i != _size; ++i)
            {
                int value = _boardData![x, i];
                if (value == 0) return false;
                ++currArray[value - 1];
            }

            foreach (int i in currArray)
            {
                if (i != 1) return false;
            }

            return true;
        }
        
        /**
     * <summary>
     * Проверяет завершенность сектора
     * </summary>
     * <param name="index">индекс сектора</param>
     */
        private bool CheckSector(int index)
        {
            int sideX = (int) Math.Sqrt(_size);

            int x = index % sideX;
            int y = index / sideX;

            byte[] currArray = new byte[_size];
            for (int i = 0; i != sideX; ++i)
            {
                for (int j = 0; j != sideX; ++j)
                {
                    int value = _boardData![j + sideX * y, i + sideX * x];
                    if (value == 0) return false;
                    ++currArray[value - 1];
                }
            }

            foreach (int i in currArray)
            {
                if (i != 1) return false;
            }

            return true;
        }

        /**
     * <summary>
     * Проверяет завершенность всей доски
     * </summary>
     * <exception cref="NullReferenceException">если доска не инициализирована</exception>
     */
        public bool CheckBoard()
        {
            if (_boardData == null) throw new NullReferenceException();
            bool flag = (Math.Ceiling(Math.Sqrt(_size)) - Math.Sqrt(_size) < 0.0000001);
            for (int i = 0; i < _size; ++i)
            {
                if (!CheckLine(i)) return false;
                if (!CheckColumn(i)) return false;
                if (flag)
                {
                    if (!CheckSector(i)) return false;
                }
            }

            return true;
        }
    }
}