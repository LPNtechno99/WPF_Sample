   M S B A M L   `   `   `  ����I  EDataGridSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DataGridSampleDataGridSample  5   	       DataGridSample.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DataGridSample     5   	     � Title$  
MainWindow��5   	   $	��800��6   $	��600��6)    � 	Resources 5	         DGHeaderStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  DGCHeaderStyle �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%M  &	        &	 X     �� 5
   
   "  6&   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   "  6'   .�5      ��  � ��$ 30��6'   �� 5       � ��
 �2͚�6+   �� 5       � ��
 �   �6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Calibri)�6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
     -   5        $��
MCDataGrid��5   &   $	��200��5      $	��500��6    $
��Left=�6,   $	��Top=�6G   $��	52,40,0,0q�5         	RowHeight$ 30Q�68      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6G      GridLinesVisibility$ Vertical=�5      	   HeadersVisibility$		 All=�62   
�������
   RowBackground

 �����   AlternatingRowBackground
 ��ح�
�������$��5q�5   &      AreRowDetailsFrozen .     FrozenColumnCount$ 0��5          CanUserReorderColumns .    CanUserResizeColumns .    CanUserSortColumns . $   HorizontalScrollBarVisibility$ Visible=�5!   -   "   VerticalScrollBarVisibility$ Visible=�6U   5#        5%   
   -   5        $��	dataGrid2��5%   9   $��1��6   $	��200��6    $	��500��6-      SelectionUnit$
 Cell=�6J      RowHeaderWidth$ 10Q�5&      
 ����$		 All=�6M   #���   5'      $ Visible=�6;   $ Visible=�5(      $ Vertical=�69   5*        5,   
   -   5        $��	dataGrid3��5,   9   $��2��6   $	��200��6    $	��500��6-      AutoGenerateColumns . $ 10Q�5-      $ 
Horizontal=�6'   $ * 5.      $
 Cell=�6#      SelectionMode$ Extended=�68    .     CanUserResizeRows .  $��Stretch=�5/   -   $��Stretch=�6K      RowStyle 50      �� 51      )  #System.Windows.Controls.DataGridRow"  6   .�52      ��  � ��
 ����63    �� Triggers 53      P� 54       P� Property �@J�IsMouseOver P� Value . . �55      ��  � ��
 � � �6;   �� 56       � ��
 �����6;   57      59      5;      5<      5=      