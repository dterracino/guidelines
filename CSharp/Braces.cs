namespace Flux
{
    public class Braces
    {
        public string AutoProperty { get; set; }

        public bool ReadOnlyProperty
        {
            get
            {
                return true;
            }
        }
    }
}