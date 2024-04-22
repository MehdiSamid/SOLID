using System.Runtime.InteropServices;

namespace ISP
{
    public class program
    {
        static void Main(string[] args)
        {
            IOpenable textDocument = new TextDocument();
            IEditable spreadsheetDocument = new SpreadsheetDocument();
            ISaveable presentationDocument = new PresentationDocument();

            textDocument.Open();
            spreadsheetDocument.Edit();
            presentationDocument.Save();
        }
    }
}
