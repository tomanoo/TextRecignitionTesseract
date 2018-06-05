namespace TextRecognitionTesseract
{
    partial class TextRecognition
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseImage = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.textRecognitionResult = new System.Windows.Forms.TextBox();
            this.saveText = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.loadImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseImage
            // 
            this.chooseImage.Location = new System.Drawing.Point(13, 13);
            this.chooseImage.Name = "chooseImage";
            this.chooseImage.Size = new System.Drawing.Size(83, 23);
            this.chooseImage.TabIndex = 0;
            this.chooseImage.Text = "Choose Image";
            this.chooseImage.UseVisualStyleBackColor = true;
            this.chooseImage.Click += new System.EventHandler(this.chooseImage_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // textRecognitionResult
            // 
            this.textRecognitionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textRecognitionResult.Location = new System.Drawing.Point(12, 325);
            this.textRecognitionResult.Multiline = true;
            this.textRecognitionResult.Name = "textRecognitionResult";
            this.textRecognitionResult.Size = new System.Drawing.Size(392, 152);
            this.textRecognitionResult.TabIndex = 1;
            // 
            // saveText
            // 
            this.saveText.Location = new System.Drawing.Point(328, 13);
            this.saveText.Name = "saveText";
            this.saveText.Size = new System.Drawing.Size(75, 23);
            this.saveText.TabIndex = 2;
            this.saveText.Text = "Save Text";
            this.saveText.UseVisualStyleBackColor = true;
            this.saveText.Click += new System.EventHandler(this.saveText_Click);
            // 
            // loadImage
            // 
            this.loadImage.BackColor = System.Drawing.SystemColors.Window;
            this.loadImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadImage.Location = new System.Drawing.Point(12, 94);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(391, 164);
            this.loadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadImage.TabIndex = 3;
            this.loadImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loaded Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recognised text:";
            // 
            // TextRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.saveText);
            this.Controls.Add(this.textRecognitionResult);
            this.Controls.Add(this.chooseImage);
            this.Name = "TextRecognition";
            this.Text = "Text Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.loadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseImage;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox textRecognitionResult;
        private System.Windows.Forms.Button saveText;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.PictureBox loadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

