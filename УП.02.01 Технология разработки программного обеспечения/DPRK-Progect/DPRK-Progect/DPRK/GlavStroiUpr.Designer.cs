namespace DPRK
{
    partial class GlavStroiUpr
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
            this.label2 = new System.Windows.Forms.Label();
            this.informationRegion = new System.Windows.Forms.DataGridView();
            this.informationConstructionEquipment = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.addRegion = new System.Windows.Forms.Button();
            this.addConstructionEquipment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informationRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationConstructionEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(93, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация об участках";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(543, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Информация об строительной технике";
            // 
            // informationRegion
            // 
            this.informationRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationRegion.Location = new System.Drawing.Point(35, 118);
            this.informationRegion.Name = "informationRegion";
            this.informationRegion.RowHeadersWidth = 51;
            this.informationRegion.RowTemplate.Height = 24;
            this.informationRegion.Size = new System.Drawing.Size(407, 299);
            this.informationRegion.TabIndex = 2;
            // 
            // informationConstructionEquipment
            // 
            this.informationConstructionEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationConstructionEquipment.Location = new System.Drawing.Point(534, 118);
            this.informationConstructionEquipment.Name = "informationConstructionEquipment";
            this.informationConstructionEquipment.RowHeadersWidth = 51;
            this.informationConstructionEquipment.RowTemplate.Height = 24;
            this.informationConstructionEquipment.Size = new System.Drawing.Size(407, 299);
            this.informationConstructionEquipment.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(875, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 34);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // addRegion
            // 
            this.addRegion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRegion.Location = new System.Drawing.Point(135, 446);
            this.addRegion.Name = "addRegion";
            this.addRegion.Size = new System.Drawing.Size(116, 34);
            this.addRegion.TabIndex = 5;
            this.addRegion.Text = "Добавить";
            this.addRegion.UseVisualStyleBackColor = false;
            this.addRegion.Click += new System.EventHandler(this.addRegion_Click);
            // 
            // addConstructionEquipment
            // 
            this.addConstructionEquipment.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addConstructionEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addConstructionEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addConstructionEquipment.Location = new System.Drawing.Point(636, 446);
            this.addConstructionEquipment.Name = "addConstructionEquipment";
            this.addConstructionEquipment.Size = new System.Drawing.Size(208, 34);
            this.addConstructionEquipment.TabIndex = 6;
            this.addConstructionEquipment.Text = "Добавить технику";
            this.addConstructionEquipment.UseVisualStyleBackColor = false;
            this.addConstructionEquipment.Click += new System.EventHandler(this.addConstructionEquipment_Click);
            // 
            // GlavStroiUpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 538);
            this.Controls.Add(this.addConstructionEquipment);
            this.Controls.Add(this.addRegion);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.informationConstructionEquipment);
            this.Controls.Add(this.informationRegion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GlavStroiUpr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavStroiUpr";
            ((System.ComponentModel.ISupportInitialize)(this.informationRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationConstructionEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView informationRegion;
        private System.Windows.Forms.DataGridView informationConstructionEquipment;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button addRegion;
        private System.Windows.Forms.Button addConstructionEquipment;
    }
}