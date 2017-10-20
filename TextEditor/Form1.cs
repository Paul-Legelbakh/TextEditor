using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace TextEditor
{
    /// <summary>
    /// Мой редактор типа Блокнота
    /// </summary>
    public partial class Form1 : Form
    {

        private string _filename = "";

        private string filename
        {
            get { return _filename; }
            set
            {
                _filename = value;
                Text = value;
            }
        }


        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void Перейти(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Заменить(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void НайтиДалее(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Найти(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Удалить(object sender, EventArgs e)
        {
            if (Текст.SelectedText.Equals("")) return;
            Текст.SelectedText = "";
        }

        protected void ОПрограмме(object sender, EventArgs e)
        {
            MessageBox.Show("Просто текстовый редактор, версия такая-то...", "О программе", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        protected void ПереносСлов(object sender, EventArgs e)
        {
            ПунктМенюПереносСлов.Checked = !ПунктМенюПереносСлов.Checked;
            Текст.WordWrap = ПунктМенюПереносСлов.Checked;
        }

        protected void ВыборЦвета(object sender, EventArgs e)
        {
            ДиалогВыбораЦвета.ShowDialog();
            Текст.SelectionColor = ДиалогВыбораЦвета.Color;
        }

        protected void ВыборШрифта(object sender, EventArgs e)
        {
            ДиалогВыборШрифта.ShowDialog();
            Текст.SelectionFont = ДиалогВыборШрифта.Font;
        }

        protected void ВставкаВремениИДаты(object sender, EventArgs e)
        {
            Текст.SelectedText = DateTime.Now.ToString();
        }

        protected void ВыделитьВсе(object sender, EventArgs e)
        {
            Текст.SelectAll();
        }

        protected void Вставить(object sender, EventArgs e)
        {
            DataObject Data = (DataObject)Clipboard.GetDataObject();
            Текст.SelectedText = (string)Data.GetData(DataFormats.Text);
        }

        protected void Копировать(object sender, EventArgs e)
        {
            if (Текст.SelectedText.Equals("")) return;
            Clipboard.SetDataObject(Текст.SelectedText, true);
        }

        protected void Вырезать(object sender, EventArgs e)
        {
            if (Текст.SelectedText.Equals("")) return;
            Clipboard.SetDataObject(Текст.SelectedText, true);
            Текст.SelectedText = "";
        }

        protected void Вернуть(object sender, EventArgs e)
        {
            Текст.Redo();
        }

        protected void Отменить(object sender, EventArgs e)
        {
            Текст.Undo();
        }

        protected void СохранитьФайл(object sender, EventArgs e)
        {
            if (filename.Equals(""))
            {
                ДиалогСохранить.ShowDialog();
                if (!ДиалогСохранить.FileName.Equals(""))
                {
                    filename = ДиалогСохранить.FileName;
                }
            }
            Текст.SaveFile(filename, RichTextBoxStreamType.PlainText);
            Text = filename;
        }

        protected void СохранитьКак(object sender, EventArgs e)
        {
            ДиалогСохранить.ShowDialog();
            if (!ДиалогСохранить.FileName.Equals(""))
            {
                filename = ДиалогСохранить.FileName;
                Текст.SaveFile(filename, RichTextBoxStreamType.PlainText);
                Text = filename;
            }
        }

        protected void СоздатьНовыйФайл(object sender, EventArgs e)
        {
            Текст.Clear();
        }

        protected void ОткрытьФайл(object sender, EventArgs e)
        {
            ДиалогОткрытьФайл.ShowDialog();
            filename = ДиалогОткрытьФайл.FileName;
            if (!filename.Equals(""))
            {
                Текст.LoadFile(filename, RichTextBoxStreamType.PlainText);
                Text = filename;
            }
        }

        protected void rs(object sender, EventArgs e)
        {
            Текст.Size = Size;
        }

        private void ВыходИзПрограммы(object sender, EventArgs e)
        {
            Close();
        }

        [STAThreadAttribute]
        public static void Main(string[] args)
        {
            Application.Run(new Form1());
        }
    }
}
