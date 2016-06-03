using Wortell.XamarinForms.Behaviors;
using Wortell.XamarinForms.Controls;
using Xamarin.Forms;

namespace XamarinFormsDemos.Views.Controls
{
  public partial class FloatingPopupControl : IFloatingPopup
  {
    private readonly FloatingPopupDisplayStrategy _strategy;

    public FloatingPopupControl()
    {
      InitializeComponent();
      _strategy = new FloatingPopupDisplayStrategy(InfoText, this, MessageGrid);
    }

    public async void ShowMessageFor(VisualElement parentElement, string text, Point? delta = null)
    {
      await _strategy.ShowMessageFor(parentElement, text, delta);
    }
  }
}
