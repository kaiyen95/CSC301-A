   M S B A M L   `   `   `  ����I  ESymBank.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY=clr-namespace:SymBank.Shared.Commands;assembly=SymBank.SharedSymBank.Shared.Commands  5      B >SymBank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:SymBankSymBank 5   	      SymBank.Shell   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Mcmd=clr-namespace:SymBank.Shared.Commands;assembly=SymBank.Shared     5      'localclr-namespace:SymBank     5   	   -   5          � Title$  SymBank System��5	   	   $	��400��5
      $	��600��6   .��5      � -   5         �Name$ shellLayout��5      .+�5      ]� .+�5      o� -   5         o�Name$ mbrMain��5   
   $	��Top=�6   .@�5      m� $��_Tools��6   .@�5      m� -   5         m�Name$ mnuWebBrowser��5      $��_Web Browser��5       m� CommandParameter$ https://www.google.com��5      (   "SymBank.Shared.Commands.MyCommands   OpenBrowser m� Command# Z 5       m� Icon 5      �� 5   	   $
��None=�6   $��Images/world.png��6   5      m� 5      $��_Notepad��6   $ notepad��5   
      Open# Z 5   
   m� 5      $��_Instructor��6   $  C:\CSC301-A\instructor.txt��5   
   # Z 5   
   m� 5      $��_Google��6   $ https://google.com��5    
   # Z 5!   
   5"      5#      c� 5$      -   5        	 c�Name$	 tbrMain��5$      $	��Top=�6   .@�5%      �� -   5        
 ��Name$
 btnWebBrowser��5%       � ToolTip$ Open web browser��5&      $��https://www.microsoft.com��5'      #��Z 5(      .��5)      �� $
��None=�6   $��Images/world.png��6   5*      5+      �� 5,      -   5         ��Name$ sbrMain��5,      $��Bottom=�6    .@�5-      �� -   5         ��Name$ 	lblStatus��5-      $��Ready.��6   5.      � 5/      -	   5        $ shellWorkspace��5/   
    � ColumnDefinitions 50      �� 51      $
��Auto �6   �� 52      $
��Auto �6   �� 53      $��* �6   .+�55      �� -
   5         ��Name$ 
sideRegion��56      $��0��55      $y�	Collapsed=�57      �� 58      $��1��6   $
��Left=�59      $��3��5:      �� 5;      -   5         ��Name$ 
mainRegion��5<      $��2��5;      $y�	Collapsed=�5=      5>      5?      5@      5A      