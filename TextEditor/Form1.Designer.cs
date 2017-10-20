using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

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

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components;

        private ColorDialog ДиалогВыбораЦвета;
        private FontDialog ДиалогВыборШрифта;
        private SaveFileDialog ДиалогСохранить;
        private OpenFileDialog ДиалогОткрытьФайл;
        private MainMenu ГлавноеМеню;
        private MenuItem ПунктМенюПереносСлов;
        private RichTextBox Текст;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ResourceManager resources = new ResourceManager(typeof(Form1));
            components = new Container();
            ДиалогВыборШрифта = new FontDialog();
            Текст = new RichTextBox();
            ДиалогОткрытьФайл = new OpenFileDialog();
            MenuItem ПунктМенюФормат = new MenuItem();
            MenuItem ПунктМенюПомощь = new MenuItem();
            ГлавноеМеню = new MainMenu();

            ДиалогВыбораЦвета = new ColorDialog();
            ДиалогСохранить = new SaveFileDialog();

            Текст.AutoWordSelection = true;
            Текст.Size = new Size(336, 312);
            Текст.TabIndex = 1;
            Текст.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            Текст.Font = new Font("Arial", 10, FontStyle.Bold);

            ДиалогОткрытьФайл.Filter = "Текстовый файл|*.txt";
            ДиалогОткрытьФайл.ReadOnlyChecked = true;
            ДиалогОткрытьФайл.DefaultExt = "txt";
            ДиалогОткрытьФайл.Multiselect = true;

            ПунктМенюПереносСлов = new MenuItem("Перенос по словам", new EventHandler(ПереносСлов));

            ПунктМенюПомощь = new MenuItem(
            "Помощь",
            new MenuItem[]
            {
new MenuItem("О программе", new EventHandler(ОПрограмме))
            }
            );

            ГлавноеМеню.MenuItems.AddRange(
            new MenuItem[]{
new MenuItem(
"&Файл",
new MenuItem[]
{
new MenuItem("Создать", new EventHandler(СоздатьНовыйФайл), Shortcut.CtrlN),
new MenuItem("Открыть...", new EventHandler(ОткрытьФайл), Shortcut.CtrlO),
new MenuItem("Сохранить", new EventHandler(СохранитьФайл), Shortcut.CtrlS),
new MenuItem("Сохранить как...", new EventHandler(СохранитьКак)),
new MenuItem("-"),
new MenuItem("Выход", new EventHandler(ВыходИзПрограммы) )
}
),
new MenuItem(
"&Правка",
new MenuItem[]
{
new MenuItem("Отменить", new EventHandler(Отменить), Shortcut.CtrlZ),
new MenuItem("Вернуть", new EventHandler(Вернуть)),
new MenuItem("-"),
new MenuItem("Вырезать", new EventHandler(Вырезать), Shortcut.CtrlX),
new MenuItem("&Копировать", new EventHandler(Копировать), Shortcut.CtrlC),
new MenuItem("Вставить", new EventHandler(Вставить), Shortcut.CtrlV),
new MenuItem("Удалить", new EventHandler(Удалить), Shortcut.Del),
new MenuItem("-"),
new MenuItem("Найти...", new EventHandler(Найти), Shortcut.CtrlF),
new MenuItem("Найти далее", new EventHandler(НайтиДалее), Shortcut.F3),
new MenuItem("Заменить...", new EventHandler(Заменить), Shortcut.CtrlH),
new MenuItem("Перейти...", new EventHandler(Перейти), Shortcut.CtrlG),
new MenuItem("-"),
new MenuItem("В&ыделить все", new EventHandler(ВыделитьВсе), Shortcut.CtrlA),
new MenuItem("Время и дата", new EventHandler(ВставкаВремениИДаты), Shortcut.F5)
}),
new MenuItem(
"Формат",
new MenuItem[]
{
ПунктМенюПереносСлов,
new MenuItem("Шрифт", new EventHandler(ВыборШрифта) ),
new MenuItem("Цвет", new EventHandler(ВыборЦвета) )
}),

ПунктМенюПомощь
            });

            ДиалогСохранить.Filter = "Текстовый файл|*.txt";
            ДиалогСохранить.InitialDirectory = System.IO.Directory.GetCurrentDirectory(); // System.IO.Path.GetDirectoryName("");
            ДиалогСохранить.DefaultExt = "txt";
            ДиалогСохранить.FileName = "Untitled";
            ДиалогСохранить.CheckFileExists = true;

            Text = "Мой редактор";
            AutoScaleBaseSize = new Size(5, 13);
            Menu = ГлавноеМеню;
            ClientSize = new Size(344, 317);
            Resize += new EventHandler(rs);
            Controls.Add(Текст);
        }

        #endregion
    }
}