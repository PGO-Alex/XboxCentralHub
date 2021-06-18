using System;
using System.Collections.Generic;
using System.Diagnostics;
using Controller.Class;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Controller
{
    public class ReportContext
    {   public TimeSpan TotalTime = TimeSpan.Zero;
        public RentContext rentContext = new RentContext();
        public List<TimeSpan> TimeTotalList = new List<TimeSpan>();

        public void BuildPDF()
        {
            
            //Path + Filename with datetime
            string filename = $"{Alerthandler.directoryPath}Report_{DateTime.Now:dd-MM_hh-mm-ss}.pdf";
            // Create a new PDF document
            PdfWriter writer = new PdfWriter(filename);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("Underground Games 2")
                .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(20);
            document.Add(header);
            Paragraph subheader = new Paragraph("Reporte de Rentas - "+ DateTime.Now.ToString("dd/MMMM/yyyy"))
                .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(15);
            document.Add(subheader);
            Table table = new Table(7, false);
            Cell cell11 = new Cell(1, 1)
                  .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph("Inicio"));
            Cell cell12 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Nombre de la Consola"));
            Cell cell13 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Id Consola"));
            Cell cell14 = new Cell(1, 1)
                  .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph("Hora Inicio"));
            Cell cell15 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Hora Fin"));
            Cell cell16 = new Cell(1, 1)
                  .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph("Tiempo trabajado"));
            Cell cell17 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Tipo de renta"));
            table.AddHeaderCell(cell11);
            table.AddHeaderCell(cell12);
            table.AddHeaderCell(cell13);
            table.AddHeaderCell(cell14);
            table.AddHeaderCell(cell15);
            table.AddHeaderCell(cell16);
            table.AddHeaderCell(cell17);

            List<string[]> LineList = rentContext.GetRentsToday();
            foreach (var item in LineList)
            {
                Cell cell21 = new Cell(1, 1)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph($"{item[6]}"));
                Cell cell22 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph($"{item[5]}"));
                Cell cell23 = new Cell(1, 1)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph($"{item[1]}"));
                Cell cell24 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph($"{item[2]}"));
                Cell cell25 = new Cell(1, 1)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph($"{item[3]}"));
                Cell cell26 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph($"{item[4]}"));

                TimeTotalList.Add(TimeSpan.Parse(item[4]));
                Cell cell27 = new Cell(1, 1)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph($"{item[7]}"));
                table.AddCell(cell21);
                table.AddCell(cell22);
                table.AddCell(cell23);
                table.AddCell(cell24);
                table.AddCell(cell25);
                table.AddCell(cell26);
                table.AddCell(cell27);
            }
            document.Add(table);

            Paragraph spacing1 = new Paragraph("")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(20);
            document.Add(spacing1);
            foreach (TimeSpan item in TimeTotalList)
            {
                TotalTime += item;
            }
            Paragraph HT = new Paragraph("Horas Totales = "+TotalTime)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            document.Add(HT);
            // Line separator
            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);
            document.Add(spacing1);
            Table TimeByConsole = new Table(2,false);

            Cell cell_r1c1 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph("Consola"));
            Cell cell_r1c2 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph("Tiempo Total del dia"));
            TimeByConsole.AddHeaderCell(cell_r1c1);
            TimeByConsole.AddHeaderCell(cell_r1c2);
            document.Add(TimeByConsole);

            document.Close();
            Process.Start(filename);
        }
    }
}
