namespace RGR_UD_MusicProgram.Dispatcher
{
    partial class DispatcherMenu
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
            this.Customerbutton = new System.Windows.Forms.Button();
            this.Shipbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pathbutton = new System.Windows.Forms.Button();
            this.Cargobutton = new System.Windows.Forms.Button();
            this.Ordersbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customerbutton
            // 
            this.Customerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Customerbutton.Location = new System.Drawing.Point(147, 255);
            this.Customerbutton.Name = "Customerbutton";
            this.Customerbutton.Size = new System.Drawing.Size(243, 85);
            this.Customerbutton.TabIndex = 6;
            this.Customerbutton.Text = "Заказчики";
            this.Customerbutton.UseVisualStyleBackColor = true;
            // 
            // Shipbutton
            // 
            this.Shipbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shipbutton.Location = new System.Drawing.Point(147, 149);
            this.Shipbutton.Name = "Shipbutton";
            this.Shipbutton.Size = new System.Drawing.Size(243, 85);
            this.Shipbutton.TabIndex = 5;
            this.Shipbutton.Text = "Корабли";
            this.Shipbutton.UseVisualStyleBackColor = true;
            this.Shipbutton.Click += new System.EventHandler(this.Shipbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "Главное меню";
            // 
            // Pathbutton
            // 
            this.Pathbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pathbutton.Location = new System.Drawing.Point(147, 470);
            this.Pathbutton.Name = "Pathbutton";
            this.Pathbutton.Size = new System.Drawing.Size(243, 85);
            this.Pathbutton.TabIndex = 8;
            this.Pathbutton.Text = "Маршруты";
            this.Pathbutton.UseVisualStyleBackColor = true;
            this.Pathbutton.Click += new System.EventHandler(this.Pathbutton_Click);
            // 
            // Cargobutton
            // 
            this.Cargobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cargobutton.Location = new System.Drawing.Point(147, 364);
            this.Cargobutton.Name = "Cargobutton";
            this.Cargobutton.Size = new System.Drawing.Size(243, 85);
            this.Cargobutton.TabIndex = 7;
            this.Cargobutton.Text = "Грузы";
            this.Cargobutton.UseVisualStyleBackColor = true;
            this.Cargobutton.Click += new System.EventHandler(this.Cargobutton_Click);
            // 
            // Ordersbutton
            // 
            this.Ordersbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ordersbutton.Location = new System.Drawing.Point(147, 578);
            this.Ordersbutton.Name = "Ordersbutton";
            this.Ordersbutton.Size = new System.Drawing.Size(243, 85);
            this.Ordersbutton.TabIndex = 9;
            this.Ordersbutton.Text = "Заказы";
            this.Ordersbutton.UseVisualStyleBackColor = true;
            this.Ordersbutton.Click += new System.EventHandler(this.Ordersbutton_Click);
            // 
            // DispatcherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 680);
            this.Controls.Add(this.Ordersbutton);
            this.Controls.Add(this.Pathbutton);
            this.Controls.Add(this.Cargobutton);
            this.Controls.Add(this.Customerbutton);
            this.Controls.Add(this.Shipbutton);
            this.Controls.Add(this.label1);
            this.Name = "DispatcherMenu";
            this.Text = "DispatcherMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Customerbutton;
        private System.Windows.Forms.Button Shipbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pathbutton;
        private System.Windows.Forms.Button Cargobutton;
        private System.Windows.Forms.Button Ordersbutton;
    }
}