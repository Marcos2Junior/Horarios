using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO; 

namespace horario
{
    public class gerapdf
    {

        public bool Gerar(string arquivo, string valor)
        {
            FileStream fs = new FileStream(arquivo, FileMode.Create);

            Document document = new Document(PageSize.A4, 25, 25, 30, 30);

            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            document.Open();
            // Add a simple and wellknown phrase to the document in a flow layout manner 
            document.Add(new Paragraph(valor));
            // Close the document  
            document.Close();

            // Close the writer instance  
            writer.Close();
            // Always close open filehandles explicity  
            fs.Close(); 

            return true;
        }
    }
}
