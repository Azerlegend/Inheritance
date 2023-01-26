using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ExpertDocumentProgram : ProDocumentProgram
    {



        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
