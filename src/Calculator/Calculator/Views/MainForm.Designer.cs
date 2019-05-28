using System;

namespace Calculator.Views
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.operationText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.toolTop = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = global::Calculator.Properties.Settings.Default.BagroundColour;
            this.menuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "BagroundColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(219, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "M&enu";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.settingsToolStripMenuItem.Text = "S&ettings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.logToolStripMenuItem.Text = "L&og";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.helpToolStripMenuItem.Text = "H&elp";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.aboutToolStripMenuItem.Text = "Abo&ut";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            // 
            // operationText
            // 
            this.operationText.AutoSize = true;
            this.operationText.Location = new System.Drawing.Point(197, 24);
            this.operationText.Name = "operationText";
            this.operationText.Size = new System.Drawing.Size(0, 13);
            this.operationText.TabIndex = 20;
            this.operationText.Click += new System.EventHandler(this.operationText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pristina", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Made by Krivah Too";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonClear.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonClear.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonClear.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonClear.Location = new System.Drawing.Point(113, 231);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(44, 41);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = global::Calculator.Properties.Settings.Default.OperatorBackColour;
            this.buttonDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivide.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "OperatorTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonDivide.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonDivide.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "OperatorBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDivide.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonDivide.ForeColor = global::Calculator.Properties.Settings.Default.OperatorTextColour;
            this.buttonDivide.Location = new System.Drawing.Point(163, 231);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(44, 41);
            this.buttonDivide.TabIndex = 17;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = global::Calculator.Properties.Settings.Default.OperatorBackColour;
            this.buttonEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEqual.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEqual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "OperatorBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEqual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "OperatorTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEqual.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonEqual.ForeColor = global::Calculator.Properties.Settings.Default.OperatorTextColour;
            this.buttonEqual.Location = new System.Drawing.Point(14, 278);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(193, 41);
            this.buttonEqual.TabIndex = 16;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDot.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonDot.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonDot.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDot.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonDot.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonDot.Location = new System.Drawing.Point(13, 231);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(44, 41);
            this.buttonDot.TabIndex = 15;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZero.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonZero.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonZero.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZero.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonZero.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonZero.Location = new System.Drawing.Point(63, 231);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(44, 41);
            this.buttonZero.TabIndex = 14;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click_1);
            // 
            // textBox
            // 
            this.textBox.BackColor = global::Calculator.Properties.Settings.Default.AnswerBackColour;
            this.textBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "AnswerTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "AnswerFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "AnswerBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox.Font = global::Calculator.Properties.Settings.Default.AnswerFont;
            this.textBox.ForeColor = global::Calculator.Properties.Settings.Default.AnswerTextColour;
            this.textBox.Location = new System.Drawing.Point(14, 38);
            this.textBox.Name = "textBox";
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox.Size = new System.Drawing.Size(193, 29);
            this.textBox.TabIndex = 13;
            this.textBox.Text = "0";
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEight.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEight.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEight.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEight.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonEight.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonEight.Location = new System.Drawing.Point(63, 184);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(44, 41);
            this.buttonEight.TabIndex = 12;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNine.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonNine.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonNine.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNine.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonNine.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonNine.Location = new System.Drawing.Point(113, 184);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(44, 41);
            this.buttonNine.TabIndex = 11;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = global::Calculator.Properties.Settings.Default.OperatorBackColour;
            this.buttonMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiply.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "OperatorTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonMultiply.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonMultiply.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "OperatorBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMultiply.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonMultiply.ForeColor = global::Calculator.Properties.Settings.Default.OperatorTextColour;
            this.buttonMultiply.Location = new System.Drawing.Point(163, 184);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(44, 41);
            this.buttonMultiply.TabIndex = 10;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = global::Calculator.Properties.Settings.Default.OperatorBackColour;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "OperatorTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonAdd.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonAdd.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "OperatorBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonAdd.ForeColor = global::Calculator.Properties.Settings.Default.OperatorTextColour;
            this.buttonAdd.Location = new System.Drawing.Point(163, 90);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 41);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = global::Calculator.Properties.Settings.Default.OperatorBackColour;
            this.buttonMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinus.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "OperatorTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonMinus.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonMinus.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "OperatorBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinus.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonMinus.ForeColor = global::Calculator.Properties.Settings.Default.OperatorTextColour;
            this.buttonMinus.Location = new System.Drawing.Point(163, 137);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(44, 41);
            this.buttonMinus.TabIndex = 8;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSix.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSix.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSix.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSix.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonSix.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonSix.Location = new System.Drawing.Point(113, 137);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(44, 41);
            this.buttonSix.TabIndex = 7;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFive.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonFive.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonFive.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFive.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonFive.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonFive.Location = new System.Drawing.Point(63, 137);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(44, 41);
            this.buttonFive.TabIndex = 6;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFour.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonFour.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonFour.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFour.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonFour.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonFour.Location = new System.Drawing.Point(13, 137);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(44, 41);
            this.buttonFour.TabIndex = 5;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeven.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSeven.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSeven.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeven.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonSeven.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonSeven.Location = new System.Drawing.Point(13, 184);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(44, 41);
            this.buttonSeven.TabIndex = 4;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThree.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonThree.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonThree.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThree.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonThree.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonThree.Location = new System.Drawing.Point(113, 90);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(44, 41);
            this.buttonThree.TabIndex = 3;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTwo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTwo.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTwo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTwo.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonTwo.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonTwo.Location = new System.Drawing.Point(63, 90);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(44, 41);
            this.buttonTwo.TabIndex = 2;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = global::Calculator.Properties.Settings.Default.ButtonBackColour;
            this.buttonOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOne.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Calculator.Properties.Settings.Default, "ButtonTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonOne.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Calculator.Properties.Settings.Default, "ButtonFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonOne.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "ButtonBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOne.Font = global::Calculator.Properties.Settings.Default.ButtonFont;
            this.buttonOne.ForeColor = global::Calculator.Properties.Settings.Default.ButtonTextColour;
            this.buttonOne.Location = new System.Drawing.Point(13, 90);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(44, 41);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.BackColor = System.Drawing.Color.Transparent;
            this.buttonTop.Location = new System.Drawing.Point(176, 0);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(43, 26);
            this.buttonTop.TabIndex = 23;
            this.buttonTop.Text = "P&in";
            this.buttonTop.UseVisualStyleBackColor = false;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            this.buttonTop.GotFocus += new System.EventHandler(this.buttonTop_GotFocus);
            // 
            // toolTop
            // 
            this.toolTop.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Calculator.Properties.Settings.Default.BagroundColour;
            this.ClientSize = new System.Drawing.Size(219, 346);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operationText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Calculator.Properties.Settings.Default, "BagroundColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label operationText;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.ToolTip toolTop;
    }
}

