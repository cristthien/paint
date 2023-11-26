
namespace paint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.oval_btn = new System.Windows.Forms.Button();
            this.circle_btn = new System.Windows.Forms.Button();
            this.paintFunction_pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rectangle_btn = new System.Windows.Forms.Button();
            this.square_btn = new System.Windows.Forms.Button();
            this.pentagon_btn = new System.Windows.Forms.Button();
            this.triangle_btn = new System.Windows.Forms.Button();
            this.formatColorFill_btn = new System.Windows.Forms.Button();
            this.line_btn = new System.Windows.Forms.Button();
            this.eraser_btn = new System.Windows.Forms.Button();
            this.pencil_btn = new System.Windows.Forms.Button();
            this.FileEdit_pnl = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.undo_btn = new System.Windows.Forms.Button();
            this.saveFile_btn = new System.Windows.Forms.Button();
            this.openFile_btn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.color_pnl = new System.Windows.Forms.Panel();
            this.color_panel = new System.Windows.Forms.Button();
            this.LimeColor_btn = new System.Windows.Forms.Button();
            this.IvoryColor_btn = new System.Windows.Forms.Button();
            this.LavenderBlushColor_btn = new System.Windows.Forms.Button();
            this.LightPinkColor_btn = new System.Windows.Forms.Button();
            this.TanColor_btn = new System.Windows.Forms.Button();
            this.FireBrickColor_btn = new System.Windows.Forms.Button();
            this.sliverColor_btn = new System.Windows.Forms.Button();
            this.LinenColor_btn = new System.Windows.Forms.Button();
            this.blackColor_btn = new System.Windows.Forms.Button();
            this.dimGrayColor_btn = new System.Windows.Forms.Button();
            this.grayColor_btn = new System.Windows.Forms.Button();
            this.whiteColor_btn = new System.Windows.Forms.Button();
            this.presentColor = new System.Windows.Forms.PictureBox();
            this.drawArea = new System.Windows.Forms.PictureBox();
            this.paintFunction_pnl.SuspendLayout();
            this.FileEdit_pnl.SuspendLayout();
            this.color_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presentColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // oval_btn
            // 
            this.oval_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oval_btn.BackgroundImage")));
            this.oval_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.oval_btn.FlatAppearance.BorderSize = 0;
            this.oval_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oval_btn.Location = new System.Drawing.Point(3, 150);
            this.oval_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oval_btn.Name = "oval_btn";
            this.oval_btn.Size = new System.Drawing.Size(40, 34);
            this.oval_btn.TabIndex = 12;
            this.oval_btn.UseVisualStyleBackColor = true;
            this.oval_btn.Click += new System.EventHandler(this.oval_btn_Click);
            // 
            // circle_btn
            // 
            this.circle_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle_btn.BackgroundImage")));
            this.circle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circle_btn.FlatAppearance.BorderSize = 0;
            this.circle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_btn.Location = new System.Drawing.Point(3, 116);
            this.circle_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circle_btn.Name = "circle_btn";
            this.circle_btn.Size = new System.Drawing.Size(40, 34);
            this.circle_btn.TabIndex = 13;
            this.circle_btn.UseVisualStyleBackColor = true;
            this.circle_btn.Click += new System.EventHandler(this.circle_btn_Click);
            // 
            // paintFunction_pnl
            // 
            this.paintFunction_pnl.BackColor = System.Drawing.Color.White;
            this.paintFunction_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paintFunction_pnl.Controls.Add(this.label1);
            this.paintFunction_pnl.Controls.Add(this.comboBox1);
            this.paintFunction_pnl.Controls.Add(this.oval_btn);
            this.paintFunction_pnl.Controls.Add(this.circle_btn);
            this.paintFunction_pnl.Controls.Add(this.rectangle_btn);
            this.paintFunction_pnl.Controls.Add(this.square_btn);
            this.paintFunction_pnl.Controls.Add(this.pentagon_btn);
            this.paintFunction_pnl.Controls.Add(this.triangle_btn);
            this.paintFunction_pnl.Controls.Add(this.formatColorFill_btn);
            this.paintFunction_pnl.Controls.Add(this.line_btn);
            this.paintFunction_pnl.Controls.Add(this.eraser_btn);
            this.paintFunction_pnl.Controls.Add(this.pencil_btn);
            this.paintFunction_pnl.Location = new System.Drawing.Point(6, 103);
            this.paintFunction_pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paintFunction_pnl.Name = "paintFunction_pnl";
            this.paintFunction_pnl.Size = new System.Drawing.Size(94, 273);
            this.paintFunction_pnl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pen Size";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(3, 229);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rectangle_btn
            // 
            this.rectangle_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle_btn.BackgroundImage")));
            this.rectangle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangle_btn.FlatAppearance.BorderSize = 0;
            this.rectangle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle_btn.Location = new System.Drawing.Point(43, 78);
            this.rectangle_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangle_btn.Name = "rectangle_btn";
            this.rectangle_btn.Size = new System.Drawing.Size(40, 34);
            this.rectangle_btn.TabIndex = 11;
            this.rectangle_btn.UseVisualStyleBackColor = true;
            this.rectangle_btn.Click += new System.EventHandler(this.rectangle_btn_Click);
            // 
            // square_btn
            // 
            this.square_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("square_btn.BackgroundImage")));
            this.square_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.square_btn.FlatAppearance.BorderSize = 0;
            this.square_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square_btn.Location = new System.Drawing.Point(3, 78);
            this.square_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.square_btn.Name = "square_btn";
            this.square_btn.Size = new System.Drawing.Size(40, 34);
            this.square_btn.TabIndex = 10;
            this.square_btn.UseVisualStyleBackColor = true;
            this.square_btn.Click += new System.EventHandler(this.square_btn_Click);
            // 
            // pentagon_btn
            // 
            this.pentagon_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pentagon_btn.BackgroundImage")));
            this.pentagon_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pentagon_btn.FlatAppearance.BorderSize = 0;
            this.pentagon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pentagon_btn.Location = new System.Drawing.Point(43, 150);
            this.pentagon_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pentagon_btn.Name = "pentagon_btn";
            this.pentagon_btn.Size = new System.Drawing.Size(40, 34);
            this.pentagon_btn.TabIndex = 15;
            this.pentagon_btn.UseVisualStyleBackColor = true;
            this.pentagon_btn.Click += new System.EventHandler(this.pentagon_btn_Click);
            // 
            // triangle_btn
            // 
            this.triangle_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangle_btn.BackgroundImage")));
            this.triangle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangle_btn.FlatAppearance.BorderSize = 0;
            this.triangle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangle_btn.Location = new System.Drawing.Point(43, 116);
            this.triangle_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangle_btn.Name = "triangle_btn";
            this.triangle_btn.Size = new System.Drawing.Size(40, 34);
            this.triangle_btn.TabIndex = 14;
            this.triangle_btn.UseVisualStyleBackColor = true;
            this.triangle_btn.Click += new System.EventHandler(this.triangle_btn_Click);
            // 
            // formatColorFill_btn
            // 
            this.formatColorFill_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formatColorFill_btn.BackgroundImage")));
            this.formatColorFill_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.formatColorFill_btn.FlatAppearance.BorderSize = 0;
            this.formatColorFill_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formatColorFill_btn.Location = new System.Drawing.Point(3, 40);
            this.formatColorFill_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formatColorFill_btn.Name = "formatColorFill_btn";
            this.formatColorFill_btn.Size = new System.Drawing.Size(40, 34);
            this.formatColorFill_btn.TabIndex = 9;
            this.formatColorFill_btn.UseVisualStyleBackColor = true;
            this.formatColorFill_btn.Click += new System.EventHandler(this.formatColorFill_btn_Click);
            // 
            // line_btn
            // 
            this.line_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line_btn.BackgroundImage")));
            this.line_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.line_btn.FlatAppearance.BorderSize = 0;
            this.line_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line_btn.Location = new System.Drawing.Point(43, 40);
            this.line_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line_btn.Name = "line_btn";
            this.line_btn.Size = new System.Drawing.Size(40, 34);
            this.line_btn.TabIndex = 17;
            this.line_btn.UseVisualStyleBackColor = true;
            this.line_btn.Click += new System.EventHandler(this.line_btn_Click);
            // 
            // eraser_btn
            // 
            this.eraser_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraser_btn.BackgroundImage")));
            this.eraser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eraser_btn.FlatAppearance.BorderSize = 0;
            this.eraser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraser_btn.Location = new System.Drawing.Point(43, 2);
            this.eraser_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eraser_btn.Name = "eraser_btn";
            this.eraser_btn.Size = new System.Drawing.Size(40, 34);
            this.eraser_btn.TabIndex = 5;
            this.eraser_btn.UseVisualStyleBackColor = true;
            this.eraser_btn.Click += new System.EventHandler(this.eraser_btn_Click);
            // 
            // pencil_btn
            // 
            this.pencil_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencil_btn.BackgroundImage")));
            this.pencil_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pencil_btn.FlatAppearance.BorderSize = 0;
            this.pencil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencil_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pencil_btn.Location = new System.Drawing.Point(3, 2);
            this.pencil_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pencil_btn.Name = "pencil_btn";
            this.pencil_btn.Size = new System.Drawing.Size(40, 34);
            this.pencil_btn.TabIndex = 4;
            this.pencil_btn.UseVisualStyleBackColor = true;
            this.pencil_btn.Click += new System.EventHandler(this.pencil_btn_Click);
            // 
            // FileEdit_pnl
            // 
            this.FileEdit_pnl.BackColor = System.Drawing.Color.White;
            this.FileEdit_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FileEdit_pnl.Controls.Add(this.btnRestart);
            this.FileEdit_pnl.Controls.Add(this.undo_btn);
            this.FileEdit_pnl.Controls.Add(this.saveFile_btn);
            this.FileEdit_pnl.Controls.Add(this.openFile_btn);
            this.FileEdit_pnl.Location = new System.Drawing.Point(6, 11);
            this.FileEdit_pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileEdit_pnl.Name = "FileEdit_pnl";
            this.FileEdit_pnl.Size = new System.Drawing.Size(94, 88);
            this.FileEdit_pnl.TabIndex = 5;
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.BackgroundImage")));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(43, 45);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(40, 34);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // undo_btn
            // 
            this.undo_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("undo_btn.BackgroundImage")));
            this.undo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.undo_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.undo_btn.FlatAppearance.BorderSize = 0;
            this.undo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo_btn.Location = new System.Drawing.Point(3, 45);
            this.undo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(40, 34);
            this.undo_btn.TabIndex = 2;
            this.undo_btn.UseVisualStyleBackColor = true;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // saveFile_btn
            // 
            this.saveFile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveFile_btn.BackgroundImage")));
            this.saveFile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveFile_btn.FlatAppearance.BorderSize = 0;
            this.saveFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFile_btn.Location = new System.Drawing.Point(3, 7);
            this.saveFile_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveFile_btn.Name = "saveFile_btn";
            this.saveFile_btn.Size = new System.Drawing.Size(40, 34);
            this.saveFile_btn.TabIndex = 1;
            this.saveFile_btn.UseVisualStyleBackColor = true;
            this.saveFile_btn.Click += new System.EventHandler(this.saveFile_btn_Click);
            // 
            // openFile_btn
            // 
            this.openFile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openFile_btn.BackgroundImage")));
            this.openFile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openFile_btn.FlatAppearance.BorderSize = 0;
            this.openFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile_btn.Location = new System.Drawing.Point(43, 7);
            this.openFile_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(40, 34);
            this.openFile_btn.TabIndex = 0;
            this.openFile_btn.UseVisualStyleBackColor = true;
            this.openFile_btn.Click += new System.EventHandler(this.openFile_btn_Click);
            // 
            // color_pnl
            // 
            this.color_pnl.BackColor = System.Drawing.Color.White;
            this.color_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.color_pnl.Controls.Add(this.color_panel);
            this.color_pnl.Controls.Add(this.LimeColor_btn);
            this.color_pnl.Controls.Add(this.IvoryColor_btn);
            this.color_pnl.Controls.Add(this.LavenderBlushColor_btn);
            this.color_pnl.Controls.Add(this.LightPinkColor_btn);
            this.color_pnl.Controls.Add(this.TanColor_btn);
            this.color_pnl.Controls.Add(this.FireBrickColor_btn);
            this.color_pnl.Controls.Add(this.sliverColor_btn);
            this.color_pnl.Controls.Add(this.LinenColor_btn);
            this.color_pnl.Controls.Add(this.blackColor_btn);
            this.color_pnl.Controls.Add(this.dimGrayColor_btn);
            this.color_pnl.Controls.Add(this.grayColor_btn);
            this.color_pnl.Controls.Add(this.whiteColor_btn);
            this.color_pnl.Controls.Add(this.presentColor);
            this.color_pnl.Location = new System.Drawing.Point(6, 380);
            this.color_pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color_pnl.Name = "color_pnl";
            this.color_pnl.Size = new System.Drawing.Size(94, 201);
            this.color_pnl.TabIndex = 6;
            // 
            // color_panel
            // 
            this.color_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("color_panel.BackgroundImage")));
            this.color_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.color_panel.FlatAppearance.BorderSize = 0;
            this.color_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_panel.Location = new System.Drawing.Point(16, 138);
            this.color_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color_panel.Name = "color_panel";
            this.color_panel.Size = new System.Drawing.Size(53, 45);
            this.color_panel.TabIndex = 18;
            this.color_panel.UseVisualStyleBackColor = true;
            this.color_panel.Click += new System.EventHandler(this.color_panel_Click);
            // 
            // LimeColor_btn
            // 
            this.LimeColor_btn.BackColor = System.Drawing.Color.Lime;
            this.LimeColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LimeColor_btn.Location = new System.Drawing.Point(64, 116);
            this.LimeColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LimeColor_btn.Name = "LimeColor_btn";
            this.LimeColor_btn.Size = new System.Drawing.Size(21, 18);
            this.LimeColor_btn.TabIndex = 13;
            this.LimeColor_btn.UseVisualStyleBackColor = false;
            this.LimeColor_btn.Click += new System.EventHandler(this.LimeColor_btn_Click);
            // 
            // IvoryColor_btn
            // 
            this.IvoryColor_btn.BackColor = System.Drawing.Color.Ivory;
            this.IvoryColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IvoryColor_btn.Location = new System.Drawing.Point(64, 94);
            this.IvoryColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IvoryColor_btn.Name = "IvoryColor_btn";
            this.IvoryColor_btn.Size = new System.Drawing.Size(21, 18);
            this.IvoryColor_btn.TabIndex = 12;
            this.IvoryColor_btn.UseVisualStyleBackColor = false;
            this.IvoryColor_btn.Click += new System.EventHandler(this.IvoryColor_btn_Click);
            // 
            // LavenderBlushColor_btn
            // 
            this.LavenderBlushColor_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.LavenderBlushColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LavenderBlushColor_btn.Location = new System.Drawing.Point(64, 72);
            this.LavenderBlushColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LavenderBlushColor_btn.Name = "LavenderBlushColor_btn";
            this.LavenderBlushColor_btn.Size = new System.Drawing.Size(21, 18);
            this.LavenderBlushColor_btn.TabIndex = 11;
            this.LavenderBlushColor_btn.UseVisualStyleBackColor = false;
            this.LavenderBlushColor_btn.Click += new System.EventHandler(this.LavenderBlushColor_btn_Click);
            // 
            // LightPinkColor_btn
            // 
            this.LightPinkColor_btn.BackColor = System.Drawing.Color.LightPink;
            this.LightPinkColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LightPinkColor_btn.Location = new System.Drawing.Point(64, 50);
            this.LightPinkColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LightPinkColor_btn.Name = "LightPinkColor_btn";
            this.LightPinkColor_btn.Size = new System.Drawing.Size(21, 18);
            this.LightPinkColor_btn.TabIndex = 10;
            this.LightPinkColor_btn.UseVisualStyleBackColor = false;
            this.LightPinkColor_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // TanColor_btn
            // 
            this.TanColor_btn.BackColor = System.Drawing.Color.Tan;
            this.TanColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TanColor_btn.Location = new System.Drawing.Point(35, 116);
            this.TanColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TanColor_btn.Name = "TanColor_btn";
            this.TanColor_btn.Size = new System.Drawing.Size(21, 18);
            this.TanColor_btn.TabIndex = 9;
            this.TanColor_btn.UseVisualStyleBackColor = false;
            this.TanColor_btn.Click += new System.EventHandler(this.TanColor_btn_Click);
            // 
            // FireBrickColor_btn
            // 
            this.FireBrickColor_btn.BackColor = System.Drawing.Color.Firebrick;
            this.FireBrickColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FireBrickColor_btn.Location = new System.Drawing.Point(35, 94);
            this.FireBrickColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FireBrickColor_btn.Name = "FireBrickColor_btn";
            this.FireBrickColor_btn.Size = new System.Drawing.Size(21, 18);
            this.FireBrickColor_btn.TabIndex = 8;
            this.FireBrickColor_btn.UseVisualStyleBackColor = false;
            this.FireBrickColor_btn.Click += new System.EventHandler(this.FireBrickColor_btn_Click);
            // 
            // sliverColor_btn
            // 
            this.sliverColor_btn.BackColor = System.Drawing.Color.Silver;
            this.sliverColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sliverColor_btn.Location = new System.Drawing.Point(35, 72);
            this.sliverColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sliverColor_btn.Name = "sliverColor_btn";
            this.sliverColor_btn.Size = new System.Drawing.Size(21, 18);
            this.sliverColor_btn.TabIndex = 7;
            this.sliverColor_btn.UseVisualStyleBackColor = false;
            this.sliverColor_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // LinenColor_btn
            // 
            this.LinenColor_btn.BackColor = System.Drawing.Color.Linen;
            this.LinenColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LinenColor_btn.Location = new System.Drawing.Point(35, 50);
            this.LinenColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LinenColor_btn.Name = "LinenColor_btn";
            this.LinenColor_btn.Size = new System.Drawing.Size(21, 18);
            this.LinenColor_btn.TabIndex = 6;
            this.LinenColor_btn.UseVisualStyleBackColor = false;
            this.LinenColor_btn.Click += new System.EventHandler(this.LinenColor_btn_Click);
            // 
            // blackColor_btn
            // 
            this.blackColor_btn.BackColor = System.Drawing.Color.Black;
            this.blackColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blackColor_btn.Location = new System.Drawing.Point(6, 116);
            this.blackColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blackColor_btn.Name = "blackColor_btn";
            this.blackColor_btn.Size = new System.Drawing.Size(21, 18);
            this.blackColor_btn.TabIndex = 5;
            this.blackColor_btn.UseVisualStyleBackColor = false;
            this.blackColor_btn.Click += new System.EventHandler(this.blackColor_btn_Click_1);
            // 
            // dimGrayColor_btn
            // 
            this.dimGrayColor_btn.BackColor = System.Drawing.Color.DimGray;
            this.dimGrayColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dimGrayColor_btn.Location = new System.Drawing.Point(6, 94);
            this.dimGrayColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dimGrayColor_btn.Name = "dimGrayColor_btn";
            this.dimGrayColor_btn.Size = new System.Drawing.Size(21, 18);
            this.dimGrayColor_btn.TabIndex = 4;
            this.dimGrayColor_btn.UseVisualStyleBackColor = false;
            this.dimGrayColor_btn.Click += new System.EventHandler(this.dimGrayColor_btn_Click);
            // 
            // grayColor_btn
            // 
            this.grayColor_btn.BackColor = System.Drawing.Color.Silver;
            this.grayColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grayColor_btn.Location = new System.Drawing.Point(6, 72);
            this.grayColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grayColor_btn.Name = "grayColor_btn";
            this.grayColor_btn.Size = new System.Drawing.Size(21, 18);
            this.grayColor_btn.TabIndex = 2;
            this.grayColor_btn.UseVisualStyleBackColor = false;
            this.grayColor_btn.Click += new System.EventHandler(this.grayColor_btn_Click);
            // 
            // whiteColor_btn
            // 
            this.whiteColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.whiteColor_btn.Location = new System.Drawing.Point(6, 50);
            this.whiteColor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.whiteColor_btn.Name = "whiteColor_btn";
            this.whiteColor_btn.Size = new System.Drawing.Size(21, 18);
            this.whiteColor_btn.TabIndex = 1;
            this.whiteColor_btn.UseVisualStyleBackColor = true;
            this.whiteColor_btn.Click += new System.EventHandler(this.whiteColor_btn_Click);
            // 
            // presentColor
            // 
            this.presentColor.BackColor = System.Drawing.Color.White;
            this.presentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presentColor.Location = new System.Drawing.Point(25, 9);
            this.presentColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.presentColor.Name = "presentColor";
            this.presentColor.Size = new System.Drawing.Size(40, 37);
            this.presentColor.TabIndex = 0;
            this.presentColor.TabStop = false;
            // 
            // drawArea
            // 
            this.drawArea.BackColor = System.Drawing.Color.White;
            this.drawArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawArea.Location = new System.Drawing.Point(106, 11);
            this.drawArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(1057, 572);
            this.drawArea.TabIndex = 0;
            this.drawArea.TabStop = false;
            this.drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawArea_Paint);
            this.drawArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseClick);
            this.drawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseDown);
            this.drawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseMove);
            this.drawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1175, 594);
            this.Controls.Add(this.color_pnl);
            this.Controls.Add(this.FileEdit_pnl);
            this.Controls.Add(this.paintFunction_pnl);
            this.Controls.Add(this.drawArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPaint";
            this.paintFunction_pnl.ResumeLayout(false);
            this.paintFunction_pnl.PerformLayout();
            this.FileEdit_pnl.ResumeLayout(false);
            this.color_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.presentColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox drawArea;
        private System.Windows.Forms.Button pencil_btn;
        private System.Windows.Forms.Button eraser_btn;
        private System.Windows.Forms.Button formatColorFill_btn;
        private System.Windows.Forms.Button square_btn;
        private System.Windows.Forms.Button rectangle_btn;
        private System.Windows.Forms.Button circle_btn;
        private System.Windows.Forms.Button oval_btn;
        private System.Windows.Forms.Button triangle_btn;
        private System.Windows.Forms.Button pentagon_btn;
        private System.Windows.Forms.Button line_btn;
        private System.Windows.Forms.Button openFile_btn;
        private System.Windows.Forms.Button saveFile_btn;
        private System.Windows.Forms.Panel paintFunction_pnl;
        private System.Windows.Forms.Panel FileEdit_pnl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel color_pnl;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.PictureBox presentColor;
        private System.Windows.Forms.Button whiteColor_btn;
        private System.Windows.Forms.Button dimGrayColor_btn;
        private System.Windows.Forms.Button grayColor_btn;
        private System.Windows.Forms.Button LinenColor_btn;
        private System.Windows.Forms.Button blackColor_btn;
        private System.Windows.Forms.Button LimeColor_btn;
        private System.Windows.Forms.Button IvoryColor_btn;
        private System.Windows.Forms.Button LavenderBlushColor_btn;
        private System.Windows.Forms.Button LightPinkColor_btn;
        private System.Windows.Forms.Button TanColor_btn;
        private System.Windows.Forms.Button FireBrickColor_btn;
        private System.Windows.Forms.Button sliverColor_btn;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button color_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

