   M S B A M L   `   `   `  ????>  :3_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_3_1_3_1  5   	       _3_1.pozhertvovanie   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.1, Version=21.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aF 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:_3_1     5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   ICustom<http://schemas.devexpress.com/winfx/2008/xaml/core/themekeys  6G   -   5          ? Title$   Пожертвование??5	   	   $??309.836??6   $??401.639??60    ? 	Resources 5         TextBoxStyle1 ?? 
TargetType-  'DevExpress.Xpf.Core.ScrollBarExtensions ?? Property ?? Value/  )DevExpress.Xpf.Core.TextBoxScrollBehavior ?? 
TargetType"  DevExpress.Xpf.Core.DXBorder  Name ?? CornerRadius&   DevExpress.Xpf.Core.BlendHelper2   	ThemeInfo	   EnableDPICorrection
 ??Name ?? Triggers P? Property P? Value ?? 
TargetName ?? Triggers9  3DevExpress.Xpf.Utils.Themes.CommonThemeKeyExtension?  ?DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionInternalBase`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   ResourceKey:  4DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionGeneric   	ThemeName&   DevExpress.Xpf.Core.ThemeManager  LabelStyle1 J? SnapsToDevicePixels ??Name ?? ContentStringFormat ?? ContentStringFormat??%
  &	        &	 ?    ?? 5   
   " ??6&   .?5      ??  ?@ ScrollBehavior 6F     ?? 5       ?@J?	AllowDrop . 6*   ?? 5       ? ??
 ?????6+   ?? 5       ? ?? ?#5D3F9A6,   ?? 5       ? ??$ 1q?60   ?? 5       ?@??
CaretBrush ?	#FF4444446+   ?? 5       ?@?FocusVisualStyle 61   Z? ?? 5       ? ?? ?	#FF4444446+   ?? 5       ? ??$ 2q?6(   ?? 5       ?@??PanningMode$ VerticalFirst=?69   ?? 5       ?@??SelectionBrush ?	#FF0173C76/   ?? 5       ?@??IsFlicksEnabled .  67   ?? 5       ? ?? 5      ?? 5      " ??6&   .R?5        $ 	IsDefault??6&   $ 7??69   #??z??6J   #??z??6v   #??z??6?   $M GCore\Core\Themes\Office2019Colorful\StandardControls\TextBox.xaml;23;12??6?   	 6?   Z? ._?5      ?? $
 PART_ContentHost??6+   #??z??6E   $M GCore\Core\Themes\Office2019Colorful\StandardControls\TextBox.xaml;24;14??6i   5       5      P? 5        ? {? .  . ?5!   "   ?? $ 	IsDefault??6<    ?@J?Opacity$
 0.38Q?6S   5"      5$      5&       5'      P? 5(       ?@??
IsReadOnly . . ?5)      ??  ? ?? ?	#FFABABAB64   ?? 5*       ? ?? 63   C? *  $ ReadOnlyBackgroundBrush??$ Office2019Colorful??+5+      P? 5,       ?@J?	IsFocused . . ?5-      ??  ? ?? ?	#FF0173C764   5.      P? 5/       ?@ IsTouchEnabled . . ?50      ??  ? ??$ 13q?60   51      53      ?? 54   
   " ??6$   .?55      ??  ? ??$ 14(?6)   ?? 56       ? ??$ UltraCondensed&?6,   ?? 57       ? ??$
 Left=?6;   ?? 58       ? ??$	 Top=?69   ?? 59       ? ??$ DemiBold"?6+   ?? 5:       ? ?? ?#5D3F9A6+   ?? 5;       ? ??$	 0,3q?6(   ?? 5<       ? ?? 5=      ?? 5>      " ??6&   .R?5?        #??z??6&   #??z??6R   #??z??6?   # z 6?   $K ECore\Core\Themes\Office2019Colorful\StandardControls\Label.xaml;14;12??6  	 6?   Z? ._?5@      ?? $ Content??6/   #??z??6@   #??z??6t   # z 6?   #??z??6?   #??z??6  ??. $K ECore\Core\Themes\Office2019Colorful\StandardControls\Label.xaml;15;14??6U  #??z??6?  5A       5B      P? 5C       ? {? .  . ?5D   "   ?? $ Content??6<    ?@J?Opacity$
 0.38Q?6Q   5E      5G      5I      ?? 5J       ? ??$	 Top=?69    5K      P? 5L       ?@ IsTouchEnabled . . ?5M      ??  ? ??$
 0,14q?60   5N      5P      5Q      .??5R      ? .+?5S   
   &	   System.Windows.Controls.DataGrid	  -   5         	 Name$ DG_donat??5S       	  AutoGenerateColumns .  $y?	Collapsed=?6A    	  Columns 5T      0
  *System.Windows.Controls.DataGridTextColumn
  5U      ,  &System.Windows.Controls.DataGridColumn   Header$ 
numb_donat??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   ?? *
numb_donat+
  5V      $ 
date_donat??6%    69   ?? *
date_donat+
  5W      $
 summ??6%    63   ?? *summ+
  5X      $ numb pay??6%    67   ?? *
numb_pay+
  5Y      $ inn fund??6%    67   ?? *
inn_fund+
  5Z      $ loginn??6%    65   ?? *loginn+5\      ?? 5]   
   -   5         ??Name$ TBnumb??5]   )   $y?	Collapsed=?6   $
??Left=?69   $??23??6T   $??	79,16,0,0q?6`    ?? TextWrapping$
 Wrap=?6s   $	??Top=?6?   $	??120??6?   ??6?   ?? *SelectedItem.numb_donat+ ?? ElementName$ DG_donat??6?   (  "System.Windows.Controls.DatePicker  5^   
   -   5          Name$ date_eventtx??5^   \   $
??Left=?6r   $??23??6?   $	??Top=?6?   $	??120??6?   $??
237,13,0,0q?6?      SelectedDate 6   ?? *SelectedItem.date_donat+$ DG_donat??6?   ?? 5_   
   -   5        $ TBsumm??5_      $
??Left=?6"   $??23??6=   $??
237,41,0,0q?6I   $
 Wrap=?6]   $	??Top=?6?   $	??120??6?   #???   6?   ??6q   ?? *SelectedItem.summ+$ DG_donat??6?   ?? 5`   
   -   5        $ TBpay??5`      $
??Left=?6!   $??23??6<   $??
237,69,0,0q?6H   $
 Wrap=?6\   $	??Top=?6?   $	??120??6?   #???   6?   ??6p   ?? *SelectedItem.numb_pay+$ DG_donat??6?   ?? 5a   
   -   5        $ TBinn??5a      $
??Left=?6!   $??23??6<   $??
237,99,0,0q?6H   $
 Wrap=?6\   $	??Top=?6?   $	??120??6?   #???   6?   ??6p   ?? *SelectedItem.inn_fund+$ DG_donat??6?   ?? 5b   
   -   5        $ TBloginn??5b      $
??Left=?6$   $??23??6?   $??237,129,0,0q?6K   $
 Wrap=?6`   $	??Top=?6?   $	??120??6?   #???   6?   ??6t   ?? *SelectedItem.loginn+$ DG_donat??6?   ?? 5c   
   -	   5        $??Пожертвовать??5c      $
??Left=?6(   $??226,154,0,0q?6C   $	??Top=?6X   $	??142??6p   6|   ?? 5d   
   -
   5        $??Юкасса??5d      $
??Left=?6"   $??226,213,0,0q?6=   $	??Top=?6R   $	??142??6j   6v   ?? 5e   
   $)??#Дата пожертвования??6   $
??Left=?6-   $??4,10,0,0q?6H   $	??Top=?6Z   #???  6r   ?? 5f   
   $??
Сумма??6   $
??Left=?6    $??4,38,0,0q?6;   $	??Top=?6M   #???  6e   ?? 5g   
   $8??2Номер платежной информации??6   $
??Left=?65   $??4,65,0,0q?6P   $	??Top=?6b   #???  6z   ?? 5h   
   $??ИНН фонда??6   $
??Left=?6$   $??4,97,0,0q?6?   $	??Top=?6Q   #???  6i   ?? 5i   
   $??
Логин??6   $
??Left=?6    $??	4,127,0,0q?6;   $	??Top=?6N   #???  6f   5j      5k      