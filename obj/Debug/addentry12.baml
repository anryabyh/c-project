   M S B A M L   `   `   `  ????  3_1    _3_1.addentry12   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.1, Version=21.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aF 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          ? Title$&   Запись на событие??5   	   $??181.534??6#   $	??350??64   .??5      ? .+?5	   
   &   System.Windows.Controls.DataGrid  -   5        $??dgentry??5	   =   $y?	Collapsed=?6      
IsReadOnly . $
??Left=?6L   $	??250??6g   $	??416??6t   $??	58,30,0,0q?6?      AutoGenerateColumns .  $	??Top=?6?      Columns 5
      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер записи??6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *
numb_entry+6D     5      $ Дата??6D    6%   ?? *
date_entry+6D     5      $ 
Логин??6@    6%   ?? *loginn+6@     5      $ События??6D    6%   ?? *
numb_event+6D   5      ?? 5   
   -   5        $??Запись??5      $
??Left=?6"   $??	93,88,0,0q?6=   $	??Top=?6P   $	??120??6h    J? RenderTransformOrigin$ 0.544,-0.36&?6t   6?   ?? 5   
   -   5        $??События??5      $
??Left=?6#   $??
225,-1,0,0q?6>   $	??Top=?6R   $	??108??6j   6v   ?? 5   
   -   5        $??TBnumben??5   l   $y?	Collapsed=?6   $
??Left=?6|   $??23??6?    ?? TextWrapping$
 Wrap=?6?   $	??Top=?6?   $	??120??6?   $??	79,89,0,0q?6?   ??6)   ??  ?? ElementName$ dgentry??	 ?? Path$	 SelectedItem.numb_entry?6?   (  "System.Windows.Controls.DatePicker  5   
   -   5        $??date_eventtx??5   `   $
??Left=?6t   $??23??6?   $	??Top=?6?   $	??120??6?   $??	93,-1,0,0q?6?   
   SelectedDate
 6   ?? $ dgentry??$	 SelectedItem.date_entry?6?   ?? 5   
   -   5        $??TBloginn??5   R   $
??Left=?6b   $??23??6}   $
 Wrap=?6?   $	??Top=?6?   $	??120??6?   $??	93,32,0,0q?6?   ??6   ?? $ dgentry??$	 SelectedItem.loginn?6?   ?? 5   
   -   5        $??TBnumbev??5   U   $
??Left=?6e   $??23??6?   $
 Wrap=?6?   $	??Top=?6?   $	??120??6?   $??	93,60,0,0q?6?   ??6   ?? $ dgentry??$	 SelectedItem.numb_event?6?   ?? 5   
   $??Дата записи??6   $
??Left=?6&   $??0,-1,0,0q?6A   $	??Top=?6S   ?? 5   
   $??Номер события??6   $
??Left=?6(   $??1,60,0,0q?6C   $	??Top=?6U   $ 0.219,0.694&?6m   ?? 5   
   $??
Логин??6   $
??Left=?6    $??0,33,0,0q?6;   $	??Top=?6M   5      5      