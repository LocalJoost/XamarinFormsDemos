using Xamarin.Forms;

namespace Wortell.XamarinForms.Behaviors.Base
{
  public abstract class ViewInitializedBehaviorBase<T> : BindableBehaviorBase<T> where T : VisualElement
  {
    #region ViewIsInitialized Attached Dependency Property      
    public static readonly BindableProperty ViewIsInitializedProperty =
       BindableProperty.Create(nameof(ViewIsInitialized), typeof(bool), typeof(ViewInitializedBehaviorBase<T>),
       default(bool), BindingMode.TwoWay,
       propertyChanged: OnViewIsInitializedChanged);

    public bool ViewIsInitialized
    {
      get
      {
        return (bool)GetValue(ViewIsInitializedProperty);
      }
      set
      {
        SetValue(ViewIsInitializedProperty, value);
      }
    }

    private static void OnViewIsInitializedChanged(BindableObject bindable, object oldValue, object newValue)
    {
      var thisObj = bindable as ViewInitializedBehaviorBase<T>;
      thisObj?.Init((bool)newValue);
    }

    #endregion

    protected abstract void Init(bool viewIsInitialized);

  }
}
