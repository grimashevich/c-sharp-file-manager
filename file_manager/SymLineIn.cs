namespace file_manager
{
    public class SymLineIn: SymLine
    {
        /*Линия, которая встраивается внутрь прямоугольника. Отличается крайними символами*/
        public SymLineIn(char sym, int x, int y, int len, LineType _dir = LineType.Horizontal)
            : base(sym, x, y, len, _dir)
        {
            if (_dir == LineType.Horizontal)
            {
                pList[0].sym = '╠';
                pList[len - 1].sym = '╣';
            }
            else
            {
                pList[0].sym = '╦';
                pList[len - 1].sym = '╩';
            }
        }
    }
}