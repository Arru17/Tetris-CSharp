namespace Lab4_Tetris.vista
{
    partial class VistaJuego
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
            this.panelTab = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTab = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPieza = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Rotar = new System.Windows.Forms.Button();
            this.textPosHoriz = new System.Windows.Forms.TextBox();
            this.Colocar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ImprimirTab = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textPoints = new System.Windows.Forms.TextBox();
            this.panelTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTab
            // 
            this.panelTab.AutoScroll = true;
            this.panelTab.Controls.Add(this.tableLayoutPanelTab);
            this.panelTab.Location = new System.Drawing.Point(12, 12);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(875, 657);
            this.panelTab.TabIndex = 0;
            // 
            // tableLayoutPanelTab
            // 
            this.tableLayoutPanelTab.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanelTab.ColumnCount = 1;
            this.tableLayoutPanelTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTab.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTab.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTab.Name = "tableLayoutPanelTab";
            this.tableLayoutPanelTab.RowCount = 1;
            this.tableLayoutPanelTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTab.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelTab.TabIndex = 0;
            // 
            // tableLayoutPanelPieza
            // 
            this.tableLayoutPanelPieza.ColumnCount = 4;
            this.tableLayoutPanelPieza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieza.Location = new System.Drawing.Point(1016, 38);
            this.tableLayoutPanelPieza.Name = "tableLayoutPanelPieza";
            this.tableLayoutPanelPieza.RowCount = 4;
            this.tableLayoutPanelPieza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieza.Size = new System.Drawing.Size(160, 160);
            this.tableLayoutPanelPieza.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1016, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Siguiente Pieza:";
            // 
            // Rotar
            // 
            this.Rotar.Location = new System.Drawing.Point(1057, 220);
            this.Rotar.Name = "Rotar";
            this.Rotar.Size = new System.Drawing.Size(85, 23);
            this.Rotar.TabIndex = 2;
            this.Rotar.Text = "Rotar pieza";
            this.Rotar.UseVisualStyleBackColor = true;
            this.Rotar.Click += new System.EventHandler(this.Rotar_Click);
            // 
            // textPosHoriz
            // 
            this.textPosHoriz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textPosHoriz.Location = new System.Drawing.Point(1045, 393);
            this.textPosHoriz.Name = "textPosHoriz";
            this.textPosHoriz.Size = new System.Drawing.Size(119, 20);
            this.textPosHoriz.TabIndex = 3;
            // 
            // Colocar
            // 
            this.Colocar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Colocar.Location = new System.Drawing.Point(1067, 419);
            this.Colocar.Name = "Colocar";
            this.Colocar.Size = new System.Drawing.Size(75, 46);
            this.Colocar.TabIndex = 4;
            this.Colocar.Text = "Colocar";
            this.Colocar.UseVisualStyleBackColor = false;
            this.Colocar.Click += new System.EventHandler(this.Colocar_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Red;
            this.Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salir.Location = new System.Drawing.Point(1067, 488);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 52);
            this.Salir.TabIndex = 5;
            this.Salir.TabStop = false;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(1017, 357);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(159, 13);
            this.textBox3.TabIndex = 6;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Ingrese posicion de la columna:";
            // 
            // ImprimirTab
            // 
            this.ImprimirTab.BackColor = System.Drawing.Color.Gray;
            this.ImprimirTab.Location = new System.Drawing.Point(1067, 646);
            this.ImprimirTab.Name = "ImprimirTab";
            this.ImprimirTab.Size = new System.Drawing.Size(109, 23);
            this.ImprimirTab.TabIndex = 7;
            this.ImprimirTab.Text = "Imprimir tablero";
            this.ImprimirTab.UseVisualStyleBackColor = false;
            this.ImprimirTab.Click += new System.EventHandler(this.ImprimirTab_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(1000, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(79, 13);
            this.textBox2.TabIndex = 8;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Puntaje Actual:";
            // 
            // textPoints
            // 
            this.textPoints.BackColor = System.Drawing.Color.Silver;
            this.textPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPoints.Location = new System.Drawing.Point(1085, 288);
            this.textPoints.Name = "textPoints";
            this.textPoints.ReadOnly = true;
            this.textPoints.Size = new System.Drawing.Size(100, 13);
            this.textPoints.TabIndex = 9;
            this.textPoints.TabStop = false;
            // 
            // VistaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.textPoints);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ImprimirTab);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Colocar);
            this.Controls.Add(this.textPosHoriz);
            this.Controls.Add(this.Rotar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanelPieza);
            this.Controls.Add(this.panelTab);
            this.Name = "VistaJuego";
            this.Text = "Menu Tetris";
            this.Load += new System.EventHandler(this.VistaJuego_Load);
            this.panelTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPieza;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Rotar;
        private System.Windows.Forms.TextBox textPosHoriz;
        private System.Windows.Forms.Button Colocar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ImprimirTab;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textPoints;
    }
}