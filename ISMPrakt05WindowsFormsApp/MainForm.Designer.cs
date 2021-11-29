
namespace ISMPrakt05WindowsFormsApp
{
    partial class MainForm
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
            this.taskLabel = new System.Windows.Forms.Label();
            this.holderN = new System.Windows.Forms.Label();
            this.colsElemetsText = new System.Windows.Forms.TextBox();
            this.generateArrayBautton = new System.Windows.Forms.Button();
            this.arrayLabel = new System.Windows.Forms.Label();
            this.arrayTextBox = new System.Windows.Forms.TextBox();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.operationLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabel.Location = new System.Drawing.Point(12, 22);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(346, 25);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Введите кл-во элементов массива:";
            // 
            // holderN
            // 
            this.holderN.AutoSize = true;
            this.holderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderN.Location = new System.Drawing.Point(12, 70);
            this.holderN.Name = "holderN";
            this.holderN.Size = new System.Drawing.Size(48, 25);
            this.holderN.TabIndex = 1;
            this.holderN.Text = "N = ";
            // 
            // colsElemetsText
            // 
            this.colsElemetsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colsElemetsText.Location = new System.Drawing.Point(66, 70);
            this.colsElemetsText.Name = "colsElemetsText";
            this.colsElemetsText.Size = new System.Drawing.Size(298, 30);
            this.colsElemetsText.TabIndex = 2;
            // 
            // generateArrayBautton
            // 
            this.generateArrayBautton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateArrayBautton.Location = new System.Drawing.Point(83, 151);
            this.generateArrayBautton.Name = "generateArrayBautton";
            this.generateArrayBautton.Size = new System.Drawing.Size(183, 53);
            this.generateArrayBautton.TabIndex = 3;
            this.generateArrayBautton.Text = "Сгенерировать";
            this.generateArrayBautton.UseVisualStyleBackColor = true;
            this.generateArrayBautton.Click += new System.EventHandler(this.generateArrayBautton_Click);
            // 
            // arrayLabel
            // 
            this.arrayLabel.AutoSize = true;
            this.arrayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrayLabel.Location = new System.Drawing.Point(548, 19);
            this.arrayLabel.Name = "arrayLabel";
            this.arrayLabel.Size = new System.Drawing.Size(79, 25);
            this.arrayLabel.TabIndex = 4;
            this.arrayLabel.Text = "Массив";
            // 
            // arrayTextBox
            // 
            this.arrayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrayTextBox.Location = new System.Drawing.Point(427, 67);
            this.arrayTextBox.Multiline = true;
            this.arrayTextBox.Name = "arrayTextBox";
            this.arrayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.arrayTextBox.Size = new System.Drawing.Size(347, 172);
            this.arrayTextBox.TabIndex = 5;
            // 
            // operationComboBox
            // 
            this.operationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "Сумма отрицательных элементов массива",
            "Максимальный среди парных элементов массива",
            "Произведение элементов массива с парными индексами",
            "Индекс максимального элемента массива",
            "Максимальный за модулем элемент массива",
            "Сумма индексов положительных элемнтов",
            "Кл-во непарных элементов массива"});
            this.operationComboBox.Location = new System.Drawing.Point(233, 288);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(541, 28);
            this.operationComboBox.TabIndex = 6;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.operationComboBox_SelectedIndexChanged);
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationLabel.Location = new System.Drawing.Point(12, 291);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(204, 25);
            this.operationLabel.TabIndex = 7;
            this.operationLabel.Text = "Выберите действие:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(103, 424);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(64, 25);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "label1";
            this.resultLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 593);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.arrayTextBox);
            this.Controls.Add(this.arrayLabel);
            this.Controls.Add(this.generateArrayBautton);
            this.Controls.Add(this.colsElemetsText);
            this.Controls.Add(this.holderN);
            this.Controls.Add(this.taskLabel);
            this.Name = "MainForm";
            this.Text = "Операції над мисивами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label holderN;
        private System.Windows.Forms.TextBox colsElemetsText;
        private System.Windows.Forms.Button generateArrayBautton;
        private System.Windows.Forms.Label arrayLabel;
        private System.Windows.Forms.TextBox arrayTextBox;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

