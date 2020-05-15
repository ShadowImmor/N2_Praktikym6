namespace Задание_1_1_г
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
            this.Nlabel = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.InMasbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.NumericUpDown();
            this.Isn = new System.Windows.Forms.RichTextBox();
            this.Ishlabel = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.Ismlable = new System.Windows.Forms.Label();
            this.Ism = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            this.SuspendLayout();
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nlabel.Location = new System.Drawing.Point(12, 34);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(251, 28);
            this.Nlabel.TabIndex = 0;
            this.Nlabel.Text = "Размерность массива";
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(280, 32);
            this.N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 36);
            this.N.TabIndex = 1;
            this.N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InMasbutton
            // 
            this.InMasbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InMasbutton.Location = new System.Drawing.Point(483, 22);
            this.InMasbutton.Name = "InMasbutton";
            this.InMasbutton.Size = new System.Drawing.Size(360, 53);
            this.InMasbutton.TabIndex = 3;
            this.InMasbutton.Text = "Сгенерировать массив";
            this.InMasbutton.UseVisualStyleBackColor = true;
            this.InMasbutton.Click += new System.EventHandler(this.InMasbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Минимальное значение";
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min.Location = new System.Drawing.Point(315, 90);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(120, 36);
            this.Min.TabIndex = 6;
            // 
            // Isn
            // 
            this.Isn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Isn.Location = new System.Drawing.Point(17, 216);
            this.Isn.Name = "Isn";
            this.Isn.ReadOnly = true;
            this.Isn.Size = new System.Drawing.Size(1133, 42);
            this.Isn.TabIndex = 7;
            this.Isn.Text = "";
            // 
            // Ishlabel
            // 
            this.Ishlabel.AutoSize = true;
            this.Ishlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ishlabel.Location = new System.Drawing.Point(478, 162);
            this.Ishlabel.Name = "Ishlabel";
            this.Ishlabel.Size = new System.Drawing.Size(214, 28);
            this.Ishlabel.TabIndex = 8;
            this.Ishlabel.Text = "Исходный массив";
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(483, 275);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(173, 45);
            this.Change.TabIndex = 9;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Ismlable
            // 
            this.Ismlable.AutoSize = true;
            this.Ismlable.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ismlable.Location = new System.Drawing.Point(447, 354);
            this.Ismlable.Name = "Ismlable";
            this.Ismlable.Size = new System.Drawing.Size(245, 28);
            this.Ismlable.TabIndex = 10;
            this.Ismlable.Text = "Измененный массив";
            // 
            // Ism
            // 
            this.Ism.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ism.Location = new System.Drawing.Point(17, 408);
            this.Ism.Name = "Ism";
            this.Ism.ReadOnly = true;
            this.Ism.Size = new System.Drawing.Size(1133, 43);
            this.Ism.TabIndex = 11;
            this.Ism.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 470);
            this.Controls.Add(this.Ism);
            this.Controls.Add(this.Ismlable);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Ishlabel);
            this.Controls.Add(this.Isn);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InMasbutton);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Nlabel);
            this.Name = "Form1";
            this.Text = "Задание 1.1";
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nlabel;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.Button InMasbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Min;
        private System.Windows.Forms.RichTextBox Isn;
        private System.Windows.Forms.Label Ishlabel;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label Ismlable;
        private System.Windows.Forms.RichTextBox Ism;
    }
}

