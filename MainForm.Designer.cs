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
            openFileDialog = new OpenFileDialog();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            ditherModeToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            monochromeToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            toolStrip1 = new ToolStrip();
            ditherAlgorithmLabel = new ToolStripLabel();
            ditherAlgorithmComboBox = new ToolStripComboBox();
            paletteLabel = new ToolStripLabel();
            paletteComboBox = new ToolStripComboBox();
            applyButton = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            ditheredPictureBox = new PictureBox();
            panel1 = new Panel();
            originalPictureBox = new PictureBox();
            menuStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ditheredPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).BeginInit();
            SuspendLayout();
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { ditherAlgorithmLabel, ditherAlgorithmComboBox, paletteLabel, paletteComboBox, applyButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1229, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // ditherAlgorithmLabel
            // 
            ditherAlgorithmLabel.Name = "ditherAlgorithmLabel";
            ditherAlgorithmLabel.Size = new Size(97, 22);
            ditherAlgorithmLabel.Text = "Dither algorithm:";
            // 
            // ditherAlgorithmComboBox
            // 
            ditherAlgorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ditherAlgorithmComboBox.Name = "ditherAlgorithmComboBox";
            ditherAlgorithmComboBox.Size = new Size(121, 25);
            // 
            // paletteLabel
            // 
            paletteLabel.Name = "paletteLabel";
            paletteLabel.Size = new Size(46, 22);
            paletteLabel.Text = "Palette:";
            // 
            // paletteComboBox
            // 
            paletteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            paletteComboBox.Name = "paletteComboBox";
            paletteComboBox.Size = new Size(121, 25);
            // 
            // applyButton
            // 
            applyButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            applyButton.ImageTransparentColor = Color.Magenta;
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(42, 22);
            applyButton.Text = "Apply";
            applyButton.Click += applyButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1229, 486);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ditheredPictureBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(617, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 480);
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
            panel1.Size = new Size(608, 480);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 535);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "DitherApp";
            FormClosed += MainForm_FormClosed;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ditheredPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem ditherModeToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem monochromeToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private ToolStrip toolStrip1;
        private ToolStripLabel ditherAlgorithmLabel;
        private ToolStripComboBox ditherAlgorithmComboBox;
        private ToolStripLabel paletteLabel;
        private ToolStripComboBox paletteComboBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private PictureBox ditheredPictureBox;
        private Panel panel1;
        private PictureBox originalPictureBox;
        private ToolStripButton applyButton;
    }
}
