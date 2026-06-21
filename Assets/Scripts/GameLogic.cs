using System;

namespace GameCoreSimpleSeaBattle.CoreGame
{
    public class GameLogic
    {
        private readonly Map _map;

        private int _countSteps = 0;
        private bool _isGameOver = false;

        public bool IsGameOver => _isGameOver;

        public Action<int> OnGameOver;

        public GameLogic(Map map) 
        {
            _map = map;
        }

        public void StartGame()
        {
            _map.Reset();
            RandPositionShip();
        }

        public bool Step(int x, int y)
        {
            Vector2 point = new Vector2(x, y);
            return Step(point);
        }

        public bool Step(Vector2 point)
        {
            char cell = _map.GetCell(point);
            _countSteps++;

            try
            {
                if(cell != '1')
                {
                    _map.Update(point, '-');
                    return false;
                }
                else
                {
                    _map.Update(point, '*');
                    OnGameOver?.Invoke(_countSteps);
                    _isGameOver = true;
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public char[,] GetMapWithoutShips() => _map.GetMapWithoutShips();
        public char[,] GetMap() => _map.GetMap();

        private void RandPositionShip()
        {
            Vector2 point = new();
            Random rand = new();

            point.X = rand.Next(0, _map.GetCountColumns());
            point.Y = rand.Next(0, _map.GetCountRows());

            _map.Update(point, '1');
        }
    }
}
