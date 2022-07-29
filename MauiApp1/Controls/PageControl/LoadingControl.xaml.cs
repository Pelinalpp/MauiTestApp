namespace MauiApp1.Controls.PageControl;

using MauiApp1.ViewModels;
using System.ComponentModel;

public partial class LoadingControl : ContentView
{
    BaseViewModel _vm;
    readonly Animation loadingAnimation;
    readonly Animation loadingRotationAnimation;
    readonly Animation loadingScaleInAnimation;
    readonly Animation loadingScaleOutAnimation;

    public LoadingControl(BaseViewModel vm)
    {
        InitializeComponent();
        _vm = vm;

        loadingAnimation = new Animation();
        loadingScaleInAnimation = new Animation(v => Loading.Scale = v, 1, 2, Easing.SpringIn);
        loadingRotationAnimation = new Animation(v => Loading.Rotation = v, 0, 360, Easing.Linear);
        loadingScaleOutAnimation = new Animation(v => Loading.Scale = v, 2, 1, Easing.SpringOut);
        loadingAnimation.Add(0, 0.5, loadingScaleInAnimation);
        loadingAnimation.Add(0, 1, loadingRotationAnimation);
        loadingAnimation.Add(0.5, 1, loadingScaleOutAnimation);

        _vm.PropertyChanged += VM_PropertyChanged;
    }


    private void VM_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(_vm.IsLoading) && _vm.IsLoading)
        {
            loadingAnimation.Commit(this, "loadingAnimation", 16, 1500, Easing.Linear,
                (v, c) => Loading.Rotation = 0,
                () => true);
        }
        else if (e.PropertyName == nameof(_vm.IsLoading) && !_vm.IsLoading)
        {
            this.AbortAnimation("loadingAnimation");
        }
    }
}