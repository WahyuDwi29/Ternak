   M S B A M L   `   `   `  ����  Ternak Admin#    Ternak_Admin.View.ChickenPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  ChickenPage��5      $	��710��6   $	��890��6+    � Language$ idn-ID�6:   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6'   
�������.��5      �� $
��10 0q�6   .+�5      �� -   5         ��Name$ ListViewProducts��5      $��0q�6N   ��65   �� ��5      �� 5      .R�5      �� $
��10,0q�6%   $	��160��63   $	��235��6?   ._�5   "   �� $��
CowProduct��6-   -   5        .+�5   &   �� $	��140��6-   $	��140��69    �� CornerRadius$ 7��6F   $	��5,0q�6W    J� Effect 5   *   3  -System.Windows.Media.Effects.DropShadowEffect  5   .      ShadowDepth$ 2Q�6?   ��5   *   �� 5   .    �� ImageSource 69   �� *Image+5    '   �� 5!   &   $��5q�60   $��17(�5"   0   $��Franklin Gothic Medium)�6>   $��Center=�5#   0   ��5!   ;   �� *Value+	 �� StringFormat$	 {0:C0}��5#   0   �� 5$   &   $	��5 0q�60   $��15(�6S   $��Center=�5%   0   ��5$   =   �� *Name+5%   0   5&   #   5'      5(      ��5*      �� 5+      .R�5-      � ��5.   !   �� * (FrameworkElement.ActualWidth)+
 �� RelativeSource
 ��  �� AncestorType ScrollContentPresenter � 	ItemWidth 50   !   �� *(ListView.View).ItemWidth+
 ��  ListView��51   !   �� *	ItemWidth+
 �� *Self+ � 
ItemHeight 52   !   �� *(ListView.View).ItemHeight+
 ��  ListView54      56      57      58      59      5:      