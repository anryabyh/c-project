using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ClosedXML.Excel;

namespace _3_1
{
    /// <summary>
    /// Логика взаимодействия для ЗаписьНаСобытиесФондом.xaml
    /// </summary>
    public partial class ЗаписьНаСобытиесФондом : Window
    {
        council_of_womenEntities db;
        public ЗаписьНаСобытиесФондом()
        {
            InitializeComponent();
        }
        private void Window_loaded_dgentryandfund(object sender, RoutedEventArgs e)
        {
            db = new council_of_womenEntities();
            var query = db.entry1.Join(db.event12,
           s => s.numb_entry,
           n => n.numb_event,
           (s, n) => new { loginn = s.loginn, numb_entry=s.numb_entry,date = n.date_event, name_event = n.name_event });
            dgentryandevent.ItemsSource = query.ToList();


        }

        private void Datebutton_Click(object sender, RoutedEventArgs e)
        {
            var start = DP_Start.SelectedDate.Value;
            var end = DP_End.SelectedDate.Value;
            if (start != null && end != null)
            {
                dgentryandevent.ItemsSource = null;
                dgentryandevent.ItemsSource = db.event12
                    .Where(d => d.date_event >= start && d.date_event <= end)
                    .Join(db.entry1,
                    n => n.numb_event,
                    s => s.numb_entry,
                     (s, n) => new { loginn = n.loginn, numb_entry = n.numb_entry, date = s.date_event, name_event = s.name_event })
                    .ToList();
                Repot(start, end);
            }
            else
                MessageBox.Show("Не выбрана дата");
        }
        private void Repot(DateTime start,DateTime end) 
        {
            var path = Environment.CurrentDirectory;
            var workbook = new XLWorkbook();
            workbook.AddWorksheet();
            var worksheet = workbook.Worksheet(1);
            string data = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
            worksheet.Cell("A1").Value = "Отчет с"+ " " + start.ToString("dd MMMM yyyy") + " " + "по" + " "  + end.ToString("dd MMMM yyyy");
            worksheet.Cell("A3").Value = "Дата:" + " " + data;
            worksheet.Cell("A5").Value = "Логин";
            worksheet.Cell("B5").Value = "Номер записи";
            worksheet.Cell("C5").Value = "Дата";
            worksheet.Cell("D5").Value = "Название события";
            var list = db.event12
                    .Where(d => d.date_event >= start && d.date_event <= end)
                    .Join(db.entry1,
                    n => n.numb_event,
                    s => s.numb_entry,
                     (s, n) => new { loginn = n.loginn, numb_entry = n.numb_entry, date = s.date_event, name_event = s.name_event })
                    .ToList();
            int row = 6;
            foreach (var item in list) 
            {
                worksheet.Cell($"A{row}").Value = item.loginn;
                worksheet.Cell($"B{row}").Value = item.numb_entry;
                worksheet.Cell($"C{row}").Value = item.date;
                worksheet.Cell($"D{row}").Value = item.name_event;
                row++;
            }
            worksheet.Columns().AdjustToContents();
            var filepath = $@"{path}\Отчет.xlsx";
            workbook.SaveAs(filepath);
            System.Diagnostics.Process.Start(filepath);
        }

        private void dgentryandevent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
