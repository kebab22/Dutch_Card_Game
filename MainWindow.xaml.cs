using DutchGame.Models;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace DutchGame;

public partial class MainWindow : Window
{
    public Player Player1 { get; set; }
    public Player Player3 { get; set; }
    public Player Player2 { get; set; }
    public Player Player4 { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        Player1 = new Player(1, "Haifa")
        {
            Cards = [
                new TableCard(CardRank.Two, CardSuit.Hearts, true),
                new TableCard(CardRank.Three, CardSuit.Diamonds, true),
                new TableCard(CardRank.King, CardSuit.Hearts, false),
                new TableCard(CardRank.Queen, CardSuit.Spades, false),
            ]
        };

        Player3 = new Player(3, "Hisham")
        {
            Cards = [
                new TableCard(CardRank.Ace, CardSuit.Hearts, false),
                new TableCard(CardRank.King, CardSuit.Clubs, true),
                new TableCard(CardRank.Ten, CardSuit.Spades, false),
                new TableCard(CardRank.Jack, CardSuit.Diamonds, true),
            ]
        };

        Player2 = new Player(2, "Hashim")
        {
            Cards = [
                new TableCard(CardRank.Queen, CardSuit.Hearts, true),
                new TableCard(CardRank.Seven, CardSuit.Spades, false),
                new TableCard(CardRank.Nine, CardSuit.Clubs, false),
                new TableCard(CardRank.Ace, CardSuit.Hearts, true),
            ]
        };

        Player4 = new Player(4, "Maariya")
        {
            Cards = [
                new TableCard(CardRank.King, CardSuit.Clubs, false),
                new TableCard(CardRank.Six, CardSuit.Hearts, false),
                new TableCard(CardRank.Three, CardSuit.Diamonds, true),
                new TableCard(CardRank.Jack, CardSuit.Hearts, true)
            ]
        };
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        // Renders all players cards

        RenderTableHand(Player1);
        RenderTableHand(Player3);
        RenderTableHand(Player2);
        RenderTableHand(Player4);
    }

    private void RenderTableHand(Player player)
    {
        if (player.Id == 1)
        {
            Player1TableHandPanel.Children.Clear();

            foreach (TableCard card in player.Cards)
            {
                string cardImageSource = $"Player{player.Id}-Back";
                if (!card.IsHidden)
                {
                    cardImageSource = $"{card.Rank}-{card.Suit}";
                }

                Image cardImage = new();
                {
                        Width = 96,
                        Margin = new Thickness(4, 0, 4, 0),
                        Source = new BitmapImage(new Uri($"/Resources/Images/Cards/{cardImageSource}.png", UriKind.Relative))
                    };

                Player1TableHandPanel.Children.Add(cardImage);
            }
        }
        else if (player.Id == 3)
        {
            Player1TableHandPanel.Children.Clear(); 

            foreach (TableCard card in player.Cards)
            {
                string cardImageSource = $"Player{player.Id}-Back";
                if (!card.IsHidden)
                {
                    cardImageSource = $"{card.Rank}-{card.Suit}";
                }

                Image cardImage = new();
                {
                    Width = 96,
                    Margin = new Thickness(4, 0, 4, 0),
                    Source = new BitmapImage(new Uri($"/Resources/Images/Cards/{{cardImageSource}}.png\", UriKind.Relative))
                };

                Player1TableHandPanel.Children.Add(cardImage);
            }
        }
           
        
       
        }
    }
}
            /* if (player.Id == 1 && player.Id == 3) & (player.Id == 2 && player.Id == 4)// Player 1 table hand region
             {
                 Player1TableHandPanel.Children.Clear();
                 Player3TableHandPanel.Children.Clear(); 
                 Player2TableHandPanel.Children.Clear();
                 Player4TableHandPanel.Children.Clear();

                 foreach (TableCard card in player.Cards)
                 {
                     string cardImageSource = $"Player{player.Id}-Back";
                     if (!card.IsHidden)
                     {
                         cardImageSource = $"{card.Rank}-{card.Suit}";
                     }

                     if (player.Id == 1 || player.Id == 3)
                     {
                         Image cardImage = new()
                         {
                             Width = 96,
                             Margin = new Thickness(4, 0, 4, 0),
                             Source = new BitmapImage(new Uri($"/Resources/Images/Cards/{cardImageSource}.png", UriKind.Relative))
                         };
                     }

                         if (player.Id == 1)
                         {
                             Player1TableHandPanel.Children.Add(cardImage);
                         }
                         else if (player.Id == 3)
                         {
                             Player3TableHandPanel.Children.Add(cardImage);
                         }
                     }*/
        

       /* else if (player.Id == 2 || player.Id == 4)
        {
            Player2TableHandPanel.Children.Clear();
            Player3TableHandPanel.Children.Clear();

            foreach (TableCard card in player.Cards)
            {
                string cardImageSource = $"Player{player.Id}-Back";
                if (!card.IsHidden)
                {
                    cardImageSource = $"{card.Rank}-{card.Suit}";
                }

                Image cardImage = new()
                {
                    Width = 146,
                    Margin = new Thickness(0, 4, 0, 0),
                    Source = new BitmapImage(new Uri($"/Resources/Image/Cards/{cardImageSource}.png", UriKind.Relative))
                };

                Player
            }
        }
        }*/
    
