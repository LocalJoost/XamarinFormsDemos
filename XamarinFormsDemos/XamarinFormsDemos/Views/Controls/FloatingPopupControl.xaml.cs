using System.Diagnostics;
using System.Threading.Tasks;
using Wortell.XamarinForms.Controls;
using Wortell.XamarinForms.Extensions;
using Xamarin.Forms;

namespace XamarinFormsDemos.Views.Controls
{
  public partial class FloatingPopupControl : IFloatingPopup
  {
    public FloatingPopupControl()
    {
      InitializeComponent();
      IsVisible = false;
      MessageGrid.Opacity = 0;

      GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(ResetControl) });
      SizeChanged += (sender, args) => { ResetControl(); };
    }

    public async void  ShowMessageFor(VisualElement parentElement, string text, Point? delta = null)
    {
      InfoText.Text = text;
      IsVisible = true;

      // IOS apparently needs to have some time to layout the grid first
      if( Device.OS == TargetPlatform.iOS) await Task.Delay(25);
      var gridLocation = MessageGrid.GetAbsoluteLocation();
      var parentLocation = parentElement.GetAbsoluteLocation();

      MessageGrid.TranslationX = parentLocation.X - gridLocation.X - MessageGrid.Width + parentElement.Width +
                                 delta?.X ?? 0;
      MessageGrid.TranslationY = parentLocation.Y - gridLocation.Y + parentElement.Height + delta?.Y ?? 0;
      Debug.WriteLine(MessageGrid.TranslationX + "," + MessageGrid.TranslationY);
      MessageGrid.Opacity = 1;
    }

    private void ResetControl()
    {
      if (MessageGrid.Opacity != 0)
      {
        MessageGrid.Opacity = 0;
        IsVisible = false;
      }
    }
  }
}
