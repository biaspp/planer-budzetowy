using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zaliczenie.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy WydatekView.xaml
    /// </summary>
    public partial class WydatekView : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-4NVG1IFF;Initial Catalog=dane;Integrated Security=True");
        
        public WydatekView()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Clear()
        {
            wydnazwaTb.Text = "";
            wydkwotaTb.Text = "";
            wydopisTb.Text = "";
            CatCb.SelectedIndex = 0;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (wydnazwaTb.Text == " " || wydkwotaTb.Text == " " || wydopisTb.Text == " " || CatCb.SelectedIndex == -1)
                    {
                MessageBox.Show("Brakuje danych");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into wydatki(wydnazwa, wydkwota, wydkategoria, wyddata, wydopis) values(@WN, @WK,@WKA, @WD, @WDE)", Con);
                    cmd.Parameters.AddWithValue("@WN", wydnazwaTb.Text);
                    cmd.Parameters.AddWithValue("@WK", wydkwotaTb.Text);
                    cmd.Parameters.AddWithValue("@WKA", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@WD", wyddata.Value.Date);
                    cmd.Parameters.AddWithValue("@WDE", wydopisTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano wydatek!");
                    Con.Close();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
    }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
