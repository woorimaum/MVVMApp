using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVMApp.Core
{
    public partial class MainViewModel : ObservableObject
    {
        //[ObservableProperty]
        //public partial int Counter { get; set; }

        [ObservableProperty]
        public int counter;

        [RelayCommand]
        public void Increment()
        {
            Counter++;
        }

        [RelayCommand]
        public void Decrement() 
        {
            Counter--;
        }
    }
}
