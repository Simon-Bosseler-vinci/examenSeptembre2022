   M S B A M L   `   `   `  ����  examenSeptembre2022$    examenSeptembre2022.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)    � 	Resources 5         listboxTemplate �� Orientation  	listSales��%�  &	        &	 �     �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5	      �� $	��5,0q�67   ��6   �� *	ProductId+67   �� 5
      $	��5,0q�69   ��6   �� *ProductName+69   5      5      �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $	��5,0q�67   ��6   �� *	ProductId+67   �� 5      $	��5,0q�68   ��6   �� *
TotalSales+68   5      5      5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5#      �� -   5        $��Products��5$      #��[  5&      $��Stretch=�5(      $��Stretch=�5)      ��5%      �� *ProductList+ �� SelectedItem 5'      �� *SelectedProduct+5)      �� 5,   
   $
��Left=�6   $	��Top=�60   $��
350,30,0,0q�6H   $��1��6\   .+�5-      �� $��Product ID:��6   $
��Bold"�6+   �� 5.      ��6   �� *SelectedProduct.ProductId+�� 50      $��Product name:��6   $
��Bold"�6-   �� 51      $��10q�6h   ��6   �� *SelectedProduct.ProductName+ �� UpdateSourceTrigger$ PropertyChanged=�6h   �� 53      $��Fournisseur:��6   $
��Bold"�6,   �� 54      ��6   �� *SelectedProduct.ContactName+�� 56      $��Catégorie:��6   $
��Bold"�6*   �� 57      $��10q�6l   ��6   �� *!SelectedProduct.QuantityPerUnit+$ PropertyChanged=�6l   �� 59      $��Mettre à jour��6   $��10q�6O   ��6-   �� *UpdateCommand+6O   5:      �� 5=   
   -   5         ��Name$ productComboBoxv2��5=      #��[ 5?      $
��Left=�5@      $	��Top=�6-   $	��300��5A      $��80��6   $��2��6*   $��20q�67   ��5>      �� *ProductSalesList+5B      5D      5E      