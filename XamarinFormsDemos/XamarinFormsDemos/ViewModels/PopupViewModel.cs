using Xamarin.Forms;

namespace XamarinFormsDemos.ViewModels
{
  public class PopupViewModel : MenuViewModelBase
  {
    public Command CloseMenuCommand { get; private set; }

    public PopupViewModel() : base()
    {
      CloseMenuCommand = new Command(() => IsMenuVisible = false);
    }
  }
}