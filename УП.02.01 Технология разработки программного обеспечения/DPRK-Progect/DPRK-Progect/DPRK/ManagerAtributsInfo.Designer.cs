namespace DPRK
{
    partial class ManagerAtributsInfo
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
            this.atributeValue = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.atributic = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.atributeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(143, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация об атрибутах";
            // 
            // atributeValue
            // 
            this.atributeValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atributeValue.Location = new System.Drawing.Point(501, 61);
            this.atributeValue.Name = "atributeValue";
            this.atributeValue.RowHeadersWidth = 51;
            this.atributeValue.RowTemplate.Height = 24;
            this.atributeValue.Size = new System.Drawing.Size(578, 377);
            this.atributeValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Атрибут";
            // 
            // atributic
            // 
            this.atributic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atributic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.atributic.FormattingEnabled = true;
            this.atributic.Location = new System.Drawing.Point(39, 85);
            this.atributic.Name = "atributic";
            this.atributic.Size = new System.Drawing.Size(412, 26);
            this.atributic.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Значение";
            // 
            // value
            // 
            this.value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.value.Location = new System.Drawing.Point(39, 150);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(412, 24);
            this.value.TabIndex = 6;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumTurquoise;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.add.Location = new System.Drawing.Point(39, 205);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(202, 50);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.MediumTurquoise;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.delete.Location = new System.Drawing.Point(259, 205);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(192, 50);
            this.delete.TabIndex = 8;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.exit.Location = new System.Drawing.Point(259, 273);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(192, 54);
            this.exit.TabIndex = 9;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.MediumTurquoise;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.confirm.Location = new System.Drawing.Point(39, 273);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(202, 54);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "Подтвердить";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // ManagerAtributsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.atributic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.atributeValue);
            this.Controls.Add(this.label1);
            this.Name = "ManagerAtributsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerAtributsInfo";
            ((System.ComponentModel.ISupportInitialize)(this.atributeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView atributeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox atributic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button confirm;
    }
}