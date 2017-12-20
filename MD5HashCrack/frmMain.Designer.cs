partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkNumeric = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.btnStartResume = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLastMD5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.numLowerLimit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Tried:";
            // 
            // txtResume
            // 
            this.txtResume.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResume.Location = new System.Drawing.Point(8, 28);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(142, 22);
            this.txtResume.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max # of char between";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Options:";
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Checked = true;
            this.chkLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLower.Location = new System.Drawing.Point(15, 90);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(98, 17);
            this.chkLower.TabIndex = 6;
            this.chkLower.Text = "Lowercase A-Z";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(15, 113);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(98, 17);
            this.chkUpper.TabIndex = 7;
            this.chkUpper.Text = "Uppercase A-Z";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // chkNumeric
            // 
            this.chkNumeric.AutoSize = true;
            this.chkNumeric.Checked = true;
            this.chkNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumeric.Location = new System.Drawing.Point(15, 136);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Size = new System.Drawing.Size(65, 17);
            this.chkNumeric.TabIndex = 8;
            this.chkNumeric.Text = "Numeric";
            this.chkNumeric.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(15, 159);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(115, 17);
            this.chkSpecial.TabIndex = 9;
            this.chkSpecial.Text = "Special Characters";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // btnStartResume
            // 
            this.btnStartResume.Location = new System.Drawing.Point(15, 373);
            this.btnStartResume.Name = "btnStartResume";
            this.btnStartResume.Size = new System.Drawing.Size(75, 23);
            this.btnStartResume.TabIndex = 10;
            this.btnStartResume.Text = "Start";
            this.btnStartResume.UseVisualStyleBackColor = true;
            this.btnStartResume.Click += new System.EventHandler(this.btnStartResume_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "The MD5 to search for:";
            // 
            // txtMD5
            // 
            this.txtMD5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMD5.Location = new System.Drawing.Point(12, 25);
            this.txtMD5.MaxLength = 32;
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(268, 21);
            this.txtMD5.TabIndex = 12;
            // 
            // btnAbort
            // 
            this.btnAbort.Enabled = false;
            this.btnAbort.Location = new System.Drawing.Point(109, 373);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 13;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 352);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Waiting to Start...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "and";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(205, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLastMD5
            // 
            this.txtLastMD5.Enabled = false;
            this.txtLastMD5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastMD5.Location = new System.Drawing.Point(8, 72);
            this.txtLastMD5.Name = "txtLastMD5";
            this.txtLastMD5.Size = new System.Drawing.Size(259, 21);
            this.txtLastMD5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "MD5 Tried:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLastMD5);
            this.groupBox1.Controls.Add(this.txtResume);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 103);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numLowerLimit);
            this.groupBox2.Controls.Add(this.numUpperLimit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkLower);
            this.groupBox2.Controls.Add(this.chkUpper);
            this.groupBox2.Controls.Add(this.chkNumeric);
            this.groupBox2.Controls.Add(this.chkSpecial);
            this.groupBox2.Location = new System.Drawing.Point(15, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 182);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // numUpperLimit
            // 
            this.numUpperLimit.Location = new System.Drawing.Point(103, 44);
            this.numUpperLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpperLimit.Name = "numUpperLimit";
            this.numUpperLimit.Size = new System.Drawing.Size(39, 20);
            this.numUpperLimit.TabIndex = 17;
            this.numUpperLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numLowerLimit
            // 
            this.numLowerLimit.Location = new System.Drawing.Point(15, 45);
            this.numLowerLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLowerLimit.Name = "numLowerLimit";
            this.numLowerLimit.Size = new System.Drawing.Size(51, 20);
            this.numLowerLimit.TabIndex = 18;
            this.numLowerLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Created by : Batsakidis Athanasios";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 430);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStartResume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD5 Bruter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtResume;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox chkLower;
    private System.Windows.Forms.CheckBox chkUpper;
    private System.Windows.Forms.CheckBox chkNumeric;
    private System.Windows.Forms.CheckBox chkSpecial;
    private System.Windows.Forms.Button btnStartResume;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtMD5;
    private System.Windows.Forms.Button btnAbort;
    private System.Windows.Forms.Timer tmrMain;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.TextBox txtLastMD5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.NumericUpDown numLowerLimit;
    private System.Windows.Forms.NumericUpDown numUpperLimit;
    private System.Windows.Forms.Label label7;
}