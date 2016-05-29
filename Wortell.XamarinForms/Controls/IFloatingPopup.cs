using Xamarin.Forms;

namespace Wortell.XamarinForms.Controls
{
  public interface IFloatingPopup
  {
    void ShowMessageFor(VisualElement parentElement, string text, Point? delta = null);
  }
}
