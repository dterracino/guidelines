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

        public void SomeMethod()
        {
            if (true) {
                // Do something...
            }
            else {
                // You know the drill
            }

            using (var reader = new StreamReader()) {
                var foo = new Foo {
                    Id = "foo",
                    Description = "bar"
                };
            }
        }

        private void Bar()
        {
            var task = new Task<string>(() => {
                foreach (var doodad in doodads) {
                    doodad.Initialize();
                }

                return "Yay!";
            });
        }
    }
}