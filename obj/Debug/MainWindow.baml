   M S B A M L   `   `   `  ����L  HLibraryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LibraryManagementLibraryManagement  5      "    LibraryManagement.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      -localclr-namespace:LibraryManagement   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5        � Title$   ��5	      $	��380��5
      $	��450��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��2��6    �� CornerRadius$ 10��6"   ��5      �� 5      .��5      �  � Offset$	 0.0Q�6#    � Color$ #7be9f6��60   � 5      $ 1Q�6#   $ #083da0��6.   � 5      $ 0Q�6#   $ White��6.   5      5      �� 5!   
   .+�5"      �� $��50��6   .+�5#      �� -   5           
modernbttn#���   5$      $��30��5%      $��30��5&      $��0,0,0,1q�5'      $��Right=�5(      $��X��5*      5+      �� 5,      $��Center=�6   .+�5.      �� $��80��6   $#��icon/old-library-building.png��6#   �� 5/      $��Center=�50      $��	helvetica)�51      $��22(�52      $��Light"�53      
�������$��Library Management��55      56      57      �� 59   
   $��1��6   .+�5:      �� 	 �� Orientation$	 
Horizontal=�6   .+�5;      �� -   5        
 ��Name$
 
TxtBoxUser��5<      $	��235��5=      $��25��5>      $��65,0,0,0q�5?      $��Center=�5@      $
��Left=�5A      
������ $��0q�5C      $��	helvetica)�5D      $��20(�5E      $��Light"�5F      
������� J� Opacity$	 0.5Q�5H      $��Username��5I      .  (MahApps.Metro.IconPacks.PackIconMaterial  5J      $��Center=�5K      $��Center=�5L      
�������   Kind$ Account=�5N      5O      �� 5P      $	��250��5Q      $��2��5R      
�������$	 0.5Q�5T      �� 5W      $��0,10,0,0q�6   $	 
Horizontal=�6+   .+�5X      G� -   5         G�Name$ 
TxtBoxPass��5Y      $	��235��5Z      $��25��5[      $��65,0,0,0q�5\      $��Center=�5]      $
��Left=�5^      
������ $��0q�5`      $��	helvetica)�5a      $��20(�5b      $��Light"�5c      
�������$	 0.5Q�5e       G� Password$ Password��5f        5g      $��Center=�5h      $��Center=�5i      
�������$ FormTextboxPassword=�5k      5l      �� 5m      $	��250��5n      $��2��5o      
�������$	 0.5Q�5q      �� 5r      $��0,50,0,0q�6   $	 
Horizontal=�6+   .+�5s      �� -   5         ��Name$ 	BttnLogin��5u      #���   5t      $	��100��5v      $��40��5w      $��	60,0,60,0q�5x      $��Login��5y      5z      �� 5{      -   5        $ BttnRegister��5}      #���   5|      $	��100��5~      $��40��5      $��Register��5�      5�      5�      5�      5�      