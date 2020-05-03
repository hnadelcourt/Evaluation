using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation
{
    class Note
    {
        public int matiere { get; private set; }
        public double note { get; private set; }
        public Note(int m, float n)
        {
            matiere = m;
            note = n;
        }
    }
}