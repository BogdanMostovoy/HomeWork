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

            int pointCanAttack = 0; // координата, куда фигура может атаковать
            int pointCanAttack2 = 0; // вторая координата
            int pointCanAttack3 = 0;    // Третья кооридната
            int pointCanAttack4 = 0;
            bool verticalPosition = false;
            bool horizontalPosition = false;

            bool figureKilled = false;

            if (typeOfFigure == 1) // пешка
            {
                verticalPosition = verticalCoordinateAattackFigure == (verticalCoordinatesAttacedFigure - 1);
                pointCanAttack = horizontalCoordinatesAttackFigure + 1;
                pointCanAttack2 = horizontalCoordinatesAttackFigure - 1;

            }
            if (verticalPosition && pointCanAttack == horizontalCoordinatesAttackedFigure || pointCanAttack2 == horizontalCoordinatesAttackedFigure)
            {
                figureKilled = true;
            }

            else if (typeOfFigure == 2) // тура
            {
                verticalPosition = verticalCoordinateAattackFigure == verticalCoordinatesAttacedFigure;
                horizontalPosition = horizontalCoordinatesAttackFigure == horizontalCoordinatesAttackedFigure;
            }
            if (verticalPosition || horizontalPosition)
            {
                figureKilled = true;
            }


            else if (typeOfFigure == 3) // конь
            {
               verticalPosition = verticalCoordinatesAttacedFigure == (verticalCoordinateAattackFigure + 2);
               horizontalPosition = horizontalCoordinatesAttackedFigure == (horizontalCoordinatesAttackFigure + 1);
              

            }
            if(horizontalPosition && verticalPosition)
            {
                figureKilled = true;
            }
            
            
            else if (typeOfFigure == 4) // слон
            {

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