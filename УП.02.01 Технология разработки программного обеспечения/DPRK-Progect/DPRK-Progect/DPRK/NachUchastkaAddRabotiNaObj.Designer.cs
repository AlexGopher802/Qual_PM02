namespace DPRK
{
    partial class NachUchastkaAddRabotiNaObj
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
            this.vidWork = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brigade = new System.Windows.Forms.ComboBox();
            this.completionDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(230, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация об объекте";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(231, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вид работы";
            // 
            // vidWork
            // 
            this.vidWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vidWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vidWork.FormattingEnabled = true;
            this.vidWork.Location = new System.Drawing.Point(235, 98);
            this.vidWork.Name = "vidWork";
            this.vidWork.Size = new System.Drawing.Size(296, 26);
            this.vidWork.TabIndex = 2;
            this.vidWork.SelectedIndexChanged += new System.EventHandler(this.vidWork_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(231, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выбор бригады";
            // 
            // brigade
            // 
            this.brigade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brigade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brigade.FormattingEnabled = true;
            this.brigade.Location = new System.Drawing.Point(235, 161);
            this.brigade.Name = "brigade";
            this.brigade.Size = new System.Drawing.Size(296, 26);
            this.brigade.TabIndex = 4;
            this.brigade.SelectedIndexChanged += new System.EventHandler(this.brigade_SelectedIndexChanged);
            // 
            // completionDate
            // 
            this.completionDate.Location = new System.Drawing.Point(235, 227);
            this.completionDate.Name = "completionDate";
            this.completionDate.Size = new System.Drawing.Size(296, 22);
            this.completionDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Location = new System.Drawing.Point(231, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Срок выполнения работы";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(235, 289);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(136, 36);
            this.exit.TabIndex = 7;
            this.exit.Text = "Отменить";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.MediumTurquoise;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm.Location = new System.Drawing.Point(385, 289);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(146, 36);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Подтвердить";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // NachUchastkaAddRabotiNaObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.completionDate);
            this.Controls.Add(this.brigade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vidWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NachUchastkaAddRabotiNaObj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NachUchastkaAddRabotiNaObj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vidWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox brigade;
        private System.Windows.Forms.DateTimePicker completionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button confirm;
    }
}