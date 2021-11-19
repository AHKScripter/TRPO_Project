
namespace TRPO_Project
{
    partial class ToDoItem
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
            this.components = new System.ComponentModel.Container();
            this.ToDoList_Elipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ToDoItem_lable_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToDoList_Elipse1
            // 
            this.ToDoList_Elipse1.ElipseRadius = 15;
            this.ToDoList_Elipse1.TargetControl = this;
            // 
            // ToDoItem_lable_text
            // 
            this.ToDoItem_lable_text.AutoSize = true;
            this.ToDoItem_lable_text.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDoItem_lable_text.ForeColor = System.Drawing.Color.White;
            this.ToDoItem_lable_text.Location = new System.Drawing.Point(8, 5);
            this.ToDoItem_lable_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToDoItem_lable_text.Name = "ToDoItem_lable_text";
            this.ToDoItem_lable_text.Size = new System.Drawing.Size(67, 33);
            this.ToDoItem_lable_text.TabIndex = 0;
            this.ToDoItem_lable_text.Text = "Text";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRPO_Project.Properties.Resources.trash_bin1;
            this.pictureBox1.Location = new System.Drawing.Point(353, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ToDoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToDoItem_lable_text);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ToDoItem";
            this.Size = new System.Drawing.Size(401, 42);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ToDoList_Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ToDoItem_lable_text;
    }
}
