   M S B A M L   `   `   `  ����  InterpretScript     InterpretScript.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  InterpretScript��5   	   $	��600��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ CanMinimize=�6_   .��5      � ���	#FF2D2D30 � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��100 �6   .+�5
   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��2,0,2,0q�6   $��0��6*   $��Center=�6:   $	��Top=�6W   .+�5      �� $��Script��6   $��30(�6*   $��20q�68   $��Center=�6D   
�������6a   �� 5      -   5        $��
ScriptText��5      ���	#FF4C4C4F$	��380��6G   " �� VerticalScrollBarVisibility$ Visible=�6T    �� TextAlignment$ Justify=�6z   
���   �
������� �� SelectionBrush
 �   � �� 
LineHeight$ 1��6�   5      �� 5      $��2,0,2,0q�6   $��1��6*   $��Center=�6:   $��Center=�6W   .+�5      �� $��Result��6   $��30(�6*   $��20q�68   $��Center=�6D   
�������6a   �� 5      -   5        $��
ResultText��5      ���	#FF4C4C4F$	��380��6G   $ Visible=�6T   
���   �{�.  $ 1��6�    6�   Z� 6�   5      5      �� 5   
   -   5        $��	RunScript��5      $��1��6"   $	��Run��6/   $��200,20,200,20q�6=   $��20(�6T   6b   5      5      