namespace FoodConsultant.Model.Food
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    // TODO: большинство, если не все, классы модели, должны реализовывать интерфейс INotifyPropertyChanged
    public class Food : INotifyPropertyChanged
    {
        // TODO: должен содержать:
        // TODO: 1. название
        // TODO: 2. из какого семейства (FoodCategory)
        // TODO: 3. полное описание
        // TODO: 4. с какими продуктами сочетается
        // TODO: (возможно проще сделать по семействам:
        // TODO: типа сочетается с продуктами такого то семейства,
        // TODO: потом при проверке сравниваем семейство продукта
        // TODO: со списком совместимости, если такое семейство есть в списке
        // TODO: значит совместим)

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
