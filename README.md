# MahApps.Metro.Resources
Old icon resources repository which will be no longer updated.

You can get this package via [NuGet](https://www.nuget.org/packages/MahApps.Metro.Resources).

Entypo [license](./src/MahApps.Metro.Resources/Entypo-license.txt)  
[WindowsIcons](http://modernuiicons.com) [license](./src/MahApps.Metro.Resources/WindowsIcons-license.txt)

But you should really use the new [MahApps.Metro.IconPacks](https://github.com/MahApps/MahApps.Metro.IconPacks) to get some additional awesome stylish and handmade icons for better cool looking applications.

# Usage

Add the `MahApps.Metro.Resources` resource dictionary to your `App.xaml` or window resource tag.

```xaml
<ResourceDictionary Source="pack://application:,,,/MahApps.Metro.Resources;component/Icons.xaml" />
```

If you added all `MahApps.Metro` resources to your `App.xaml` or window resources tag then you can use the icons e.g. for a circle button like in this sample.

```xaml
<Button Width="50" Height="50"
        Style="{DynamicResource MetroCircleButtonStyle}">
    <Rectangle Width="20" Height="20"
               Fill="{Binding Path=Foreground, RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type Button}}}">
        <Rectangle.OpacityMask>
            <VisualBrush Stretch="Uniform" Visual="{DynamicResource appbar_city}" />
        </Rectangle.OpacityMask>
    </Rectangle>
</Button>
```

# Showcase

You can use this application [download](https://github.com/MahApps/MahApps.Metro.Resources/releases/download/v0.6.1/MahApps.Metro.Resources.Showcase.zip) if you want to show which Icons are included.

![2016-09-13_15h33_53](https://cloud.githubusercontent.com/assets/658431/18475679/a696fe4a-79c7-11e6-913b-453b6249bde4.png)
