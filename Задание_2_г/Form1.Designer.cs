namespace Задание_2_г
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
            this.Maslabel = new System.Windows.Forms.Label();
            this.IndexMin = new System.Windows.Forms.TextBox();
            this.IndexMinbutton = new System.Windows.Forms.Button();
            this.IndMinlabel = new System.Windows.Forms.Label();
            this.Mas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            this.SuspendLayout();
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nlabel.Location = new System.Drawing.Point(12, 22);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(251, 28);
            this.Nlabel.TabIndex = 0;
            this.Nlabel.Text = "Размерность массива";
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(286, 20);
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
            this.InMasbutton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InMasbutton.Location = new System.Drawing.Point(476, 12);
            this.InMasbutton.Name = "InMasbutton";
            this.InMasbutton.Size = new System.Drawing.Size(259, 90);
            this.InMasbutton.TabIndex = 2;
            this.InMasbutton.Text = "Рандомно сгенерировать массив";
            this.InMasbutton.UseVisualStyleBackColor = true;
            this.InMasbutton.Click += new System.EventHandler(this.InMasbutton_Click);
            // 
            // Maslabel
            // 
            this.Maslabel.AutoSize = true;
            this.Maslabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Maslabel.Location = new System.Drawing.Point(359, 112);
            this.Maslabel.Name = "Maslabel";
            this.Maslabel.Size = new System.Drawing.Size(96, 28);
            this.Maslabel.TabIndex = 3;
            this.Maslabel.Text = "Массив";
            // 
            // IndexMin
            // 
            this.IndexMin.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexMin.Location = new System.Drawing.Point(476, 302);
            this.IndexMin.Name = "IndexMin";
            this.IndexMin.ReadOnly = true;
            this.IndexMin.Size = new System.Drawing.Size(312, 36);
            this.IndexMin.TabIndex = 7;
            // 
            // IndexMinbutton
            // 
            this.IndexMinbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexMinbutton.Location = new System.Drawing.Point(137, 219);
            this.IndexMinbutton.Name = "IndexMinbutton";
            this.IndexMinbutton.Size = new System.Drawing.Size(576, 48);
            this.IndexMinbutton.TabIndex = 5;
            this.IndexMinbutton.Text = "Узнать номера минимальных элементов";
            this.IndexMinbutton.UseVisualStyleBackColor = true;
            this.IndexMinbutton.Click += new System.EventHandler(this.IndexMinbutton_Click);
            // 
            // IndMinlabel
            // 
            this.IndMinlabel.AutoSize = true;
            this.IndMinlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndMinlabel.Location = new System.Drawing.Point(12, 305);
            this.IndMinlabel.Name = "IndMinlabel";
            this.IndMinlabel.Size = new System.Drawing.Size(443, 28);
            this.IndMinlabel.TabIndex = 6;
            this.IndMinlabel.Text = "Номера всех минимальных элементов";
            // 
            // Mas
            // 
            this.Mas.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mas.Location = new System.Drawing.Point(12, 158);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(776, 36);
            this.Mas.TabIndex = 8;
            this.Mas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mas_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mas);
            this.Controls.Add(this.IndexMin);
            this.Controls.Add(this.IndMinlabel);
            this.Controls.Add(this.IndexMinbutton);
            this.Controls.Add(this.Maslabel);
            this.Controls.Add(this.InMasbutton);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Nlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nlabel;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.Button InMasbutton;
        private System.Windows.Forms.Label Maslabel;
        private System.Windows.Forms.TextBox IndexMin;
        private System.Windows.Forms.Button IndexMinbutton;
        private System.Windows.Forms.Label IndMinlabel;
        private System.Windows.Forms.TextBox Mas;
    }
}

