   M S B A M L   `   `   `  ����  GroupProject    GroupProject.wndInventory   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Gamer's Asylum��5   	   $	��479��6    $	��424��6-   ���	#FF122538.��5      � .+�5   
   �� -   5         ��Name$ btnClose��5      $��Close��6#   $��	0,0,10,10q�63   $��75��6F    �� 	IsDefault . $��Bottom=�6y   $��Right=�6�   �� 5   
   -   5        $ 
btnNewItem��5      $��Create New Item��6%   $
��Left=�6?   $��	10,71,0,0q�6Z   $	��Top=�6m   $	��103��6�   6�   �� 5   
   -   5        $ btnEditItem��5      $��	Edit Item��6&   $
��Left=�6:   $��
118,71,0,0q�6U   $	��Top=�6i   $��75��6�   {�.  6�   �� 5	   
   -   5        $ btnDeleteItem��5	      $��Delete Item��6(   $
��Left=�6>   $��
198,71,0,0q�6Y   $	��Top=�6m   $��75��6�   {�.  6�   �� 5
   
   -   5         ��Name$ lblTitle��5
      $��Gamer's Asylum: Inventory��6"   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   $��39��6�   $	��322��6�   
�������$
��Bold"�6�   $��24(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgItemList��5      $��10,98,10,37q�6'      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Description��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� 	 �� Path$	 ItemDescription�6e     5      $
 Cost��6%    63   �� $	 ItemCost�
 �� StringFormat$
 C��6g   5      5      5      