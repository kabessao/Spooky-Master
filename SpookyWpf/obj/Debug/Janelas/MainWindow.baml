   M S B A M L   `   `   `  ����D  @SpookyWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SpookyWpf	SpookyWpf  5   	       SpookyWpf.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SpookyWpf     5   	   -   5          �Name$  Janela��5	   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Spooky��5   	    � SizeToContent$ Height=�6   $	��200��6/   .��5      �� -   5         ��Name$ Panel��5      $	��5 5q�5      .+�5   
   � $��5��6    � 	Resources 5       �� 
TargetType �� Property	 �� Value��%Q   '��       �� 5      " ��6   .�5      ��  � ��$	 5��6/   5      5      
 � ColumnDefinitions
 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� -   5        {�. $��0q�5      
������� � Cursor$
 Hand��5       $	��0 2q�5!      5%      �� 5'   
   -   5        $��Escolha uma opção:��5'      $
��Bold"�5)      �� 5*   
   -   5         ��Name$ 	cboxOpcao��5*       �� SelectedIndex$ 0��5+      .@�5,      �� .��6   Mostrar tudo6)   �� 5-      .��6   Esconder items na lista64   �� 5.      .��6   Esconder tudo6*   5/      �� 50   
   -   5        .��53      � $	��178��6   .+�54      � -   5         �Name$	 bar��54       � Maximum$	 100Q�6+    � Minimum$ 0Q�55      �� 56      $��	Confirmar��6    �� TextAlignment$ Center=�57      58      59      � 5;   
   $��0 5 0 0 q�6   
 5<      �� 5=      $��* �6#   �� 5>      $��* �6#   .+�5@      �� -   5        $��	0 0 2.5 0q�5C      $��Mostrar log��5D      �� 5E      -	   5        $��	2.5 0 0 0q�5H      $��1��5I      $��Fazer backup��5J      5K      �� 5L   
   -
   5        $��Modificar lista��5P      $	��0 5q�5Q      5X      5Y      