   M S B A M L   `   `   `  ????>  :3_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_3_1_3_1  5          _3_1.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.1, Version=21.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aF 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $localclr-namespace:_3_1     5        ?? 	Resources  5          MyGlassGradientStopsResource ? Color ? Offset  MyGlassBrushResource ?? 
StartPoint ?? EndPoint ?? Opacity  GrayBlueGradientBrush ?? 
TargetType ?? Property ?? Value	 ?? 
TargetType
 ??Name ?? RadiusX ?? RadiusY J? Opacity J? RenderTransformOrigin J? BitmapEffect ??Name ?? Triggers P? Property P? Value ?? 
TargetName ?? Radius :? RoutedEvent ??Name ?? 
TargetName ?? TargetProperty	 W? By g? Duration ?? BeginStoryboardName??%-  &	        &	 K    7   &	 ?    '?? ?    7  7  ? 5   
   ? 5	      $ 
WhiteSmoke??6   $	 0.2Q?6.   ? 5
      $ Transparent??6   $	 0.4Q?6/   ? 5      $ 
WhiteSmoke??6   $	 0.5Q?6.   ? 5      $ Transparent??6   $
 0.75Q?6/   ? 5      $ 
WhiteSmoke??6   $	 0.9Q?6.   ? 5      $ Transparent??6   $ 1Q?6/   5      ?? 5   
   $	 0,0&?5      $	 1,1&?6   $
 0.75Q?6%   8??  5      ?? 5   
   $	 0,0&?6<   $	 1,1&?6M   .??5      ? $ #5D3F9A??6   $ 0Q?6+   ? 5      $ #5D3F9A??6   $
 0.25Q?6+   ? 5      $ 	SteelBlue??6   $	 0.5Q?6-   ? 5      $ #14F4F1??6   $ 1Q?6+   5      ?? 5   
   " ??6   .?5      ??  ? ??8   6+   ?? 5       ? ??$ 80??6&   ?? 5       ? ??$ 10q?6'   ?? 5       ? ?? 5       ?? 5!      "	 ??6&   .R?5"      ? #??z??6#   #??z??6C   }?. .+?5&   "   ?? $
 outerRectangle??6,   $??Stretch=?6D   $??Stretch=?5'      #??z??6#   $ 20??5(      $ 20??6   $??5??6!   
?????? 65   ?? 5+   "   $
 innerRectangle??6,   $??Stretch=?6D   $??Stretch=?5,      
?????? $??20??68   #??z??5-      $ 20??6+   $ 20??68   ?? 50   "   $
 	glassCube??6,   $??Stretch=?6?   $??Stretch=?51      $??2??52      $ 10??6   $ 10??6(   $ 0Q?65   8?? $ 0.5,0.5&?54      ??55   &   ?? 56   *   $ 0.5,0&?6>   $ 0.5,1&?6Q   ??58   2   ? $	 0.0Q?6?   $ 	LightBlue??6L   ? 59   2   $	 1.0Q?6?   $
 Gray??6L   5;   +   z?5@   &   V? 5A   *   .~?5B   .   ?? ?? 5C   .   5D   +    5G   &   ?? 5H   *   5J   #   ]? 5M   "   $!??myContentPresenterDockPanel??6,   .+?5N   &   ?? $ myContentPresenter??67   $??20q?6S   #??z??5O   	   $??14(?6.   $
??Bold"?6F   
???????6b   5P   #   5Q       5R      P? 5S       ?@J?IsMouseOver . . ?5X   "   ?? $ outerRectangle??6F   # ? ??5Y       ? ???? 5\   "   $ 	glassCube??6V    ?@J?Opacity$ 1Q?6F   6V   ?? 5_   "   $ myContentPresenter??6X    ?@J?BitmapEffect 5`   &   ?? 5a   *   $ 1Q?6;   5c   #   5d      :? 5e      $ Mouse.MouseEnter??6+   [?5f   "   ?? 5g   &   $ mouseEnterBeginStoryboard??66   .??5h   *   ?? .??5j   .   W? $ 	glassCube??6>   $V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)?5k      $
 -0.1X?5m      $ 0:0:0.5D?6   W? 5o   .   $ 	glassCube??5p   	   $V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)?5q      $
 -0.1X?5s      $ 0:0:0.5D?6   5t   +   5u   '   5w      :? 5x      $ Mouse.MouseLeave??6+   [?5y   "   ?? 5{   &   $ mouseEnterBeginStoryboard??65   5}      :? 5~      $ Button.Click??6+   [?5   "   ?? 5?   &   .??5?   *   ?? .??5?   .   W? $ 	glassCube??6>   $V P(Rectangle.RenderTransform).(TransformGroup.Children)[1].(RotateTransform.Angle)?5?      $	 360X?5?      $ 0:0:0.5D?6   5?   +   5?   '   5?      5?      5?      5?      5?      5?      