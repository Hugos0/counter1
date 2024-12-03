using System;

namespace CounterApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAddCounterClicked(object sender, EventArgs e)
    {
        var counterLayout = new VerticalStackLayout
        {
            Padding = new Thickness(10),
            BackgroundColor = Colors.LightGray,
            Margin = new Thickness(0, 10, 0, 0)
        };

        var counterName = new Entry
        {
            Placeholder = "Nazwa licznika",
            FontSize = 18
        };

        var counterValue = new Label
        {
            Text = "0",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center
        };

        var incrementButton = new Button
        {
            Text = "+",
            HorizontalOptions = LayoutOptions.Center
        };

        var decrementButton = new Button
        {
            Text = "-",
            HorizontalOptions = LayoutOptions.Center
        };

        int counter = 0;

        incrementButton.Clicked += (s, args) =>
        {
            counter++;
            counterValue.Text = counter.ToString();
        };

        decrementButton.Clicked += (s, args) =>
        {
            counter--;
            counterValue.Text = counter.ToString();
        };

        counterLayout.Children.Add(counterName);
        counterLayout.Children.Add(counterValue);
        counterLayout.Children.Add(new HorizontalStackLayout
        {
            Spacing = 10,
            HorizontalOptions = LayoutOptions.Center,
            Children = { incrementButton, decrementButton }
        });

        CountersStack.Children.Add(counterLayout);
    }
}
