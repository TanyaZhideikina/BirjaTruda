
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Input;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;



namespace Labor
{
    /// <summary>
    /// Interaction logic for RegistrationPerson.xaml
    /// </summary>
    public partial class WorkSpace : Window
    {
        Labor.Birja_TrudaDataSet birja_TrudaDataSet = new Birja_TrudaDataSet();
        Labor.Birja_TrudaDataSetTableAdapters.AplicantsTableAdapter birja_TrudaDataSetAplicantsTableAdapter = new Birja_TrudaDataSetTableAdapters.AplicantsTableAdapter();

        public WorkSpace()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "background.jpg"));
            this.Background = myBrush;

            Labor.Birja_TrudaDataSet birja_TrudaDataSet = ((Labor.Birja_TrudaDataSet)(this.FindResource("birja_TrudaDataSet")));
            Labor.Birja_TrudaDataSetTableAdapters.AplicantsTableAdapter birja_TrudaDataSetAplicantsTableAdapter = new Labor.Birja_TrudaDataSetTableAdapters.AplicantsTableAdapter();
            birja_TrudaDataSetAplicantsTableAdapter.Fill(birja_TrudaDataSet.Aplicants);
            this.birja_TrudaDataSet = birja_TrudaDataSet;
            this.birja_TrudaDataSetAplicantsTableAdapter = birja_TrudaDataSetAplicantsTableAdapter;

        }

        private void EnterClientBaseWorkSpace(object sender, RoutedEventArgs e)
        {
            ClientBaseWorkSpace clientBaseWorkSpace = new ClientBaseWorkSpace();
            clientBaseWorkSpace.Show();
            clientBaseWorkSpace.Activate();
            //this.mainFrame.Navigate(clientBaseWorkSpace);
            //this.Content = clientBaseWorkSpace;

        }

        private void EnterVacanciesBaseWorkSpace(object sender, RoutedEventArgs e)
        {
           
            VacanciesBase clientBase = new VacanciesBase();
            //альтернативный вариант перехода
            //mainFrame.NavigationService.Navigate(new Uri("VacansyBase.xml", UriKind.Relative));
            //mainFrame.NavigationService.Navigate(new VacanciesBase());


            //mainFrame.Navigate(clientBase);
            //this.Content = clientBase;
            clientBase.Show();
            this.Close();
            clientBase.Activate();

        }
        private void ChangeShrift(object sender, RoutedEventArgs e)
        {

            //FontDialog fontDialog = new FontDialog();
            //if (fontDialog.ShowDialog() == DialogResult.OK)
            //{
            //    FontFamilyConverter ffc = new FontFamilyConverter();

            //    this.EnterClientBase.FontSize = fontDialog.Font.Size;
            //    this.EnterClientBase.FontFamily = (System.Windows.Media.FontFamily)ffc.ConvertFromString(fontDialog.Font.Name);

            //    if (fontDialog.Font.Bold)
            //        this.EnterClientBase.FontWeight = FontWeights.Bold;
            //    else
            //        this.EnterClientBase.FontWeight = FontWeights.Normal;

            //    if (fontDialog.Font.Italic)
            //        this.EnterClientBase.FontStyle = FontStyles.Italic;
            //    else
            //        this.EnterClientBase.FontStyle = FontStyles.Normal;
            //    //
            //}
        }

        private void ChangeBackgroundColor(object sender, RoutedEventArgs e)
        {
            //ColorDialog colorDialog = new ColorDialog();
            //if (colorDialog.ShowDialog() == DialogResult.OK)
            //{
            //    System.Drawing.Color color1 = colorDialog.Color;
            //    System.Windows.Media.Color color = new System.Windows.Media.Color();
            //    color.A = color1.A;
            //    color.R = color1.R;
            //    color.G = color1.G;
            //    color.B = color1.B;
            //    this.Background = new SolidColorBrush(color);
            // }
        }

        private void ChangeShriftColor(object sender, RoutedEventArgs e)
        {
            //ColorDialog colorDialog = new ColorDialog();
            //if (colorDialog.ShowDialog() == DialogResult.OK)
            //{
            //    System.Drawing.Color color1 = colorDialog.Color;
            //    System.Windows.Media.Color color = new System.Windows.Media.Color();
            //    color.A = color1.A;
            //    color.R = color1.R;
            //    color.G = color1.G;
            //    color.B = color1.B;
            //    //this.EnterClientBase.FontStyle. = new SolidColorBrush(color);
            //}
        }

        private void ChangeElementsColor(object sender, RoutedEventArgs e)
        {
            //ColorDialog colorDialog = new ColorDialog();
            //if (colorDialog.ShowDialog() == DialogResult.OK)
            //{
            //    System.Drawing.Color color1 = colorDialog.Color;
            //    System.Windows.Media.Color color = new System.Windows.Media.Color();
            //    color.A = color1.A;
            //    color.R = color1.R;
            //    color.G = color1.G;
            //    color.B = color1.B;
            //    //this.Background = new SolidColorBrush(color);
            //}
        }
        
        private void mainFrame_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
        //    if (e.Key == Key.CapsLock)
        //    {
        //        if (CapsLockLabel.Visibility == Visibility.Hidden)
        //        {
        //            CapsLockLabel.Visibility = Visibility.Visible;
        //        }
        //        else
        //        {
        //            CapsLockLabel.Visibility = Visibility.Hidden;
        //        }
        //    }

        //    if (e.Key == Key.NumLock)
        //    {
        //        if (NumLockLabel.Visibility == Visibility.Hidden)
        //        {
        //            NumLockLabel.Visibility = Visibility.Visible;
        //        }
        //        else
        //        {
        //            NumLockLabel.Visibility = Visibility.Hidden;
        //        }
        //    }
        //}

        //private void Page_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        //{
        //    if (e.Key == Key.CapsLock)
        //    {
        //        if (CapsLockLabel.Visibility == Visibility.Hidden)
        //        {
        //            CapsLockLabel.Visibility = Visibility.Visible;
        //        }
        //        else
        //        {
        //            CapsLockLabel.Visibility = Visibility.Hidden;
        //        }
        //    }

        //    if (e.Key == Key.NumLock)
        //    {
        //        if (NumLockLabel.Visibility == Visibility.Hidden)
        //        {
        //            NumLockLabel.Visibility = Visibility.Visible;
        //        }
        //        else
        //        {
        //            NumLockLabel.Visibility = Visibility.Hidden;
        //        }
        //    }
        }

        private void AboutUs_click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Key_Down(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (e.Key == Key.CapsLock)
            {
                if (e.IsToggled)
                {
                    CapsLock.Text = "CapsLock pressed";
                }
                else
                {
                    CapsLock.Text = "CapsLock is not pressed";
                }
            }
        }

        private void Open_Word(object sender, RoutedEventArgs e)
        {
           
            Word.Application WordApplication = new Word.Application();
           // object fileName = @"C:\Users\nata\Downloads\Labor(2)\Labor\Labor\bin\Debug\Reports\Persons.dotx";
            Word.Document WordDocument = WordApplication.Documents.Open(@"C:\Users\nata\Downloads\LaborMain\Labor\Labor\bin\Debug\Reports\Persons.dotx");
            for (int i = 0; i < birja_TrudaDataSet.Aplicants.Count; i++)
            {
                WordDocument.Bookmarks["person_name"].Range.Text = " " + birja_TrudaDataSet.Aplicants[i][1].ToString() + " "; //count//.birja_TrudaDataSet.Aplicants.
                WordDocument.Bookmarks["person_name"].Range.Text += " " + birja_TrudaDataSet.Aplicants[i][2].ToString() + "\n ";
            }
                WordDocument.Bookmarks["person_count"].Range.Text += " " + birja_TrudaDataSet.Aplicants.Count +" ";

            WordDocument.Fields.Update();
            WordApplication.Visible = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Labor.Birja_TrudaDataSet birja_TrudaDataSet = ((Labor.Birja_TrudaDataSet)(this.FindResource("birja_TrudaDataSet")));
            // Загрузить данные в таблицу Aplicants. Можно изменить этот код как требуется.
            Labor.Birja_TrudaDataSetTableAdapters.AplicantsTableAdapter birja_TrudaDataSetAplicantsTableAdapter = new Labor.Birja_TrudaDataSetTableAdapters.AplicantsTableAdapter();
            birja_TrudaDataSetAplicantsTableAdapter.Fill(birja_TrudaDataSet.Aplicants);
            System.Windows.Data.CollectionViewSource aplicantsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("aplicantsViewSource")));
            aplicantsViewSource.View.MoveCurrentToFirst();
        }

        private void Open_Excel(object sender, RoutedEventArgs e)
        {  
            Excel.Application ExcelApplication = new Excel.Application();
            Excel.Workbook newWorkbook = ExcelApplication.Workbooks.Add();
            Excel.Worksheet currentSheet = (Excel.Worksheet)ExcelApplication.Workbooks[1].Worksheets[1];
            Labor.Birja_TrudaDataSet birja_TrudaDataSet = ((Labor.Birja_TrudaDataSet)(this.FindResource("birja_TrudaDataSet")));
            Labor.Birja_TrudaDataSetTableAdapters.AplicantsTableAdapter birja_TrudaDataSetAplicantsTableAdapter = new Labor.Birja_TrudaDataSetTableAdapters.AplicantsTableAdapter();
            birja_TrudaDataSetAplicantsTableAdapter.Fill(birja_TrudaDataSet.Aplicants);

            for (int i = 0; i < birja_TrudaDataSet.Aplicants.Count; i++)
            {
                //for (int j = 1; j < 6; i++)
                {
                    currentSheet.Cells[i + 1, 1] = birja_TrudaDataSet.Aplicants[i][2].ToString(); //count//.birja_TrudaDataSet.Aplicants.
                                                                                                  // currentSheet.Cells[i + 1, 2] = birja_TrudaDataSet.Aplicants[i][2].ToString(); }

                }
            }

            ExcelApplication.Visible = true;
        }
    }
}