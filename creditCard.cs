using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoFinal
{
    public partial class creditCard : Form
    {
        #region Vatiables locales publicas
        public event Action<string> PaymentCompleted;
        #endregion

        #region Constructor
        public creditCard()
        {
            InitializeComponent();

            //Connect TextChanged events of the TextBoxes to the ValidateInputs function
            txtCardholder.TextChanged += InputChanged;
            txtCardNumber.TextChanged += InputChanged;
            txtExpirationDate.TextChanged += InputChanged;
            txtCVV.TextChanged += InputChanged;

            ValidateInputs(); //Validate inputs initially
        }
        #endregion

        #region Validar Campos
        private void ValidateInputs()
        {
            //Enable or disable the button according to the status of fields
            btnPay.Enabled = !string.IsNullOrWhiteSpace(txtCardholder.Text) &&
                             !string.IsNullOrWhiteSpace(txtCardNumber.Text) &&
                             !string.IsNullOrWhiteSpace(txtExpirationDate.Text) &&
                             !string.IsNullOrWhiteSpace(txtCVV.Text);
        }

        // Method to be executed when changing the text in the TextBoxes
        private void InputChanged(object sender, EventArgs e)
        {
            ValidateInputs(); // Validar cada vez que cambia un campo
        }
        #endregion

        #region Botones formulario
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Simplemente cierra el formulario sin realizar acciones
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Invocar el evento PaymentCompleted con el método de pago "Tarjeta"
            PaymentCompleted?.Invoke("Tarjeta");
            //MessageBox.Show("Pago realizado exitosamente con tarjeta.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Cerrar el formulario
        }
        #endregion
    }
}
