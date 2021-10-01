
namespace Listas
{
    partial class lstMenor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstInter = new System.Windows.Forms.ListBox();
            this.Menor = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.Mayor = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.Mayor);
            this.panel1.Controls.Add(this.lstInter);
            this.panel1.Controls.Add(this.Menor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 344);
            this.panel1.TabIndex = 0;
            // 
            // lstInter
            // 
            this.lstInter.FormattingEnabled = true;
            this.lstInter.ItemHeight = 25;
            this.lstInter.Location = new System.Drawing.Point(518, 6);
            this.lstInter.Name = "lstInter";
            this.lstInter.Size = new System.Drawing.Size(285, 329);
            this.lstInter.TabIndex = 0;
            // 
            // Menor
            // 
            this.Menor.FormattingEnabled = true;
            this.Menor.ItemHeight = 25;
            this.Menor.Location = new System.Drawing.Point(104, 6);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(285, 329);
            this.Menor.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200"});
            this.comboBox1.Location = new System.Drawing.Point(104, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1119, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(104, 243);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(1119, 48);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Mayor
            // 
            this.Mayor.FormattingEnabled = true;
            this.Mayor.ItemHeight = 25;
            this.Mayor.Location = new System.Drawing.Point(872, 6);
            this.Mayor.Name = "Mayor";
            this.Mayor.Size = new System.Drawing.Size(279, 329);
            this.Mayor.TabIndex = 1;
            // 
            // lstMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1382, 695);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "lstMenor";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstInter;
        private System.Windows.Forms.ListBox Menor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox Mayor;
    }
}

