using System.Net.Mime;

namespace ProgramaTipTime;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void BtnPercent15_OnClicked(object? sender, EventArgs e)
    {
        TipSlider.Value = 15;
    }

    private void BtnPercent30_OnClicked(object? sender, EventArgs e)
    {
        TipSlider.Value = 30;
    }

    private void BtnRoundDown_OnClicked(object? sender, EventArgs e)
    {
        TipSlider.Value = Math.Floor(TipSlider.Value);
    }

    private void BtnRoundUp_OnClicked(object? sender, EventArgs e)
    {
        TipSlider.Value = Math.Ceiling(TipSlider.Value);
        
    }

    private void TipSlider_OnValueChanged(object? sender, ValueChangedEventArgs e)
    {
        double valorRefeicao = Convert.ToDouble(TipInput.Text);
        double valorSlider = Math.Round(TipSlider.Value, 2);
        
        LabelPorcentagemGorjeta.Text = valorSlider.ToString() + "%";
        double valorGorjeta = Math.Round(valorRefeicao * (valorSlider * 0.01), 2);
        LabelGorjeta.Text = valorGorjeta.ToString() + " R$";

        double valorTotal = valorGorjeta + valorRefeicao;
        LabelTotal.Text = valorTotal.ToString();
        
    }
}