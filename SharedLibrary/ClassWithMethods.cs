namespace SharedLibrary
{
    public class ClassWithMethods
    {
        /// <summary>
        /// Accessible anywhere the class is.
        /// </summary>
        /// <param name="name">Name to greet</param>
        /// <returns>Greeting for name</returns>
        public string PublicMethod(string name)
        {
            return $"Hello {name}";
        }

        /// <summary>
        /// Accessible within the current assembly,
        /// or those indicated by an InternalsVisible attribute
        /// </summary>
        /// <param name="name">Name to greet</param>
        /// <returns>Greeting for name</returns>
        internal string InternalMethod(string name)
        {
            return $"Howdy {name}";
        }
    }
}
