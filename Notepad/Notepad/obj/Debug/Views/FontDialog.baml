   M S B A M L   `   `   `  ����B  >Notepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Notepad.ViewsNotepad.Views  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U<clr-namespace:System.Windows.Media;assembly=PresentationCoreSystem.Windows.Media 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	      I6clr-namespace:System.Windows;assembly=PresentationCoreSystem.Windows 5
          Notepad.Views.FontDialog   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Notepad.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Nmedia<clr-namespace:System.Windows.Media;assembly=PresentationCore     5      6sys&clr-namespace:System;assembly=mscorlib     5	      Fwin6clr-namespace:System.Windows;assembly=PresentationCore     5
        � Title$
  Font��5      $	��400��5      $	��300��5       � 
ResizeMode$ NoResize=�5       � 	Resources 5         FontFamilyOptions S� 
MethodName S� 
ObjectType   System.Windows.Media.Fonts  FontSizeOptions �� Type  FontWeightOptions  FontStyleOptions��%'  &	        &	 B     &	     &	 �    S� 5   
   $ get_SystemFontFamilies��5      "  5      �� 5   
   " X�6*   .s�5      X�8Q�6   X�5      10Q�6   X�5      12Q�6   X�5      14Q�6   X�5      16Q�6   X�5      24Q�6   5      �� 5   
   " #�6,   .s�5       #�
Normal"�6%   #�5!      Bold"�6#   #�5"      	ExtraBold"�6(   5#      �� 5%   
   " %�6+   .s�5&      %�
Normal$�6$   %�5'      
Italic$�6$   %�5(      Oblique$�6%   5)      5*      .��5+      � $��5,5,5,5q�6    � RowDefinitions 5,   
   �� 5-      �� 5.      �� 5/      $
��auto �6    � ColumnDefinitions 51   
   �� 52      �� 53      .+�56   
   ]� $��0��57      $��2��58      $��0,0,0,5q�59      .+�5:      �� $��70��6   $
��Left=�6#   Font Family :6H   �� 5;       �� SelectedIndex$ 0��5=      ��5<      �� 	 �� Source#	 [  
 �� SelectedItem
 5>      �� *Family+��5?      �� 5@      .R�5A      �� ��6$   �� ��6;   �� 5B      5D      5E      ]� 5G   
   $��1��5H      $��2��5I      $��0,0,0,5q�5J      .+�5K      �� $��70��6   $
��Left=�6#   Font Size :6F   �� 5L      $ 0��5N      ��5M      �� #	 [ 
 5O      �� *Size+��5P      �� 5Q      .R�5R      �� ��6$   �� ��6;   �� 5S      5U      5V      �� 5X   
   $��2��6   $��0,0,5,0q�6"   .+�5Y      �� Font Style :6&   �� 5Z      $ 0��5\      ��5[      �� #	 [ 
 5]      �� *Style+5^      �� 5`   
   $��2��6   $��1��6"   .+�5a      �� Font Weight :6'   �� 5b      $ 0��5d      ��5c      �� #	 [ 
 5e      �� *Weight+5f      5g      5h      