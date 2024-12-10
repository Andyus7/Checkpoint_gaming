using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsProyectoFinal.Models
{

    public static class shoppingCartUtils
    {
        #region Generar PDF
        public static void GeneratePDF(List<CartItem> items, string metodoPago, int currentUserId,decimal total,AdmonBD db)
        {
            string receiptDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Receipts");
            if (!Directory.Exists(receiptDirectory))
            {
                Directory.CreateDirectory(receiptDirectory);
            }

            string receiptPath = Path.Combine(receiptDirectory, $"Receipt_{DateTime.Now:yyyyMMddHHmmss}.pdf");
            try
            {
                using (FileStream fs = new FileStream(receiptPath, FileMode.Create))
                {
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, fs);

                    doc.Open();
                    doc.Add(new Paragraph("CHECKPOINT GAMES"));
                    doc.Add(new Paragraph($"Nombre del cliente: {db.GetUserName(currentUserId,db)}"));
                    doc.Add(new Paragraph($"Método de pago: {metodoPago}"));
                    doc.Add(new Paragraph($"Fecha: {DateTime.Now}"));
                    doc.Add(new Paragraph("Productos comprados:"));

                    foreach (var item in items)
                    {
                        doc.Add(new Paragraph($"{item.Name} - ${item.Price} x {item.Quantity}"));
                    }

                    doc.Add(new Paragraph($"Total: ${total:F2}"));
                    doc.Close();
                }
                //In case you want to see in which path the file was created
                if (File.Exists(receiptPath))
                {
                    MessageBox.Show($"Receipt successfully generated in:{receiptPath}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The PDF file could not be generated. Check permissions or path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when generating the receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
