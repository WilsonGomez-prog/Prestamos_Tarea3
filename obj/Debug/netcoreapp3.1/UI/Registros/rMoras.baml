   M S B A M L   `   `   `  ����K  GPrestamos_Tarea3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Prestamos_Tarea3.UI.RegistrosPrestamos_Tarea3.UI.Registros  5   	   I)clr-namespace:Prestamos_Tarea3.ValidacionPrestamos_Tarea3.Validacion  5   	   *    $Prestamos_Tarea3.UI.Registros.rMoras   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:Prestamos_Tarea3.UI.Registros     5   	   7m)clr-namespace:Prestamos_Tarea3.Validacion     5   	     � Title$  Registro de Moras��5	   	   $	��550��6#   $	��540��60    � 
ResizeMode$ NoResize=�6<    � WindowStartupLocation$ CenterScreen=�6R   .��5
      � .+�5   
   �� .+�5      �� $	��ID:��6   $��15(�6"   $��30��60   $��30��6<   $��20,0,0,0q�6G   $
��Left=�6Y   �� 5      -   5         ��Name$ MoraIdTextBox��5      $��25��6-   $��50��69   $��
80,-25,0,0q�6D   $
��Left=�6X   .��6s   .��5      ��  �� Path$ MoraId�6    �� UpdateSourceTrigger$ PropertyChanged=�6(    �� Mode$ TwoWay=�6N    �� ValidationRules 5      1   +Prestamos_Tarea3.Validacion.ValidacionMonto  5      -   5        validacionmoraid��,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated$
 True��5   F   5      5      �� 5      -   5        	 ��Name$	 BuscarButton��5      $��25��6+   $��70��67   $��170, -25, 0, 0q�6B   $
��Left=�6Z   .��5      ]� .+�5      �� $��-5, 0, 0, 0q�6    Buscar6>   �� 5      $��/Imagenes/search_icon.png��6   $��20��6A   $��5,0,0,0q�6M   5      5      �� 5      $��Fecha:��6   $��15(�6%   $��30��63   $��70��6?   $��	20,10,0,0q�6J   $
��Left=�6]   (  "System.Windows.Controls.DatePicker  5      -   5        
  Name$
 FechaDatePicker��5      $��25��62   $	��160��6>   $��
80,-25,0,0q�6J   $
��Left=�6^      SelectedDate 5      �� 5       $ Fecha�6   $ PropertyChanged=�6+   $ TwoWay=�6Q    5!      1   +Prestamos_Tarea3.Validacion.ValidacionFecha  5"      -   5        validacionfecha��$
 True��5"   I   5$      5&      �� 5(      $��Detalles de la mora.��6   $��15(�65   $��0,10,0,0q�6C   .��5)      �� .+�5+      �� $��	Prestamo:��6   $��15(�60   $��30��6>   $��87��6J   $��20,0,0,0q�6U   $
��Left=�6g   �� 5,      -   5         ��Name$ PrestamoComboBox��5,      $��25��6a   $	��160��6m   $��25,0,0,0q�6y   $
��Left=�6�    �� Text 69   �� *DetalleMora.PrestamoId+6�   �� 5/      $��Valor:��6   $��15(�6-   $��30��6;   $��50��6G   $��240,-80,0,0q�6R   $
��Left=�6g   �� 50      -   5        $ ValorTextBox��50      $��25��64   $��90��6@   $��250,-25,0,0q�6K   $
��Left=�6`   .��6{   .��51      �� $ DetalleMora.Valor�6"   $ PropertyChanged=�6;   $ TwoWay=�6a    52        53   "   -   5        validacionmonto��$
 True��53   M   55      56      �� 58       �� Orientation$ 
Horizontal=�6!   $	��480��6:   $	��270��6F   $��	20,20,0,0q�6S   $
��Left=�6f   .+�59      &   System.Windows.Controls.DataGrid  -	   5          Name$ DetallesDataGrid��59   #      AutoGenerateColumns$ False��6a   $	��220��6}   $	��475��6�      
IsReadOnly$
 True��6�   $	��Top=�6�   ��6=   �� *DetalleMora+   Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;   "   ,  &System.Windows.Controls.DataGridColumn   Header$ ID��65      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6X   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6A   �� *Id+6X     5<   "   $ Cliente��65   $	 220 6e    6F   �� *
PrestamoId+6e     5=   "   $
 Mora��65   $	 100 6]    6C   �� *Valor+6]   5?      �� 5B      $��Total:��6    $��15(�61   $��30��6?   $��50��6K   $��-150,220,0,0q�6V   $
��Left=�6l   �� 5C      -
   5        $ MontoTextBox��5C   "   $��25��6O   $��90��6[   $��-90,220,0,0q�6f   $
��Left=�6{    �� 
IsReadOnly$
 True��6�   ��68   �� *Total+6�   5D      5E      5F      �� 5J      -   5        $	 AgregarButton��5J      $��35��6,   $��80��68   $��390,-625,0,0q�6C   .��5K      ]� .+�5L      �� $��
2, 3, 0, 0q�6    	Agregar6>   �� 5M      $��/Imagenes/add_icon.png��6   $��30��6>   $��5,-2,0,0q�6J   5N      5O      �� 5Q      -   5        $	 RemoverButton��5Q      $��35��6,   $��80��68   $��	0,-50,0,0q�6C   .��5R      ]� .+�5S      �� $��
0, 3, 0, 0q�6    	Remover6=   �� 5T      $��/Imagenes/remove_icon.png��6   $��30��6A   $��5,-2,0,0q�6M   $��22��6_   5U      5V      �� 5X      $��Center=�6   $	��300��66   $��0,10,0,0q�6B   .+�5Y      �� -   5        $	 NuevoButton��5Y      $��35��6.   $��80��6:   $��0,0,0,0q�6E   $
��Left=�6p   .��5Z      ]� $��80��6    .+�5[      �� $
��Left=�6$   $��2,5,0,0q�6?   Nuevo6W   �� 5\      $��/Imagenes/new_icon.png��6    $��30��6B   $��10,0,0,0q�6N   5]      5^      �� 5`      -   5        $	 GuardarButton��5`      $��35��60   $��80��6<   $��	0,-35,0,0q�6G   $��Center=�6v   .��5a      ]� $��80��6    .+�5b      �� $
��Left=�6$   $��2,5,0,0q�6?   	Guardar6Y   �� 5c      $��/Imagenes/save_icon.png��6    $��25��6C   $��0,0,0,0q�6O   5d      5e      �� 5g      -   5        $	 EliminarButton��5g      $��35��61   $��80��6=   $��	0,-35,0,0q�6H   $��Right=�6x   .��5h      ]� $��80��6    .+�5i      �� $
��Left=�6$   $��2,5,0,0q�6?   
Eliminar6Z   �� 5j      $��/Imagenes/delete_icon.png��6    $��30��6E   $��0,0,0,0q�6Q   5k      5l      5m      5o      5p      5q      