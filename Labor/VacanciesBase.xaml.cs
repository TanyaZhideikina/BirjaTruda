using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Labor
{
    /// <summary>
    /// Interaction logic for VacanciesBase.xaml
    /// </summary>
    public partial class VacanciesBase : Window
    {
        Labor.Birja_TrudaDataSet birja_TrudaDataSet = new Birja_TrudaDataSet();
        System.Windows.Data.CollectionViewSource vacansiesViewSource = new System.Windows.Data.CollectionViewSource();
        Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter birja_TrudaDataSetVacansiesTableAdapter = new Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter();

       // Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter birja_TrudaDataSetVacansiesTableAdapter = new Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter();

        public VacanciesBase()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "background.jpg"));
            this.Background = myBrush;
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //DataSet dataSet = new DataSet();
            string connectionString = @"Data Source=ROTE\SQLEXPRESS;Initial Catalog=Birja_Truda;Integrated Security=True";
            //string sqlExpression = "SELECT Position,Photo,Salary,InformationAboutWork,DateOfCreating FROM Vacansies";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sqlExpression, connection);
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //    dataAdapter.Fill(dataSet);
            //dataGrid.Items = dataSet.It
            //System.Windows.Data.CollectionViewSource vacansiesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vacansiesViewSource")));
            //vacansiesViewSource.View.MoveCurrentToFirst();
            //Labor.Birja_TrudaDataSetTableAdapters.VacansiesTableAdapter birja_TrudaDataSetVacansiesTableAdapter = new SqlDataAdapter(command);
            //birja_TrudaDataSetVacansiesTableAdapter.Fill(birja_TrudaDataSet.Vacansies);
            //System.Windows.Data.CollectionViewSource vacansiesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vacansiesViewSource")));
            //vacansiesViewSource.View.MoveCurrentToFirst();
            Labor.Birja_TrudaDataSet birja_TrudaDataSet = ((Labor.Birja_TrudaDataSet)(this.FindResource("birja_TrudaDataSet")));
            this.birja_TrudaDataSet = birja_TrudaDataSet;
            // Загрузить данные в таблицу Vacansies. Можно изменить этот код как требуется.
            birja_TrudaDataSetVacansiesTableAdapter.Fill(birja_TrudaDataSet.Vacansies);
            System.Windows.Data.CollectionViewSource vacansiesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vacansiesViewSource")));
            this.vacansiesViewSource = vacansiesViewSource;
            vacansiesViewSource.View.MoveCurrentToFirst();
            //new SqlConnection(connectionString).Open();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            birja_TrudaDataSetVacansiesTableAdapter.Update(birja_TrudaDataSet.Vacansies);


            //birja_TrudaDataSetVacansiesTableAdapter.

            //string connectionString = @"Data Source=ROTE\SQLEXPRESS;Initial Catalog=Birja_Truda;Integrated Security=True";
            //string sqlExpression = "INSERT INTO Vacancies(VacansyID, CompanyID, Position,Photo,Salary, InformationAboutWork, DateOfCreating, Reguirements,Telophone, Email, Adress) VALUES (@VacansyID, @CompanyID, @Position,@Photo,@Salary, @InformationAboutWork, @DateOfCreating, @Reguirements,@Telophone, @Email, @Adress)";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.CommandText = sqlExpression;
            //    command.Parameters.AddWithValue("@VacansyID", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.Parameters.AddWithValue("@CompanyID", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.Parameters.AddWithValue("@Position", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.Parameters.AddWithValue("@Salary", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.Parameters.AddWithValue("@VacansyID", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.Parameters.AddWithValue("@VacansyID", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.Parameters.AddWithValue("@VacansyID", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.Parameters.AddWithValue("@VacansyID", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.Parameters.AddWithValue("@VacansyID", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.Parameters.AddWithValue("@VacansyID", dataGrid.Columns[dataGrid.Items.Count]);
            //    command.ExecuteNonQuery();

            //}
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (vacansiesViewSource.View.CurrentPosition < ((CollectionView)vacansiesViewSource.View).Count - 1)
            {
                vacansiesViewSource.View.MoveCurrentToNext();
            }
            //birja_TrudaDataSetVacansiesTableAdapter.Save(birja_TrudaDataSet.Vacansies);

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            birja_TrudaDataSetVacansiesTableAdapter.Fill(birja_TrudaDataSet.Vacansies);
            System.Windows.Data.CollectionViewSource vacansiesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vacansiesViewSource")));
            this.vacansiesViewSource = vacansiesViewSource;
            vacansiesViewSource.View.MoveCurrentToFirst();

        }
    }
}
