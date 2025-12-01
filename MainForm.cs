using System.Drawing.Imaging;
using System.Resources;
using Dither.Dithers;

namespace Dither
{
    internal enum SelectedDither
    {
        Color,
        Monochrome
    }

    public partial class MainForm : Form
    {

        private Bitmap? _originalBitmap;
        private Bitmap? _ditheredBitmap;

        private readonly ResourceManager _locRm = new ResourceManager("Dither.Dither", typeof(MainForm).Assembly);

        private SelectedDither _selectedDither = SelectedDither.Monochrome;

        public MainForm()
        {
            InitializeComponent();
            LocalizeControls();
            SetDitherMode(_selectedDither);

            ditherAlgorithmComboBox.ComboBox.DisplayMember = "Name";
            ditherAlgorithmComboBox.ComboBox.DataSource = DitherAlgorithms.All;

            paletteComboBox.ComboBox.DisplayMember = "Name";
            paletteComboBox.ComboBox.DataSource = Palettes.All;
        }

        private void LocalizeControls()
        {
            fileToolStripMenuItem.Text = _locRm.GetString("fileToolStrip");
            saveToolStripMenuItem.Text = _locRm.GetString("saveToolStrip");
            loadToolStripMenuItem.Text = _locRm.GetString("loadToolStrip");

            ditherModeToolStripMenuItem.Text = _locRm.GetString("ditherModeToolStrip");
            colorToolStripMenuItem.Text = _locRm.GetString("colorModeToolStrip");
            monochromeToolStripMenuItem.Text = _locRm.GetString("monochromeModeToolStrip");

            ditherAlgorithmLabel.Text = $@"{_locRm.GetString("ditherAlgorithmLabel")}:";
            paletteLabel.Text = $@"{_locRm.GetString("paletteLabel")}:";

            applyButton.Text = _locRm.GetString("applyButton");
        }

        private void SetOriginalBitmap(Bitmap bitmap)
        {
            if (bitmap == _originalBitmap) return;
            ClearOriginalBitmap();
            _originalBitmap = bitmap;
            originalPictureBox.Image = _originalBitmap;
        }

        private void SetDitheredBitmap(Bitmap bitmap)
        {
            if (bitmap == _ditheredBitmap) return;
            ClearDitheredBitmap();
            _ditheredBitmap = bitmap;
            ditheredPictureBox.Image = _ditheredBitmap;
        }

        private void ClearOriginalBitmap()
        {
            _originalBitmap?.Dispose();
            _originalBitmap = null;
            originalPictureBox.Image = null;
        }

        private void ClearDitheredBitmap()
        {
            _ditheredBitmap?.Dispose();
            _ditheredBitmap = null;
            ditheredPictureBox.Image = null;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                using Bitmap bitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);
                SetOriginalBitmap(new Bitmap(bitmap));
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"{_locRm.GetString("msgBoxLoadFileErrText")} ({ex.Message})", _locRm.GetString("msgBoxErrorCaption"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDitherMode(SelectedDither.Color);
        }

        private void monochromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDitherMode(SelectedDither.Monochrome);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearDitheredBitmap();
            ClearOriginalBitmap();
        }

        private void SetDitherMode(SelectedDither selectedDither)
        {
            _selectedDither = selectedDither;
            colorToolStripMenuItem.Checked = false;
            monochromeToolStripMenuItem.Checked = false;
            paletteComboBox.Enabled = false;
            switch (_selectedDither)
            {
                case SelectedDither.Monochrome:
                    monochromeToolStripMenuItem.Checked = true;
                    break;
                case SelectedDither.Color:
                    colorToolStripMenuItem.Checked = true;
                    paletteComboBox.Enabled = true;
                    break;
                default:
                    return;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ditheredBitmap == null)
            {
                MessageBox.Show(_locRm.GetString("msgBoxNotLoadFileErrText"), _locRm.GetString("msgBoxErrorCaption"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                _ditheredBitmap.Save(saveFileDialog.FileName, GetImageFormat(Path.GetExtension(saveFileDialog.FileName)));
                MessageBox.Show($@"{_locRm.GetString("msgBoxSaveFIleInfText")} {saveFileDialog.FileName}", _locRm.GetString("msgBoxSaveFileInfCaption"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"{_locRm.GetString("msgBoxSaveFileErrText")} ({ex.Message})", _locRm.GetString("msgBoxErrorCaption"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ImageFormat GetImageFormat(string extension)
        {
            return extension.ToLower() switch
            {
                ".jpg" or ".jpeg" => ImageFormat.Jpeg,
                ".png" => ImageFormat.Png,
                ".bmp" => ImageFormat.Bmp,
                _ => throw new ArgumentException(_locRm.GetString("invalidFileTypeErr"))
            };
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null)
            {
                MessageBox.Show(_locRm.GetString("msgBoxNotLoadFileErrText"), _locRm.GetString("msgBoxErrorCaption"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ditherAlgorithmComboBox.SelectedItem is not DitherAlgorithm algorithm) return;

            try
            {
                Bitmap bitmap = _selectedDither switch
                {
                    SelectedDither.Monochrome => new MonochromeDither(algorithm).Convert(_originalBitmap),
                    SelectedDither.Color when paletteComboBox.SelectedItem is Palette palette =>
                        new ColorDither(algorithm, palette).Convert(_originalBitmap),
                    SelectedDither.Color => throw new ArgumentException(
                        _locRm.GetString("notSelectedPaletteForColorfulDitherErr")),
                    _ => throw new ArgumentException(_locRm.GetString("invalidDitherModeErr"))
                };

                SetDitheredBitmap(bitmap);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"{_locRm.GetString("msgBoxDitherErrText")} ({ex.Message})", _locRm.GetString("msgBoxErrorCaption"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
