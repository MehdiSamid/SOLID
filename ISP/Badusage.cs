using System;

namespace ISP
{
    public interface IDocument
    {
        void Open();
        void Edit();
        void Save();
        
    }

    public class TextDocument2 : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening text document...");
        }

        public void Edit()
        {
            Console.WriteLine("Editing text document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving text document...");
        }
    }

    public class SpreadsheetDocument2 : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening spreadsheet document...");
        }

        public void Edit()
        {
            Console.WriteLine("Editing spreadsheet document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving spreadsheet document...");
        }
    }

    public class PresentationDocument2 : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening presentation document...");
        }

        public void Edit()
        {
            Console.WriteLine("Editing presentation document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving presentation document...");
        }
    }

}
