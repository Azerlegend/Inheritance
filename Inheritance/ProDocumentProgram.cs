using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ProDocumentProgram : DocumentProgram
    {

        public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }

        
    }
}
