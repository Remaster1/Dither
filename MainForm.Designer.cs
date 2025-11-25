namespace Dither
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            ditheredPictureBox = new PictureBox();
            panel1 = new Panel();
            originalPictureBox = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            paletteComboBox = new ComboBox();
            paletteLabel = new Label();
            ditherAlgorithmComboBox = new ComboBox();
            ditherAlgorithmLabel = new Label();
            openFileDialog = new OpenFileDialog();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            ditherModeToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            monochromeToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            applyButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ditheredPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.56602F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5660248F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8679562F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1229, 511);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ditheredPictureBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(464, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 505);
            panel2.TabIndex = 11;
            // 
            // ditheredPictureBox
            // 
            ditheredPictureBox.Location = new Point(0, 0);
            ditheredPictureBox.Name = "ditheredPictureBox";
            ditheredPictureBox.Size = new Size(1, 1);
            ditheredPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ditheredPictureBox.TabIndex = 2;
            ditheredPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(originalPictureBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 505);
            panel1.TabIndex = 3;
            // 
            // originalPictureBox
            // 
            originalPictureBox.Location = new Point(0, 0);
            originalPictureBox.Name = "originalPictureBox";
            originalPictureBox.Size = new Size(1, 1);
            originalPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            originalPictureBox.TabIndex = 2;
            originalPictureBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(paletteComboBox, 1, 1);
            tableLayoutPanel2.Controls.Add(paletteLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(ditherAlgorithmComboBox, 1, 0);
            tableLayoutPanel2.Controls.Add(ditherAlgorithmLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(applyButton, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(925, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(301, 88);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // paletteComboBox
            // 
            paletteComboBox.Dock = DockStyle.Fill;
            paletteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            paletteComboBox.FormattingEnabled = true;
            paletteComboBox.Location = new Point(153, 32);
            paletteComboBox.Name = "paletteComboBox";
            paletteComboBox.Size = new Size(145, 23);
            paletteComboBox.TabIndex = 10;
            // 
            // paletteLabel
            // 
            paletteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paletteLabel.AutoSize = true;
            paletteLabel.Location = new Point(3, 29);
            paletteLabel.Name = "paletteLabel";
            paletteLabel.Size = new Size(144, 29);
            paletteLabel.TabIndex = 4;
            paletteLabel.Text = "Palette:";
            paletteLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ditherAlgorithmComboBox
            // 
            ditherAlgorithmComboBox.Dock = DockStyle.Fill;
            ditherAlgorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ditherAlgorithmComboBox.FormattingEnabled = true;
            ditherAlgorithmComboBox.Location = new Point(153, 3);
            ditherAlgorithmComboBox.Name = "ditherAlgorithmComboBox";
            ditherAlgorithmComboBox.Size = new Size(145, 23);
            ditherAlgorithmComboBox.TabIndex = 3;
            // 
            // ditherAlgorithmLabel
            // 
            ditherAlgorithmLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ditherAlgorithmLabel.AutoSize = true;
            ditherAlgorithmLabel.Location = new Point(3, 0);
            ditherAlgorithmLabel.Name = "ditherAlgorithmLabel";
            ditherAlgorithmLabel.Size = new Size(144, 29);
            ditherAlgorithmLabel.TabIndex = 2;
            ditherAlgorithmLabel.Text = "Dither algorithm:";
            ditherAlgorithmLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "file";
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, ditherModeToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1229, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // ditherModeToolStripMenuItem
            // 
            ditherModeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, monochromeToolStripMenuItem });
            ditherModeToolStripMenuItem.Name = "ditherModeToolStripMenuItem";
            ditherModeToolStripMenuItem.Size = new Size(85, 20);
            ditherModeToolStripMenuItem.Text = "Dither Mode";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(147, 22);
            colorToolStripMenuItem.Text = "Colorful";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // monochromeToolStripMenuItem
            // 
            monochromeToolStripMenuItem.Name = "monochromeToolStripMenuItem";
            monochromeToolStripMenuItem.Size = new Size(147, 22);
            monochromeToolStripMenuItem.Text = "Monochrome";
            monochromeToolStripMenuItem.Click += monochromeToolStripMenuItem_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.FileName = "file";
            saveFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png";
            // 
            // applyButton
            // 
            tableLayoutPanel2.SetColumnSpan(applyButton, 2);
            applyButton.Dock = DockStyle.Top;
            applyButton.Location = new Point(3, 61);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(295, 23);
            applyButton.TabIndex = 11;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 535);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "DitherApp";
            FormClosed += MainForm_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ditheredPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private OpenFileDialog openFileDialog;
        private Panel panel1;
        private PictureBox originalPictureBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem ditherModeToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem monochromeToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox paletteComboBox;
        private Label paletteLabel;
        private ComboBox ditherAlgorithmComboBox;
        private Label ditherAlgorithmLabel;
        private Panel panel2;
        private PictureBox ditheredPictureBox;
        private Button applyButton;
    }
}
