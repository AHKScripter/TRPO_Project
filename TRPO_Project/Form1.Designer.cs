
namespace TRPO_Project
{
    partial class Main_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.Main_menu_panel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicBox_Avatar = new System.Windows.Forms.PictureBox();
            this.Main_menu_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_menu_panel
            // 
            this.Main_menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.Main_menu_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Main_menu_panel.BackgroundImage")));
            this.Main_menu_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_menu_panel.BorderRadius = 1;
            this.Main_menu_panel.Controls.Add(this.panel1);
            this.Main_menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Main_menu_panel.GradientBottomLeft = System.Drawing.Color.DarkBlue;
            this.Main_menu_panel.GradientBottomRight = System.Drawing.Color.DarkMagenta;
            this.Main_menu_panel.GradientTopLeft = System.Drawing.Color.Aqua;
            this.Main_menu_panel.GradientTopRight = System.Drawing.Color.DeepPink;
            this.Main_menu_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_menu_panel.Name = "Main_menu_panel";
            this.Main_menu_panel.Quality = 10;
            this.Main_menu_panel.Size = new System.Drawing.Size(200, 570);
            this.Main_menu_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PicBox_Avatar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 154);
            this.panel1.TabIndex = 0;
            // 
            // PicBox_Avatar
            // 
            this.PicBox_Avatar.Image = global::TRPO_Project.Properties.Resources.uranus;
            this.PicBox_Avatar.Location = new System.Drawing.Point(50, 10);
            this.PicBox_Avatar.Name = "PicBox_Avatar";
            this.PicBox_Avatar.Size = new System.Drawing.Size(100, 100);
            this.PicBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Avatar.TabIndex = 0;
            this.PicBox_Avatar.TabStop = false;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 570);
            this.Controls.Add(this.Main_menu_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList";
            this.Main_menu_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel Main_menu_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicBox_Avatar;
    }
}

