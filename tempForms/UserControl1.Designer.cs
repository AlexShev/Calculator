
namespace tempForms
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMC
            // 
            this.buttonMC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMC.FlatAppearance.BorderSize = 0;
            this.buttonMC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMC.Location = new System.Drawing.Point(196, 31);
            this.buttonMC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(37, 21);
            this.buttonMC.TabIndex = 63;
            this.buttonMC.Text = "МC";
            this.buttonMC.UseVisualStyleBackColor = false;
            this.buttonMC.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.buttonMC.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMMinus.FlatAppearance.BorderSize = 0;
            this.buttonMMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMMinus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMMinus.Location = new System.Drawing.Point(278, 31);
            this.buttonMMinus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(37, 21);
            this.buttonMMinus.TabIndex = 62;
            this.buttonMMinus.Text = "М-";
            this.buttonMMinus.UseVisualStyleBackColor = false;
            this.buttonMMinus.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.buttonMMinus.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMPlus.FlatAppearance.BorderSize = 0;
            this.buttonMPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMPlus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMPlus.Location = new System.Drawing.Point(237, 31);
            this.buttonMPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(37, 21);
            this.buttonMPlus.TabIndex = 61;
            this.buttonMPlus.Text = "М+";
            this.buttonMPlus.UseVisualStyleBackColor = false;
            this.buttonMPlus.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.buttonMPlus.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            // 
            // label1
            // 
            this.label_1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_1.Location = new System.Drawing.Point(13, 6);
            this.label_1.Name = "label1";
            this.label_1.Size = new System.Drawing.Size(312, 23);
            this.label_1.TabIndex = 64;
            this.label_1.Text = "label1";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_1.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.label_1.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.label_1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(330, 60);
            this.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonMC;
        public System.Windows.Forms.Button buttonMMinus;
        public System.Windows.Forms.Button buttonMPlus;
        public System.Windows.Forms.Label label_1;
    }
}
