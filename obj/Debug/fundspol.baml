   M S B A M L   `   `   `  ????>  :3_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_3_1_3_1  5   	       _3_1.fundspol   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.1, Version=21.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aF 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:_3_1     5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   ICustom<http://schemas.devexpress.com/winfx/2008/xaml/core/themekeys  6G   -   5          ? Title$  
Фонды??5	   	   $??437.705??6   $??759.426??6(    ? 	Resources 5
         TextBoxStyle1 ?? 
TargetType-  'DevExpress.Xpf.Core.ScrollBarExtensions ?? Property ?? Value/  )DevExpress.Xpf.Core.TextBoxScrollBehavior ?? 
TargetType"  DevExpress.Xpf.Core.DXBorder  Name ?? CornerRadius&   DevExpress.Xpf.Core.BlendHelper2   	ThemeInfo	   EnableDPICorrection
 ??Name ?? Triggers P? Property P? Value ?? 
TargetName ?? Triggers9  3DevExpress.Xpf.Utils.Themes.CommonThemeKeyExtension?  ?DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionInternalBase`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   ResourceKey:  4DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionGeneric   	ThemeName&   DevExpress.Xpf.Core.ThemeManager  LabelStyle1 J? SnapsToDevicePixels ??Name ?? ContentStringFormat ?? ContentStringFormat??%?	  &	        &	     ?? 5   
   " ??6&   .?5      ??  ?@ ScrollBehavior 6F     ?? 5       ?@J?	AllowDrop . 6*   ?? 5       ? ??
 ?????6+   ?? 5       ? ?? ?#14F4F16,   ?? 5       ? ??$ 3q?60   ?? 5       ?@??
CaretBrush ?	#FF4444446+   ?? 5       ?@?FocusVisualStyle 61   Z? ?? 5       ? ?? ?	#FF4444446+   ?? 5       ? ??$ 2q?6(   ?? 5       ?@??PanningMode$ VerticalFirst=?69   ?? 5       ?@??SelectionBrush ?	#FF0173C76/   ?? 5       ?@??IsFlicksEnabled .  67   ?? 5       ? ?? 5      ?? 5      " ??6&   .R?5        $ 	IsDefault??6&   #??z??69   $ 15??6e   #??z??6w   #??z??6?   $M GCore\Core\Themes\Office2019Colorful\StandardControls\TextBox.xaml;23;12??6?   	 6?   Z? ._?5      ?? $
 PART_ContentHost??6+   #??z??6E   $M GCore\Core\Themes\Office2019Colorful\StandardControls\TextBox.xaml;24;14??6i   $??3,0,-3,0q?6?   5       5      P? 5       ? {? .  . ?5    "   ?? $ 	IsDefault??6<    ?@J?Opacity$
 0.38Q?6S   5!      5#      5%       5&      P? 5'       ?@??
IsReadOnly . . ?5(      ??  ? ?? ?	#FFABABAB64   ?? 5)       ? ?? 63   C? *  $ ReadOnlyBackgroundBrush??$ Office2019Colorful??+5*      P? 5+       ?@J?	IsFocused . . ?5,      ??  ? ?? ?	#FF0173C764   5-      P? 5.       ?@ IsTouchEnabled . . ?5/      ??  ? ??$ 13q?60   50      52      ?? 53   
   " ??6$   .?54      ??  ? ??$
 Left=?6;   ?? 55       ? ??$	 Top=?69   ?? 56       ? ?? ?#5D3F9A6+   ?? 57       ? ??$ 14(?6)   ?? 58       ? ??$	 0,3q?6(   ?? 59       ? ?? 5:      ?? 5;      " ??6&   .R?5<        #??z??6&   #??z??6R   #??z??6?   # z 6?   $K ECore\Core\Themes\Office2019Colorful\StandardControls\Label.xaml;14;12??6  	 6?   Z? ._?5=      ?? $ Content??6/   #??z??6@   #??z??6t   # z 6?   #??z??6?   #??z??6  ??. $K ECore\Core\Themes\Office2019Colorful\StandardControls\Label.xaml;15;14??6U  #??z??6?  5>       5?      P? 5@       ? {? .  . ?5A   "   ?? $ Content??6<    ?@J?Opacity$
 0.38Q?6Q   5B      5D      5F      ?? 5G       ? ??$	 Top=?69    5H      P? 5I       ?@ IsTouchEnabled . . ?5J      ??  ? ??$
 0,14q?60   5K      5M      5N      .??5O      ? .+?5P   
   &	   System.Windows.Controls.DataGrid	  -   5         	 Name$ dgfunds??5P   g   ???#5D3F9A$??14(?6(    	  
IsReadOnly .  ?? SelectedValuePath$ 	numb_fund??6I   $
??Left=?6x   $	??301??6?   $	??675??6?   $??	39,81,0,0q?6?    	  AutoGenerateColumns .  $	??Top=?6?    	  Columns 5Q      0
  *System.Windows.Controls.DataGridTextColumn
  5R      ,  &System.Windows.Controls.DataGridColumn   Header$! Название фонда??6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *	name_fund+6C   
  5S      $ 
Улица??6E    6%   ?? *street_fund+6E   
  5T      $ Номер дома??6D    6%   ?? *
house_fund+6D   
  5U      $ 
Город??6C    6%   ?? *	town_fund+6C   
  5V      $! Номер телефона??6D    6%   ?? *
phone_fund+6D   
  5W      $ ИНН??6B    6%   ?? *
inn_fund+6B   5Y      ?? 5Z   
   -   5         ??Name$ 	TB_Search??5Z      $
??Left=?6H   $??23??6c   $??	38,46,0,0q?6o    ?? TextWrapping$
 Wrap=?6?   $	??Top=?6?   $	??676??6?   #???   6?   ?? 5[   
   $1??+Поиск по названию фонда??6   $
??Left=?62   $??	42,21,0,0q?6M   $	??Top=?6`   #???  6x   5\      5]      