   M S B A M L   `   `   `  ����D  @Project 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Project_2	Project_2  5   	       Project_2.SaleWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Project_2     5   	     � Title$  Sale Window��5   	   $��334.854��6   $��693.578��6.   .��5	      � ���#212121.+�5
   
   �� -   5         ��Name$ 
rifTextBox��5
      $
��Left=�6&   $��23��6A   $��	74,64,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5         ��Name$ searchButton��5      $��Search��6'   $
��Left=�68   $��
208,64,0,0q�6S   $	��Top=�6g   $��74��6   6�   �� 5   
   -   5         ��Name$ rifLabel��5      
�������$��RIF ID:��65   $
��Left=�6G   $��	10,61,0,0q�6b   $	��Top=�6u   $��59��6�   �� 5   
   -   5         ��Name$ itemListBox��5      $
��Left=�6'   $	��141��6B   $��
10,133,0,0q�6O   $	��Top=�6c   $	��272��6{   �� 5   
   -   5        $ 
backButton��5      $
��Back��6%   $
��Left=�64   $��	10,17,0,0q�6O   $	��Top=�6b   $��60��6z   6�   �� 5   
   -   5        $ resetButton��5      $��Reset Search��6&   $
��Left=�6=   $��
208,92,0,0q�6X   $	��Top=�6l   $��74��6�   6�   �� 5   
   -   5        $ 
sellButton��5      $��Checkout��6%   $
��Left=�68   $��549,259,0,0q�6S   $	��Top=�6h   $	��120��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ saleDataGrid��5         AutoGenerateColumns .     CanUserAddRows . $
��Left=�6�   $��
385,10,0,0q�6�   $	��Top=�6�   $	��204��6�   $	��284��6�   	   
IsReadOnly	 . ��6[   �� *RowObjectBinding+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 95 6C      
IsReadOnly .    Header$
 Item��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$
 Name�6a     5      $ 60 6G    . $ Quantity��6e      CanUserResize .   6%   �� $ Quantity�6w     5      $	 120 6D    . $ Price��6c    .   6%   �� $ Price�6r   5      �� 5   
   -	   5        $ totalTextBox��5       �� TextAlignment$ Right=�6(    �� 
IsReadOnly . $
��Left=�6P   $��23��6k   $��549,223,0,0q�6w   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��$ 0.00��6�   �� 5   
   -
   5        $ 
totalLabel��5      
�������$��Total:��67   $
��Left=�6H   $��506,220,0,0q�6c   $	��Top=�6x   �� 5   
   -   5        $ 	addButton��5      $	��Add��6$   $
��Left=�62   $��297,133,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ removeButton��5      $��Remove��6'   $
��Left=�68   $��297,158,0,0q�6S   $	��Top=�6h   $��75��6�   6�   5      5      