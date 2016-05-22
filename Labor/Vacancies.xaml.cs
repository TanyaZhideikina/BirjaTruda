using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Common;

namespace Labor
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Vacancies : Window
    {
        Labor.Birja_TrudaDataSet birja_TrudaDataSet = new Birja_TrudaDataSet();
        System.Windows.Data.CollectionViewSource vacansiesViewSource = new System.Windows.Data.CollectionViewSource();
        Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter birja_TrudaDataSetVacansiesTableAdapter = new Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter();
        int pageSize = 5; // размер страницы
        int pageNumber = 0; // текущая страница

        public Vacancies()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Labor.Birja_TrudaDataSet birja_TrudaDataSet = ((Labor.Birja_TrudaDataSet)(this.FindResource("birja_TrudaDataSet")));

            // Загрузить данные в таблицу Vacansies. Можно изменить этот код как требуется.
            // DataTable positionVacansies = new DataTable();
            // positionVacansies.Columns.Add(birja_TrudaDataSet.Vacansies.PositionColumn);
            // birja_TrudaDataSet.Tables.Add(positionVacansies);
            // this.birja_TrudaDataSetVacansiesTableAdapter = new DataAdapter(Birja_TrudaConnectionString).Fill((DataSet)birja_TrudaDataSet);//Columns["Position"]
            //new Birja_TrudaDataSetTableAdapters().Fill(birja_TrudaDataSet);
            //DataColumn headerVacancies = new DataColumn("vacanciesPosition", Type.GetType("System.String"));
            //headerVacancies = birja_TrudaDataSet.Vacansies.Columns;

            //System.Windows.Data.CollectionViewSource vacansiesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vacansiesViewSource")));

            birja_TrudaDataSetVacansiesTableAdapter.Fill(birja_TrudaDataSet.Vacansies);

            System.Windows.Data.CollectionViewSource vacansiesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vacansiesViewSource")));

            //for (int i = 0; i < 5; i++)
            //{
            //    dataGrid.Columns.Add(birja_TrudaDataSet.Vacansie);
            //    //System.Windows.Data.CollectionViewSource vacansiesViewSource.I
            //}

            //var t = new DataTable();

            // create column header
            //foreach (string s in identifiders)
            //{
            //    t.Columns.Add(new DataColumn(s)); // <<=== i'm expecting you don't have defined any DataColumns, haven't you?
            //}

            //// Add data to DataTable
            //for (int lineNumber = identifierLineNumber; lineNumber < lineCount; lineNumber++)
            //{
            //    DataRow newRow = t.NewRow();
            //    for (int column = 0; column < identifierCount; column++)
            //    {
            //        newRow[column] = fileContent.ElementAt(lineNumber)[column];
            //    }
            //    t.Rows.Add(newRow);
            //}

            //return t.DefaultView;


            //foreach (DataRow row in birja_TrudaDataSet.Vacansies)
            //{
            //    var cells = row.ItemArray;
            //    foreach(object cell in cells)
            //    {
            //        dataGrid.Items.Add(cell.ToString());
            //    }
            //}
            // System.Windows.Data.CollectionViewSource vacansiesViewSource =

            // ((System.Windows.Data.CollectionViewSource)(this.FindResource("vacansiesViewSource")));


            vacansiesViewSource.View.MoveCurrentToFirst();

            this.birja_TrudaDataSet = birja_TrudaDataSet;

        }
    }
}
