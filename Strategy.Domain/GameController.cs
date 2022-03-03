using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Strategy.Domain.Models;

namespace Strategy.Domain
{
    /// <summary>
    /// Контроллер хода игры.
    /// </summary>
    public class GameController
    {
        private readonly Map _map;

        // Очки жизни каждого юнита.
        private readonly Dictionary<object, int> _hp = new Dictionary<object, int>();

        /// <inheritdoc />
        public GameController(Map map)
        {
            _map = map;
        }


        /// <summary>
        /// Получить координаты объекта.
        /// </summary>
        /// <param name="o">Координаты объекта, которые необходимо получить.</param>
        /// <returns>Координата x, координата y.</returns>
        public Coordinates GetObjectCoordinates(Base o)
        {
            return new Coordinates(o.X, o.Y);

            throw new ArgumentException("Неизвестный тип");
        }

        /// <summary>
        /// Может ли юнит передвинуться в указанную клетку.
        /// </summary>
        /// <param name="u">Юнит.</param>
        /// <param name="x">Координата X клетки.</param>
        /// <param name="y">Координата Y клетки.</param>
        /// <returns>
        /// <see langvalue="true" />, если юнит может переместиться
        /// <see langvalue="false" /> - иначе.
        /// </returns>
        public bool CanMoveUnit(BaseUnit u, int x, int y)
        {
            if (!u.CanMove(x, y))
            {
                return false;
            }


            foreach (BaseMapObject g in _map.Ground)
            {
                if (g is Water w && w.X == x && w.Y == y)
                {
                    return false;
                }
            }

            foreach (BaseUnit u1 in _map.Units)
            {
                if (u1.IsEqualCoordinates(x, y)) return false;
            }

            return true;
        }

        /// <summary>
        /// Передвинуть юнита в указанную клетку.
        /// </summary>
        /// <param name="u">Юнит.</param>
        /// <param name="x">Координата X клетки.</param>
        /// <param name="y">Координата Y клетки.</param>
        public void MoveUnit(BaseUnit u, int x, int y)
        {
            if (!CanMoveUnit(u, x, y))
                return;

            u.X = x;
            u.Y = y;
        }

        /// <summary>
        /// Проверить, может ли один юнит атаковать другого.
        /// </summary>
        /// <param name="au">Юнит, который собирается совершить атаку.</param>
        /// <param name="tu">Юнит, который является целью.</param>
        /// <returns>
        /// <see langvalue="true" />, если атака возможна
        /// <see langvalue="false" /> - иначе.
        /// </returns>
        public bool CanAttackUnit(BaseUnit au, BaseUnit tu)
        {
            var cr = GetObjectCoordinates(tu);
            Player ptu;
            ptu = tu.Player;

            if (IsDead(tu))
                return false;

            if (au.Player == ptu)
            {
                return false;
            }

            var dx = au.X - cr.X;
            var dy = au.Y - cr.Y;

            if (au is RangeUnit r)
            {
                return r.CanAttack(dx, dy);
            }

            if (au is MeleeUnit m)
            {
                return m.CanAttack(dx, dy);
            }

            throw new ArgumentException("Неизвестный тип");
        }

        /// <summary>
        /// Атаковать указанного юнита.
        /// </summary>
        /// <param name="au">Юнит, который собирается совершить атаку.</param>
        /// <param name="tu">Юнит, который является целью.</param>
        public void AttackUnit(BaseUnit au, BaseUnit tu)
        {
            if (!CanAttackUnit(au, tu))
                return;

            InitializeUnitHp(tu);
            var thp = _hp[tu];
            var cr = GetObjectCoordinates(tu);
            int d = 0;

            if (au is RangeUnit r)
            {
                var dx = r.X - cr.X;
                var dy = r.Y - cr.Y;
                d = r.AttackUnit(dx, dy);
            }
            else if (au is MeleeUnit m)
            {
                d = m.AttackUnit();
            }
            else
                throw new ArgumentException("Неизвестный тип");

            _hp[tu] = Math.Max(thp - d, 0);
        }

        /// <summary>
        /// Получить изображение объекта.
        /// </summary>
        public ImageSource GetObjectSource(Base o)
        {
            if (o is BaseUnit bu && IsDead(bu)) return BaseUnit.DeadUnitSource; 
            return o.SourceImage;
        }

        /// <summary>
        /// Проверить, что указанный юнит умер.
        /// </summary>
        /// <param name="u">Юнит.</param>
        /// <returns>
        /// <see langvalue="true" />, если у юнита не осталось очков здоровья,
        /// <see langvalue="false" /> - иначе.
        /// </returns>
        private bool IsDead(BaseUnit u)
        {
            if (_hp.TryGetValue(u, out var hp))
                return hp == 0;

            InitializeUnitHp(u);
            return false;
        }

        /// <summary>
        /// Инициализировать здоровье юнита.
        /// </summary>
        /// <param name="u">Юнит.</param>
        private void InitializeUnitHp(object u)
        {
            if (_hp.ContainsKey(u))
                return;

            if (u is Archer)
            {
                _hp.Add(u, 50);
            }
            else if (u is Catapult)
            {
                _hp.Add(u, 70);
            }
            else if (u is Horseman)
            {
                _hp.Add(u, 200);
            }
            else if (u is Swordsman)
            {
                _hp.Add(u, 100);
            }
            else
                throw new ArgumentException("Неизвестный тип");
        }
    }
}