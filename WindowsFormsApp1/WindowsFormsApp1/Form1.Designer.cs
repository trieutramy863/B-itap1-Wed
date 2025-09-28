namespace ConsoleApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.NumericUpDown numGrid;
        private System.Windows.Forms.CheckBox chkMirror;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblMeta;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.numGrid = new System.Windows.Forms.NumericUpDown();
            this.chkMirror = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lblMeta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(360, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "hello world";
            // 
            // numGrid
            // 
            this.numGrid.Location = new System.Drawing.Point(12, 40);
            this.numGrid.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numGrid.Name = "numGrid";
            this.numGrid.Size = new System.Drawing.Size(80, 26);
            this.numGrid.TabIndex = 1;
            this.numGrid.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // chkMirror
            // 
            this.chkMirror.AutoSize = true;
            this.chkMirror.Location = new System.Drawing.Point(110, 42);
            this.chkMirror.Name = "chkMirror";
            this.chkMirror.Size = new System.Drawing.Size(75, 24);
            this.chkMirror.TabIndex = 2;
            this.chkMirror.Text = "Mirror";
            this.chkMirror.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(201, 40);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(85, 26);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(12, 75);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(560, 330);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // lblMeta
            // 
            this.lblMeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMeta.AutoSize = true;
            this.lblMeta.Location = new System.Drawing.Point(12, 415);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(55, 20);
            this.lblMeta.TabIndex = 5;
            this.lblMeta.Text = "Ready";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.lblMeta);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chkMirror);
            this.Controls.Add(this.numGrid);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "UniqueArt - WinForms";
            ((System.ComponentModel.ISupportInitialize)(this.numGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
