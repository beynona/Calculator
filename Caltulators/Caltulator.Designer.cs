namespace Caltulators
{
    partial class Caltulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caltulator));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.factorial = new System.Windows.Forms.Button();
            this.ABS = new System.Windows.Forms.Button();
            this.Nsqrt = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.dots = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Panel1.Controls.Add(this.factorial);
            this.Panel1.Controls.Add(this.ABS);
            this.Panel1.Controls.Add(this.Nsqrt);
            this.Panel1.Controls.Add(this.power);
            this.Panel1.Controls.Add(this.sqrt);
            this.Panel1.Controls.Add(this.percent);
            this.Panel1.Controls.Add(this.dots);
            this.Panel1.Controls.Add(this.equally);
            this.Panel1.Controls.Add(this.C);
            this.Panel1.Controls.Add(this.CE);
            this.Panel1.Controls.Add(this.division);
            this.Panel1.Controls.Add(this.multiplication);
            this.Panel1.Controls.Add(this.subtraction);
            this.Panel1.Controls.Add(this.addition);
            this.Panel1.Controls.Add(this.Button0);
            this.Panel1.Controls.Add(this.Button9);
            this.Panel1.Controls.Add(this.Button6);
            this.Panel1.Controls.Add(this.Button3);
            this.Panel1.Controls.Add(this.Button8);
            this.Panel1.Controls.Add(this.Button7);
            this.Panel1.Controls.Add(this.Button5);
            this.Panel1.Controls.Add(this.Button4);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Location = new System.Drawing.Point(-4, 67);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(436, 397);
            this.Panel1.TabIndex = 4;
            // 
            // factorial
            // 
            this.factorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.factorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.factorial.FlatAppearance.BorderSize = 0;
            this.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factorial.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.factorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.factorial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.factorial.Location = new System.Drawing.Point(328, 15);
            this.factorial.Margin = new System.Windows.Forms.Padding(2);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(108, 52);
            this.factorial.TabIndex = 23;
            this.factorial.Text = "!";
            this.factorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.factorial.UseVisualStyleBackColor = false;
            this.factorial.Click += new System.EventHandler(this.OperationClick);
            // 
            // ABS
            // 
            this.ABS.AllowDrop = true;
            this.ABS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ABS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ABS.FlatAppearance.BorderSize = 0;
            this.ABS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABS.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.ABS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ABS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ABS.Location = new System.Drawing.Point(220, 15);
            this.ABS.Margin = new System.Windows.Forms.Padding(2);
            this.ABS.Name = "ABS";
            this.ABS.Size = new System.Drawing.Size(108, 52);
            this.ABS.TabIndex = 22;
            this.ABS.Text = "||";
            this.ABS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ABS.UseVisualStyleBackColor = false;
            this.ABS.Click += new System.EventHandler(this.OperationClick);
            // 
            // Nsqrt
            // 
            this.Nsqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.Nsqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nsqrt.FlatAppearance.BorderSize = 0;
            this.Nsqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nsqrt.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Nsqrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Nsqrt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nsqrt.Location = new System.Drawing.Point(112, 15);
            this.Nsqrt.Margin = new System.Windows.Forms.Padding(2);
            this.Nsqrt.Name = "Nsqrt";
            this.Nsqrt.Size = new System.Drawing.Size(108, 52);
            this.Nsqrt.TabIndex = 21;
            this.Nsqrt.Text = "√n";
            this.Nsqrt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nsqrt.UseVisualStyleBackColor = false;
            this.Nsqrt.Click += new System.EventHandler(this.OperationClick);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.power.FlatAppearance.BorderSize = 0;
            this.power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.power.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.power.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.power.Location = new System.Drawing.Point(4, 15);
            this.power.Margin = new System.Windows.Forms.Padding(2);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(108, 52);
            this.power.TabIndex = 20;
            this.power.Text = "n*";
            this.power.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.OperationClick);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.sqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sqrt.FlatAppearance.BorderSize = 0;
            this.sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrt.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.sqrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.sqrt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sqrt.Location = new System.Drawing.Point(328, 66);
            this.sqrt.Margin = new System.Windows.Forms.Padding(2);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(108, 66);
            this.sqrt.TabIndex = 19;
            this.sqrt.Text = "√";
            this.sqrt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.OperationClick);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.percent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.percent.FlatAppearance.BorderSize = 0;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.percent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.percent.Location = new System.Drawing.Point(220, 66);
            this.percent.Margin = new System.Windows.Forms.Padding(2);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(108, 66);
            this.percent.TabIndex = 18;
            this.percent.Text = "%";
            this.percent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.OperationClick);
            // 
            // dots
            // 
            this.dots.AccessibleDescription = " ";
            this.dots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.dots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dots.FlatAppearance.BorderSize = 0;
            this.dots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dots.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.dots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.dots.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dots.Location = new System.Drawing.Point(0, 317);
            this.dots.Margin = new System.Windows.Forms.Padding(2);
            this.dots.Name = "dots";
            this.dots.Size = new System.Drawing.Size(108, 66);
            this.dots.TabIndex = 17;
            this.dots.Text = ",";
            this.dots.UseVisualStyleBackColor = false;
            this.dots.Click += new System.EventHandler(this.Comma);
            // 
            // equally
            // 
            this.equally.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.equally.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.equally.FlatAppearance.BorderSize = 0;
            this.equally.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equally.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.equally.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.equally.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.equally.Location = new System.Drawing.Point(216, 317);
            this.equally.Margin = new System.Windows.Forms.Padding(2);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(108, 66);
            this.equally.TabIndex = 16;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = false;
            this.equally.Click += new System.EventHandler(this.Equal);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.C.FlatAppearance.BorderSize = 0;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold);
            this.C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.C.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.C.Location = new System.Drawing.Point(112, 66);
            this.C.Margin = new System.Windows.Forms.Padding(2);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(108, 66);
            this.C.TabIndex = 15;
            this.C.Text = "C";
            this.C.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.ClearText);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.CE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CE.FlatAppearance.BorderSize = 0;
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CE.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold);
            this.CE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.CE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CE.Location = new System.Drawing.Point(4, 66);
            this.CE.Margin = new System.Windows.Forms.Padding(2);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(108, 66);
            this.CE.TabIndex = 14;
            this.CE.Text = "CE";
            this.CE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.ClearText);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.division.FlatAppearance.BorderSize = 0;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.division.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.division.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.division.Location = new System.Drawing.Point(324, 318);
            this.division.Margin = new System.Windows.Forms.Padding(2);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(108, 66);
            this.division.TabIndex = 13;
            this.division.Text = "/";
            this.division.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.OperationClick);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.multiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiplication.FlatAppearance.BorderSize = 0;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplication.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.multiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.multiplication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.multiplication.Location = new System.Drawing.Point(328, 252);
            this.multiplication.Margin = new System.Windows.Forms.Padding(2);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(108, 66);
            this.multiplication.TabIndex = 12;
            this.multiplication.Text = "*";
            this.multiplication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.OperationClick);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.subtraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.subtraction.FlatAppearance.BorderSize = 0;
            this.subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtraction.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.subtraction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.subtraction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.subtraction.Location = new System.Drawing.Point(328, 192);
            this.subtraction.Margin = new System.Windows.Forms.Padding(2);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(108, 66);
            this.subtraction.TabIndex = 11;
            this.subtraction.Text = "-";
            this.subtraction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.OperationClick);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.addition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addition.FlatAppearance.BorderSize = 0;
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addition.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.addition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.addition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addition.Location = new System.Drawing.Point(325, 132);
            this.addition.Margin = new System.Windows.Forms.Padding(2);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(108, 66);
            this.addition.TabIndex = 10;
            this.addition.Text = "+";
            this.addition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.OperationClick);
            // 
            // Button0
            // 
            this.Button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button0.FlatAppearance.BorderSize = 0;
            this.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button0.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button0.Location = new System.Drawing.Point(108, 317);
            this.Button0.Margin = new System.Windows.Forms.Padding(2);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(108, 66);
            this.Button0.TabIndex = 0;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button9.Location = new System.Drawing.Point(217, 132);
            this.Button9.Margin = new System.Windows.Forms.Padding(2);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(108, 66);
            this.Button9.TabIndex = 9;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button6.Location = new System.Drawing.Point(220, 191);
            this.Button6.Margin = new System.Windows.Forms.Padding(2);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(108, 66);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button3.Location = new System.Drawing.Point(220, 251);
            this.Button3.Margin = new System.Windows.Forms.Padding(2);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(108, 66);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button8.Location = new System.Drawing.Point(110, 131);
            this.Button8.Margin = new System.Windows.Forms.Padding(2);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(108, 66);
            this.Button8.TabIndex = 8;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button7.Location = new System.Drawing.Point(3, 131);
            this.Button7.Margin = new System.Windows.Forms.Padding(2);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(108, 66);
            this.Button7.TabIndex = 7;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button5.Location = new System.Drawing.Point(112, 191);
            this.Button5.Margin = new System.Windows.Forms.Padding(2);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(108, 66);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button4.Location = new System.Drawing.Point(4, 191);
            this.Button4.Margin = new System.Windows.Forms.Padding(2);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(108, 66);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button2.Location = new System.Drawing.Point(112, 251);
            this.Button2.Margin = new System.Windows.Forms.Padding(2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(108, 66);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button1.Location = new System.Drawing.Point(4, 251);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(108, 66);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.NumberClicked);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.FloralWhite;
            this.textBox.Location = new System.Drawing.Point(0, 13);
            this.textBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox.Size = new System.Drawing.Size(500, 55);
            this.textBox.TabIndex = 5;
            this.textBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Caltulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(429, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caltulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caltulator";
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button division;
        internal System.Windows.Forms.Button multiplication;
        internal System.Windows.Forms.Button subtraction;
        internal System.Windows.Forms.Button addition;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button C;
        internal System.Windows.Forms.Button CE;
        internal System.Windows.Forms.Button equally;
        internal System.Windows.Forms.Button dots;
        internal System.Windows.Forms.Button percent;
        internal System.Windows.Forms.Button sqrt;
        internal System.Windows.Forms.Button power;
        internal System.Windows.Forms.Button Nsqrt;
        internal System.Windows.Forms.Button ABS;
        internal System.Windows.Forms.Button factorial;
        public System.Windows.Forms.Button Button0;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

