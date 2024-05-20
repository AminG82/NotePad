namespace NotePad
{
    public interface ITools
    {
        void Insert(string str);
        void Undo();
        void Redo();

    }
}
