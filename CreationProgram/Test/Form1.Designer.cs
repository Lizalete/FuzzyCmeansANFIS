namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_TEST = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_TEST
            // 
            this.BTN_TEST.Location = new System.Drawing.Point(12, 12);
            this.BTN_TEST.Name = "BTN_TEST";
            this.BTN_TEST.Size = new System.Drawing.Size(75, 23);
            this.BTN_TEST.TabIndex = 0;
            this.BTN_TEST.Text = "button1";
            this.BTN_TEST.UseVisualStyleBackColor = true;
            this.BTN_TEST.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTN_TEST);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_TEST;
    }
}

