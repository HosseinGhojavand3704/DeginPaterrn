namespace DeginPaterrn.Decorator.DecoratorVsInheritance
{
    /// <summary>
    /// Window
    /// </summary>
    public abstract class Window
    {
        protected abstract string _color { get; set; }
        public abstract string GetColor();
        public abstract void SetColor(string newColor);
    }

    public class ConcreteWindow : Window
    {
        protected override string _color { get; set; }

        public ConcreteWindow(string color)
        {
            _color = color;
        }

        public override string GetColor() => _color;

        public override void SetColor(string newColor)
        {
            _color = newColor;
        }
    }

    /// <summary>
    /// Decorator Window
    /// </summary>

    public class DecoratorWindow : Window
    {
        private readonly Window _window;
        protected override string _color { get; set; }

        public DecoratorWindow
        (
            Window window,
            string color
        ) {
            _window = window;
            _color = color;
        }

        public override string GetColor() => _window.GetColor();
        public override void SetColor(string newColor) => _window.SetColor(newColor);
    }

    /// <summary>
    /// Concrete Decorator Window
    /// </summary>

    public class ConcreteDecoratorScrollWindow : DecoratorWindow
    {
        public ConcreteDecoratorScrollWindow(Window window , string color) : base(window , color)
        {
            _color = color;
        }

        public string GetColor() => base.GetColor();

        public void SetColor(string newColor)
        {
            base.SetColor(newColor);
        }

        public void NewFeature()
        {
            Console.WriteLine("this is log newFeature");
        }
    }

    public class ConcreteDecoratorShdowWindow : DecoratorWindow
    {
        public ConcreteDecoratorShdowWindow(Window window, string color) : base(window, color)
        {
            _color = color;
        }

        public string GetColor() => base.GetColor();

        public void SetColor(string newColor)
        {
            Console.WriteLine(GetColor());
            base.SetColor(newColor);
        }

        public void NewFeature()
        {
            Console.WriteLine("this is log newFeature2");
        }
    }
}
