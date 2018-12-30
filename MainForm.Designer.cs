namespace RLFImageClassification
{
    partial class MainForm
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
            this.panelResultsContainer = new System.Windows.Forms.Panel();
            this.panelResults = new System.Windows.Forms.Panel();
            this.lblPrimitivePercentage = new System.Windows.Forms.Label();
            this.lblPrimitiveLengthUniformity = new System.Windows.Forms.Label();
            this.lblGrayLevelUniformity = new System.Windows.Forms.Label();
            this.lblLongPrimitiveEmphasis = new System.Windows.Forms.Label();
            this.lblShortPrimitiveEmphasis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRunProcessing = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelResultsContainer.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultsContainer
            // 
            this.panelResultsContainer.Controls.Add(this.groupBox1);
            this.panelResultsContainer.Controls.Add(this.lblHelp);
            this.panelResultsContainer.Location = new System.Drawing.Point(12, 12);
            this.panelResultsContainer.Name = "panelResultsContainer";
            this.panelResultsContainer.Size = new System.Drawing.Size(676, 347);
            this.panelResultsContainer.TabIndex = 0;
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.lblPrimitivePercentage);
            this.panelResults.Controls.Add(this.lblPrimitiveLengthUniformity);
            this.panelResults.Controls.Add(this.lblGrayLevelUniformity);
            this.panelResults.Controls.Add(this.lblLongPrimitiveEmphasis);
            this.panelResults.Controls.Add(this.lblShortPrimitiveEmphasis);
            this.panelResults.Controls.Add(this.label6);
            this.panelResults.Controls.Add(this.label5);
            this.panelResults.Controls.Add(this.label4);
            this.panelResults.Controls.Add(this.label3);
            this.panelResults.Controls.Add(this.label2);
            this.panelResults.Location = new System.Drawing.Point(6, 32);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(647, 232);
            this.panelResults.TabIndex = 9;
            this.panelResults.Visible = false;
            // 
            // lblPrimitivePercentage
            // 
            this.lblPrimitivePercentage.AutoSize = true;
            this.lblPrimitivePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrimitivePercentage.Location = new System.Drawing.Point(450, 187);
            this.lblPrimitivePercentage.Name = "lblPrimitivePercentage";
            this.lblPrimitivePercentage.Size = new System.Drawing.Size(0, 20);
            this.lblPrimitivePercentage.TabIndex = 7;
            // 
            // lblPrimitiveLengthUniformity
            // 
            this.lblPrimitiveLengthUniformity.AutoSize = true;
            this.lblPrimitiveLengthUniformity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrimitiveLengthUniformity.Location = new System.Drawing.Point(450, 147);
            this.lblPrimitiveLengthUniformity.Name = "lblPrimitiveLengthUniformity";
            this.lblPrimitiveLengthUniformity.Size = new System.Drawing.Size(0, 20);
            this.lblPrimitiveLengthUniformity.TabIndex = 8;
            // 
            // lblGrayLevelUniformity
            // 
            this.lblGrayLevelUniformity.AutoSize = true;
            this.lblGrayLevelUniformity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGrayLevelUniformity.Location = new System.Drawing.Point(450, 107);
            this.lblGrayLevelUniformity.Name = "lblGrayLevelUniformity";
            this.lblGrayLevelUniformity.Size = new System.Drawing.Size(0, 20);
            this.lblGrayLevelUniformity.TabIndex = 6;
            // 
            // lblLongPrimitiveEmphasis
            // 
            this.lblLongPrimitiveEmphasis.AutoSize = true;
            this.lblLongPrimitiveEmphasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLongPrimitiveEmphasis.Location = new System.Drawing.Point(450, 67);
            this.lblLongPrimitiveEmphasis.Name = "lblLongPrimitiveEmphasis";
            this.lblLongPrimitiveEmphasis.Size = new System.Drawing.Size(0, 20);
            this.lblLongPrimitiveEmphasis.TabIndex = 5;
            // 
            // lblShortPrimitiveEmphasis
            // 
            this.lblShortPrimitiveEmphasis.AutoSize = true;
            this.lblShortPrimitiveEmphasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblShortPrimitiveEmphasis.Location = new System.Drawing.Point(450, 27);
            this.lblShortPrimitiveEmphasis.Name = "lblShortPrimitiveEmphasis";
            this.lblShortPrimitiveEmphasis.Size = new System.Drawing.Size(0, 20);
            this.lblShortPrimitiveEmphasis.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(20, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Primitive percentage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(20, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Primitive length uniformity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(20, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gray-level uniformity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Long primitive emphasis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Short primitive emphasis:";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.lblImagePath);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnRunProcessing);
            this.panelMenu.Controls.Add(this.btnLoadImage);
            this.panelMenu.Location = new System.Drawing.Point(13, 367);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(676, 119);
            this.panelMenu.TabIndex = 1;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(66, 58);
            this.lblImagePath.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(0, 17);
            this.lblImagePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obraz:";
            // 
            // btnRunProcessing
            // 
            this.btnRunProcessing.Location = new System.Drawing.Point(470, 16);
            this.btnRunProcessing.Name = "btnRunProcessing";
            this.btnRunProcessing.Size = new System.Drawing.Size(189, 84);
            this.btnRunProcessing.TabIndex = 1;
            this.btnRunProcessing.Text = "Start";
            this.btnRunProcessing.UseVisualStyleBackColor = true;
            this.btnRunProcessing.Click += new System.EventHandler(this.btnRunProcessing_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 16);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(267, 29);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Wybierz obraz";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHelp.Location = new System.Drawing.Point(38, 10);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(600, 50);
            this.lblHelp.TabIndex = 9;
            this.lblHelp.Text = "Wybierz obraz do analizy i kliknij \"Start\", aby obliczyć wartości parametrów Run " +
    "Length Features (RLF)";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelResults);
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 270);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 498);
            this.Controls.Add(this.panelResultsContainer);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "RLF";
            this.panelResultsContainer.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResultsContainer;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRunProcessing;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblPrimitivePercentage;
        private System.Windows.Forms.Label lblPrimitiveLengthUniformity;
        private System.Windows.Forms.Label lblGrayLevelUniformity;
        private System.Windows.Forms.Label lblLongPrimitiveEmphasis;
        private System.Windows.Forms.Label lblShortPrimitiveEmphasis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

