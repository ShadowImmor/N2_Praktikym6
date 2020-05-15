namespace Задание_1_2_г
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rasmerlabel = new System.Windows.Forms.Label();
            this.Minlabel = new System.Windows.Forms.Label();
            this.InMas = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.Min = new System.Windows.Forms.NumericUpDown();
            this.Isn = new System.Windows.Forms.RichTextBox();
            this.Ishlabel = new System.Windows.Forms.Label();
            this.Ismlabel = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.Ism = new System.Windows.Forms.RichTextBox();
            this.Nlabel = new System.Windows.Forms.Label();
            this.Mlabel = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M)).BeginInit();
            this.SuspendLayout();
            // 
            // Rasmerlabel
            // 
            this.Rasmerlabel.AutoSize = true;
            this.Rasmerlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rasmerlabel.Location = new System.Drawing.Point(12, 48);
            this.Rasmerlabel.Name = "Rasmerlabel";
            this.Rasmerlabel.Size = new System.Drawing.Size(285, 28);
            this.Rasmerlabel.TabIndex = 0;
            this.Rasmerlabel.Text = "Введите размер массива";
            // 
            // Minlabel
            // 
            this.Minlabel.AutoSize = true;
            this.Minlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minlabel.Location = new System.Drawing.Point(12, 149);
            this.Minlabel.Name = "Minlabel";
            this.Minlabel.Size = new System.Drawing.Size(285, 28);
            this.Minlabel.TabIndex = 1;
            this.Minlabel.Text = "Минимальное значение";
            // 
            // InMas
            // 
            this.InMas.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InMas.Location = new System.Drawing.Point(350, 285);
            this.InMas.Name = "InMas";
            this.InMas.Size = new System.Drawing.Size(229, 70);
            this.InMas.TabIndex = 2;
            this.InMas.Text = "Сгенерировать\r\nмассив";
            this.InMas.UseVisualStyleBackColor = true;
            this.InMas.Click += new System.EventHandler(this.InMas_Click);
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(585, 11);
            this.N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(82, 36);
            this.N.TabIndex = 3;
            this.N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min.Location = new System.Drawing.Point(318, 147);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(128, 36);
            this.Min.TabIndex = 4;
            // 
            // Isn
            // 
            this.Isn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Isn.Location = new System.Drawing.Point(12, 257);
            this.Isn.Name = "Isn";
            this.Isn.ReadOnly = true;
            this.Isn.Size = new System.Drawing.Size(329, 253);
            this.Isn.TabIndex = 5;
            this.Isn.Text = "";
            // 
            // Ishlabel
            // 
            this.Ishlabel.AutoSize = true;
            this.Ishlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ishlabel.Location = new System.Drawing.Point(41, 220);
            this.Ishlabel.Name = "Ishlabel";
            this.Ishlabel.Size = new System.Drawing.Size(214, 28);
            this.Ishlabel.TabIndex = 6;
            this.Ishlabel.Text = "Исходный массив";
            // 
            // Ismlabel
            // 
            this.Ismlabel.AutoSize = true;
            this.Ismlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ismlabel.Location = new System.Drawing.Point(657, 220);
            this.Ismlabel.Name = "Ismlabel";
            this.Ismlabel.Size = new System.Drawing.Size(245, 28);
            this.Ismlabel.TabIndex = 7;
            this.Ismlabel.Text = "Измененный массив";
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(386, 427);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(164, 44);
            this.Change.TabIndex = 8;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Ism
            // 
            this.Ism.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ism.Location = new System.Drawing.Point(600, 257);
            this.Ism.Name = "Ism";
            this.Ism.ReadOnly = true;
            this.Ism.Size = new System.Drawing.Size(329, 253);
            this.Ism.TabIndex = 9;
            this.Ism.Text = "";
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nlabel.Location = new System.Drawing.Point(313, 13);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(226, 28);
            this.Nlabel.TabIndex = 10;
            this.Nlabel.Text = "Колличество строк";
            // 
            // Mlabel
            // 
            this.Mlabel.AutoSize = true;
            this.Mlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mlabel.Location = new System.Drawing.Point(313, 74);
            this.Mlabel.Name = "Mlabel";
            this.Mlabel.Size = new System.Drawing.Size(266, 28);
            this.Mlabel.TabIndex = 11;
            this.Mlabel.Text = "Колличество столбцов";
            // 
            // M
            // 
            this.M.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M.Location = new System.Drawing.Point(585, 72);
            this.M.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(82, 36);
            this.M.TabIndex = 12;
            this.M.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 522);
            this.Controls.Add(this.M);
            this.Controls.Add(this.Mlabel);
            this.Controls.Add(this.Nlabel);
            this.Controls.Add(this.Ism);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Ismlabel);
            this.Controls.Add(this.Ishlabel);
            this.Controls.Add(this.Isn);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.N);
            this.Controls.Add(this.InMas);
            this.Controls.Add(this.Minlabel);
            this.Controls.Add(this.Rasmerlabel);
            this.Name = "Form1";
            this.Text = "Задание 1.2";
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rasmerlabel;
        private System.Windows.Forms.Label Minlabel;
        private System.Windows.Forms.Button InMas;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.NumericUpDown Min;
        private System.Windows.Forms.RichTextBox Isn;
        private System.Windows.Forms.Label Ishlabel;
        private System.Windows.Forms.Label Ismlabel;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.RichTextBox Ism;
        private System.Windows.Forms.Label Nlabel;
        private System.Windows.Forms.Label Mlabel;
        private System.Windows.Forms.NumericUpDown M;
    }
}

