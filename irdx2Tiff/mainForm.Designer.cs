namespace irdx2Tiff
{
    partial class mainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.imageBoxConverted = new Emgu.CV.UI.ImageBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxConverted)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "PyroSoft files|*.irdx|All files|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(6, 32);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 43);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open files";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // imageBoxConverted
            // 
            this.imageBoxConverted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxConverted.Location = new System.Drawing.Point(88, 32);
            this.imageBoxConverted.Name = "imageBoxConverted";
            this.imageBoxConverted.Size = new System.Drawing.Size(640, 480);
            this.imageBoxConverted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxConverted.TabIndex = 2;
            this.imageBoxConverted.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(88, 518);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(640, 23);
            this.progressBar.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(734, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(516, 480);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 542);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.imageBoxConverted);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.Text = "Irdx2Tiff";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxConverted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonOpen;
        private Emgu.CV.UI.ImageBox imageBoxConverted;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

