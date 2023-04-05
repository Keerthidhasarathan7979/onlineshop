﻿using onlineshopping;
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

namespace onlineshopping
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<shop> online;
        public MainWindow()
        {

            InitializeComponent();

            txtp.Text = 0.ToString();
            txtt.Text = 0.ToString();
            online = new List<shop>()
            {
              new shop{id="K1001",name="yellow with blue yoik kurtie",brand="Aveesa",price=860,size="L",cod="yes"},
              new shop{id="K1002",name="A line kurtie",brand="Aveesa",price=470,size=",M",cod="yes"},
              new shop{id="K1003",name="Anarkali kurtie",brand="Aveesa",price=620,size=",XLL",cod="yes"},
              new shop{id="K1004",name="Trail Cut kurtie",brand="Aveesa",price=820,size=",S",cod="yes"},
              new shop{id="K1005",name="Frock Kurtie",brand="Aveesa",price=900,size="XL",cod="yes"},

                 new shop{id="SS1801",name="Green With White salwar",brand="Aveesa",price=810,size="XL",cod="no"},
                new shop{id="SS1072",name="MultiColor With Gray Yolk salwar",brand="Kayra",price=630,size="L",cod="Yes"},
                new shop{id="SS1014",name="White with red salwar",brand="BIBA",price=800,size="M",cod="no"},
                new shop{id="SS1008",name="Mango printed yellow salwar",brand="Max",price=760,size="S",cod="Yes"},
                new shop{id="SS1701",name="White salwar with green bottom",brand="Aveesa",price=890,size="XL",cod="no"},
                new shop{id="SS1022",name="yellow semisilk salwar",brand="Kayra",price=1130,size="L",cod="Yes"},
                new shop{id="SS1174",name="Pure cotton pink salwar",brand="BIBA",price=900,size="M",cod="no"},
                new shop{id="SS1968",name="blue thread work salwar",brand="Max",price=1060,size="S",cod="Yes"},

                new shop{id="SA1321",name="Gray Checked Softsilk saree",brand="Aveesa",price=1980,size="XL",cod="no"},
                new shop{id="SA1074",name="MultiColor Banaras saree",brand="Kayra",price=2750,size="XL",cod="Yes"},
                new shop{id="SA1320",name="Green Kanchipuram silk saree",brand="BIBA",price=3860,size="XL",cod="no"},
                new shop{id="SA1118",name="Peach Color semi silk saree",brand="Max",price=1860,size="XL",cod="Yes"},
                new shop{id="SA1021",name="peacock printed blue Softsilk saree",brand="Aveesa",price=1180,size="XL",cod="no"},
                new shop{id="SA1049",name="green with red and blue Banaras saree",brand="Kayra",price=1750,size="XL",cod="Yes"},
                new shop{id="SA1120",name="red with golden Kanchipuram silk saree",brand="BIBA",price=2860,size="XL",cod="no"},
                new shop{id="SA1008",name="Pink Color semi silk saree",brand="Max",price=1860,size="XL",cod="Yes"},

                new shop{id="GW8071",name="Purple goergette gown",brand="Aveesa",price=990,size="S",cod="no"},
                new shop{id="GW1702",name="Pink floor length gown",brand="Kayra",price=860,size="L",cod="Yes"},
                new shop{id="GW8564",name="Green floral rayon gown",brand="BIBA",price=1100,size="M",cod="no"},
                new shop{id="GW1080",name="Velvet red full Stitched gown",brand="Max",price=1960,size="XL",cod="Yes"},
                new shop{id="GW3071",name="Pink goergette gown",brand="Aveesa",price=1090,size="S",cod="no"},
                new shop{id="GW7702",name="blue temple print gown",brand="Kayra",price=760,size="L",cod="Yes"},
                new shop{id="GW2564",name="red floral rayon gown",brand="BIBA",price=1180,size="M",cod="no"},
                new shop{id="GW1180",name="black velvet semi Stitched gown",brand="Max",price=2960,size="XL",cod="Yes"},

            };

            lstview.ItemsSource = online;

        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            if (rb1.IsChecked == true)
            {
                if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                {
                    string value = txts.Text;
                    int start = Convert.ToInt32(txtp.Text);
                    int end = Convert.ToInt32(txtt.Text);
                    var brand1 = from br1 in online
                                 where br1.name.Contains("kurti") && br1.price >= start && br1.price <= end && br1.name.Contains(value)
                                 select br1;
                    lstview.ItemsSource = null;
                    lstview.ItemsSource = brand1;

                }
                else
                {
                    var brand11 = from br1 in online
                                  where br1.name.Contains("kurti")
                                  select br1;
                    lstview.ItemsSource = null;
                    lstview.ItemsSource = brand11;
                }

                if (rb2.IsChecked == true)
                {
                    if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                    {
                        string value = txts.Text;
                        int start = Convert.ToInt32(txtp.Text);
                        int end = Convert.ToInt32(txtt.Text);
                        var brand1 = from br1 in online
                                     where br1.name.Contains("salwar") && br1.price >= start && br1.price <= end && br1.name.Contains(value)
                                     select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = brand1;

                    }
                    else
                    {
                        var brand11 = from br1 in online
                                      where br1.name.Contains("salwar")
                                      select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = brand11;
                    }
                    if (rb3.IsChecked == true)
                    {
                        if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                        {
                            string value = txts.Text;
                            int start = Convert.ToInt32(txtp.Text);
                            int end = Convert.ToInt32(txtt.Text);
                            var brand1 = from br1 in online
                                         where br1.name.Contains("saree") && br1.price >= start && br1.price <= end && br1.name.Contains(value)
                                         select br1;
                            lstview.ItemsSource = null;
                            lstview.ItemsSource = brand1;

                        }
                        else
                        {
                            var brand11 = from br1 in online
                                          where br1.name.Contains("saree")
                                          select br1;
                            lstview.ItemsSource = null;
                            lstview.ItemsSource = brand11;
                        }
                        if (rb4.IsChecked == true)
                        {
                            if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                            {
                                string value = txts.Text;
                                int start = Convert.ToInt32(txtp.Text);
                                int end = Convert.ToInt32(txtt.Text);
                                var brand1 = from br1 in online
                                             where br1.name.Contains("gown") && br1.price >= start && br1.price <= end && br1.name.Contains(value)
                                             select br1;
                                lstview.ItemsSource = null;
                                lstview.ItemsSource = brand1;

                            }
                            else
                            {
                                var brand11 = from br1 in online
                                              where br1.name.Contains("gown")
                                              select br1;
                                lstview.ItemsSource = null;
                                lstview.ItemsSource = brand11;
                            }

                        }

                    }

                }

                private void rbb1_Checked(object sender, RoutedEventArgs e)
                {



                    if (rbb1.IsChecked == true)
                    {
                        if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                        {
                            string value = txts.Text;
                            int start = Convert.ToInt32(txtp.Text);
                            int end = Convert.ToInt32(txtt.Text);
                            var brand1 = from br1 in online
                                         where br1.brand == "Aveesa" && br1.price >= start && br1.price <= end && br1.name.Contains(value)
                                         select br1;
                            lstview.ItemsSource = null;
                            lstview.ItemsSource = brand1;

                        }
                        else
                        {
                            var brand11 = from br1 in online
                                          where br1.brand == "Aveesa"
                                          select br1;
                            lstview.ItemsSource = null;
                            lstview.ItemsSource = brand11;
                        }

                        if (rbb2.IsChecked == true)
                        {
                            if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                            {
                                string value = txts.Text;
                                int start = Convert.ToInt32(txtp.Text);
                                int end = Convert.ToInt32(txtt.Text);
                                var brand2 = from br2 in online
                                             where br2.brand == "BIBA" && br2.price >= start && br2.price <= end && br2.name.Contains(value)
                                             select br2;
                                lstview.ItemsSource = null;
                                lstview.ItemsSource = brand2;

                            }
                            else
                            {
                                var brand12 = from br2 in online
                                              where br2.brand == "BIBA"
                                              select br2;
                                lstview.ItemsSource = null;
                                lstview.ItemsSource = brand12;
                            }

                        }

                        if (rbb3.IsChecked == true)
                        {
                            if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                            {
                                string value = txts.Text;
                                int start = Convert.ToInt32(txtp.Text);
                                int end = Convert.ToInt32(txtt.Text);
                                var brand3 = from br3 in online
                                             where br3.brand == "Max" && br3.price >= start && br3.price <= end && br3.name.Contains(value)
                                             select br3;
                                lstview.ItemsSource = null;
                                lstview.ItemsSource = brand3;

                            }
                            else
                            {
                                var brand13 = from br3 in online
                                              where br3.brand == "Max"
                                              select br3;
                                lstview.ItemsSource = null;
                                lstview.ItemsSource = brand13;
                            }
                            if (rbb4.IsChecked == true)
                            {
                                if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                                {
                                    string value = txts.Text;
                                    int start = Convert.ToInt32(txtp.Text);
                                    int end = Convert.ToInt32(txtt.Text);
                                    var brand4 = from br4 in online
                                                 where br4.brand == "Kayra" && br4.price >= start && br4.price <= end && br4.name.Contains(value)
                                                 select br4;
                                    lstview.ItemsSource = null;
                                    lstview.ItemsSource = brand4;

                                }
                                else
                                {
                                    var brand14 = from br4 in online
                                                  where br4.brand == "Kayra"
                                                  select br4;
                                    lstview.ItemsSource = null;
                                    lstview.ItemsSource = brand14;
                                }

                            }

                        }
                    }
                }
            }



            private void rbs1_Checked(object sender, RoutedEventArgs e)
            {

                if (rbs1.IsChecked == true)
                {
                    if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                    {
                        string value = txts.Text;
                        int start = Convert.ToInt32(txtp.Text);
                        int end = Convert.ToInt32(txtt.Text);
                        var size1 = from br1 in online
                                    where br1.size == "S" && br1.price >= start && br1.price <= end && br1.name.Contains(value)
                                    select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = size1;

                    }

                    else
                    {
                        var size11 = from br1 in online
                                     where br1.size == "S"
                                     select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = size11;
                    }

                }


                if (rbs2.IsChecked == true)
                {
                    if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                    {
                        string value = txts.Text;
                        int start = Convert.ToInt32(txtp.Text);
                        int end = Convert.ToInt32(txtt.Text);
                        var size2 = from br1 in online
                                    where br1.size == "M" && br1.price >= start && br1.price <= end && br1.name.Contains(value)
                                    select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = size2;

                    }
                    else
                    {
                        var size12 = from br1 in online
                                     where br1.size == "M"
                                     select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = size12;
                    }

                }


                if (rbs3.IsChecked == true)
                {
                    if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                    {
                        string value = txts.Text;
                        int start = Convert.ToInt32(txtp.Text);
                        int end = Convert.ToInt32(txtt.Text);
                        var size3 = from br1 in online
                                    where br1.size == "L" && br1.price >= start && br1.price <= end && br1.name.Contains(value)
                                    select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = size3;

                    }
                    else
                    {
                        var size13 = from br1 in online
                                     where br1.size == "L"
                                     select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = size13;
                    }

                }


                if (rbs4.IsChecked == true)
                {
                    if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                    {
                        string value = txts.Text;
                        int start = Convert.ToInt32(txtp.Text);
                        int end = Convert.ToInt32(txtt.Text);
                        var size4 = from br1 in online
                                    where br1.size == "XL" && br1.price >= start && br1.price <= end && br1.name.Contains(value)
                                    select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = size4;

                    }
                    else
                    {
                        var size14 = from br1 in online
                                     where br1.size == "XL"
                                     select br1;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = size14;
                    }

                }


            }

            private void rbp1_Checked(object sender, RoutedEventArgs e)
            {
                if (rbp1.IsChecked == true)
                {
                    if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                    {
                        string value = txts.Text;
                        int start = Convert.ToInt32(txtp.Text);
                        int end = Convert.ToInt32(txtt.Text);
                        var low = from lower in online
                                  where lower.price >= start && lower.price <= end && lower.name.Contains(value)
                                  orderby lower.price ascending
                                  select lower;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = low;
                    }
                    else
                    {
                        string value = txts.Text;
                        var low = from lower in online
                                  where lower.name.Contains(value)
                                  orderby lower.price ascending
                                  select lower;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = low;
                    }
                }
            }

            private void rbp2_Checked(object sender, RoutedEventArgs e)
            {
                if (rbp2.IsChecked == true)
                {
                    if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                    {
                        string value = txts.Text;
                        int start = Convert.ToInt32(txtp.Text);
                        int end = Convert.ToInt32(txtt.Text);
                        var low = from lower in online
                                  where lower.price >= start && lower.price <= end && lower.name.Contains(value)
                                  orderby lower.price descending
                                  select lower;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = low;
                    }
                    else
                    {
                        string value = txts.Text;
                        var low = from lower in online
                                  where lower.name.Contains(value)
                                  orderby lower.price descending
                                  select lower;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = low;
                    }
                }
            }

        

           
            private void chck_Checked(object sender, RoutedEventArgs e)
            {

             if (chck.IsChecked == true)
                {
                    if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                    {
                        string value = txts.Text;
                        int start = Convert.ToInt32(txtp.Text);
                        int end = Convert.ToInt32(txtt.Text);
                        var check1 = from delivery in online
                                     where delivery.cod == "Yes" && delivery.price >= start && delivery.price <= end && delivery.name.Contains(value)
                                     select delivery;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = check1;

                    }
                    else
                    {
                        var check = from delivery in online
                                    where delivery.cod == "Yes"
                                    select delivery;
                        lstview.ItemsSource = null;
                        lstview.ItemsSource = check;
                    }

                }
                else if (chck.IsChecked == false)
                {
                    lstview.ItemsSource = null;
                    lstview.ItemsSource = online;
                }
            

        }
    }



    private void Button_Click(object sender, RoutedEventArgs e)
        {

            {
                if (txtp.Text != 0.ToString() && txtt.Text != 0.ToString())
                {
                    string value = txts.Text;
                    int start = Convert.ToInt32(txtp.Text);
                    int end = Convert.ToInt32(txtt.Text);
                    var cost = from price in online
                               where price.price >= start && price.price <= end && price.name.Contains(value)
                               orderby price.price ascending
                               select price;
                    lstview.ItemsSource = null;
                    lstview.ItemsSource = cost;
                }
                else
                {
                    string value = txts.Text;
                    var cost = from price in online
                               where price.name.Contains(value)
                               orderby price.price ascending
                               select price;
                    lstview.ItemsSource = null;
                    lstview.ItemsSource = cost;
                }
            }
        }
    }

}


    


    






