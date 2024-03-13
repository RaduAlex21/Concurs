using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ConcursDraexlmaier.Styles
{
    /// <summary>
    /// Interaction logic for InfoCard.xaml
    /// </summary>
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();

            //this.DataContext

        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(InfoCard));

        public FontAwesomeExtension Icon
        {
            get { return (FontAwesomeExtension)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(FontAwesomeExtension), typeof(InfoCard));

        public Color Background1
        {
            get { return (Color)GetValue(Background1Property); }
            set { SetValue(Background1Property, value); }
        }
        public static readonly DependencyProperty Background1Property = DependencyProperty.Register("Background1", typeof(Color), typeof(InfoCard));
        public Color Background2
        {
            get { return (Color)GetValue(Background2Property); }
            set { SetValue(Background2Property, value); }
        }
        public static readonly DependencyProperty Background2Property = DependencyProperty.Register("Background2", typeof(Color), typeof(InfoCard));

        public Color EllipseBackGround1
        {
            get { return (Color)GetValue(Ellipse1Property); }
            set { SetValue(Ellipse1Property, value); }
        }
        public static readonly DependencyProperty Ellipse1Property = DependencyProperty.Register("EllipseBackGround1", typeof(Color), typeof(InfoCard));
        public Color EllipseBackGround2
        {
            get { return (Color)GetValue(Ellipse2Property); }
            set { SetValue(Ellipse2Property, value); }
        }
        public static readonly DependencyProperty Ellipse2Property = DependencyProperty.Register("Ellipse2Property", typeof(Color), typeof(InfoCard));
    }
}
