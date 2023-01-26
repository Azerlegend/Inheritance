using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Keyword: var keyword = Console.ReadLine();

            switch (keyword)
            {

                case "basic":
                    var documentProgram = new DocumentProgram() ;
                    documentProgram.OpenDocument();
                    documentProgram.EditDocument();
                    documentProgram.SaveDocument();
                    break;
                case "pro":
                    var proDocumentProgram = new ProDocumentProgram();
                    proDocumentProgram.OpenDocument();
                    proDocumentProgram.EditDocument();
                    proDocumentProgram.SaveDocument();
                    break;
                case "expert":
                    var expertDocument = new ExpertDocumentProgram();
                    expertDocument.OpenDocument();
                    expertDocument.EditDocument();
                    expertDocument.SaveDocument();
                    break;
                default:
                    goto Keyword;


            }

        }
    }
}
