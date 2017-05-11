namespace CRUD_v2
{
    partial class MainAP
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnOpenBuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Управление таблицей \"Шаблоны поиска\"";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выйти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRole.Location = new System.Drawing.Point(29, 9);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 13);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Status";
            this.lblRole.Visible = false;
            // 
            // btnOpenBuilder
            // 
            this.btnOpenBuilder.Location = new System.Drawing.Point(83, 114);
            this.btnOpenBuilder.Name = "btnOpenBuilder";
            this.btnOpenBuilder.Size = new System.Drawing.Size(147, 23);
            this.btnOpenBuilder.TabIndex = 4;
            this.btnOpenBuilder.Text = "Паттерн Строитель";
            this.btnOpenBuilder.UseVisualStyleBackColor = true;
            this.btnOpenBuilder.Click += new System.EventHandler(this.btnOpenBuilder_Click);
            // 
            // MainAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 215);
            this.Controls.Add(this.btnOpenBuilder);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "MainAP";
            this.Text = "Панель администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnOpenBuilder;
    }
}