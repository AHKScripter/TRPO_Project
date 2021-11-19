
using System;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Main_menu_panel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.Menu_button_minimized = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Menu_button_exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Menu_button_ideas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Menu_button_targets = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Menu_button_books = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Menu_Button_Learning = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu_label_name = new System.Windows.Forms.Label();
            this.PicBox_Avatar = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ideas1 = new TRPO_Project.Ideas();
            this.targets1 = new TRPO_Project.Targets();
            this.learning1 = new TRPO_Project.Learning();
            this.books1 = new TRPO_Project.Books();
            this.time = new System.Windows.Forms.Label();
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
            this.Main_menu_panel.Controls.Add(this.Menu_button_minimized);
            this.Main_menu_panel.Controls.Add(this.Menu_button_exit);
            this.Main_menu_panel.Controls.Add(this.Menu_button_ideas);
            this.Main_menu_panel.Controls.Add(this.Menu_button_targets);
            this.Main_menu_panel.Controls.Add(this.Menu_button_books);
            this.Main_menu_panel.Controls.Add(this.Menu_Button_Learning);
            this.Main_menu_panel.Controls.Add(this.panel1);
            this.Main_menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Main_menu_panel.GradientBottomLeft = System.Drawing.Color.DarkBlue;
            this.Main_menu_panel.GradientBottomRight = System.Drawing.Color.DarkMagenta;
            this.Main_menu_panel.GradientTopLeft = System.Drawing.Color.Aqua;
            this.Main_menu_panel.GradientTopRight = System.Drawing.Color.DeepPink;
            this.Main_menu_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_menu_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_menu_panel.Name = "Main_menu_panel";
            this.Main_menu_panel.Quality = 10;
            this.Main_menu_panel.Size = new System.Drawing.Size(133, 370);
            this.Main_menu_panel.TabIndex = 0;
            // 
            // Menu_button_minimized
            // 
            this.Menu_button_minimized.AllowAnimations = true;
            this.Menu_button_minimized.AllowMouseEffects = true;
            this.Menu_button_minimized.AllowToggling = false;
            this.Menu_button_minimized.AnimationSpeed = 200;
            this.Menu_button_minimized.AutoGenerateColors = false;
            this.Menu_button_minimized.AutoRoundBorders = false;
            this.Menu_button_minimized.AutoSizeLeftIcon = true;
            this.Menu_button_minimized.AutoSizeRightIcon = true;
            this.Menu_button_minimized.BackColor = System.Drawing.Color.Transparent;
            this.Menu_button_minimized.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Menu_button_minimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_button_minimized.BackgroundImage")));
            this.Menu_button_minimized.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_minimized.ButtonText = "Minimized";
            this.Menu_button_minimized.ButtonTextMarginLeft = 0;
            this.Menu_button_minimized.ColorContrastOnClick = 45;
            this.Menu_button_minimized.ColorContrastOnHover = 45;
            this.Menu_button_minimized.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Menu_button_minimized.CustomizableEdges = borderEdges1;
            this.Menu_button_minimized.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Menu_button_minimized.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Menu_button_minimized.DisabledFillColor = System.Drawing.Color.Empty;
            this.Menu_button_minimized.DisabledForecolor = System.Drawing.Color.Empty;
            this.Menu_button_minimized.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Menu_button_minimized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu_button_minimized.ForeColor = System.Drawing.Color.White;
            this.Menu_button_minimized.IconLeft = global::TRPO_Project.Properties.Resources.minus_1;
            this.Menu_button_minimized.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_button_minimized.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_minimized.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Menu_button_minimized.IconMarginLeft = 11;
            this.Menu_button_minimized.IconPadding = 1;
            this.Menu_button_minimized.IconRight = null;
            this.Menu_button_minimized.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu_button_minimized.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_minimized.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Menu_button_minimized.IconSize = 25;
            this.Menu_button_minimized.IdleBorderColor = System.Drawing.Color.Empty;
            this.Menu_button_minimized.IdleBorderRadius = 0;
            this.Menu_button_minimized.IdleBorderThickness = 0;
            this.Menu_button_minimized.IdleFillColor = System.Drawing.Color.Empty;
            this.Menu_button_minimized.IdleIconLeftImage = global::TRPO_Project.Properties.Resources.minus_1;
            this.Menu_button_minimized.IdleIconRightImage = null;
            this.Menu_button_minimized.IndicateFocus = false;
            this.Menu_button_minimized.Location = new System.Drawing.Point(0, 318);
            this.Menu_button_minimized.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu_button_minimized.Name = "Menu_button_minimized";
            this.Menu_button_minimized.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.Menu_button_minimized.OnDisabledState.BorderRadius = 0;
            this.Menu_button_minimized.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_minimized.OnDisabledState.BorderThickness = 0;
            this.Menu_button_minimized.OnDisabledState.FillColor = System.Drawing.Color.Empty;
            this.Menu_button_minimized.OnDisabledState.ForeColor = System.Drawing.Color.Empty;
            this.Menu_button_minimized.OnDisabledState.IconLeftImage = null;
            this.Menu_button_minimized.OnDisabledState.IconRightImage = null;
            this.Menu_button_minimized.onHoverState.BorderColor = System.Drawing.Color.Indigo;
            this.Menu_button_minimized.onHoverState.BorderRadius = 0;
            this.Menu_button_minimized.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_minimized.onHoverState.BorderThickness = 0;
            this.Menu_button_minimized.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Menu_button_minimized.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_minimized.onHoverState.IconLeftImage = global::TRPO_Project.Properties.Resources.minus_1;
            this.Menu_button_minimized.onHoverState.IconRightImage = null;
            this.Menu_button_minimized.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_minimized.OnIdleState.BorderRadius = 0;
            this.Menu_button_minimized.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_minimized.OnIdleState.BorderThickness = 0;
            this.Menu_button_minimized.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_minimized.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_minimized.OnIdleState.IconLeftImage = global::TRPO_Project.Properties.Resources.minus_1;
            this.Menu_button_minimized.OnIdleState.IconRightImage = null;
            this.Menu_button_minimized.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_minimized.OnPressedState.BorderRadius = 0;
            this.Menu_button_minimized.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_minimized.OnPressedState.BorderThickness = 0;
            this.Menu_button_minimized.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_minimized.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_minimized.OnPressedState.IconLeftImage = global::TRPO_Project.Properties.Resources.minus_2;
            this.Menu_button_minimized.OnPressedState.IconRightImage = null;
            this.Menu_button_minimized.Size = new System.Drawing.Size(133, 39);
            this.Menu_button_minimized.TabIndex = 6;
            this.Menu_button_minimized.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Menu_button_minimized.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Menu_button_minimized.TextMarginLeft = 0;
            this.Menu_button_minimized.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Menu_button_minimized.UseDefaultRadiusAndThickness = true;
            this.Menu_button_minimized.Click += new System.EventHandler(this.Menu_button_minimized_Click);
            // 
            // Menu_button_exit
            // 
            this.Menu_button_exit.AllowAnimations = true;
            this.Menu_button_exit.AllowMouseEffects = true;
            this.Menu_button_exit.AllowToggling = false;
            this.Menu_button_exit.AnimationSpeed = 200;
            this.Menu_button_exit.AutoGenerateColors = false;
            this.Menu_button_exit.AutoRoundBorders = false;
            this.Menu_button_exit.AutoSizeLeftIcon = true;
            this.Menu_button_exit.AutoSizeRightIcon = true;
            this.Menu_button_exit.BackColor = System.Drawing.Color.Transparent;
            this.Menu_button_exit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Menu_button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_button_exit.BackgroundImage")));
            this.Menu_button_exit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_exit.ButtonText = "Exit";
            this.Menu_button_exit.ButtonTextMarginLeft = 0;
            this.Menu_button_exit.ColorContrastOnClick = 45;
            this.Menu_button_exit.ColorContrastOnHover = 45;
            this.Menu_button_exit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Menu_button_exit.CustomizableEdges = borderEdges2;
            this.Menu_button_exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Menu_button_exit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Menu_button_exit.DisabledFillColor = System.Drawing.Color.Empty;
            this.Menu_button_exit.DisabledForecolor = System.Drawing.Color.Empty;
            this.Menu_button_exit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Menu_button_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu_button_exit.ForeColor = System.Drawing.Color.White;
            this.Menu_button_exit.IconLeft = global::TRPO_Project.Properties.Resources.emergency_exit_1;
            this.Menu_button_exit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_button_exit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_exit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Menu_button_exit.IconMarginLeft = 11;
            this.Menu_button_exit.IconPadding = 1;
            this.Menu_button_exit.IconRight = null;
            this.Menu_button_exit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu_button_exit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_exit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Menu_button_exit.IconSize = 25;
            this.Menu_button_exit.IdleBorderColor = System.Drawing.Color.Empty;
            this.Menu_button_exit.IdleBorderRadius = 0;
            this.Menu_button_exit.IdleBorderThickness = 0;
            this.Menu_button_exit.IdleFillColor = System.Drawing.Color.Empty;
            this.Menu_button_exit.IdleIconLeftImage = global::TRPO_Project.Properties.Resources.emergency_exit_1;
            this.Menu_button_exit.IdleIconRightImage = null;
            this.Menu_button_exit.IndicateFocus = false;
            this.Menu_button_exit.Location = new System.Drawing.Point(-2, 276);
            this.Menu_button_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu_button_exit.Name = "Menu_button_exit";
            this.Menu_button_exit.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.Menu_button_exit.OnDisabledState.BorderRadius = 0;
            this.Menu_button_exit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_exit.OnDisabledState.BorderThickness = 0;
            this.Menu_button_exit.OnDisabledState.FillColor = System.Drawing.Color.Empty;
            this.Menu_button_exit.OnDisabledState.ForeColor = System.Drawing.Color.Empty;
            this.Menu_button_exit.OnDisabledState.IconLeftImage = null;
            this.Menu_button_exit.OnDisabledState.IconRightImage = null;
            this.Menu_button_exit.onHoverState.BorderColor = System.Drawing.Color.Indigo;
            this.Menu_button_exit.onHoverState.BorderRadius = 0;
            this.Menu_button_exit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_exit.onHoverState.BorderThickness = 0;
            this.Menu_button_exit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Menu_button_exit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_exit.onHoverState.IconLeftImage = global::TRPO_Project.Properties.Resources.emergency_exit_1;
            this.Menu_button_exit.onHoverState.IconRightImage = null;
            this.Menu_button_exit.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_exit.OnIdleState.BorderRadius = 0;
            this.Menu_button_exit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_exit.OnIdleState.BorderThickness = 0;
            this.Menu_button_exit.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_exit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_exit.OnIdleState.IconLeftImage = global::TRPO_Project.Properties.Resources.emergency_exit_1;
            this.Menu_button_exit.OnIdleState.IconRightImage = null;
            this.Menu_button_exit.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_exit.OnPressedState.BorderRadius = 0;
            this.Menu_button_exit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_exit.OnPressedState.BorderThickness = 0;
            this.Menu_button_exit.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_exit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_exit.OnPressedState.IconLeftImage = global::TRPO_Project.Properties.Resources.emergency_exit_2;
            this.Menu_button_exit.OnPressedState.IconRightImage = null;
            this.Menu_button_exit.Size = new System.Drawing.Size(133, 39);
            this.Menu_button_exit.TabIndex = 5;
            this.Menu_button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Menu_button_exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Menu_button_exit.TextMarginLeft = 0;
            this.Menu_button_exit.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Menu_button_exit.UseDefaultRadiusAndThickness = true;
            this.Menu_button_exit.Click += new System.EventHandler(this.Menu_button_exit_Click);
            // 
            // Menu_button_ideas
            // 
            this.Menu_button_ideas.AllowAnimations = true;
            this.Menu_button_ideas.AllowMouseEffects = true;
            this.Menu_button_ideas.AllowToggling = false;
            this.Menu_button_ideas.AnimationSpeed = 200;
            this.Menu_button_ideas.AutoGenerateColors = false;
            this.Menu_button_ideas.AutoRoundBorders = false;
            this.Menu_button_ideas.AutoSizeLeftIcon = true;
            this.Menu_button_ideas.AutoSizeRightIcon = true;
            this.Menu_button_ideas.BackColor = System.Drawing.Color.Transparent;
            this.Menu_button_ideas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Menu_button_ideas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_button_ideas.BackgroundImage")));
            this.Menu_button_ideas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_ideas.ButtonText = "Ideas";
            this.Menu_button_ideas.ButtonTextMarginLeft = 0;
            this.Menu_button_ideas.ColorContrastOnClick = 45;
            this.Menu_button_ideas.ColorContrastOnHover = 45;
            this.Menu_button_ideas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Menu_button_ideas.CustomizableEdges = borderEdges3;
            this.Menu_button_ideas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Menu_button_ideas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Menu_button_ideas.DisabledFillColor = System.Drawing.Color.Empty;
            this.Menu_button_ideas.DisabledForecolor = System.Drawing.Color.Empty;
            this.Menu_button_ideas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Menu_button_ideas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu_button_ideas.ForeColor = System.Drawing.Color.White;
            this.Menu_button_ideas.IconLeft = global::TRPO_Project.Properties.Resources.idea_1;
            this.Menu_button_ideas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_button_ideas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_ideas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Menu_button_ideas.IconMarginLeft = 11;
            this.Menu_button_ideas.IconPadding = 1;
            this.Menu_button_ideas.IconRight = null;
            this.Menu_button_ideas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu_button_ideas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_ideas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Menu_button_ideas.IconSize = 25;
            this.Menu_button_ideas.IdleBorderColor = System.Drawing.Color.Empty;
            this.Menu_button_ideas.IdleBorderRadius = 0;
            this.Menu_button_ideas.IdleBorderThickness = 0;
            this.Menu_button_ideas.IdleFillColor = System.Drawing.Color.Empty;
            this.Menu_button_ideas.IdleIconLeftImage = global::TRPO_Project.Properties.Resources.idea_1;
            this.Menu_button_ideas.IdleIconRightImage = null;
            this.Menu_button_ideas.IndicateFocus = false;
            this.Menu_button_ideas.Location = new System.Drawing.Point(-2, 233);
            this.Menu_button_ideas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu_button_ideas.Name = "Menu_button_ideas";
            this.Menu_button_ideas.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.Menu_button_ideas.OnDisabledState.BorderRadius = 0;
            this.Menu_button_ideas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_ideas.OnDisabledState.BorderThickness = 0;
            this.Menu_button_ideas.OnDisabledState.FillColor = System.Drawing.Color.Empty;
            this.Menu_button_ideas.OnDisabledState.ForeColor = System.Drawing.Color.Empty;
            this.Menu_button_ideas.OnDisabledState.IconLeftImage = null;
            this.Menu_button_ideas.OnDisabledState.IconRightImage = null;
            this.Menu_button_ideas.onHoverState.BorderColor = System.Drawing.Color.Indigo;
            this.Menu_button_ideas.onHoverState.BorderRadius = 0;
            this.Menu_button_ideas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_ideas.onHoverState.BorderThickness = 0;
            this.Menu_button_ideas.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Menu_button_ideas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_ideas.onHoverState.IconLeftImage = global::TRPO_Project.Properties.Resources.idea_1;
            this.Menu_button_ideas.onHoverState.IconRightImage = null;
            this.Menu_button_ideas.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_ideas.OnIdleState.BorderRadius = 0;
            this.Menu_button_ideas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_ideas.OnIdleState.BorderThickness = 0;
            this.Menu_button_ideas.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_ideas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_ideas.OnIdleState.IconLeftImage = global::TRPO_Project.Properties.Resources.idea_1;
            this.Menu_button_ideas.OnIdleState.IconRightImage = null;
            this.Menu_button_ideas.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_ideas.OnPressedState.BorderRadius = 0;
            this.Menu_button_ideas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_ideas.OnPressedState.BorderThickness = 0;
            this.Menu_button_ideas.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_ideas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_ideas.OnPressedState.IconLeftImage = global::TRPO_Project.Properties.Resources.idea_2;
            this.Menu_button_ideas.OnPressedState.IconRightImage = null;
            this.Menu_button_ideas.Size = new System.Drawing.Size(133, 39);
            this.Menu_button_ideas.TabIndex = 4;
            this.Menu_button_ideas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Menu_button_ideas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Menu_button_ideas.TextMarginLeft = 0;
            this.Menu_button_ideas.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Menu_button_ideas.UseDefaultRadiusAndThickness = true;
            this.Menu_button_ideas.Click += new System.EventHandler(this.Menu_button_ideas_Click);
            // 
            // Menu_button_targets
            // 
            this.Menu_button_targets.AllowAnimations = true;
            this.Menu_button_targets.AllowMouseEffects = true;
            this.Menu_button_targets.AllowToggling = false;
            this.Menu_button_targets.AnimationSpeed = 200;
            this.Menu_button_targets.AutoGenerateColors = false;
            this.Menu_button_targets.AutoRoundBorders = false;
            this.Menu_button_targets.AutoSizeLeftIcon = true;
            this.Menu_button_targets.AutoSizeRightIcon = true;
            this.Menu_button_targets.BackColor = System.Drawing.Color.Transparent;
            this.Menu_button_targets.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Menu_button_targets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_button_targets.BackgroundImage")));
            this.Menu_button_targets.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_targets.ButtonText = "Targets";
            this.Menu_button_targets.ButtonTextMarginLeft = 0;
            this.Menu_button_targets.ColorContrastOnClick = 45;
            this.Menu_button_targets.ColorContrastOnHover = 45;
            this.Menu_button_targets.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.Menu_button_targets.CustomizableEdges = borderEdges4;
            this.Menu_button_targets.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Menu_button_targets.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Menu_button_targets.DisabledFillColor = System.Drawing.Color.Empty;
            this.Menu_button_targets.DisabledForecolor = System.Drawing.Color.Empty;
            this.Menu_button_targets.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Menu_button_targets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu_button_targets.ForeColor = System.Drawing.Color.White;
            this.Menu_button_targets.IconLeft = global::TRPO_Project.Properties.Resources.target_1;
            this.Menu_button_targets.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_button_targets.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_targets.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Menu_button_targets.IconMarginLeft = 11;
            this.Menu_button_targets.IconPadding = 1;
            this.Menu_button_targets.IconRight = null;
            this.Menu_button_targets.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu_button_targets.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_targets.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Menu_button_targets.IconSize = 25;
            this.Menu_button_targets.IdleBorderColor = System.Drawing.Color.Empty;
            this.Menu_button_targets.IdleBorderRadius = 0;
            this.Menu_button_targets.IdleBorderThickness = 0;
            this.Menu_button_targets.IdleFillColor = System.Drawing.Color.Empty;
            this.Menu_button_targets.IdleIconLeftImage = global::TRPO_Project.Properties.Resources.target_1;
            this.Menu_button_targets.IdleIconRightImage = null;
            this.Menu_button_targets.IndicateFocus = false;
            this.Menu_button_targets.Location = new System.Drawing.Point(0, 190);
            this.Menu_button_targets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu_button_targets.Name = "Menu_button_targets";
            this.Menu_button_targets.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.Menu_button_targets.OnDisabledState.BorderRadius = 0;
            this.Menu_button_targets.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_targets.OnDisabledState.BorderThickness = 0;
            this.Menu_button_targets.OnDisabledState.FillColor = System.Drawing.Color.Empty;
            this.Menu_button_targets.OnDisabledState.ForeColor = System.Drawing.Color.Empty;
            this.Menu_button_targets.OnDisabledState.IconLeftImage = null;
            this.Menu_button_targets.OnDisabledState.IconRightImage = null;
            this.Menu_button_targets.onHoverState.BorderColor = System.Drawing.Color.Indigo;
            this.Menu_button_targets.onHoverState.BorderRadius = 0;
            this.Menu_button_targets.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_targets.onHoverState.BorderThickness = 0;
            this.Menu_button_targets.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Menu_button_targets.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_targets.onHoverState.IconLeftImage = global::TRPO_Project.Properties.Resources.target_1;
            this.Menu_button_targets.onHoverState.IconRightImage = null;
            this.Menu_button_targets.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_targets.OnIdleState.BorderRadius = 0;
            this.Menu_button_targets.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_targets.OnIdleState.BorderThickness = 0;
            this.Menu_button_targets.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_targets.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_targets.OnIdleState.IconLeftImage = global::TRPO_Project.Properties.Resources.target_1;
            this.Menu_button_targets.OnIdleState.IconRightImage = null;
            this.Menu_button_targets.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_targets.OnPressedState.BorderRadius = 0;
            this.Menu_button_targets.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_targets.OnPressedState.BorderThickness = 0;
            this.Menu_button_targets.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_targets.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_targets.OnPressedState.IconLeftImage = global::TRPO_Project.Properties.Resources.target_2;
            this.Menu_button_targets.OnPressedState.IconRightImage = null;
            this.Menu_button_targets.Size = new System.Drawing.Size(133, 39);
            this.Menu_button_targets.TabIndex = 3;
            this.Menu_button_targets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Menu_button_targets.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Menu_button_targets.TextMarginLeft = 0;
            this.Menu_button_targets.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Menu_button_targets.UseDefaultRadiusAndThickness = true;
            this.Menu_button_targets.Click += new System.EventHandler(this.Menu_button_targets_Click);
            // 
            // Menu_button_books
            // 
            this.Menu_button_books.AllowAnimations = true;
            this.Menu_button_books.AllowMouseEffects = true;
            this.Menu_button_books.AllowToggling = false;
            this.Menu_button_books.AnimationSpeed = 200;
            this.Menu_button_books.AutoGenerateColors = false;
            this.Menu_button_books.AutoRoundBorders = false;
            this.Menu_button_books.AutoSizeLeftIcon = true;
            this.Menu_button_books.AutoSizeRightIcon = true;
            this.Menu_button_books.BackColor = System.Drawing.Color.Transparent;
            this.Menu_button_books.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Menu_button_books.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_button_books.BackgroundImage")));
            this.Menu_button_books.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_books.ButtonText = "Books";
            this.Menu_button_books.ButtonTextMarginLeft = 0;
            this.Menu_button_books.ColorContrastOnClick = 45;
            this.Menu_button_books.ColorContrastOnHover = 45;
            this.Menu_button_books.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.Menu_button_books.CustomizableEdges = borderEdges5;
            this.Menu_button_books.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Menu_button_books.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Menu_button_books.DisabledFillColor = System.Drawing.Color.Empty;
            this.Menu_button_books.DisabledForecolor = System.Drawing.Color.Empty;
            this.Menu_button_books.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Menu_button_books.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu_button_books.ForeColor = System.Drawing.Color.White;
            this.Menu_button_books.IconLeft = global::TRPO_Project.Properties.Resources.books_1;
            this.Menu_button_books.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_button_books.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_books.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Menu_button_books.IconMarginLeft = 11;
            this.Menu_button_books.IconPadding = 1;
            this.Menu_button_books.IconRight = null;
            this.Menu_button_books.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu_button_books.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_button_books.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Menu_button_books.IconSize = 25;
            this.Menu_button_books.IdleBorderColor = System.Drawing.Color.Empty;
            this.Menu_button_books.IdleBorderRadius = 0;
            this.Menu_button_books.IdleBorderThickness = 0;
            this.Menu_button_books.IdleFillColor = System.Drawing.Color.Empty;
            this.Menu_button_books.IdleIconLeftImage = global::TRPO_Project.Properties.Resources.books_1;
            this.Menu_button_books.IdleIconRightImage = null;
            this.Menu_button_books.IndicateFocus = false;
            this.Menu_button_books.Location = new System.Drawing.Point(0, 147);
            this.Menu_button_books.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu_button_books.Name = "Menu_button_books";
            this.Menu_button_books.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.Menu_button_books.OnDisabledState.BorderRadius = 0;
            this.Menu_button_books.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_books.OnDisabledState.BorderThickness = 0;
            this.Menu_button_books.OnDisabledState.FillColor = System.Drawing.Color.Empty;
            this.Menu_button_books.OnDisabledState.ForeColor = System.Drawing.Color.Empty;
            this.Menu_button_books.OnDisabledState.IconLeftImage = null;
            this.Menu_button_books.OnDisabledState.IconRightImage = null;
            this.Menu_button_books.onHoverState.BorderColor = System.Drawing.Color.Indigo;
            this.Menu_button_books.onHoverState.BorderRadius = 0;
            this.Menu_button_books.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_books.onHoverState.BorderThickness = 0;
            this.Menu_button_books.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Menu_button_books.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_books.onHoverState.IconLeftImage = global::TRPO_Project.Properties.Resources.books_1;
            this.Menu_button_books.onHoverState.IconRightImage = null;
            this.Menu_button_books.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_books.OnIdleState.BorderRadius = 0;
            this.Menu_button_books.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_books.OnIdleState.BorderThickness = 0;
            this.Menu_button_books.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_books.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_books.OnIdleState.IconLeftImage = global::TRPO_Project.Properties.Resources.books_1;
            this.Menu_button_books.OnIdleState.IconRightImage = null;
            this.Menu_button_books.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_button_books.OnPressedState.BorderRadius = 0;
            this.Menu_button_books.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_button_books.OnPressedState.BorderThickness = 0;
            this.Menu_button_books.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_button_books.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Menu_button_books.OnPressedState.IconLeftImage = global::TRPO_Project.Properties.Resources.books_2;
            this.Menu_button_books.OnPressedState.IconRightImage = null;
            this.Menu_button_books.Size = new System.Drawing.Size(133, 39);
            this.Menu_button_books.TabIndex = 2;
            this.Menu_button_books.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Menu_button_books.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Menu_button_books.TextMarginLeft = 0;
            this.Menu_button_books.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Menu_button_books.UseDefaultRadiusAndThickness = true;
            this.Menu_button_books.Click += new System.EventHandler(this.Menu_button_books_Click);
            // 
            // Menu_Button_Learning
            // 
            this.Menu_Button_Learning.AllowAnimations = true;
            this.Menu_Button_Learning.AllowMouseEffects = true;
            this.Menu_Button_Learning.AllowToggling = false;
            this.Menu_Button_Learning.AnimationSpeed = 200;
            this.Menu_Button_Learning.AutoGenerateColors = false;
            this.Menu_Button_Learning.AutoRoundBorders = false;
            this.Menu_Button_Learning.AutoSizeLeftIcon = true;
            this.Menu_Button_Learning.AutoSizeRightIcon = true;
            this.Menu_Button_Learning.BackColor = System.Drawing.Color.Transparent;
            this.Menu_Button_Learning.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Menu_Button_Learning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_Button_Learning.BackgroundImage")));
            this.Menu_Button_Learning.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_Button_Learning.ButtonText = "Learning";
            this.Menu_Button_Learning.ButtonTextMarginLeft = 0;
            this.Menu_Button_Learning.ColorContrastOnClick = 45;
            this.Menu_Button_Learning.ColorContrastOnHover = 45;
            this.Menu_Button_Learning.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.Menu_Button_Learning.CustomizableEdges = borderEdges6;
            this.Menu_Button_Learning.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Menu_Button_Learning.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Menu_Button_Learning.DisabledFillColor = System.Drawing.Color.Empty;
            this.Menu_Button_Learning.DisabledForecolor = System.Drawing.Color.Empty;
            this.Menu_Button_Learning.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Menu_Button_Learning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu_Button_Learning.ForeColor = System.Drawing.Color.White;
            this.Menu_Button_Learning.IconLeft = global::TRPO_Project.Properties.Resources.astronomy;
            this.Menu_Button_Learning.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_Button_Learning.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_Button_Learning.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Menu_Button_Learning.IconMarginLeft = 11;
            this.Menu_Button_Learning.IconPadding = 1;
            this.Menu_Button_Learning.IconRight = null;
            this.Menu_Button_Learning.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu_Button_Learning.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Menu_Button_Learning.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Menu_Button_Learning.IconSize = 25;
            this.Menu_Button_Learning.IdleBorderColor = System.Drawing.Color.Empty;
            this.Menu_Button_Learning.IdleBorderRadius = 0;
            this.Menu_Button_Learning.IdleBorderThickness = 0;
            this.Menu_Button_Learning.IdleFillColor = System.Drawing.Color.Empty;
            this.Menu_Button_Learning.IdleIconLeftImage = global::TRPO_Project.Properties.Resources.astronomy;
            this.Menu_Button_Learning.IdleIconRightImage = null;
            this.Menu_Button_Learning.IndicateFocus = false;
            this.Menu_Button_Learning.Location = new System.Drawing.Point(0, 104);
            this.Menu_Button_Learning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu_Button_Learning.Name = "Menu_Button_Learning";
            this.Menu_Button_Learning.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.Menu_Button_Learning.OnDisabledState.BorderRadius = 0;
            this.Menu_Button_Learning.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_Button_Learning.OnDisabledState.BorderThickness = 0;
            this.Menu_Button_Learning.OnDisabledState.FillColor = System.Drawing.Color.Empty;
            this.Menu_Button_Learning.OnDisabledState.ForeColor = System.Drawing.Color.Empty;
            this.Menu_Button_Learning.OnDisabledState.IconLeftImage = null;
            this.Menu_Button_Learning.OnDisabledState.IconRightImage = null;
            this.Menu_Button_Learning.onHoverState.BorderColor = System.Drawing.Color.Indigo;
            this.Menu_Button_Learning.onHoverState.BorderRadius = 0;
            this.Menu_Button_Learning.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_Button_Learning.onHoverState.BorderThickness = 0;
            this.Menu_Button_Learning.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Menu_Button_Learning.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Menu_Button_Learning.onHoverState.IconLeftImage = global::TRPO_Project.Properties.Resources.astronomy;
            this.Menu_Button_Learning.onHoverState.IconRightImage = null;
            this.Menu_Button_Learning.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_Button_Learning.OnIdleState.BorderRadius = 0;
            this.Menu_Button_Learning.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_Button_Learning.OnIdleState.BorderThickness = 0;
            this.Menu_Button_Learning.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_Button_Learning.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Menu_Button_Learning.OnIdleState.IconLeftImage = global::TRPO_Project.Properties.Resources.astronomy;
            this.Menu_Button_Learning.OnIdleState.IconRightImage = null;
            this.Menu_Button_Learning.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_Button_Learning.OnPressedState.BorderRadius = 0;
            this.Menu_Button_Learning.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Menu_Button_Learning.OnPressedState.BorderThickness = 0;
            this.Menu_Button_Learning.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.Menu_Button_Learning.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Menu_Button_Learning.OnPressedState.IconLeftImage = global::TRPO_Project.Properties.Resources.astronomy_2;
            this.Menu_Button_Learning.OnPressedState.IconRightImage = null;
            this.Menu_Button_Learning.Size = new System.Drawing.Size(133, 39);
            this.Menu_Button_Learning.TabIndex = 1;
            this.Menu_Button_Learning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Menu_Button_Learning.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Menu_Button_Learning.TextMarginLeft = 0;
            this.Menu_Button_Learning.TextPadding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Menu_Button_Learning.UseDefaultRadiusAndThickness = true;
            this.Menu_Button_Learning.Click += new System.EventHandler(this.Menu_Button_Learning_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Menu_label_name);
            this.panel1.Controls.Add(this.PicBox_Avatar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 100);
            this.panel1.TabIndex = 0;
            // 
            // Menu_label_name
            // 
            this.Menu_label_name.AutoSize = true;
            this.Menu_label_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu_label_name.ForeColor = System.Drawing.Color.White;
            this.Menu_label_name.Location = new System.Drawing.Point(37, 73);
            this.Menu_label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Menu_label_name.Name = "Menu_label_name";
            this.Menu_label_name.Size = new System.Drawing.Size(60, 21);
            this.Menu_label_name.TabIndex = 1;
            this.Menu_label_name.Text = "Alex T.";
            this.Menu_label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBox_Avatar
            // 
            this.PicBox_Avatar.Image = global::TRPO_Project.Properties.Resources.uranus;
            this.PicBox_Avatar.Location = new System.Drawing.Point(33, 6);
            this.PicBox_Avatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicBox_Avatar.Name = "PicBox_Avatar";
            this.PicBox_Avatar.Size = new System.Drawing.Size(67, 65);
            this.PicBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Avatar.TabIndex = 0;
            this.PicBox_Avatar.TabStop = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.date.Location = new System.Drawing.Point(393, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(181, 24);
            this.date.TabIndex = 1;
            this.date.Text = "18 ноября 2021г.";
            this.date.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ideas1
            // 
            this.ideas1.Location = new System.Drawing.Point(138, 97);
            this.ideas1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ideas1.Name = "ideas1";
            this.ideas1.Size = new System.Drawing.Size(433, 273);
            this.ideas1.TabIndex = 5;
            // 
            // targets1
            // 
            this.targets1.Location = new System.Drawing.Point(138, 97);
            this.targets1.Name = "targets1";
            this.targets1.Size = new System.Drawing.Size(433, 273);
            this.targets1.TabIndex = 4;
            // 
            // learning1
            // 
            this.learning1.Location = new System.Drawing.Point(138, 97);
            this.learning1.Name = "learning1";
            this.learning1.Size = new System.Drawing.Size(433, 273);
            this.learning1.TabIndex = 3;
            // 
            // books1
            // 
            this.books1.Location = new System.Drawing.Point(138, 97);
            this.books1.Name = "books1";
            this.books1.Size = new System.Drawing.Size(433, 273);
            this.books1.TabIndex = 2;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.time.Location = new System.Drawing.Point(479, 24);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(92, 24);
            this.time.TabIndex = 6;
            this.time.Text = "10:08:21";
            this.time.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 370);
            this.Controls.Add(this.time);
            this.Controls.Add(this.ideas1);
            this.Controls.Add(this.targets1);
            this.Controls.Add(this.learning1);
            this.Controls.Add(this.books1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Main_menu_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList";
            this.Main_menu_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel Main_menu_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicBox_Avatar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Menu_Button_Learning;
        private System.Windows.Forms.Label Menu_label_name;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Menu_button_exit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Menu_button_ideas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Menu_button_targets;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Menu_button_books;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Menu_button_minimized;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer1;
        private Books books1;
        private Learning learning1;
        private Targets targets1;
        private Ideas ideas1;
        private System.Windows.Forms.Label time;
    }
}

