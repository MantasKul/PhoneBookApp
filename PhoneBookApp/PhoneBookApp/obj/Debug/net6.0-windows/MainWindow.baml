   M S B A M L   `   `   `  ����G  CPhoneBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PhoneBookAppPhoneBookApp  5   	       PhoneBookApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PhoneBookApp     5   	     � Title$  
Phone Book��5   	   $	��700��6   $	��500��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��9* �6   �� 5      $��1* �6   .+�5   
   � $��0��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataList��5         AutoGenerateColumns$ False��6)      CanUserAddRows$ false��5         
IsReadOnly$
 True��5      ��5      �� *
contacts+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
Visibility$ Hidden=�65   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6I   �� *ID+  5      $ 	Full Name��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1* 6<   	 6G   �� *Name+  5      $ 	Phone No.��6)   $
 1* 6<   	 6G   �� *	PhoneNo+  5      $ 
Birth Date��6)   $
 1* 6=   	 6H   �� *	BirthDate+ �� StringFormat$ {0:yy-MM-dd}��5      5      � 5   
   $��2��6    � ColumnDefinitions 5       �� 5!      $��1* �6#   �� 5"      $��1* �6#   �� 5#      $��1* �6#   .+�5&      �� $��0��6   $	��Add��6%   ��63   �� *addContactWindowCommand+�� 5'      $��1��6   $
��Edit��6%   ��64   �� *editContactWindowCommand+��6a   ��  �� ElementName$ DataList�� �� Path$ SelectedItem��� 5(      $��2��6   $��Delete��6%   ��66   �� *deleteContactCommand+��6_   �� $ DataList��$ SelectedItem�5)      5*      5+      