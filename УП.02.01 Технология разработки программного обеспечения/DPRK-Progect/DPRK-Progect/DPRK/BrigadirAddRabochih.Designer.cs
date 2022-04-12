namespace DPRK
{
    partial class BrigadirAddRabochih
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
            this.employee = new System.Windows.Forms.ComboBox();
            this.lable = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.listEmployee = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.listWorks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.White;
            this.employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employee.FormattingEnabled = true;
            this.employee.Location = new System.Drawing.Point(48, 46);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(407, 26);
            this.employee.TabIndex = 0;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lable.Location = new System.Drawing.Point(44, 23);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(146, 20);
            this.lable.TabIndex = 1;
            this.lable.Text = "Выбор рабочего";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumTurquoise;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(477, 36);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(209, 36);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listEmployee
            // 
            this.listEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEmployee.Location = new System.Drawing.Point(48, 95);
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.RowHeadersWidth = 51;
            this.listEmployee.RowTemplate.Height = 24;
            this.listEmployee.Size = new System.Drawing.Size(799, 274);
            this.listEmployee.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(730, 36);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(117, 36);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // listWorks
            // 
            this.listWorks.BackColor = System.Drawing.Color.MediumTurquoise;
            this.listWorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listWorks.Location = new System.Drawing.Point(316, 395);
            this.listWorks.Name = "listWorks";
            this.listWorks.Size = new System.Drawing.Size(237, 43);
            this.listWorks.TabIndex = 5;
            this.listWorks.Text = "Список работ";
            this.listWorks.UseVisualStyleBackColor = false;
            this.listWorks.Click += new System.EventHandler(this.listWorks_Click);
            // 
            // BrigadirAddRabochih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.listWorks);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.listEmployee);
            this.Controls.Add(this.add);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.employee);
            this.Name = "BrigadirAddRabochih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrigadirAddRabochih";
            ((System.ComponentModel.ISupportInitialize)(this.listEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employee;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView listEmployee;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button listWorks;
    }
}