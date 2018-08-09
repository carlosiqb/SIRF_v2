namespace SIRF.Utilerias
{
    /// <summary>
    /// Clase para el consumo de patrón de diseño Singleton
    /// </summary>
    public class Instance<T> where T : new()
    {
        private static T instance = default(T);
        /// <summary>
        /// Evalua si la instancia existe, procede a utilizarla; en caso contrario la crea para ser utilizada.
        /// </summary>
        public static T Instances
        {
            get
            {
                return (instance == null) ? new T() : instance;
            }
        }
    }
}
