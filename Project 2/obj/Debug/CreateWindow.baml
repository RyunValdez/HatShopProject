   M S B A M L   `   `   `  ����D  @Project 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Project_2	Project_2  5   	       Project_2.CreateWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Project_2     5   	     � Title$  Create Item��5   	   $	��350��6   $	��525��6*   .��5	      � ���#212121.+�5
   
   �� -   5         ��Name$ ItemNameText��5
      $
��Left=�6(   $��23��6C   $��122,134,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ 	PriceText��5      $
��Left=�6%   $��23��6@   $��122,162,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ QuantityText��5      $
��Left=�6(   $��23��6C   $��122,190,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ DescriptionText��5      $
��Left=�6+   $��23��6F   $��122,218,0,0q�6R   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   	� 5   
   -   5         	�Name$ merchButton��5      
�������$��Merchandise��6>   $
��Left=�6T   $��
117,98,0,0q�6o   $	��Top=�6�   	� 5   
   -   5        $ snapBackButton��5      
�������$��SnapBack Hat��6A   $
��Left=�6X   $��
258,98,0,0q�6s   $	��Top=�6�   	� 5   
   -   5        $ fittedButton��5      
�������$��
Fitted Hat��6?   $
��Left=�6T   $��
406,98,0,0q�6o   $	��Top=�6�   �� 5   
   -   5         ��Name$ newIDbutton��5      $��Create New Item��6&   $
��Left=�6@   $��381,254,0,0q�6[   $	��Top=�6p   $	��118��6�   6�   �� 5   
   -	   5         ��Name$ RIF_ID_Label��5      
�������$��RIF ID: ��69   $
��Left=�6L   $��	30,55,0,0q�6g   $	��Top=�6z   $��45��6�   �� 5   
   -
   5        $ RIF_ID_Text��5      $
��Left=�6'   $��23��6B   $��
101,58,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $ Item_Type_Label��5      
�������$��Item Type: ��6<   $
��Left=�6R   $��	28,92,0,0q�6m   $	��Top=�6�   $��66��6�   �� 5   
   -   5        $ Item_Name_Label��5      
�������$��Name: ��6<   $
��Left=�6M   $��
28,132,0,0q�6h   $	��Top=�6|   $��66��6�   �� 5   
   -   5        $ Item_Price_Label��5      
�������$��Price: ��6=   $
��Left=�6O   $��
28,161,0,0q�6j   $	��Top=�6~   $��66��6�   �� 5   
   -   5        $ Item_Quantity_Label��5      
�������$��
Quantity: ��6@   $
��Left=�6U   $��
28,187,0,0q�6p   $	��Top=�6�   $��66��6�   �� 5   
   -   5        $ Item_Description_Label��5      
�������$��Description: ��6C   $
��Left=�6[   $��
28,216,0,0q�6v   $	��Top=�6�   $��74��6�   �� 5   
   -   5        $ Item_HatSize_Label��5      
�������$��Size: ��6?   $
��Left=�6P   $��
28,247,0,0q�6k   $	��Top=�6   $��66��6�   �� 5   
   -   5        $ confirmLabel��5      
�������$�� ��69   $
��Left=�6D   $��439,287,0,0q�6_   $	��Top=�6t   �� 5   
   -   5         ��Name$ sizeComboBox��5      $
��Left=�6c   $��122,247,0,0q�6~   $	��Top=�6�   $	��120��6�   {�6)   �� *	IsChecked+ �� ElementName$ fittedButton��6�   �� 5   
   -   5        $ 
backButton��5      $
��Back��6%   $
��Left=�64   $��	10,18,0,0q�6O   $	��Top=�6b   $��75��6z   6�   5      5      