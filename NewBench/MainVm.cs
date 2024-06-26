﻿using NewBench.API;
using NewBench.Base;
using System.ComponentModel;
using System.Windows.Input;
using NewBench.Base.Interface.Instance;
using NewBench.Base.Object;

namespace NewBench
{
    public class MainVm : INotifyPropertyChanged
    {
        private readonly Bench _bench;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand ButtonCmd { get; set; }

        private string _displayText = "示例文字";
        public string DisplayText
        {
            get => _displayText;
            set
            {
                _displayText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DisplayText)));
            }
        }

        public MainVm()
        {
            _bench = new Bench();
            _bench.GetPublisher<IPublisher>()!.SomethingPublished += MainVm_SomethingPublished;

            ButtonCmd = new ExampleCommand(_bench.GetCoordinator<Coordinator.Coordinator>()!.DoSomething);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonCmd)));
        }

        private void MainVm_SomethingPublished(object? sender, EventArgs<string> e)
        {
            DisplayText = e.Value;
        }
    }
}
