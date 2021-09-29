using System.Globalization;

namespace file_manager
{
    public class SymRectangle
    {
        /*Прямоугольник, рисуется слева-направо, сверху-вниз от заданной координаты*/
        
        /*Углы*/
        private Point ltCorner;
        private Point rtCorner;
        private Point rbCorner;
        private Point lbCorner;
        
        /*Стенки*/
        private SymLine topLine;
        private SymLine bottomLine;
        private SymLine leftLine;
        private SymLine rightLine;

        public SymRectangle(int x, int y, int width, int height)
        {
            ltCorner = new Point(x, y, '╔');
            rtCorner = new Point(x + width - 1, y, '╗');
            rbCorner = new Point(x + width - 1, y + height - 1, '╝');
            lbCorner = new Point(x, y + height - 1, '╚');

            topLine = new SymLine('═', x + 1, y, width - 2, LineType.Horizontal);
            bottomLine = new SymLine('═', x + 1, y + height - 1, width - 2, LineType.Horizontal);
            leftLine = new SymLine('║', x, y + 1, height - 2, LineType.Vertical);
            rightLine = new SymLine('║', x + width - 1, y + 1, height - 2, LineType.Vertical);
        }

        public void Draw()
        {
            ltCorner.Draw();
            rtCorner.Draw();
            rbCorner.Draw();
            lbCorner.Draw();
            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
        }
    }
}