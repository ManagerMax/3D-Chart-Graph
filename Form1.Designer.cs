namespace _3D_Chart_Graph
{
    partial class Form1
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
            this.formula = new System.Windows.Forms.Button();
            this.graph3D1 = new Plot3D.Graph3D();
            this.show_all = new System.Windows.Forms.Button();
            this.surface = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formula
            // 
            this.formula.Location = new System.Drawing.Point(48, 20);
            this.formula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(112, 35);
            this.formula.TabIndex = 1;
            this.formula.Text = "Formula";
            this.formula.UseVisualStyleBackColor = true;
            this.formula.Click += new System.EventHandler(this.formula_Click);
            // 
            // graph3D1
            // 
            this.graph3D1.AxisX_Color = System.Drawing.Color.DarkBlue;
            this.graph3D1.AxisX_Legend = null;
            this.graph3D1.AxisY_Color = System.Drawing.Color.DarkGreen;
            this.graph3D1.AxisY_Legend = null;
            this.graph3D1.AxisZ_Color = System.Drawing.Color.DarkRed;
            this.graph3D1.AxisZ_Legend = null;
            this.graph3D1.BackColor = System.Drawing.Color.White;
            this.graph3D1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.graph3D1.Location = new System.Drawing.Point(18, 88);
            this.graph3D1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graph3D1.Name = "graph3D1";
            this.graph3D1.PolygonLineColor = System.Drawing.Color.Black;
            this.graph3D1.Raster = Plot3D.Graph3D.eRaster.Off;
            this.graph3D1.Size = new System.Drawing.Size(882, 625);
            this.graph3D1.TabIndex = 0;
            this.graph3D1.TopLegendColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            // 
            // show_all
            // 
            this.show_all.Location = new System.Drawing.Point(686, 20);
            this.show_all.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(112, 35);
            this.show_all.TabIndex = 2;
            this.show_all.Text = "Show All";
            this.show_all.UseVisualStyleBackColor = true;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // surface
            // 
            this.surface.Location = new System.Drawing.Point(242, 18);
            this.surface.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(112, 35);
            this.surface.TabIndex = 3;
            this.surface.Text = "Sorface";
            this.surface.UseVisualStyleBackColor = true;
            //this.surface.Click += new System.EventHandler(this.surface_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 26);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 731);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.surface);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.graph3D1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Plot3D.Graph3D graph3D1;
        private System.Windows.Forms.Button formula;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.Button surface;
        private System.Windows.Forms.TextBox textBox1;
    }
}

