namespace PictureViewerPeshekhonova
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растянутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьФотоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.вернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 377);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 386);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Stretch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.showButton);
            this.flowLayoutPanel1.Controls.Add(this.clearButton);
            this.flowLayoutPanel1.Controls.Add(this.backgroundButton);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 386);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 37);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(559, 3);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(112, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Показать рисунок";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(428, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистить рисунок";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // backgroundButton
            // 
            this.backgroundButton.Location = new System.Drawing.Point(278, 3);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(144, 23);
            this.backgroundButton.TabIndex = 2;
            this.backgroundButton.Text = "Установить цвет фона";
            this.backgroundButton.UseVisualStyleBackColor = true;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(166, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(106, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Выбор файла изображения";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.свойстваToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
<<<<<<< HEAD
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
=======
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
<<<<<<< HEAD
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
=======
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.растянутьToolStripMenuItem,
            this.изменитьЦветФонаToolStripMenuItem,
<<<<<<< HEAD
            this.удалитьФотоToolStripMenuItem,
            this.вернутьToolStripMenuItem});
=======
            this.удалитьФотоToolStripMenuItem});
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.свойстваToolStripMenuItem.Text = "Правка";
            // 
            // растянутьToolStripMenuItem
            // 
            this.растянутьToolStripMenuItem.Name = "растянутьToolStripMenuItem";
<<<<<<< HEAD
            this.растянутьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
=======
            this.растянутьToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
            this.растянутьToolStripMenuItem.Text = "Растянуть";
            this.растянутьToolStripMenuItem.Click += new System.EventHandler(this.растянутьToolStripMenuItem_Click);
            // 
            // изменитьЦветФонаToolStripMenuItem
            // 
            this.изменитьЦветФонаToolStripMenuItem.Name = "изменитьЦветФонаToolStripMenuItem";
            this.изменитьЦветФонаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
<<<<<<< HEAD
            this.изменитьЦветФонаToolStripMenuItem.Text = "Очистить";
=======
            this.изменитьЦветФонаToolStripMenuItem.Text = "Вернуть";
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
            this.изменитьЦветФонаToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветФонаToolStripMenuItem_Click);
            // 
            // удалитьФотоToolStripMenuItem
            // 
            this.удалитьФотоToolStripMenuItem.Name = "удалитьФотоToolStripMenuItem";
            this.удалитьФотоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьФотоToolStripMenuItem.Text = "Изменить фон";
            this.удалитьФотоToolStripMenuItem.Click += new System.EventHandler(this.удалитьФотоToolStripMenuItem_Click);
            // 
<<<<<<< HEAD
            // вернутьToolStripMenuItem
            // 
            this.вернутьToolStripMenuItem.Name = "вернутьToolStripMenuItem";
            this.вернутьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вернутьToolStripMenuItem.Text = "вернуть";
            this.вернутьToolStripMenuItem.Click += new System.EventHandler(this.вернутьToolStripMenuItem_Click);
            // 
=======
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Средство просмотра изображений";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растянутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьФотоToolStripMenuItem;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripMenuItem вернутьToolStripMenuItem;
=======
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
    }
}

