using System.ComponentModel;

namespace PresentationLayer.UIProcessComponents
{
    // Базовый класс для ViewModel, определяет событие для обновление пользователського интерфеса
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            { 
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
