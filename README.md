# MahApps.Metro.Resources
Old icon resources repository which will be no longer updated.

You can get this package via [NuGet](https://www.nuget.org/packages/MahApps.Metro.Resources).

Entypo [license](./src/MahApps.Metro.Resources/Entypo-license.txt)  
[WindowsIcons](http://modernuiicons.com) [license](./src/MahApps.Metro.Resources/WindowsIcons-license.txt)

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
