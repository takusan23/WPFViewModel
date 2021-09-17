using System.Diagnostics;

namespace WPFViewModel
{
    class MainWindowViewModel
    {

        /// <summary>
        /// カウンター
        /// </summary>
        public ViewModelValueChanged<int> Count { get; } = new ViewModelValueChanged<int>(0);

        /// <summary>
        /// カウントアップボタンを押したとき
        /// </summary>
        public ViewModelButtonClick Countup { get; }

        public MainWindowViewModel()
        {
            Countup = new ViewModelButtonClick(() =>
            {
                Count.value++;
            });
        }

    }
}
