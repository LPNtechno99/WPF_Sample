   M S B A M L   `   `   `  ����|  xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  5   	   D @WPFTookit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFTookit	WPFTookit 5   	      WPFTookit.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   �my{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   	   )localclr-namespace:WPFTookit     5   	     � Title$  
MainWindow��5	   	   $	��900��6   $
��1600��6)    � WindowStartupLocation$ CenterScreen=�66   .��5      � .+�5   
   >   8System.Windows.Controls.DataVisualization.Charting.Chart  -   5        $��ColumnChart1��5   [   $	��260��6   $	��380��6    $
��Left=�6,   $��
33 0 0 120q�6G      Title$ Total Marks��5      $��Bottom=�6'      Series. 5      E   ?System.Windows.Controls.DataVisualization.Charting.ColumnSeries  H   BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   DependentValuePath$ Value��6      IndependentValuePath$	 Key��69      IsSelectionEnabled .    ItemsSource 5      �� 64   5        5   
   -   5        $��
AreaChart1��5   D   $	��260��6   $	��380��6    $��434,39,778,120q�6,   $ Total Marks��5      $��Bottom=�6'   $
��Left=�6B   . 5      C   =System.Windows.Controls.DataVisualization.Charting.AreaSeries  $ Value��6   $	 Key��67    .  5      �� 64   5        5   
   -   5        $��
LineChart1��5   A   $	��375��6   $
��1539��6    $��
33,0,0,440q�6-   $ Total Marks��5      $��Bottom=�6'   $
��Left=�6B   . 5      C   =System.Windows.Controls.DataVisualization.Charting.LineSeries  -   5        $��Line1��5      $ Value��5      $	 Key��67    . 
���  �� 5      ��    DataPointStyle 5      �� 5      	 �� 
TargetTypeF   @System.Windows.Controls.DataVisualization.Charting.LineDataPoint"	  6   .�5      �� 
 �� Property
 � �� �� Value
 �  ��67   �� 5      
 � ��$
 Bold"�67   �� 5       
 � ��$ 0��63   �� 5!      
 � ��$ 0��62   �� 5"      
 � �� 5#      �� 5$   "    �� 
TargetType"  62   .R�5%   &   �  �Name$
 Root��6+   5&   #   5(      5)      5+        5,      -   5        $��Line2��5.      $ Value��5,      $	 Key��67    .  5-      �� 5.      5/        50   
   -   5        $��	PieChart1��50   B   $	��260��6   $	��333��6    $��1239,0,0,120q�6,   $ Total Marks��51      $��Bottom=�6'   $
��Left=�6B   . 52      B   <System.Windows.Controls.DataVisualization.Charting.PieSeries  $ Value��6   $	 Key��66    .  53      ��  � DataContext 63   �� 54      55      �� 57   
   -   5        $	��150��57      $	��100��6   $��35(�6*   $
��Bold"�68   $��975,489,467,280q�6_   .��6x   CLICK6   �� 58   
   -   5        $��	btnCancel��58   J   $	��150��6   $	��100��6   $��35(�6*   $
��Bold"�68   $��975,626,467,143q�6s   .��6�   CANCEL6�   59      5:      