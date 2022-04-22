using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace 随机抽取学号
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            timer1.Interval = TimeSpan.FromMilliseconds(10);
            timer1.Tick += timer_Tick;

        }
        DispatcherTimer timer1 = new DispatcherTimer();
        System.Random t = new System.Random();//初始化随机数函数
        string num1;//定义一个字符串变量，用于显示
        void timer_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "仅抽取学号")
            {
                this.num1 = Convert.ToString(t.Next(1, 49));//产生1到48之间的一个随机数
                Text.Text = num1;

            }
            else if (comboBox1.SelectedItem.ToString() == "仅抽取姓名")
            {
                string[] names = { "名字1", "名字2", "名字3", "名字4", "名字5", "名字6", "名字7", "名字8", "名字9", "名字10", "名字11", "名字12", "名字13", "名字14", "名字15", "名字16", "名字17", "名字18", "名字19", "名字20", "名字21", "名字22", "名字23", "名字24", "名字25", "名字26", "名字27", "名字28", "名字29", "名字30", "名字31", "名字32", "名字33", "名字34", "名字35", "名字36", "名字37", "名字38", "名字39", "名字40", "名字41", "名字42", "名字43", "名字44", "名字45", "名字46", "名字47", "名字48" };
                Text.Text = names[new Random().Next(0, names.Length)];
            }
            else if (comboBox1.SelectedItem.ToString() == "抽取学号和姓名")
            {
                string[] numname = { "1.名字1", "2.名字2", "3.名字3", "4.名字4", "5.名字5", "6.名字6", "7.名字7", "8.名字8", "9.名字9", "10.名字10", "11.名字11", "12.名字12", "13.名字13", "14.名字14", "15.名字15", "16.名字16", "17.名字17", "18.名字18", "19.名字19", "20.名字20", "21.名字21", "22.名字22", "23.名字23", "24.名字24", "25.名字25", "26.名字26", "27.名字27", "28.名字28", "29.名字29", "30.名字30", "31.名字31", "32.名字32", "33.名字33", "34.名字34", "35.名字35", "36.名字36", "37.名字37", "38.名字38", "39.名字39", "40.名字40", "41.名字41", "42.名字42", "43.名字43", "44.名字44", "45.名字45", "46.名字46", "47.名字47", "48.名字48" };
                Text.Text = numname[new Random().Next(0, numname.Length)];
            }

        }

        private void 滚动_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                timer1.Start();
                状态.Content = "(正在滚动)";
                Border.Visibility = Visibility.Visible;
            }
            if (checkBox1.IsChecked == false)
            {
                timer1.Start();
                状态.Content = "(正在滚动)";
                Border.Visibility = Visibility.Collapsed;
            }
        }

        private void 停止_Click(object sender, RoutedEventArgs e)
        {
            timer1.Stop();
            状态.Content = "(未在滚动)";
            Border.Visibility = Visibility.Collapsed;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Add("仅抽取学号");
            comboBox1.Items.Add("仅抽取姓名");
            comboBox1.Items.Add("抽取学号和姓名");
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Add("简体中文(中国)");
            comboBox2.Items.Add("English(US)");
            comboBox2.SelectedIndex = 0;
            ComboBox1.Items.Add("-- --");
            ComboBox1.Items.Add("“ ”");
            ComboBox1.Items.Add("‘ ’");
            ComboBox1.SelectedIndex = 0;
        }


        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // 全屏设置
            Rect rc = SystemParameters.WorkArea;//获取工作区大小
            this.Left = 0;//设置位置
            this.Top = 0;
            this.Width = rc.Width;
            this.Height = rc.Height;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            Border.Visibility = Visibility.Visible;
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            Border.Visibility=Visibility.Collapsed;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "简体中文(中国)")
            {
                滚动.Content = "滚动";
                停止.Content = "停止";
                退出.Content = "退出";
            }
            else if (comboBox2.SelectedItem.ToString() == "English(US)")
            {
                滚动.Content = "Scroll";
                停止.Content = "Stop";
                退出.Content = "Exit";
            }
        }

        private void 信息按钮_Click(object sender, RoutedEventArgs e)
        {
            信息.Visibility = Visibility.Visible;
            话.Visibility = Visibility.Collapsed;
            Text1.Text = "———————信息————————随机抽取学号，版本V1.0.6.417_Release";
        }

        private void 话按钮_Click(object sender, RoutedEventArgs e)
        {
            信息.Visibility = Visibility.Collapsed;
            话.Visibility = Visibility.Visible;

            string[] hua = { "生活就像海洋，仅有意志坚强的人，才能到达彼岸。——马克思","丢失的牛羊能够找回；可是失去的时间却无法找回。——乔叟", "时间像弹簧，能够缩短，也能够拉长。——柬埔寨谚语","对时间的慷慨，就等于慢性自杀。——奥斯特洛夫斯基", "人仅有献身于社会，才能找出那短暂而有风险的生命的意义。——爱因斯坦" };
            Text1.Text = hua[new Random().Next(0, hua.Length)];
        }


        private void 设置_Click(object sender, RoutedEventArgs e)
        {

        }
        public void c()
        {
            txtFrom.Text = "";
            txtQuan.Text = "";
            txtRe.Text = "";
            txtTo.Text = "";
        }







        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (txtFrom.Text == "" | txtTo.Text == "" | txtQuan.Text == "")
            {
                MessageBox.Show("请输入完整信息");
                return;
            }
            int x = int.Parse(txtFrom.Text);
            int y = int.Parse(txtTo.Text);
            int n = int.Parse(txtQuan.Text);

            HashSet<int> Set = new HashSet<int>();
            Random r = new Random();
        aa: for (int i = 1; i <= n; i++)
            {

                Set.Add(r.Next(x, y + 1));


            }
            if (n != Set.Count)
            {
                Set.Clear();
                goto aa;
            }

            foreach (int a in Set)
            {

                if (ComboBox1.SelectedItem.ToString() == "-- --")
                {
                    txtRe.Text += "--" + a.ToString() + "--";
                }
                else if (ComboBox1.SelectedItem.ToString() == "“ ”")
                {
                    txtRe.Text += "“" + a.ToString() + "”";
                }
                else if (ComboBox1.SelectedItem.ToString() == "‘ ’")
                {
                    txtRe.Text += "‘" + a.ToString() + "’";
                }
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            c();
        }



        private void 清空结果_Click(object sender, RoutedEventArgs e)
        {
            txtRe.Text = "";
        }

        private void 加_Click(object sender, RoutedEventArgs e)
        {
            txtRe.FontSize += 2f;
        }

        private void 减_Click(object sender, RoutedEventArgs e)
        {
            txtRe.FontSize -= 2f;
        }

        private void 主页_Click(object sender, RoutedEventArgs e)
        {
            top.Visibility = Visibility.Visible;
            top1.Visibility = Visibility.Collapsed;
            top2.Visibility = Visibility.Collapsed;
            top3.Visibility = Visibility.Collapsed;
            _1.Visibility = Visibility.Visible;
            _2.Visibility = Visibility.Collapsed;
            _3.Visibility = Visibility.Collapsed;
            _4.Visibility = Visibility.Collapsed;
        }

        private void 自定义圆_Click(object sender, RoutedEventArgs e)
        {
            top.Visibility = Visibility.Collapsed;
            top1.Visibility = Visibility.Visible;
            top2.Visibility = Visibility.Collapsed;
            top3.Visibility = Visibility.Collapsed;
            _1.Visibility = Visibility.Collapsed;
            _2.Visibility = Visibility.Visible;
            _3.Visibility = Visibility.Collapsed;
            _4.Visibility = Visibility.Collapsed;
        }

        private void 帮助_Click(object sender, RoutedEventArgs e)
        {
            top.Visibility = Visibility.Collapsed;
            top1.Visibility = Visibility.Collapsed;
            top2.Visibility = Visibility.Visible;
            top3.Visibility = Visibility.Collapsed;
            _1.Visibility = Visibility.Collapsed;
            _2.Visibility = Visibility.Collapsed;
            _3.Visibility = Visibility.Visible;
            _4.Visibility = Visibility.Collapsed;
        }

        private void 设置1_Click(object sender, RoutedEventArgs e)
        {
            top.Visibility = Visibility.Collapsed;
            top1.Visibility = Visibility.Collapsed;
            top2.Visibility = Visibility.Collapsed;
            top3.Visibility = Visibility.Visible;
            _1.Visibility = Visibility.Collapsed;
            _2.Visibility = Visibility.Collapsed;
            _3.Visibility = Visibility.Collapsed;
            _4.Visibility = Visibility.Visible;
        }


    }
}
