
namespace ToDoList
{
    partial class Main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.Button_Learning = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PB1_Avatar = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.Button_Learning);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(200, 570);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // Button_Learning
            // 
            this.Button_Learning.AllowAnimations = true;
            this.Button_Learning.AllowMouseEffects = true;
            this.Button_Learning.AllowToggling = false;
            this.Button_Learning.AnimationSpeed = 200;
            this.Button_Learning.AutoGenerateColors = false;
            this.Button_Learning.AutoRoundBorders = false;
            this.Button_Learning.AutoSizeLeftIcon = true;
            this.Button_Learning.AutoSizeRightIcon = true;
            this.Button_Learning.BackColor = System.Drawing.Color.Transparent;
            this.Button_Learning.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Button_Learning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Learning.BackgroundImage")));
            this.Button_Learning.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Learning.ButtonText = "Learning ";
            this.Button_Learning.ButtonTextMarginLeft = 0;
            this.Button_Learning.ColorContrastOnClick = 45;
            this.Button_Learning.ColorContrastOnHover = 45;
            this.Button_Learning.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Button_Learning.CustomizableEdges = borderEdges1;
            this.Button_Learning.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Learning.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Learning.DisabledFillColor = System.Drawing.Color.Empty;
            this.Button_Learning.DisabledForecolor = System.Drawing.Color.Empty;
            this.Button_Learning.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_Learning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Learning.ForeColor = System.Drawing.Color.White;
            this.Button_Learning.IconLeft = global::ToDoList.Properties.Resources.astronomy;
            this.Button_Learning.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Learning.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Learning.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Button_Learning.IconMarginLeft = 11;
            this.Button_Learning.IconPadding = 10;
            this.Button_Learning.IconRight = null;
            this.Button_Learning.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Learning.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Learning.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Button_Learning.IconSize = 25;
            this.Button_Learning.IdleBorderColor = System.Drawing.Color.Empty;
            this.Button_Learning.IdleBorderRadius = 0;
            this.Button_Learning.IdleBorderThickness = 0;
            this.Button_Learning.IdleFillColor = System.Drawing.Color.Empty;
            this.Button_Learning.IdleIconLeftImage = global::ToDoList.Properties.Resources.astronomy;
            this.Button_Learning.IdleIconRightImage = null;
            this.Button_Learning.IndicateFocus = false;
            this.Button_Learning.Location = new System.Drawing.Point(0, 160);
            this.Button_Learning.Name = "Button_Learning";
            this.Button_Learning.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Learning.OnDisabledState.BorderRadius = 0;
            this.Button_Learning.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Learning.OnDisabledState.BorderThickness = 0;
            this.Button_Learning.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Learning.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Learning.OnDisabledState.IconLeftImage = null;
            this.Button_Learning.OnDisabledState.IconRightImage = null;
            this.Button_Learning.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Button_Learning.onHoverState.BorderRadius = 0;
            this.Button_Learning.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Learning.onHoverState.BorderThickness = 0;
            this.Button_Learning.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(187)))), ((int)(((byte)(206)))));
            this.Button_Learning.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Button_Learning.onHoverState.IconLeftImage = global::ToDoList.Properties.Resources.astronomy;
            this.Button_Learning.onHoverState.IconRightImage = null;
            this.Button_Learning.OnIdleState.BorderColor = System.Drawing.Color.DarkViolet;
            this.Button_Learning.OnIdleState.BorderRadius = 0;
            this.Button_Learning.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Learning.OnIdleState.BorderThickness = 0;
            this.Button_Learning.OnIdleState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Button_Learning.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Button_Learning.OnIdleState.IconLeftImage = global::ToDoList.Properties.Resources.astronomy;
            this.Button_Learning.OnIdleState.IconRightImage = null;
            this.Button_Learning.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.Button_Learning.OnPressedState.BorderRadius = 0;
            this.Button_Learning.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Learning.OnPressedState.BorderThickness = 0;
            this.Button_Learning.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Button_Learning.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Button_Learning.OnPressedState.IconLeftImage = global::ToDoList.Properties.Resources.astronomy_2;
            this.Button_Learning.OnPressedState.IconRightImage = null;
            this.Button_Learning.Size = new System.Drawing.Size(200, 78);
            this.Button_Learning.TabIndex = 1;
            this.Button_Learning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Learning.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button_Learning.TextMarginLeft = 0;
            this.Button_Learning.TextPadding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.Button_Learning.UseDefaultRadiusAndThickness = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PB1_Avatar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 154);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alex T.";
            // 
            // PB1_Avatar
            // 
            this.PB1_Avatar.Image = global::ToDoList.Properties.Resources.uranus;
            this.PB1_Avatar.Location = new System.Drawing.Point(50, 10);
            this.PB1_Avatar.Name = "PB1_Avatar";
            this.PB1_Avatar.Size = new System.Drawing.Size(100, 100);
            this.PB1_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1_Avatar.TabIndex = 0;
            this.PB1_Avatar.TabStop = false;
            // 
            // Main_window
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 570);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB1_Avatar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Learning;
        private System.Windows.Forms.Label label1;
    }
}

