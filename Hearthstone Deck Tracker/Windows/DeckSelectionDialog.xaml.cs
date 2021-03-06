﻿#region

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.Hearthstone;

#endregion

namespace Hearthstone_Deck_Tracker
{
	/// <summary>
	/// Interaction logic for DeckSelectionDialog.xaml
	/// </summary>
	public partial class DeckSelectionDialog
	{
		public Deck SelectedDeck;

		public DeckSelectionDialog(IEnumerable<Deck> decks)
		{
			InitializeComponent();

			WindowStartupLocation = WindowStartupLocation.CenterScreen;

			DeckPickerList.Items.Clear();
			foreach(var deck in decks.OrderByDescending(d => d.Name))
				DeckPickerList.Items.Add(deck);
		}

		private void DeckPickerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			SelectedDeck = DeckPickerList.SelectedItem as Deck;
			Close();
		}
	}
}