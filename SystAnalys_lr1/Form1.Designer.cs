namespace SystAnalys_lr1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.buttonInc = new System.Windows.Forms.Button();
            this.buttonAdj = new System.Windows.Forms.Button();
            this.deleteALLButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.drawEdgeButton = new System.Windows.Forms.Button();
            this.drawVertexButton = new System.Windows.Forms.Button();
            this.sheet = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Вершины = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cycleButton = new System.Windows.Forms.Button();
            this.chainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.Вершины.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.ItemHeight = 22;
            this.listBoxMatrix.Location = new System.Drawing.Point(4, 70);
            this.listBoxMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(399, 400);
            this.listBoxMatrix.TabIndex = 6;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.selectButton.Location = new System.Drawing.Point(227, 23);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(101, 55);
            this.selectButton.TabIndex = 9;
            this.selectButton.Text = "Выбрать вершину";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // buttonInc
            // 
            this.buttonInc.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonInc.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInc.Location = new System.Drawing.Point(132, 7);
            this.buttonInc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(127, 55);
            this.buttonInc.TabIndex = 8;
            this.buttonInc.Text = "Матрица Инцидентности";
            this.buttonInc.UseVisualStyleBackColor = false;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click);
            // 
            // buttonAdj
            // 
            this.buttonAdj.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonAdj.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdj.Location = new System.Drawing.Point(4, 7);
            this.buttonAdj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdj.Name = "buttonAdj";
            this.buttonAdj.Size = new System.Drawing.Size(120, 55);
            this.buttonAdj.TabIndex = 7;
            this.buttonAdj.Text = "Матрица Смежности";
            this.buttonAdj.UseVisualStyleBackColor = false;
            this.buttonAdj.Click += new System.EventHandler(this.buttonAdj_Click);
            // 
            // deleteALLButton
            // 
            this.deleteALLButton.BackColor = System.Drawing.Color.Plum;
            this.deleteALLButton.Location = new System.Drawing.Point(449, 23);
            this.deleteALLButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteALLButton.Name = "deleteALLButton";
            this.deleteALLButton.Size = new System.Drawing.Size(103, 55);
            this.deleteALLButton.TabIndex = 5;
            this.deleteALLButton.Text = "Очистить поле";
            this.deleteALLButton.UseVisualStyleBackColor = false;
            this.deleteALLButton.Click += new System.EventHandler(this.deleteALLButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightSalmon;
            this.deleteButton.Location = new System.Drawing.Point(336, 23);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 55);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить вершину";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // drawEdgeButton
            // 
            this.drawEdgeButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.drawEdgeButton.Location = new System.Drawing.Point(117, 23);
            this.drawEdgeButton.Margin = new System.Windows.Forms.Padding(4);
            this.drawEdgeButton.Name = "drawEdgeButton";
            this.drawEdgeButton.Size = new System.Drawing.Size(101, 55);
            this.drawEdgeButton.TabIndex = 2;
            this.drawEdgeButton.Text = "Связать вершины";
            this.drawEdgeButton.UseVisualStyleBackColor = false;
            this.drawEdgeButton.Click += new System.EventHandler(this.drawEdgeButton_Click);
            // 
            // drawVertexButton
            // 
            this.drawVertexButton.BackColor = System.Drawing.Color.PaleGreen;
            this.drawVertexButton.Location = new System.Drawing.Point(8, 23);
            this.drawVertexButton.Margin = new System.Windows.Forms.Padding(4);
            this.drawVertexButton.Name = "drawVertexButton";
            this.drawVertexButton.Size = new System.Drawing.Size(101, 55);
            this.drawVertexButton.TabIndex = 1;
            this.drawVertexButton.Text = "Добавить вершину";
            this.drawVertexButton.UseVisualStyleBackColor = false;
            this.drawVertexButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sheet.Location = new System.Drawing.Point(8, 86);
            this.sheet.Margin = new System.Windows.Forms.Padding(4);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(543, 461);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.Click += new System.EventHandler(this.sheet_Click);
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Диаметр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Радиус:";
            // 
            // Вершины
            // 
            this.Вершины.Controls.Add(this.tabPage1);
            this.Вершины.Controls.Add(this.tabPage2);
            this.Вершины.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вершины.Location = new System.Drawing.Point(16, 15);
            this.Вершины.Margin = new System.Windows.Forms.Padding(4);
            this.Вершины.Name = "Вершины";
            this.Вершины.SelectedIndex = 0;
            this.Вершины.Size = new System.Drawing.Size(581, 587);
            this.Вершины.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.Controls.Add(this.drawVertexButton);
            this.tabPage1.Controls.Add(this.sheet);
            this.tabPage1.Controls.Add(this.drawEdgeButton);
            this.tabPage1.Controls.Add(this.selectButton);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.deleteALLButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(573, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MintCream;
            this.tabPage2.Controls.Add(this.cycleButton);
            this.tabPage2.Controls.Add(this.chainButton);
            this.tabPage2.Controls.Add(this.buttonAdj);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.listBoxMatrix);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonInc);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(573, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // cycleButton
            // 
            this.cycleButton.BackColor = System.Drawing.Color.LightCyan;
            this.cycleButton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cycleButton.Location = new System.Drawing.Point(272, 7);
            this.cycleButton.Margin = new System.Windows.Forms.Padding(4);
            this.cycleButton.Name = "cycleButton";
            this.cycleButton.Size = new System.Drawing.Size(136, 54);
            this.cycleButton.TabIndex = 16;
            this.cycleButton.Text = "Отобразить циклы";
            this.cycleButton.UseVisualStyleBackColor = false;
            this.cycleButton.Click += new System.EventHandler(this.cycleButton_Click);
            // 
            // chainButton
            // 
            this.chainButton.BackColor = System.Drawing.Color.MistyRose;
            this.chainButton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chainButton.Location = new System.Drawing.Point(416, 7);
            this.chainButton.Margin = new System.Windows.Forms.Padding(4);
            this.chainButton.Name = "chainButton";
            this.chainButton.Size = new System.Drawing.Size(127, 55);
            this.chainButton.TabIndex = 15;
            this.chainButton.Text = "Построить цепи";
            this.chainButton.UseVisualStyleBackColor = false;
            this.chainButton.Click += new System.EventHandler(this.chainButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(619, 625);
            this.Controls.Add(this.Вершины);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Понятие графа";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.Вершины.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button drawVertexButton;
        private System.Windows.Forms.Button drawEdgeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteALLButton;
        private System.Windows.Forms.ListBox listBoxMatrix;
        private System.Windows.Forms.Button buttonAdj;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl Вершины;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button chainButton;
        private System.Windows.Forms.Button cycleButton;
    }
}

