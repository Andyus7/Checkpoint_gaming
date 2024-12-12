using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace WinFormsProyectoFinal.Models
{

    public static class shoppingCartUtils
    {
        #region Generate PDF
        public static void GeneratePDF(List<CartItem> items, string metodoPago, int currentUserId, decimal total, AdmonBD db)
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

                    string logoPath = Path.Combine(Application.StartupPath, "Images", "Logos.png");
                    if (File.Exists(logoPath))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                        logo.ScaleToFit(100f, 100f); // Adjust size
                        logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER; // Center
                        doc.Add(logo);
                    }
                    else
                    {
                        MessageBox.Show("Logo not found. Please verify the file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    doc.Add(new Paragraph("CHECKPOINT GAMES"));
                    doc.Add(new Paragraph("Where gamers find their level"));
                    doc.Add(new Paragraph($"Client's name: {db.GetUserName(currentUserId,db)}"));
                    doc.Add(new Paragraph($"Method of payment: {metodoPago}"));
                    doc.Add(new Paragraph($"Date: {DateTime.Now}"));
                    doc.Add(new Paragraph("Products purchased:"));
                    

                    foreach (var item in items)
                    {
                        doc.Add(new Paragraph($"{item.Name} - ${item.Price} x {item.Quantity}"));
                    }

                    decimal taxes = (6 * total) / 100;
                    decimal totalWithTaxes = taxes + total;
                    doc.Add(new Paragraph($"Taxes: ${taxes:F2}"));
                    doc.Add(new Paragraph($"Total: ${totalWithTaxes:F2}"));
                    doc.Close();
                }
                /*In case you want to see in which path the file was created
                if (File.Exists(receiptPath))
                {
                    MessageBox.Show($"Receipt successfully generated in:{receiptPath}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The PDF file could not be generated. Check permissions or path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when generating the receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
