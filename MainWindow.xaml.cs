using System;
using System.Collections.Generic;
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
using System.Text.RegularExpressions;
using System.Collections;



namespace Gcollec
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmb_country.Items.Add("India");
            cmb_country.Items.Add("USA");
            cmb_country.Items.Add("Pakistan");
            cmb_country.Items.Add("China");
            cmb_country.Items.Add("Japan");
        }
        List<Student> stud;
        int count=0;

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if(txtbox_name.Text == "")
            {
                lbl_name.Visibility=Visibility.Visible;
            }
            else
            {
                lbl_name.Visibility=Visibility.Hidden;
            }
            string pattern = "^[0-9]+$";
                string age = txtbox_age.Text;
            bool matching = Regex.IsMatch(age, pattern);
            if(!matching )
            {
                lbl_age.Visibility=Visibility.Visible;
            }
            else
            {
                lbl_age.Visibility=Visibility.Hidden;
            }
            if(txtbox_name.Text != "" ) 
            {
                if(stud == null)
                {
                    stud = new List<Student>();
                }
                stud.Add(new Student { name= txtbox_name.Text,age=Convert.ToInt32( txtbox_age.Text),pass=txtbox_pass.Password,cpass=txtbox_cpass.Password,country=cmb_country.SelectedValue.ToString(),state=cmb_state.SelectedValue.ToString() });
                count++;
                MessageBox.Show("Student details saved successfully\nDetails Count:" + count);

                //Student student = new Student();
                //student.name= txtbox_name.Text;
                //student.age = txtbox_age.Text;
                //student.pass = txtbox_pass.Password;
                //student.cpass = txtbox_cpass.Password;
                //student.country = cmb_country.SelectedValue.ToString();
                //student.state = cmb_state.SelectedValue.ToString();
                //stud.Add(student);


            }
           

            //int count = 0;
            //Regex num = new Regex("[a-z]");
            //int age =Convert.ToInt32( txtbox_age.Text);
            //foreach (Match item in Regex.Matches(age.ToString(), num.ToString()));
            //{
            //    count++;
            //}
            //if(count == 0)
            //{
            //    lbl_age.Visibility=Visibility.Visible;
            //}
        }

        

        private void cmb_country_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmb_country.SelectedIndex == 0)
            {
                cmb_state.Items.Clear();
                cmb_state.Items.Add("Tamil Nadu");
                cmb_state.Items.Add("Delhi");
                cmb_state.Items.Add("Kerala");
            }
            if (cmb_country.SelectedIndex == 1)
            {
                cmb_state.Items.Clear();
                cmb_state.Items.Add("Georgia");
                cmb_state.Items.Add("California");
                cmb_state.Items.Add("San andreas");
            }
            if (cmb_country.SelectedIndex == 2)
            {
                cmb_state.Items.Clear();
                cmb_state.Items.Add("Sindh");
                cmb_state.Items.Add("Khyber");
                cmb_state.Items.Add("Balochistan");
            }
            if (cmb_country.SelectedIndex == 3)
            {
                cmb_state.Items.Clear();
                cmb_state.Items.Add("Henan");
                cmb_state.Items.Add("Hainan");
                cmb_state.Items.Add("Hebei");
            }
            if (cmb_country.SelectedIndex == 4)
            {
                cmb_state.Items.Clear();
                cmb_state.Items.Add("Hokkaido");
                cmb_state.Items.Add("Tohoku");
                cmb_state.Items.Add("Chubu");
            }
        }

        private void btn_retrieve_Click(object sender, RoutedEventArgs e)
        {
            if (stud == null)
            {
                MessageBox.Show("There are no data ");
            }
            else
            {
                for (int i = 0; i < stud.Count; i++)
                {
                    MessageBox.Show("Name : " + stud[i].name.ToString() + "\n" + "Age : " + stud[i].age.ToString() + "\n" + "Password : " + stud[i].pass.ToString() + "\n" + "Confirm Password : " + stud[i].cpass.ToString() + "\n" + "Country : " + stud[i].country.ToString() + "\n" + "State : " + stud[i].state.ToString());
                }
            }



                //string value = txtbox_name1.Text;
                //int index =0;
                //for (int i = 0; i < stud.Count; i++)
                //{
                //    index = stud[i].name.IndexOf(value);
                //}
                //if (index >= 0) // If the value is found in the list
                //{
                //    // Display all values from the index onwards
                //    for (int i = index; i < stud.Count; i++)
                //    {
                //        MessageBox.Show(stud[i].name.ToString()); // Replace with your own code to display the values
                //    }
                //}
                //for(int i=0;i<stud.Count;i++)
                //{
                //MessageBox.Show(stud[1].name.ToString()+"\n"+ stud[1].country.ToString());
                //}
                //foreach(var item in stud)
                //{
                //    MessageBox.Show(item.name.ToString());
                //}
        }




    }
}
