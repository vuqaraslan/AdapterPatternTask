   M S B A M L   `   `   `  ����a  ]Lesson3HomeWorkDesignPat.Date_28_11_23, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Lesson3HomeWorkDesignPat.Date_28_11_23&Lesson3HomeWorkDesignPat.Date_28_11_23  5   	   7    1Lesson3HomeWorkDesignPat.Date_28_11_23.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:Lesson3HomeWorkDesignPat.Date_28_11_23     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5      �� .+�5   
   � $��50��6   
����  �61   �� 5   
   
���   �$��4q�6%   $��	25,0,25,0q�69   ._�5      �  � ColumnDefinitions 5      �� 5      $��5* �6'   64   �� 5      $��3* �6'   64   .+�5      �� $	��Top=�6   $��Center=�65   $��0��5      .+�5      �� $
��Name��6    $
��Left=�5      $��25(�63   $
��Bold"�5      $��0,0,0,0q�6*   5      �� 5      $��30(�5      $
��Bold"�6,   
���   �$��2q�5    .   $	��300��6B   ��5      �� *AnketData.Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��5!      5"      �� 5$      $��Surname��6    $
��Left=�5%      $��25(�63   $
��Bold"�5&      $��0,10,0,0q�6*   5'      �� 5(      $��30(�5*      $
��Bold"�6,   
���   �$��2q�5+   .   $	��300��6B   ��5(      �� *AnketData.Surname+$ TwoWay=�$ PropertyChanged=�.��5+   N   5,      �� 5.      $	��Age��6    $
��Left=�5/      $��25(�63   $
��Bold"�50      $��0,10,0,0q�6*   51      �� 52      $��30(�54      $
��Bold"�6,   
���   �$��2q�55   .   $	��300��6B   ��52      �� *AnketData.Age+$ TwoWay=�$ PropertyChanged=�.��55   N   56      �� 58      $��Seria No��6    $
��Left=�59      $��25(�63   $
��Bold"�5:      $��0,10,0,0q�6*   5;      �� 5<      $��30(�5>      $
��Bold"�6,   
���   �$��2q�5?   .   $	��300��6B   ��5<      �� *AnketData.SeriaNo+$ TwoWay=�$ PropertyChanged=�.��5?   N   5@      �� 5A       �� Orientation$ 
Horizontal=�6!   .+�5C      �� $
��Save��6   $	��145��6,   $��20(�68   $
��Bold"�5D      
����ح�$��	0,10,0,10q�5E      
����  �$��2q�5F      ��6-   �� *SaveBtnCommand+5G      �� 5H      $
��Read��6!   $	��145��60   $��20(�6<   $
��Bold"�5I      
���  ��
�������$��
10,10,0,10q�5K      
����  �$��2q�5L      ��6-   �� *ReadBtnCommand+5M      5N      5R      �� 5T      $��1��6   $��Center=�6-   .+�5U      	� $
��Json��6"   $��20(�61   $
��Bold"�5V   "   $��0,0,0,20q�64    d� 	IsChecked 5W   "   �� *IsCheckJson+$ TwoWay=�$ PropertyChanged=�5Y      	� 5[      $	��XML��6"   $��20(�60   $
��Bold"�6>    5\   "   �� *
IsCheckXML+$ TwoWay=�$ PropertyChanged=�5^      5_      5a      5b      5g      5m      