using System.ComponentModel.Design;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите позицию атакуемой фигуры фигуры по горизонтали: ");
            int horizontalCoordinatesAttackedFigure = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите позицию атакуемой фигуры фигуры по вертикали: ");
            int verticalCoordinatesAttacedFigure = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Типы фигур:");
            Console.WriteLine("1 - пешка");
            Console.WriteLine("2 - тура");
            Console.WriteLine("3 - конь");
            Console.WriteLine("4 - слон");
            Console.WriteLine("Выберите тип фигуры: ");
            int typeOfFigure = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Введите позицию атакующей фигуры фигуры по горизонтали: ");
            int horizontalCoordinatesAttackFigure = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите позицию атакующей фигуры фигуры по вертикали: ");
            int verticalCoordinateAattackFigure = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            bool verticalIsAttack = false;
            bool horizontalIsAttack = false;

            bool figureKilled = false;

            if (typeOfFigure == 1) // пешка
            {
                verticalIsAttack = verticalCoordinateAattackFigure == (verticalCoordinatesAttacedFigure - 1);
                horizontalIsAttack = (horizontalCoordinatesAttackedFigure == horizontalCoordinatesAttackFigure + 1) || (horizontalCoordinatesAttackedFigure == horizontalCoordinatesAttackFigure - 1);

                if (verticalIsAttack && horizontalIsAttack)
                {
                    figureKilled = true;
                }
            }
            else if (typeOfFigure == 2) // тура
            {
                verticalIsAttack = (verticalCoordinateAattackFigure == verticalCoordinatesAttacedFigure);
                horizontalIsAttack = (horizontalCoordinatesAttackFigure == horizontalCoordinatesAttackedFigure);

                if(verticalIsAttack || horizontalIsAttack) 
                {
                    figureKilled = true;
                }
            }
            else if (typeOfFigure == 3) //конь 
            {

                verticalIsAttack = (verticalCoordinateAattackFigure == (verticalCoordinatesAttacedFigure + 2) || (verticalCoordinateAattackFigure == (verticalCoordinatesAttacedFigure - 2)) || (verticalCoordinateAattackFigure == (verticalCoordinatesAttacedFigure + 1)) || (verticalCoordinateAattackFigure == (verticalCoordinatesAttacedFigure - 1)));
                horizontalIsAttack = (horizontalCoordinatesAttackFigure == (horizontalCoordinatesAttackedFigure + 1) || (horizontalCoordinatesAttackFigure == (horizontalCoordinatesAttackedFigure - 1)) || (horizontalCoordinatesAttackFigure == (horizontalCoordinatesAttackedFigure - 2)) || (horizontalCoordinatesAttackFigure == (horizontalCoordinatesAttackedFigure + 2)));

                if(horizontalIsAttack && verticalIsAttack)
                {
                    figureKilled = true;
                }

            }
            else if (typeOfFigure == 4) //слон
            {
                verticalIsAttack = (verticalCoordinatesAttacedFigure % 2 == 0);
                horizontalIsAttack = (horizontalCoordinatesAttackedFigure % 2 == 0);

                if(verticalIsAttack && !horizontalIsAttack || !verticalIsAttack &&  horizontalIsAttack)
                {
                    figureKilled = true;
                }
            }
            else 
            {
                Console.WriteLine("Фигура не найдена");
            }


            if (figureKilled)
            {
                Console.WriteLine("Акатуемая фигура под угрозой");
            }
            else
            {
                Console.WriteLine("Атакуемой фигуре ничего не угрожает");
            }


        }
    }
}