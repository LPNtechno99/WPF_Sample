   M S B A M L   `   `   `  ����E  AWPF_UIdemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_UIdemo
WPF_UIdemo  5          WPF_UIdemo.Page1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:WPF_UIdemo     5        N� Title$  Page1��5	      .��5      �� $	��400��6   
���   �._�5   
   �� -   5        $��myRectangle��5   (   
����  �$	��200��5      $��30��6%   $
��Left=�5       � Triggers 5      :� 5       :� RoutedEvent$ Rectangle.MouseDown��6   .[�5      �� .��5      �� -   5         ��Name$ myStoryboard��5   %   .��5      W�  �� 
TargetName$ myRectangle��6.    �� TargetProperty$ Height�5   .    W� From$ 30X�5   .   	 W� To$	 200X�68    g� Duration$ 0:0:3D�6A   	 W� EasingFunction	 5   "   /  )System.Windows.Media.Animation.CircleEase  5   &   7  1System.Windows.Media.Animation.EasingFunctionBase
   
EasingMode$
 	EaseInOut=�61   5      5      5      5      5      5       5!      