namespace Spooky
{
    partial class Lista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLista = new System.Windows.Forms.TextBox();
            this.btnChecar = new System.Windows.Forms.Button();
            this.chkArquivos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(12, 12);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtLista.Size = new System.Drawing.Size(201, 159);
            this.txtLista.TabIndex = 0;
            // 
            // btnChecar
            // 
            this.btnChecar.Location = new System.Drawing.Point(12, 210);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(201, 23);
            this.btnChecar.TabIndex = 1;
            this.btnChecar.Text = "Checar";
            this.btnChecar.UseVisualStyleBackColor = true;
            this.btnChecar.Click += new System.EventHandler(this.btnChecar_Click);
            // 
            // chkArquivos
            // 
            this.chkArquivos.AutoSize = true;
            this.chkArquivos.Location = new System.Drawing.Point(13, 178);
            this.chkArquivos.Name = "chkArquivos";
            this.chkArquivos.Size = new System.Drawing.Size(137, 17);
            this.chkArquivos.TabIndex = 2;
            this.chkArquivos.Text = "Arquivos soltos tambem";
            this.chkArquivos.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 245);
            this.Controls.Add(this.chkArquivos);
            this.Controls.Add(this.btnChecar);
            this.Controls.Add(this.txtLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.Text = "Lista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lista_FormClosing);
            this.Load += new System.EventHandler(this.Lista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button btnChecar;
        private System.Windows.Forms.CheckBox chkArquivos;
    }
}