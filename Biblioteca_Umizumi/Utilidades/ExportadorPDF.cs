using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

public static class ExportadorPDF
{
    public static void Exportar(DataGridView dgv, string titulo = "Reporte")
    {
        using (SaveFileDialog sfd = new SaveFileDialog()
        {
            Filter = "PDF File|*.pdf",
            Title = "Guardar como PDF"
        })
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4.Rotate());
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();

                Paragraph encabezado = new Paragraph(titulo, FontFactory.GetFont("Arial", 16, Font.BOLD));
                encabezado.Alignment = Element.ALIGN_CENTER;
                encabezado.SpacingAfter = 20;
                doc.Add(encabezado);

                PdfPTable tabla = new PdfPTable(dgv.Columns.Count) { WidthPercentage = 100 };

                foreach (DataGridViewColumn col in dgv.Columns)
                    tabla.AddCell(new Phrase(col.HeaderText));

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                            tabla.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                doc.Add(tabla);
                doc.Close();

                MessageBox.Show("✅ Exportado a PDF correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

