   M S B A M L   `   `   `  ����  Ternak Admin+    %Ternak_Admin.View.ChangePembeliWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	     � Title$  ChangePembeliWindow��5   	   $	��500��6%   $	��450��62    � WindowStartupLocation$ CenterScreen=�6>    � WindowStyle$
 None=�5   	    � Language$ idn-ID�5	   	   .��5
      � .+�5   
   �� .+�5      �� -   5        $��
LblProduct��5      $��Ubah Data Pembelian��6&   $��Center=�6D   $��20(�5      $��10q�5      $��SemiBold"�6    �� 5      $��Nama Pembeli��6   $��65,10,65,-5q�6+   $��0q�6@   �� 5      -   5        $��TbNameCustomer��5      $��65,10,65,10q�6,   $��16(�5      �� 5      $��Nomor Pembeli��6   $��
65,0,65,-5q�6,   $��0q�6@   �� 5      -   5        $��TbNomor��5      $��65,10,65,10q�6%   $��16(�5      �� 5      $��Alamat Pembeli��6   $��
65,0,65,-5q�6-   $��0q�6A   �� 5      -   5        $��TbAlamat��5      $��65,10,65,10q�6&   $��16(�5      �� 5      $��Nama Produk��6   $��
65,0,65,-5q�6*   $��0q�6>   �� 5      -   5        $��TbNameProduct��5      $��65,10,65,10q�6+   $��16(�5      �� 5       $��Harga Produk��6   $��
65,0,65,-5q�6+   $��0q�6?   �� 5!      -   5        $��TbHarga��5!      $��65,10,65,10q�6%   $��16(�5"      �� 5$      $��Metode Pembayaran��6   $��	65,0,65,0q�60   $��0q�6C   6Q   � 5%      $��
65,5,65,20q�6    � ColumnDefinitions 5&      �� 5'      �� 5(      �� 5)      �� 5*      .+�5,      	� -   5        $��RdbCod��5,   ;   $��0��6   $��0��6.   $	��COD��6I    d� 	IsChecked$
 TrueY�6W   	� 5-      -   5        $��RdbBca��5-   ;   $��1��6   $��0��6.   $	��BCA��6I   	� 5.      -	   5        $��RdbBni��5.   ;   $��2��6   $��0��6.   $	��BNI��6I   	� 5/      -
   5        $��
RdbMandiri��5/   ;   $��3��6   $��0��6.   $��MANDIRI��6M   50      �� 51      -   5        $��	btnChange��51      $��Simpan��6&   
�������$��0,15,0,0q�6J   $
��Bold"�6\   $	��100��6n   $��25��52      ���#5B9978$��16(�53   *   68   �� 54      -   5        $��	btncancel��54      $��Batal��6&   
�������$��0,15,0,0q�6I   $
��Bold"�55      $	��100��6'   $��25��63   ���#5B9978$��16(�6T   56      58      59      5:      