   M S B A M L   `   `   `  ����K  GPrestamos_Tarea3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Prestamos_Tarea3Prestamos_Tarea3  5   	   I)clr-namespace:Prestamos_Tarea3.ValidacionPrestamos_Tarea3.Validacion  5   	   -    'Prestamos_Tarea3.UI.Registros.rPrestamo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Prestamos_Tarea3     5   	   7m)clr-namespace:Prestamos_Tarea3.Validacion     5   	     � Title$  Registro Prestamos��5	   	   $	��400��6$   $	��430��61    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterScreen=�6S   .��5
      � .+�5   
   �� .+�5      �� $��PrestamoID: ��6   $��30��6/   $��80��6;   $��-340, 20, 0, 0q�6F   �� 5      -   5         ��Name$ PrestamoIdTextBox��5      $��40��65   $��25��6@   $�� -240, -25, 0, 0q�6h   ��6L   �� *
PrestamoId+6h   �� 5      -   5         ��Name$ BuscarButton��5      $��40��6/   $��85��6;   $��140, -45, 0, 0q�6F   .��5      ]� .+�5      �� $��3, 10, 0, 0q�6$   Buscar6C   �� 5      $��/Imagenes/search_icon.png��6    $��10, 0, 0, 0q�6E   5      5      �� 5      $��Fecha:��6   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ FechaPrestamoDP��5      $	��160��62   $��25��6>   $�� -120, -25, 0, 0q�6J      SelectedDate 5      �� 5       �� Path$ FechaPrestamo�6    �� UpdateSourceTrigger$ PropertyChanged=�63   	 �� Mode$	 TwoWay=�6Y   
 �� ValidationRules
 5      1   +Prestamos_Tarea3.Validacion.ValidacionFecha  5      -   5        validacionfecha��,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated$
 True��5   I   5      5       �� 5#      $��
PersonaID:��6   �� 5$      -   5        $ PersonaIdTextBox��5$      $��40��60   $��25��6;   $�� -240, -25, 0, 0q�6G   .��6a   .��5%      �� $ 	PersonaId�6   $ PropertyChanged=�6+   $	 TwoWay=�6Q   
 5&      1   +Prestamos_Tarea3.Validacion.ValidacionMonto  5'      -   5        validacionid��$
 True��5'   B   5)      5*      �� 5-      $��	Concepto:��6   �� 5.      -   5        $ ConceptoTextBox��5.      $	��200��6/   $	��100��6;    �� TextWrapping$
 Wrap=�6H   $�� -80, -25, 0, 0q�6\   .��6u   .��5/      �� $ Concepto�6   $ PropertyChanged=�6*   $	 TwoWay=�6P   
 50      2   ,Prestamos_Tarea3.Validacion.ValidacionCadena  51      -   5        validacionconepto��$
 True��51   H   53      54      �� 57      $��Monto:��6   �� 58      -	   5        $ MontoTextBox��58      $��70��6,   $��25��67   $�� -210, -25, 0, 0q�6C   .��6]   .��59      �� $ Monto�6   $ PropertyChanged=�6'   $	 TwoWay=�6M   
 5:        5;      -
   5        validacionmonto��$
 True��5;   E   5=      5>      �� 5A      $��Balance:��6   �� 5B      -   5        $ BalanceTextBox��5B      $��70��6.   $��25��69   $�� -210, -25, 0, 0q�6^    �� 
IsReadOnly$
 True��6x   ��6E   �� *	Balance+6x   �� 5E       �� Orientation$ 
Horizontal=�6   $
��0,15q�62   .+�5F      �� -   5        $ NuevoButton��5F      $
��10,5q�6.   $��40��6<   $��85��6H   .��5G      ]� .+�5H      �� $��3, 10, 0, 0q�6$   Nuevo6B   �� 5I      $��/Imagenes/new_icon.png��6    $��10, 0, 0, 0q�6B   5J      5K      �� 5M      -   5        $ GuardarButton��5M      $
��20,5q�60   $��40��6>   $��85��6J   .��5N      ]� .+�5O      �� $��
3, 5, 0, 0q�6$   	Guardar6C   �� 5P      $��/Imagenes/save_icon.png��6    $��10, 0, 0, 0q�6C   5Q      5R      �� 5T      -   5        $ EliminarButton��5T      $
��10,5q�61   $��40��6?   $��85��6K   .��5U      ]� .+�5V      �� $��
4, 5, 0, 0q�6$   
Eliminar6D   �� 5W      $��/Imagenes/delete_icon.png��6    $��10, 0, 0, 0q�6E   5X      5Y      5Z      5\      5]      5^      