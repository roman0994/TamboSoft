using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Escritorio
{
    public class ExportarAExcel
    {
        public void Exportar(DataGridView dgv, string nombreForm)
        {

            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                libros_trabajo = aplicacion.Application.Workbooks.Add(true);
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                //La primer fila tendrá el nombre del formulario 
                aplicacion.Cells[1, 1] = nombreForm;

                int ColumnIndex = 0;
                foreach (DataGridViewColumn col in dgv.Columns)
                {

                    ColumnIndex++;
                    aplicacion.Cells[2, ColumnIndex] = col.HeaderText;

                }
                int rowIndex = 1;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    rowIndex++;
                    ColumnIndex = 0;

                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        ColumnIndex++;
                        aplicacion.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                    }
                }

                //Aplicamos estilo de letra
                hoja_trabajo.Rows.Cells.Font.Name = "Gadugi";

                //Marcamos las celdas del encabezado en negrita y en color de relleno gris
                hoja_trabajo.Range[hoja_trabajo.Cells[1, 1], hoja_trabajo.Cells[2, dgv.ColumnCount]].Font.Bold = true;
                hoja_trabajo.Range[hoja_trabajo.Cells[1, 1], hoja_trabajo.Cells[2, dgv.ColumnCount]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);

                //Aplicamos un borde a la tabla
                hoja_trabajo.Range[hoja_trabajo.Cells[1, 1], hoja_trabajo.Cells[dgv.RowCount + 2, dgv.ColumnCount]].Borders.Weight = XlBorderWeight.xlThin;
                //Para toda la hoja de trabajo: hoja_trabajo.Rows.Cells.Borders.Weight = XlBorderWeight.xlThick;

                //aplicacion.Visible = true;
                Worksheet worksheet = (Worksheet)aplicacion.ActiveSheet;
                //worksheet.Activate();
                libros_trabajo.SaveAs(fichero.FileName,
                 Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
    }
}
