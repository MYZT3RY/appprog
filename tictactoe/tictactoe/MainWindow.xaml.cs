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
using tictactoe;

namespace tictactoe{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private bool gameStarted = false;
        int stepsCount = 0;

        Button[,] button = new Button[5, 5];

        public MainWindow(){
            InitializeComponent();
        }

        private void StartGame_Click(object sender, RoutedEventArgs e){
            startGame.IsEnabled = false;
            button[0, 0] = button1; button[0, 1] = button2; button[0, 2] = button3; button[0, 3] = button4; button[0, 4] = button5;
            button[1, 0] = button6; button[1, 1] = button7; button[1, 2] = button8; button[1, 3] = button9; button[1, 4] = button10;
            button[2, 0] = button11; button[2, 1] = button12; button[2, 2] = button13; button[2, 3] = button14; button[2, 4] = button15;
            button[3, 0] = button16; button[3, 1] = button17; button[3, 2] = button18; button[3, 3] = button19; button[3, 4] = button20;
            button[4, 0] = button21; button[4, 1] = button22; button[4, 2] = button23; button[4, 3] = button24; button[4, 4] = button25;
            for(int i=0; i<5; i++){
                for(int j=0; j<5; j++){
                    button[i, j].IsEnabled = true;
                    button[i, j].Content = "";
                }
            }
        }

        private void Computer(){
            if (stepsCount != 25){
                Random rand = new Random();
                int tmpx = rand.Next(0, 4);
                int tmpy = rand.Next(0, 4);
                while (button[tmpx, tmpy].IsEnabled == false){
                    tmpx = rand.Next(0, 4);
                    tmpy = rand.Next(0, 4);
                }
                button[tmpx, tmpy].Content = "O";
                button[tmpx, tmpy].IsEnabled = false;
            }
            else{
                MessageBox.Show("Ничья");
            }
        }

        private void Check4Win(){
            if(button[0,0].Content == "X" && button[0, 1].Content == "X" && button[0, 2].Content == "X" && button[0, 3].Content == "X" && button[0, 4].Content == "X"
                || button[1, 0].Content == "X" && button[1, 1].Content == "X" && button[1, 2].Content == "X" && button[1, 3].Content == "X" && button[1, 4].Content == "X"
                || button[2, 0].Content == "X" && button[2, 1].Content == "X" && button[2, 2].Content == "X" && button[2, 3].Content == "X" && button[2, 4].Content == "X"
                || button[3, 0].Content == "X" && button[3, 1].Content == "X" && button[3, 2].Content == "X" && button[3, 3].Content == "X" && button[3, 4].Content == "X"
                || button[4, 0].Content == "X" && button[4, 1].Content == "X" && button[4, 2].Content == "X" && button[4, 3].Content == "X" && button[4, 4].Content == "X"
                || button[0, 0].Content == "X" && button[1, 0].Content == "X" && button[2, 0].Content == "X" && button[3, 0].Content == "X" && button[4, 0].Content == "X"
                || button[0, 1].Content == "X" && button[1, 1].Content == "X" && button[2, 1].Content == "X" && button[3, 1].Content == "X" && button[4, 1].Content == "X"
                || button[0, 2].Content == "X" && button[1, 2].Content == "X" && button[2, 2].Content == "X" && button[3, 2].Content == "X" && button[4, 2].Content == "X"
                || button[0, 3].Content == "X" && button[1, 3].Content == "X" && button[2, 3].Content == "X" && button[3, 3].Content == "X" && button[4, 3].Content == "X"
                || button[0, 4].Content == "X" && button[1, 4].Content == "X" && button[2, 4].Content == "X" && button[3, 4].Content == "X" && button[4, 4].Content == "X"
                || button[0, 0].Content == "X" && button[1, 1].Content == "X" && button[2, 2].Content == "X" && button[3, 3].Content == "X" && button[4, 4].Content == "X"
                || button[0, 4].Content == "X" && button[1, 3].Content == "X" && button[2, 2].Content == "X" && button[3, 1].Content == "X" && button[4, 0].Content == "X"){
                MessageBox.Show("Вы выиграли!");
            }
            else if (button[0, 0].Content == "O" && button[0, 1].Content == "O" && button[0, 2].Content == "O" && button[0, 3].Content == "O" && button[0, 4].Content == "O"
                || button[1, 0].Content == "O" && button[1, 1].Content == "O" && button[1, 2].Content == "O" && button[1, 3].Content == "O" && button[1, 4].Content == "O"
                || button[2, 0].Content == "O" && button[2, 1].Content == "O" && button[2, 2].Content == "O" && button[2, 3].Content == "O" && button[2, 4].Content == "O"
                || button[3, 0].Content == "O" && button[3, 1].Content == "O" && button[3, 2].Content == "O" && button[3, 3].Content == "O" && button[3, 4].Content == "O"
                || button[4, 0].Content == "O" && button[4, 1].Content == "O" && button[4, 2].Content == "O" && button[4, 3].Content == "O" && button[4, 4].Content == "O"
                || button[0, 0].Content == "O" && button[1, 0].Content == "O" && button[2, 0].Content == "O" && button[3, 0].Content == "O" && button[4, 0].Content == "O"
                || button[0, 1].Content == "O" && button[1, 1].Content == "O" && button[2, 1].Content == "O" && button[3, 1].Content == "O" && button[4, 1].Content == "O"
                || button[0, 2].Content == "O" && button[1, 2].Content == "O" && button[2, 2].Content == "O" && button[3, 2].Content == "O" && button[4, 2].Content == "O"
                || button[0, 3].Content == "O" && button[1, 3].Content == "O" && button[2, 3].Content == "O" && button[3, 3].Content == "O" && button[4, 3].Content == "O"
                || button[0, 4].Content == "O" && button[1, 4].Content == "O" && button[2, 4].Content == "O" && button[3, 4].Content == "O" && button[4, 4].Content == "O"
                || button[0, 0].Content == "O" && button[1, 1].Content == "O" && button[2, 2].Content == "O" && button[3, 3].Content == "O" && button[4, 4].Content == "O"
                || button[0, 4].Content == "O" && button[1, 3].Content == "O" && button[2, 2].Content == "O" && button[3, 1].Content == "O" && button[4, 0].Content == "O")
            {
                MessageBox.Show("Компьютер выиграл!");
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e){
            button[0, 0].Content = "X";
            button[0, 0].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button2_Click(object sender, RoutedEventArgs e){
            button[0, 1].Content = "X";
            button[0, 1].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button3_Click(object sender, RoutedEventArgs e){
            button[0, 2].Content = "X";
            button[0, 2].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button4_Click(object sender, RoutedEventArgs e){
            button[0, 3].Content = "X";
            button[0, 3].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button5_Click(object sender, RoutedEventArgs e){
            button[0, 4].Content = "X";
            button[0, 4].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button6_Click(object sender, RoutedEventArgs e){
            button[1, 0].Content = "X";
            button[1, 0].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button7_Click(object sender, RoutedEventArgs e){
            button[1, 1].Content = "X";
            button[1, 1].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button8_Click(object sender, RoutedEventArgs e){
            button[1, 2].Content = "X";
            button[1, 2].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button9_Click(object sender, RoutedEventArgs e){
            button[1, 3].Content = "X";
            button[1, 3].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button10_Click(object sender, RoutedEventArgs e){
            button[1, 4].Content = "X";
            button[1, 4].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button11_Click(object sender, RoutedEventArgs e){
            button[2, 0].Content = "X";
            button[2, 0].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button12_Click(object sender, RoutedEventArgs e){
            button[2, 1].Content = "X";
            button[2, 1].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button13_Click(object sender, RoutedEventArgs e){
            button[2, 2].Content = "X";
            button[2, 2].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button14_Click(object sender, RoutedEventArgs e){
            button[2, 3].Content = "X";
            button[2, 3].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button15_Click(object sender, RoutedEventArgs e){
            button[2, 4].Content = "X";
            button[2, 4].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button16_Click(object sender, RoutedEventArgs e){
            button[3, 0].Content = "X";
            button[3, 0].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button17_Click(object sender, RoutedEventArgs e){
            button[3, 1].Content = "X";
            button[3, 1].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button18_Click(object sender, RoutedEventArgs e){
            button[3, 2].Content = "X";
            button[3, 2].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button19_Click(object sender, RoutedEventArgs e){
            button[3, 3].Content = "X";
            button[3, 3].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button20_Click(object sender, RoutedEventArgs e){
            button[3, 4].Content = "X";
            button[3, 4].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button21_Click(object sender, RoutedEventArgs e){
            button[4, 0].Content = "X";
            button[4, 0].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button22_Click(object sender, RoutedEventArgs e){
            button[4, 1].Content = "X";
            button[4, 1].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button23_Click(object sender, RoutedEventArgs e){
            button[4, 2].Content = "X";
            button[4, 2].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button24_Click(object sender, RoutedEventArgs e){
            button[4, 3].Content = "X";
            button[4, 3].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
        private void Button25_Click(object sender, RoutedEventArgs e){
            button[4, 4].Content = "X";
            button[4, 4].IsEnabled = false;
            stepsCount++;
            Computer();
            Check4Win();
        }
    }
}
