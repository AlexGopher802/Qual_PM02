namespace DPRK
{
    partial class Admin
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
            this.headStation = new System.Windows.Forms.Button();
            this.manager = new System.Windows.Forms.Button();
            this.headConstructionDepartment = new System.Windows.Forms.Button();
            this.brigadir = new System.Windows.Forms.Button();
            this.hrManager = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headStation
            // 
            this.headStation.BackColor = System.Drawing.Color.MediumTurquoise;
            this.headStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headStation.Location = new System.Drawing.Point(213, 25);
            this.headStation.Name = "headStation";
            this.headStation.Size = new System.Drawing.Size(329, 38);
            this.headStation.TabIndex = 0;
            this.headStation.Text = "Начальник участка";
            this.headStation.UseVisualStyleBackColor = false;
            this.headStation.Click += new System.EventHandler(this.headStation_Click);
            // 
            // manager
            // 
            this.manager.BackColor = System.Drawing.Color.MediumTurquoise;
            this.manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.manager.Location = new System.Drawing.Point(213, 69);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(155, 87);
            this.manager.TabIndex = 1;
            this.manager.Text = "Менеджер";
            this.manager.UseVisualStyleBackColor = false;
            this.manager.Click += new System.EventHandler(this.manager_Click);
            // 
            // headConstructionDepartment
            // 
            this.headConstructionDepartment.BackColor = System.Drawing.Color.MediumTurquoise;
            this.headConstructionDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headConstructionDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.headConstructionDepartment.Location = new System.Drawing.Point(387, 69);
            this.headConstructionDepartment.Name = "headConstructionDepartment";
            this.headConstructionDepartment.Size = new System.Drawing.Size(155, 87);
            this.headConstructionDepartment.TabIndex = 2;
            this.headConstructionDepartment.Text = "Глава строитьного управления";
            this.headConstructionDepartment.UseVisualStyleBackColor = false;
            this.headConstructionDepartment.Click += new System.EventHandler(this.headConstructionDepartment_Click);
            // 
            // brigadir
            // 
            this.brigadir.BackColor = System.Drawing.Color.MediumTurquoise;
            this.brigadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brigadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.brigadir.Location = new System.Drawing.Point(213, 174);
            this.brigadir.Name = "brigadir";
            this.brigadir.Size = new System.Drawing.Size(155, 87);
            this.brigadir.TabIndex = 3;
            this.brigadir.Text = "Бригадир";
            this.brigadir.UseVisualStyleBackColor = false;
            this.brigadir.Click += new System.EventHandler(this.brigadir_Click);
            // 
            // hrManager
            // 
            this.hrManager.BackColor = System.Drawing.Color.MediumTurquoise;
            this.hrManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hrManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.hrManager.Location = new System.Drawing.Point(387, 174);
            this.hrManager.Name = "hrManager";
            this.hrManager.Size = new System.Drawing.Size(155, 87);
            this.hrManager.TabIndex = 4;
            this.hrManager.Text = "HR Менеджер";
            this.hrManager.UseVisualStyleBackColor = false;
            this.hrManager.Click += new System.EventHandler(this.hrManager_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(213, 281);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(329, 38);
            this.exit.TabIndex = 5;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.hrManager);
            this.Controls.Add(this.brigadir);
            this.Controls.Add(this.headConstructionDepartment);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.headStation);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button headStation;
        private System.Windows.Forms.Button manager;
        private System.Windows.Forms.Button headConstructionDepartment;
        private System.Windows.Forms.Button brigadir;
        private System.Windows.Forms.Button hrManager;
        private System.Windows.Forms.Button exit;
    }
}