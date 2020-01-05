namespace FoodConsultant.Model.Tools
{
    using System;
    using System.Reflection;

    public class Singleton<T> where T : class
    {
        #region -- Internal classes --

        /// <summary>
        /// Фабрика используется для отложенной инициализации экземпляра класса
        /// </summary>
        private sealed class SingletonCreator<TS> where TS : class
        {
            public static TS CreatorInstance { get; } = (TS)typeof(TS)
                .GetConstructor(
                    BindingFlags.Instance | BindingFlags.NonPublic,
                    null,
                    new Type[0],
                    new ParameterModifier[0])
                ?.Invoke(null);
        }

        #endregion // -- Internal classes --

        #region -- Properties --

        /// <summary>
        /// Свойства, с помощью которого получается доступ к объекту синглтона
        /// </summary>
        public static T Instance => SingletonCreator<T>.CreatorInstance;

        #endregion // -- Properties --

        #region -- Constructors --

        /// <summary>
        /// Защищённый конструктор необходим для того, чтобы предотвратить создание экземпляра класса Singleton.
        /// Он будет вызван из закрытого конструктора наследственного класса.
        /// </summary>
        protected Singleton() { }

        #endregion // -- Constructors --
    }
}
