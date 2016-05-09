namespace DMT_renameNameNumbering
{
    partial class ftm_customName
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
            this.txt_prefix = new System.Windows.Forms.TextBox();
            this.txt_startNr = new System.Windows.Forms.TextBox();
            this.txt_style = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_suffix = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_preview = new System.Windows.Forms.Label();
            this.btn_rename = new System.Windows.Forms.Button();
            this.lbl_statusMessage = new System.Windows.Forms.Label();
            this.rb_hor = new System.Windows.Forms.RadioButton();
            this.rb_vert = new System.Windows.Forms.RadioButton();
            this.lbl_preview2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_assembly = new System.Windows.Forms.RadioButton();
            this.rb_part = new System.Windows.Forms.RadioButton();
            this.btn_min_2 = new System.Windows.Forms.Button();
            this.btn_pls_2 = new System.Windows.Forms.Button();
            this.btn_min_1 = new System.Windows.Forms.Button();
            this.btn_pls_1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_prefix
            // 
            this.txt_prefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_prefix.Location = new System.Drawing.Point(113, 40);
            this.txt_prefix.Name = "txt_prefix";
            this.txt_prefix.Size = new System.Drawing.Size(83, 20);
            this.txt_prefix.TabIndex = 0;
            this.txt_prefix.Text = "<prefix>";
            this.txt_prefix.TextChanged += new System.EventHandler(this.txt_prefix_TextChanged);
            // 
            // txt_startNr
            // 
            this.txt_startNr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_startNr.Location = new System.Drawing.Point(113, 66);
            this.txt_startNr.Name = "txt_startNr";
            this.txt_startNr.Size = new System.Drawing.Size(83, 20);
            this.txt_startNr.TabIndex = 1;
            this.txt_startNr.Text = "<start nr>";
            this.txt_startNr.TextChanged += new System.EventHandler(this.txt_startNr_TextChanged);
            // 
            // txt_style
            // 
            this.txt_style.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_style.Location = new System.Drawing.Point(113, 92);
            this.txt_style.Name = "txt_style";
            this.txt_style.Size = new System.Drawing.Size(83, 20);
            this.txt_style.TabIndex = 2;
            this.txt_style.Text = "<style>";
            this.txt_style.TextChanged += new System.EventHandler(this.txt_style_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prefix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start number:";
            // 
            // lbl_suffix
            // 
            this.lbl_suffix.AutoSize = true;
            this.lbl_suffix.Location = new System.Drawing.Point(12, 95);
            this.lbl_suffix.Name = "lbl_suffix";
            this.lbl_suffix.Size = new System.Drawing.Size(43, 13);
            this.lbl_suffix.TabIndex = 5;
            this.lbl_suffix.Text = "<suffix>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preview:";
            // 
            // lbl_preview
            // 
            this.lbl_preview.AutoSize = true;
            this.lbl_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbl_preview.Location = new System.Drawing.Point(85, 119);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(58, 17);
            this.lbl_preview.TabIndex = 7;
            this.lbl_preview.Text = "<prev>";
            // 
            // btn_rename
            // 
            this.btn_rename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rename.Location = new System.Drawing.Point(12, 200);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(203, 39);
            this.btn_rename.TabIndex = 8;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // lbl_statusMessage
            // 
            this.lbl_statusMessage.AutoSize = true;
            this.lbl_statusMessage.Location = new System.Drawing.Point(12, 242);
            this.lbl_statusMessage.Name = "lbl_statusMessage";
            this.lbl_statusMessage.Size = new System.Drawing.Size(90, 13);
            this.lbl_statusMessage.TabIndex = 9;
            this.lbl_statusMessage.Text = "<statusMessage>";
            // 
            // rb_hor
            // 
            this.rb_hor.AutoSize = true;
            this.rb_hor.Location = new System.Drawing.Point(12, 12);
            this.rb_hor.Name = "rb_hor";
            this.rb_hor.Size = new System.Drawing.Size(72, 17);
            this.rb_hor.TabIndex = 10;
            this.rb_hor.Text = "Horisontal";
            this.rb_hor.UseVisualStyleBackColor = true;
            this.rb_hor.CheckedChanged += new System.EventHandler(this.rb_hor_CheckedChanged);
            // 
            // rb_vert
            // 
            this.rb_vert.AutoSize = true;
            this.rb_vert.Location = new System.Drawing.Point(101, 12);
            this.rb_vert.Name = "rb_vert";
            this.rb_vert.Size = new System.Drawing.Size(60, 17);
            this.rb_vert.TabIndex = 10;
            this.rb_vert.Text = "Vertical";
            this.rb_vert.UseVisualStyleBackColor = true;
            this.rb_vert.CheckedChanged += new System.EventHandler(this.rb_vert_CheckedChanged);
            // 
            // lbl_preview2
            // 
            this.lbl_preview2.AutoSize = true;
            this.lbl_preview2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbl_preview2.Location = new System.Drawing.Point(85, 141);
            this.lbl_preview2.Name = "lbl_preview2";
            this.lbl_preview2.Size = new System.Drawing.Size(67, 17);
            this.lbl_preview2.TabIndex = 7;
            this.lbl_preview2.Text = "<prev2>";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rb_assembly);
            this.panel1.Controls.Add(this.rb_part);
            this.panel1.Location = new System.Drawing.Point(-5, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 29);
            this.panel1.TabIndex = 11;
            // 
            // rb_assembly
            // 
            this.rb_assembly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_assembly.AutoSize = true;
            this.rb_assembly.Location = new System.Drawing.Point(105, 5);
            this.rb_assembly.Name = "rb_assembly";
            this.rb_assembly.Size = new System.Drawing.Size(69, 17);
            this.rb_assembly.TabIndex = 1;
            this.rb_assembly.TabStop = true;
            this.rb_assembly.Text = "Assembly";
            this.rb_assembly.UseVisualStyleBackColor = true;
            this.rb_assembly.CheckedChanged += new System.EventHandler(this.rb_assembly_CheckedChanged);
            // 
            // rb_part
            // 
            this.rb_part.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_part.AutoSize = true;
            this.rb_part.Checked = true;
            this.rb_part.Location = new System.Drawing.Point(16, 5);
            this.rb_part.Name = "rb_part";
            this.rb_part.Size = new System.Drawing.Size(70, 17);
            this.rb_part.TabIndex = 0;
            this.rb_part.TabStop = true;
            this.rb_part.Text = "Main Part";
            this.rb_part.UseVisualStyleBackColor = true;
            this.rb_part.CheckedChanged += new System.EventHandler(this.rb_part_CheckedChanged);
            // 
            // btn_min_2
            // 
            this.btn_min_2.Location = new System.Drawing.Point(86, 90);
            this.btn_min_2.Name = "btn_min_2";
            this.btn_min_2.Size = new System.Drawing.Size(23, 23);
            this.btn_min_2.TabIndex = 12;
            this.btn_min_2.Text = "-";
            this.btn_min_2.UseVisualStyleBackColor = true;
            this.btn_min_2.Click += new System.EventHandler(this.btn_min_2_Click);
            // 
            // btn_pls_2
            // 
            this.btn_pls_2.Location = new System.Drawing.Point(200, 90);
            this.btn_pls_2.Name = "btn_pls_2";
            this.btn_pls_2.Size = new System.Drawing.Size(23, 23);
            this.btn_pls_2.TabIndex = 13;
            this.btn_pls_2.Text = "+";
            this.btn_pls_2.UseVisualStyleBackColor = true;
            this.btn_pls_2.Click += new System.EventHandler(this.btn_pls_2_Click);
            // 
            // btn_min_1
            // 
            this.btn_min_1.Location = new System.Drawing.Point(86, 38);
            this.btn_min_1.Name = "btn_min_1";
            this.btn_min_1.Size = new System.Drawing.Size(23, 23);
            this.btn_min_1.TabIndex = 12;
            this.btn_min_1.Text = "-";
            this.btn_min_1.UseVisualStyleBackColor = true;
            this.btn_min_1.Click += new System.EventHandler(this.btn_min_1_Click);
            // 
            // btn_pls_1
            // 
            this.btn_pls_1.Location = new System.Drawing.Point(200, 38);
            this.btn_pls_1.Name = "btn_pls_1";
            this.btn_pls_1.Size = new System.Drawing.Size(23, 23);
            this.btn_pls_1.TabIndex = 13;
            this.btn_pls_1.Text = "+";
            this.btn_pls_1.UseVisualStyleBackColor = true;
            this.btn_pls_1.Click += new System.EventHandler(this.btn_pls_1_Click);
            // 
            // ftm_customName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 275);
            this.Controls.Add(this.btn_pls_1);
            this.Controls.Add(this.btn_pls_2);
            this.Controls.Add(this.btn_min_1);
            this.Controls.Add(this.btn_min_2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rb_vert);
            this.Controls.Add(this.rb_hor);
            this.Controls.Add(this.lbl_statusMessage);
            this.Controls.Add(this.btn_rename);
            this.Controls.Add(this.lbl_preview2);
            this.Controls.Add(this.lbl_preview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_suffix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_style);
            this.Controls.Add(this.txt_startNr);
            this.Controls.Add(this.txt_prefix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ftm_customName";
            this.Text = "PART custom name";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ftm_customName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_prefix;
        private System.Windows.Forms.TextBox txt_startNr;
        private System.Windows.Forms.TextBox txt_style;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_suffix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_preview;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.Label lbl_statusMessage;
        private System.Windows.Forms.RadioButton rb_hor;
        private System.Windows.Forms.RadioButton rb_vert;
        private System.Windows.Forms.Label lbl_preview2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_assembly;
        private System.Windows.Forms.RadioButton rb_part;
        private System.Windows.Forms.Button btn_min_2;
        private System.Windows.Forms.Button btn_pls_2;
        private System.Windows.Forms.Button btn_min_1;
        private System.Windows.Forms.Button btn_pls_1;
    }
}

