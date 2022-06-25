
namespace Vizuliazatia
{
    partial class Form2
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
            this.buttonWay = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.sheet = new System.Windows.Forms.PictureBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWay
            // 
            this.buttonWay.Image = global::Vizuliazatia.Properties.Resources.edge;
            this.buttonWay.Location = new System.Drawing.Point(12, 61);
            this.buttonWay.Name = "buttonWay";
            this.buttonWay.Size = new System.Drawing.Size(43, 43);
            this.buttonWay.TabIndex = 4;
            this.buttonWay.UseVisualStyleBackColor = true;
            this.buttonWay.Click += new System.EventHandler(this.buttonWay_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::Vizuliazatia.Properties.Resources.delete;
            this.buttonDelete.Location = new System.Drawing.Point(12, 110);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(43, 43);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Image = global::Vizuliazatia.Properties.Resources.deleteAll;
            this.buttonDeleteAll.Location = new System.Drawing.Point(12, 159);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(43, 43);
            this.buttonDeleteAll.TabIndex = 2;
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Image = global::Vizuliazatia.Properties.Resources.vertex2;
            this.buttonGraph.Location = new System.Drawing.Point(12, 12);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(43, 43);
            this.buttonGraph.TabIndex = 1;
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // sheet
            // 
            this.sheet.Location = new System.Drawing.Point(61, 13);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(477, 332);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.Click += new System.EventHandler(this.sheet_Click);
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(196, 371);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(194, 35);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Найти кратчайший путь";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonWay);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.sheet);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonWay;
        private System.Windows.Forms.Button buttonCalculate;
    }
}