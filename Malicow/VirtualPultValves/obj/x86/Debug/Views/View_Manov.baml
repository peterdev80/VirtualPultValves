   M S B A M L   `   `   `  ����L  HVirtualPultValves, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:VirtualPultValvesVirtualPultValves  5      I)clr-namespace:VirtualPultValves.ViewModelVirtualPultValves.ViewModel  5      (    "VirtualPultValves.Views.View_Manov   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .myclr-namespace:VirtualPultValves     5      8vm)clr-namespace:VirtualPultValves.ViewModel     5        � 	Resources  5
      1   +VirtualPultValves.ViewModel.ViewModel_Manov   VarManov%   VirtualPultValves.ManovToGradus  ConverterInpu&    VirtualPultValves.ManovIntToBool  Converter2Manov  ProgressBarControlTemplate1 �� 
TargetType � ColumnDefinitions j� Stretch F�Name J� RenderTransformOrigin �� Stretch �� Angle T� X	 T� Y
 ��Name � Points �� 	Converter �� ElementName �� Triggers �� Value �� Binding �� 
TargetName �� Property �� Value��%�  &	        &	      &	 &     &	 9     7  7    5   
   6     5   
   6     5   
   6   �� 5   
   " �6>   .R�5      � $
��Auto��6   $
��Auto��5       5      �� 5      $��0.244* �6'   �� 5      $��0.525* �6'   �� 5      $��0.231* �6'   ��5      �� 5      $ Uniform=�6!   .+�5      �� $��Stretch=�6   $��3��64   $8��2pack://siteoforigin:,,,/PictureValves/BO/MANOV.png��6H   F� 5      $ arow1��6   $��1��6&   i����    <w) ��k�p�@    ��k�p�@�� ��㒙Y!@�� ��㒙Y!@�2> ��k�p�@�2> �k�p�@���p�@	���	#FF784F55$
��Left=�6�   $��5.435��6�   $��56.711,200.531,0,0q�6�   $ 0.395,-1.129&�6  $
 Fill=�63  $	��Top=�6B  $��8.675��6Z  z�5      V� 5      .~�5       �� �� 5!      �� 5"      $ -69.631Q�6.   T� 5#      $ -7.708Q�61   $	 6.627Q�6<   5$      5&      �� 5(      $��0��6   $��0��6#   $��0��60   $��3��6A   .+�5+      �� $
 
PART_Track��6    $	��360��64   �� 5,      $
 PART_Indicator��6    � 5-       �   �J]�J]�.�
���   ����	#FF333333$	 0,0&�5.   )   z�5/      V� 50      .~�51   "   �� �� 52   "   �� 53   "    63   �� *ActualWidth+8   $ PART_Indicator��54      56      58      F� 59      $ arow2��6   $��1��6&   i����    <w) ��k�p�@    ��k�p�@�� ��㒙Y!@�� ��㒙Y!@�2> ��k�p�@�2> �k�p�@���p�@	���	#FF784F55$
��Left=�6�   $��5.435��6�   $��40.976,196.731,0,0q�6�   $) #0.499999989006636,0.500000005264072&�6  $
 Fill=�6J  $	��Top=�6Y  $��8.675��6q  $y�Hidden=�6  z�5:      V� 5;      .~�5<      �� �� 5=      �� 5>      $ -71.623Q�6.   T� 5?      5@      5B      5C       5E      �� 5F      $
 True��6�    6   �� *ActualWidth+8  $ PART_Indicator��.a�5G      �� $ arow1��6    � y�$ Hidden=�6F   �� 5H      $ arow2��6    � y�$ Visible=�6F   5I      5K      5M      .��5O      (� .��5P   
   �� $	��576��6   $	��776��6   ��5Q      �� 5R       �� ImageSource$? 9pack://siteoforigin:,,,/PictureValves/BO/manovakumetr.jpg��6   .+�5T      � #��[ 6    � Maximum$
 1000Q�6R   $ 0.518,0.512&�6�    � SmallChange$ 1Q�6�   $��453.781��6�   $��558.333��6   �� Left$ 97.667��6  
 �� Top$ 90.219��6+   � Value 6a   ��  �� Path$ Manov.ValueState� �� Source# [  ��6�   Z� z�5U      V� 5V      .~�5W      �� �� 5X      �� 5Y      $ 65.556Q�6*   T� 5Z      5[      5]      5^      5_      5b      