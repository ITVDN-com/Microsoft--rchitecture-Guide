using System;
using System.Windows.Input;

namespace PresentationLayer.UIProcessComponents
{
    // ViewModel - класс содержащий логику пользовательского интерфейса.
    public class CalcViewModel : ViewModelBase
    {
        // Свойства, значения которых будут отображены в пользовательском интерфейсе через привязку (Binding)
        public string Arg1 { get; set; }
        public string Arg2 { get; set; }
        public int Result { get; set; }
        // Команда, которая через привязку будет привязана к кнопке и которая будет запускаться при нажатии на кнопку.
        public ICommand GetResult { get; set; }

        public CalcViewModel()
        {
            // Инициализация команды. Указание метода который должен запуститься при инициации команды (RunOperation) и метода, который проверяет возможность запуска команды (CanGetResult)
            GetResult = new RelayCommand(RunOperation, CanGetResult);
        }

        // Данный метод сработает если запуститься команда, метод может обратиться к бизнес слою для выполнения вычеслений
        public void RunOperation(object p)
        {
            Result = CallToBusinessLogic();
            OnPropertyChanged("Result");
        }

        // Метод для проверки возможности запуска команды. Команда будет активной только если оба свойства заполнены.
        public bool CanGetResult(object p)
        {
            return !string.IsNullOrEmpty(Arg1) && !string.IsNullOrEmpty(Arg2);
        }

        private int CallToBusinessLogic()
        {
            return Convert.ToInt32(Arg1) + Convert.ToInt32(Arg2);
        }
    }
}
