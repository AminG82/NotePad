﻿namespace NotePad
{
    public interface ITools
    {
        void Insert(string str);
        string Undo();
        string Redo();

    }
}
