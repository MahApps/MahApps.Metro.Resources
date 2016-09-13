using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using MahApps.Metro.Controls;

namespace MahApps.Metro.Resources.Showcase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static readonly DependencyProperty AllIconsProperty
            = DependencyProperty.Register("AllIcons",
                typeof(IEnumerable),
                typeof(MainWindow),
                new PropertyMetadata(default(IEnumerable)));

        public IEnumerable AllIcons
        {
            get { return (IEnumerable) GetValue(AllIconsProperty); }
            set { SetValue(AllIconsProperty, value); }
        }

        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
            this.Loaded += this.OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var dict = new ResourceDictionary
            {
                Source =
                    new Uri("pack://application:,,,/MahApps.Metro.Resources;component/Icons.xaml",
                        UriKind.RelativeOrAbsolute)
            };
            var foundIcons = dict
                .OfType<DictionaryEntry>()
                .Where(de => de.Value is Canvas)
                .Select(de => new MetroIcon((string) de.Key, (Canvas) de.Value))
                .OrderBy(mi => mi.Name);
            this.AllIcons = new ObservableCollection<MetroIcon>(foundIcons);
        }

        public sealed class MetroIcon
        {
            public MetroIcon(string name, Visual visual)
            {
                this.Name = name;
                this.Visual = visual;
            }

            public string Name { get; private set; }
            public Visual Visual { get; set; }
        }
    }
}