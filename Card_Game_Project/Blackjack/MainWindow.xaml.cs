/*
 * Dakota Cain
 * MIS-3033-002
 */
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

namespace Blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string dealer1;
        public string dealer2;
        public string player1;
        public string player2;
        public int dValue;
        public int pValue;
        public int hitCount = 0;
        public int index = 0;

        public MainWindow()
        {
            InitializeComponent();

            btnHit.IsEnabled = false;
            btnStay.IsEnabled = false;
            btnDeal.IsEnabled = false;
        }

        private void btnDeal_Click(object sender, RoutedEventArgs e)
        {
            btnHit.IsEnabled = true;
            btnStay.IsEnabled = true;
            btnDeal.IsEnabled = false;

            dealer1 = Deck.DeckOfCards[index];
            dealer2 = Deck.DeckOfCards[index + 2];
            player1 = Deck.DeckOfCards[index + 1];
            player2 = Deck.DeckOfCards[index + 3];

            dValue = Value.CardValue(dealer1) + Value.CardValue(dealer2);
            pValue = Value.CardValue(player1) + Value.CardValue(player2);

            imgDealer1.Source = new BitmapImage(new Uri($"C:\\Users\\Dakota\\source\\repos\\BlackJackGame\\Card_Game_Project\\Blackjack\\CardImages\\{dealer1}.png"));
            imgDealer2.Source = new BitmapImage(new Uri($"C:\\Users\\Dakota\\source\\repos\\BlackJackGame\\Card_Game_Project\\Blackjack\\CardImages\\CardB.png"));
            imgPlayer1.Source = new BitmapImage(new Uri($"C:\\Users\\Dakota\\source\\repos\\BlackJackGame\\Card_Game_Project\\Blackjack\\CardImages\\{player1}.png"));
            imgPlayer2.Source = new BitmapImage(new Uri($"C:\\Users\\Dakota\\source\\repos\\BlackJackGame\\Card_Game_Project\\Blackjack\\CardImages\\{player2}.png"));


            if (index > 39)
            {
                btnShuffle.IsEnabled = true;
                btnDeal.IsEnabled = false;
                btnHit.IsEnabled = false;
                btnStay.IsEnabled = false;

                imgDealer1.Source = new BitmapImage(new Uri($"C:\\Users\\Dakota\\source\\repos\\BlackJackGame\\Card_Game_Project\\Blackjack\\CardImages\\CardB.png"));
                imgDealer2.Source = new BitmapImage(new Uri($"C:\\Users\\Dakota\\source\\repos\\BlackJackGame\\Card_Game_Project\\Blackjack\\CardImages\\CardB.png"));
                imgPlayer1.Source = new BitmapImage(new Uri($"C:\\Users\\Dakota\\source\\repos\\BlackJackGame\\Card_Game_Project\\Blackjack\\CardImages\\CardB.png"));
                imgPlayer2.Source = new BitmapImage(new Uri($"C:\\Users\\Dakota\\source\\repos\\BlackJackGame\\Card_Game_Project\\Blackjack\\CardImages\\CardB.png"));

                index = 0;
            }
            else if (pValue == 21)
            {
                btnDeal.IsEnabled = true;
                btnHit.IsEnabled = false;
                btnStay.IsEnabled = false;

                lstHistory.Items.Add("Player Blackjack! Win!");

                index += 4;
            }
            else
            {
                index += 4;
            }

        }

        private void btnHit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnStay_Click(object sender, RoutedEventArgs e)
        {
            btnHit.IsEnabled = false;
            btnStay.IsEnabled = false;
            btnDeal.IsEnabled = true;

            imgDealer2.Source = new BitmapImage(new Uri($"C:\\Users\\Dakota\\source\\repos\\BlackJackGame\\Card_Game_Project\\Blackjack\\CardImages\\{dealer2}.png"));

            if (pValue == dValue)
            {
                lstHistory.Items.Add("Push! Tie.");
            }
            else if (dValue == 21)
            {
                lstHistory.Items.Add("Dealer Blackjack! Loss.");
            }
            else if (pValue > dValue)
            {
                lstHistory.Items.Add("Win!");
            }
            else
            {
                lstHistory.Items.Add("Loss.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnDeal.IsEnabled = true;
            btnShuffle.IsEnabled = false;

            Deck.Shuffle();
        }
    }
}
