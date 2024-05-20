namespace NotePad
{
    public class Tools : ITools
    {
        public string[] Temp { get; set; }
        public int Index { get; set; }
        public int CurrentPosition { get; set; }

        public Tools()
        {
            Temp = new string[200];     // i can use Temp.Lenght too but it may cost too much memory !
            Index = 0;
            CurrentPosition = 0;
        }
        public void Insert(string str)
        {
            Temp[Index] = str;
            CurrentPosition = Index;
            Index++;
        }

        public void Redo()
        {
            
        }

        public void Undo()
        {
            
        }
    }
}
