namespace DPRK
{
    partial class BrigadirInfoORabotah
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
            this.information = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.finishWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.information)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(244, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о работах";
            // 
            // information
            // 
            this.information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.information.Location = new System.Drawing.Point(27, 77);
            this.information.Name = "information";
            this.information.RowHeadersWidth = 51;
            this.information.RowTemplate.Height = 24;
            this.information.Size = new System.Drawing.Size(743, 267);
            this.information.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(27, 375);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 38);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // finishWork
            // 
            this.finishWork.BackColor = System.Drawing.Color.MediumTurquoise;
            this.finishWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishWork.Location = new System.Drawing.Point(496, 375);
            this.finishWork.Name = "finishWork";
            this.finishWork.Size = new System.Drawing.Size(274, 38);
            this.finishWork.TabIndex = 3;
            this.finishWork.Text = "Завершить работу";
            this.finishWork.UseVisualStyleBackColor = false;
            this.finishWork.Click += new System.EventHandler(this.finishWork_Click);
            // 
            // BrigadirInfoORabotah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finishWork);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.information);
            this.Controls.Add(this.label1);
            this.Name = "BrigadirInfoORabotah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrigadirInfoORabotah";
            ((System.ComponentModel.ISupportInitialize)(this.information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView information;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button finishWork;
    }
}