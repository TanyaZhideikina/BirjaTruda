using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Labor
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        Labor.Birja_TrudaDataSet birja_TrudaDataSet = new Birja_TrudaDataSet();
        Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter birja_TrudaDataSetVacansiesTableAdapter = new Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter();

        int pageSize = 5; // размер страницы
        int pageNumber = 0; // текущая страница
        string connectionString = @"Data Source=Rote\SQLEXPRESS;Initial Catalog=Birja_Truda;Integrated Security=True";


        SqlDataAdapter adapter;
        DataSet ds;
        SqlConnection connection;
       

        public Window2()
        {
            InitializeComponent();

            dataGrid.SelectionMode = DataGridSelectionMode.Extended;
            dataGrid.IsReadOnly = true;

            using (connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);

                ds = new DataSet();
                adapter.Fill(ds, "Vacansies");
                dataGrid.ItemsSource = ds.Tables[0].AsDataView();
               
            } }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //Labor.Birja_TrudaDataSet birja_TrudaDataSet = ((Labor.Birja_TrudaDataSet)(this.FindResource("birja_TrudaDataSet")));
            //// Load data into the table Vacansies. You can modify this code as needed.
            //Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter birja_TrudaDataSetVacansiesTableAdapter = new Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter();
            //birja_TrudaDataSetVacansiesTableAdapter.Fill(birja_TrudaDataSet.Vacansies);
            //System.Windows.Data.CollectionViewSource vacansiesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vacansiesViewSource")));
            //vacansiesViewSource.View.MoveCurrentToFirst();

            //this.birja_TrudaDataSet = birja_TrudaDataSet;
            //this.birja_TrudaDataSetVacansiesTableAdapter = birja_TrudaDataSetVacansiesTableAdapter;
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (ds.Tables["Vacansies"].Rows.Count < pageSize) return;

            pageNumber++;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);

                ds.Tables["Vacansies"].Rows.Clear();

                adapter.Fill(ds, "Vacansies");
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (pageNumber == 0) return;
            pageNumber--;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);

                ds.Tables["Vacansies"].Rows.Clear();

                adapter.Fill(ds, "Vacansies");
            }
        }
        private string GetSql()
        {
            return "SELECT * FROM Vacansies ORDER BY VacansyID OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
            //(CompanyID,Position,Salary,InformationAboutWork,DateOfCreating,Requirements,Telephone,Email,Adress)
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // new Window3(ds.Tables["Vacansies"].Rows.IndexOf((DataRow)dataGrid.SelectedItem)).ShowDialog();
            //new
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connection.Close();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
