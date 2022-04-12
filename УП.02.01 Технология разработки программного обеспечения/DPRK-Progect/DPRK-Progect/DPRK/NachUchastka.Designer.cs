namespace DPRK
{
    partial class NachUchastka
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
            this.label1 = new System.Windows.Forms.Label();
            this.tipObject = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.generateReport = new System.Windows.Forms.Button();
            this.informationRegion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.informationRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип объекта";
            // 
            // tipObject
            // 
            this.tipObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tipObject.FormattingEnabled = true;
            this.tipObject.Location = new System.Drawing.Point(47, 63);
            this.tipObject.Name = "tipObject";
            this.tipObject.Size = new System.Drawing.Size(383, 26);
            this.tipObject.TabIndex = 1;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumTurquoise;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(47, 110);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(177, 41);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(244, 110);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(186, 41);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // generateReport
            // 
            this.generateReport.BackColor = System.Drawing.Color.MediumTurquoise;
            this.generateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateReport.Location = new System.Drawing.Point(47, 169);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(383, 41);
            this.generateReport.TabIndex = 4;
            this.generateReport.Text = "Сгенерировать отчет";
            this.generateReport.UseVisualStyleBackColor = false;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // informationRegion
            // 
            this.informationRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationRegion.Location = new System.Drawing.Point(463, 63);
            this.informationRegion.Name = "informationRegion";
            this.informationRegion.RowHeadersWidth = 51;
            this.informationRegion.RowTemplate.Height = 24;
            this.informationRegion.Size = new System.Drawing.Size(394, 287);
            this.informationRegion.TabIndex = 5;
            // 
            // NachUchastka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.informationRegion);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.tipObject);
            this.Controls.Add(this.label1);
            this.Name = "NachUchastka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NachUchastka";
            ((System.ComponentModel.ISupportInitialize)(this.informationRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipObject;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.DataGridView informationRegion;
    }
}