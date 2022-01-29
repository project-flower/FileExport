using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileExport
{
    public partial class FormMain : Form
    {
        #region Private Fields

        private MouseButtons draggedButton = MouseButtons.None;
        private DragDropEffects effecs = DragDropEffects.None;

        #endregion

        #region Public Methods

        public FormMain()
        {
            InitializeComponent();
            MinimumSize = Size;
        }

        #endregion

        // Designer's Methods

        private void labelExport_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = effecs;
        }

        private void labelExport_MouseDown(object sender, MouseEventArgs e)
        {
            draggedButton = e.Button;
        }

        private void labelExport_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggedButton == MouseButtons.None)
            {
                return;
            }

            if (e.Button != draggedButton)
            {
                draggedButton = MouseButtons.None;
                return;
            }

            IEnumerable<string> fileNames = textBoxFiles.Lines.Where(n => !string.IsNullOrEmpty(n));

            if (fileNames.Count() < 1)
            {
                return;
            }

            effecs = labelExport.DoDragDrop(new DataObject(DataFormats.FileDrop, fileNames.ToArray()), DragDropEffects.All);
        }

        private void textBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop) as string[];

            if ((data == null) || (data.Length < 1))
            {
                return;
            }

            var builder = new StringBuilder();

            if (textBoxFiles.Text.Length > 0)
            {
                textBoxFiles.Text += Environment.NewLine;
            }

            bool atFirst = true;

            foreach (string item in data)
            {
                if (atFirst)
                {
                    atFirst = false;
                }
                else
                {
                    builder.AppendLine();
                }

                builder.Append(item);
            }

            textBoxFiles.Text += builder.ToString();
        }

        private void textBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None);
        }
    }
}
