﻿namespace TRPO_Project
{
    partial class Targets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Targets));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Targets_list = new System.Windows.Forms.Panel();
            this.Targets_left_panel = new System.Windows.Forms.Panel();
            this.Targets_label = new System.Windows.Forms.Label();
            this.Targets_add_button = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Targets_text_box = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // Targets_list
            // 
            this.Targets_list.Location = new System.Drawing.Point(35, 43);
            this.Targets_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Targets_list.Name = "Targets_list";
            this.Targets_list.Size = new System.Drawing.Size(606, 304);
            this.Targets_list.TabIndex = 12;
            // 
            // Targets_left_panel
            // 
            this.Targets_left_panel.BackColor = System.Drawing.Color.DarkMagenta;
            this.Targets_left_panel.Location = new System.Drawing.Point(9, 43);
            this.Targets_left_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Targets_left_panel.Name = "Targets_left_panel";
            this.Targets_left_panel.Size = new System.Drawing.Size(18, 304);
            this.Targets_left_panel.TabIndex = 11;
            // 
            // Targets_label
            // 
            this.Targets_label.AutoSize = true;
            this.Targets_label.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Targets_label.Location = new System.Drawing.Point(9, 4);
            this.Targets_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Targets_label.Name = "Targets_label";
            this.Targets_label.Size = new System.Drawing.Size(263, 34);
            this.Targets_label.TabIndex = 10;
            this.Targets_label.Text = "ToDo List | Targets";
            // 
            // Targets_add_button
            // 
            this.Targets_add_button.ActiveImage = global::TRPO_Project.Properties.Resources.plus_2_1;
            this.Targets_add_button.AllowAnimations = true;
            this.Targets_add_button.AllowBuffering = false;
            this.Targets_add_button.AllowToggling = false;
            this.Targets_add_button.AllowZooming = true;
            this.Targets_add_button.AllowZoomingOnFocus = false;
            this.Targets_add_button.BackColor = System.Drawing.Color.Transparent;
            this.Targets_add_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Targets_add_button.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Targets_add_button.ErrorImage")));
            this.Targets_add_button.FadeWhenInactive = false;
            this.Targets_add_button.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Targets_add_button.Image = global::TRPO_Project.Properties.Resources.plus_1_1;
            this.Targets_add_button.ImageActive = global::TRPO_Project.Properties.Resources.plus_2_1;
            this.Targets_add_button.ImageLocation = null;
            this.Targets_add_button.ImageMargin = 0;
            this.Targets_add_button.ImageSize = new System.Drawing.Size(59, 59);
            this.Targets_add_button.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.Targets_add_button.InitialImage = ((System.Drawing.Image)(resources.GetObject("Targets_add_button.InitialImage")));
            this.Targets_add_button.Location = new System.Drawing.Point(581, 355);
            this.Targets_add_button.Name = "Targets_add_button";
            this.Targets_add_button.Rotation = 0;
            this.Targets_add_button.ShowActiveImage = true;
            this.Targets_add_button.ShowCursorChanges = true;
            this.Targets_add_button.ShowImageBorders = true;
            this.Targets_add_button.ShowSizeMarkers = false;
            this.Targets_add_button.Size = new System.Drawing.Size(60, 60);
            this.Targets_add_button.TabIndex = 14;
            this.Targets_add_button.ToolTipText = "";
            this.Targets_add_button.WaitOnLoad = false;
            this.Targets_add_button.Zoom = 0;
            this.Targets_add_button.ZoomSpeed = 10;
            this.Targets_add_button.Click += new System.EventHandler(this.Targets_add_button_Click);
            // 
            // Targets_text_box
            // 
            this.Targets_text_box.AcceptsReturn = false;
            this.Targets_text_box.AcceptsTab = false;
            this.Targets_text_box.AnimationSpeed = 200;
            this.Targets_text_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Targets_text_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Targets_text_box.AutoSizeHeight = true;
            this.Targets_text_box.BackColor = System.Drawing.Color.White;
            this.Targets_text_box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Targets_text_box.BackgroundImage")));
            this.Targets_text_box.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Targets_text_box.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Targets_text_box.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Targets_text_box.BorderColorIdle = System.Drawing.Color.Silver;
            this.Targets_text_box.BorderRadius = 1;
            this.Targets_text_box.BorderThickness = 1;
            this.Targets_text_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Targets_text_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Targets_text_box.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Targets_text_box.DefaultText = "";
            this.Targets_text_box.FillColor = System.Drawing.Color.White;
            this.Targets_text_box.HideSelection = true;
            this.Targets_text_box.IconLeft = null;
            this.Targets_text_box.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Targets_text_box.IconPadding = 10;
            this.Targets_text_box.IconRight = null;
            this.Targets_text_box.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Targets_text_box.Lines = new string[0];
            this.Targets_text_box.Location = new System.Drawing.Point(35, 357);
            this.Targets_text_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Targets_text_box.MaxLength = 32767;
            this.Targets_text_box.MinimumSize = new System.Drawing.Size(2, 2);
            this.Targets_text_box.Modified = false;
            this.Targets_text_box.Multiline = false;
            this.Targets_text_box.Name = "Targets_text_box";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Targets_text_box.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Targets_text_box.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Targets_text_box.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Targets_text_box.OnIdleState = stateProperties4;
            this.Targets_text_box.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Targets_text_box.PasswordChar = '\0';
            this.Targets_text_box.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Targets_text_box.PlaceholderText = "Enter text";
            this.Targets_text_box.ReadOnly = false;
            this.Targets_text_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Targets_text_box.SelectedText = "";
            this.Targets_text_box.SelectionLength = 0;
            this.Targets_text_box.SelectionStart = 0;
            this.Targets_text_box.ShortcutsEnabled = true;
            this.Targets_text_box.Size = new System.Drawing.Size(539, 58);
            this.Targets_text_box.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.Targets_text_box.TabIndex = 13;
            this.Targets_text_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Targets_text_box.TextMarginBottom = 0;
            this.Targets_text_box.TextMarginLeft = 3;
            this.Targets_text_box.TextMarginTop = 1;
            this.Targets_text_box.TextPlaceholder = "Enter text";
            this.Targets_text_box.UseSystemPasswordChar = false;
            this.Targets_text_box.WordWrap = true;
            // 
            // Targets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Targets_add_button);
            this.Controls.Add(this.Targets_text_box);
            this.Controls.Add(this.Targets_list);
            this.Controls.Add(this.Targets_left_panel);
            this.Controls.Add(this.Targets_label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Targets";
            this.Size = new System.Drawing.Size(650, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton Targets_add_button;
        private Bunifu.UI.WinForms.BunifuTextBox Targets_text_box;
        private System.Windows.Forms.Panel Targets_list;
        private System.Windows.Forms.Panel Targets_left_panel;
        private System.Windows.Forms.Label Targets_label;
    }
}
