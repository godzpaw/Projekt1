   M S B A M L   `   `   `  ����?  ;Cars, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CarsCars  5   	       Cars.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Cars     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         Cars.AutaDataSet   autaDataSet  autaViewSource �� Source �� Source��%U   &	        &	      7     5
   
   6   �� 5   
    66   �� *Auta+8   5      .��5      �  � DataContext# [ 6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��carsGrid��5      $��3��6#   $��3��67   ��6H   �� 6`   �� 5   
   -   5        $��b1��5      $��3��6   .��69   dodaj6@   �� 5   
   -   5        $��1��5      $��3��6!   .��6A   edytuj6I   �� 5   
   -   5        $
��usun��5      $��2��6   $��3��6-   .��6M   usuń6S   5      5       