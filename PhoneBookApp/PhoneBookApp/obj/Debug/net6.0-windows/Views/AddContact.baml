   M S B A M L   `   `   `  ����G  CPhoneBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PhoneBookApp.ViewsPhoneBookApp.Views  5   	   #    PhoneBookApp.Views.AddContact   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:PhoneBookApp.Views     5   	   -   5          �Name$  	AddWindow��5   	    � WindowStartupLocation$ CenterOwner=�5	   	    � Title$ Add Contact��5
   	   $	��300��6   $	��300��6*    � 	Resources 5      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value ��Name �� Path	 �� StringFormat
 �� RelativeSource �� AncestorType(  "System.Windows.Controls.DatePicker��%4  '        �� 5   
   "  6   .�5      ��  � �� 5      �� 5      .R�5      �� $ PART_TextBox��6"   $��-3,-2,-3,-8q�5   |   $��Center=�6�   $��Center=�6�   ��5   "   �� $ SelectedDate�$	 
yyyy MM dd��
 �� "  ��5   e   Z� 6�   5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5"   
   �� 5#      $��1* �6   �� 5$      $��1* �6   .+�5'   
   �� $��0��6   $��0��6!   $��	Full Name��61   $��Center=�6B   $��Center=�6]   �� 5(   
   $��0��6   $��1��6    �� TextWrapping$
 Wrap=�6E   $	��120��6Y   $��30��6e   $��Center=�6q   $��Center=�6�   ��6/   �� *Name+6�   �� 5*   
   $��1��6   $��0��6!   $��	Phone No.��61   $��Center=�6B   $��Center=�6]   �� 5+   
   $��1��6   $��1��6   $
 Wrap=�6H   $	��120��6\   $��30��6h   $��Center=�6t   $��Center=�6�   ��6/   �� *	PhoneNo+6�   �� 5-   
   $��2��6   $��0��6!   $��
Birth Date��61   $��Center=�6C   $��Center=�6^     5.   
   $��2��6   $��1��6"   $	��120��6U   $��30��6a      FirstDayOfWeek$ Monday=�6m      SelectedDate 62   �� *	BirthDate+6m   �� 50   
   $��3��6   $��0��6   $	��Add��6.   ��6<   �� *addContactCommand+��6b   ��  �� ElementName$ 	AddWindow�� �� Mode$ OneWay=��� 51   
   -   5        $��3��51      $��1��6   $��Cancel��6.   6?   52      53      