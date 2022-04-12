namespace DPRK
{
    partial class ManagerRegObj
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
            this.tipObject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regionObject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.ComboBox();
            this.exit = new System.Windows.Forms.Button();
            this.farther = new System.Windows.Forms.Button();
            this.addRegion = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(232, 27);
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
            this.label2.Location = new System.Drawing.Point(233, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип объекта";
            // 
            // tipObject
            // 
            this.tipObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tipObject.FormattingEnabled = true;
            this.tipObject.Location = new System.Drawing.Point(237, 99);
            this.tipObject.Name = "tipObject";
            this.tipObject.Size = new System.Drawing.Size(410, 26);
            this.tipObject.TabIndex = 2;
            this.tipObject.SelectedIndexChanged += new System.EventHandler(this.tipObject_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(233, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Участок объекта";
            // 
            // regionObject
            // 
            this.regionObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionObject.FormattingEnabled = true;
            this.regionObject.Location = new System.Drawing.Point(237, 164);
            this.regionObject.Name = "regionObject";
            this.regionObject.Size = new System.Drawing.Size(296, 26);
            this.regionObject.TabIndex = 4;
            this.regionObject.SelectedIndexChanged += new System.EventHandler(this.regionObject_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Location = new System.Drawing.Point(233, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Заказчик";
            // 
            // customer
            // 
            this.customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customer.FormattingEnabled = true;
            this.customer.Location = new System.Drawing.Point(237, 235);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(296, 26);
            this.customer.TabIndex = 6;
            this.customer.SelectedIndexChanged += new System.EventHandler(this.customer_SelectedIndexChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(237, 282);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(84, 40);
            this.exit.TabIndex = 7;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // farther
            // 
            this.farther.BackColor = System.Drawing.Color.MediumTurquoise;
            this.farther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.farther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.farther.Location = new System.Drawing.Point(435, 282);
            this.farther.Name = "farther";
            this.farther.Size = new System.Drawing.Size(98, 40);
            this.farther.TabIndex = 8;
            this.farther.Text = "Дальше";
            this.farther.UseVisualStyleBackColor = false;
            this.farther.Click += new System.EventHandler(this.farther_Click);
            // 
            // addRegion
            // 
            this.addRegion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRegion.Location = new System.Drawing.Point(549, 164);
            this.addRegion.Name = "addRegion";
            this.addRegion.Size = new System.Drawing.Size(37, 26);
            this.addRegion.TabIndex = 9;
            this.addRegion.Text = "+";
            this.addRegion.UseVisualStyleBackColor = false;
            this.addRegion.Click += new System.EventHandler(this.addRegion_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCustomer.Location = new System.Drawing.Point(549, 234);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(37, 26);
            this.addCustomer.TabIndex = 10;
            this.addCustomer.Text = "+";
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // ManagerRegObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.addRegion);
            this.Controls.Add(this.farther);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regionObject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagerRegObj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerRegObj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipObject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox regionObject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox customer;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button farther;
        private System.Windows.Forms.Button addRegion;
        private System.Windows.Forms.Button addCustomer;
    }
}