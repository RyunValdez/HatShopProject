   M S B A M L   `   `   `  ����D  @Project 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Project_2	Project_2  5   	       Project_2.SummaryWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Project_2     5   	     � Title$  SummaryWindow��5   	   $��334.854��6   $��693.578��60   .��5	      � ���#212121.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ summaryDataGrid��5
         AutoGenerateColumns .     CanUserAddRows . $
��Left=�6�   $��	10,35,0,0q�6�   $	��Top=�6�   $	��221��6�   $	��656��6�      
IsReadOnly . ��6^   �� *RowObjectBinding+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6>      
IsReadOnly .    Header$
 Item��6]   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *Name+6]     5      $
 Size��6>   $ 40 6L   	 6%   �� *Size+6L     5      $ 60 6B    . $ Quantity��6`   
   CanUserResize
 .  	 6%   �� *
Quantity+6r     5      $ RIF ID��6@   $	 160 6P   	 6%   �� *RIF_ID+6P     5      $ Price��6?   $ 94 6N   	 6%   �� *Price+6N     5      $ 94 6D    . $ Total Price��6b   
 .  	 6%   �� *
TotalPrice+6w   5      �� 5   
   -   5         ��Name$ 
backButton��5      $
��Back��6%   $
��Left=�64   $��	10,10,0,0q�6O   $	��Top=�6b   $��60��6z   6�   �� 5   
   -   5         ��Name$ totalTextBox��5       �� TextAlignment$ Right=�6(    �� 
IsReadOnly . $
��Left=�6P   $��23��6k   $��546,261,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��$ 0.00��6�   �� 5   
   -   5         ��Name$ 
totalLabel��5      
�������$��Total:��67   $
��Left=�6H   $��503,258,0,0q�6c   $	��Top=�6x   5      5      