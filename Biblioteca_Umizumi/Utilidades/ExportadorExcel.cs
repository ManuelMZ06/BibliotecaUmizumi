using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

public static class ExportadorExcel
{
    public static void Exportar(DataGridView dgv, string nombreArchivo = "Reporte")
    {
        using (SaveFileDialog sfd = new SaveFileDialog()
        {
            Filter = "Excel Workbook|*.xlsx",
            Title = "Guardar como Excel"
        })
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook libro = new XLWorkbook())
                {
                    DataTable tabla = new DataTable();

                    foreach (DataGridViewColumn col in dgv.Columns)
                        tabla.Columns.Add(col.HeaderText);

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            DataRow fila = tabla.NewRow();
                            for (int i = 0; i < dgv.Columns.Count; i++)
                                fila[i] = row.Cells[i].Value?.ToString() ?? "";
                            tabla.Rows.Add(fila);
                        }
                    }

                    libro.Worksheets.Add(tabla, nombreArchivo);
                    libro.SaveAs(sfd.FileName);

                    MessageBox.Show("✅ Exportado a Excel correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
