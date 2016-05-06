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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_TRAIN = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_TEST
            // 
            this.BTN_TEST.Location = new System.Drawing.Point(12, 12);
            this.BTN_TEST.Name = "BTN_TEST";
            this.BTN_TEST.Size = new System.Drawing.Size(260, 35);
            this.BTN_TEST.TabIndex = 0;
            this.BTN_TEST.Text = "LOAD";
            this.BTN_TEST.UseVisualStyleBackColor = true;
            this.BTN_TEST.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Error";
            // 
            // BTN_TRAIN
            // 
            this.BTN_TRAIN.Location = new System.Drawing.Point(12, 63);
            this.BTN_TRAIN.Name = "BTN_TRAIN";
            this.BTN_TRAIN.Size = new System.Drawing.Size(260, 35);
            this.BTN_TRAIN.TabIndex = 3;
            this.BTN_TRAIN.Text = "TRAIN";
            this.BTN_TRAIN.UseVisualStyleBackColor = true;
            this.BTN_TRAIN.Click += new System.EventHandler(this.BTN_TRAIN_Click);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Location = new System.Drawing.Point(12, 119);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(260, 35);
            this.BTN_SAVE.TabIndex = 4;
            this.BTN_SAVE.Text = "SAVE";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.BTN_TRAIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_TEST);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_TEST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_TRAIN;
        private System.Windows.Forms.Button BTN_SAVE;
    }
}

