
namespace StudentDb
{
    partial class Student_Information
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.StudentGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Group = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(430, 12);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(136, 22);
            this.FirstName.TabIndex = 2;
            // 
            // StudentGridView1
            // 
            this.StudentGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView1.Location = new System.Drawing.Point(9, 310);
            this.StudentGridView1.Name = "StudentGridView1";
            this.StudentGridView1.RowHeadersWidth = 51;
            this.StudentGridView1.RowTemplate.Height = 24;
            this.StudentGridView1.Size = new System.Drawing.Size(823, 160);
            this.StudentGridView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(605, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 47);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(430, 55);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(136, 22);
            this.LastName.TabIndex = 7;
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(430, 101);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(136, 22);
            this.Group.TabIndex = 8;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(430, 150);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(136, 22);
            this.Address.TabIndex = 9;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(430, 192);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(136, 22);
            this.PhoneNumber.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "PhoneNumber";
            // 
            // Student_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 471);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StudentGridView1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student_Information";
            this.Text = "Student_Information";
            this.Load += new System.EventHandler(this.Student_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.DataGridView StudentGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

