   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Presentation.UserControlsPresentation.UserControls  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      (    "Presentation.UserControls.HomeView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Presentation.UserControls     5      X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      0sys&clr-namespace:System;assembly=mscorlib  5      .��5      ��    Background4#��[  6     �� CornerRadius$  10��67   ._�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��* �6    .+�5      d� -   5         d�Name$ tgbNewProject��5        HomeNewProjectButton#��[ 62   $
��Left=�5      $��10,0,0,0q�65   .��5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�66   .+�5      �� 
�������$  50��60   $��1q�6B   ._�5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$	 Add=�6'   $��20��62   $��20��6=   $��2q�5   '   5      �� 5      $��Agregar Proyecto��6      Foreground2#��[ 68   $��5,0,0,0q�5       $��Center=�61   $��16(�6L   5      5      �� 5!      $ 
Horizontal=�6   $��Right=�62   $��Center=�6N   .+�5"      (  "System.Windows.Controls.DatePicker  -   5        $��dtpStartDateFilter��5"   /   $��0,0,10,0q�6   6/     5#      -   5        $��dtpEndDateFilter��5#   /   $��0,0,10,0q�6   6/   5$      � 5&      -   5        $��PopupNewProject��5&      $��Bottom=�6a    � 	StaysOpen$ False��5'       � PlacementTarget 5&   +   ��  �� ElementName$ tgbNewProject��.��5)      ��   Background5#��[ 6   $  0,0,6,6��6C   $	��350��5*      $	��300��6%   ._�5,      �� .+�5-      0   *Presentation.UserControls.ClearableTextBox  -   5          Name$ txtProjectName��5-   1   	   textBlockContent$	 Nombre del proyecto��6I   $��10q�6p   �� 5.      -   5        
 ��Name$
 DescriptionTextBox��5.   "    �� AcceptsReturn$
 True��6>   " �� VerticalScrollBarVisibility$
 Auto=�5/   "   $ �� HorizontalScrollBarVisibility$
 Auto=�6E    �� TextWrapping$
 Wrap=�50   "   $��	10,0,10,5q�66   $��65��6I   $	��330��6U   �� 52      $ 
Horizontal=�6%   $��Center=�6>   $��10q�53   %   .+�54        -   5        $��dtpStartDate��54   :   $��0,0,5,0q�6)   
 �� Now   SelectedDate# Z 55   )      DisplayDateStart# Z 56   )    � 	Resources 57   "   :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%_   '        �� 58   &   "  6,   .�59   *   ��  �@��
IsReadOnly$
 True��6G   5:   '   5;   #   5<        5=      -   5        $��dtpDeadline��5=   )      Text$ Fecha de entrega��6<    5>   )   �� $ dtpStartDate�� �� Path$ SelectedDate� 5?   "   ��%_   '        �� 5@   &   "  6,   .�5A   *   ��  �@��
IsReadOnly$
 True��6G   5B   '   5C   #   5D      5E      �� 5G      $ Vertical=�6%   $��10q�6<   .+�5H      �� -	   5        $��btnAttachFile��5I   @     HomeViewButton#��[ 5H   %   $
��Left=�5I   %   .��5L   "   �� $ 
Horizontal=�6-   .+�5M   &   �� 
�������$  8��6@   $��1q�6Q   $��25��6e   ._�5N   *     $ 
FileImport=�67   $��20��6I   $��20��6T   $��2q�5O   7   5P   '   �� 5R   &   $��Adjuntar Archivo��60   
���   �$��5,0,0,0q�5S   0   $��Center=�6A   $��16(�6\   5T   #   5U      �� 5W      -
   5        $
 txtFilePath��5W   &   $
 Auto=�6;   $
��Auto��6`   $��0,5,0,0q�5X   &    �� 
IsReadOnly$
 True��67   5Y      �� 5Z      -   5        $��btnAddProject��5\   !   #��[ 5Z   !   $��10q�5[   !   $
��Left=�6-   $��25��6H   .��5]      �� $��Crear Proyecto��6(   $��16(�6>   5^      5_      5`      5a      � 5b      $��1��6    � ColumnDefinitions 5c      �� 5d      $
��0.5* �6'   �� 5e      $
��0.5* �6'   .+�5h      &   System.Windows.Controls.DataGrid  -   5          Name$ ProjectsDataGrid��5k        DataGridStyle1#���  5h        DataGridCellStyle1   	CellStyle# �  6D     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5i        DataGridRowStyle1   RowStyle# �  5j         AutoGenerateColumns$ False��5k   5      SelectionMode$ Single=�5l      $��10q�62       CanUserAddRows$  False��5m      !   Columns! 5p      4  .System.Windows.Controls.DataGridTemplateColumn  5r      ,  &System.Windows.Controls.DataGridColumn"   Header$" 	Proyectos��61   #   Width5	  /System.Windows.Controls.DataGridLengthConverter$# *	 6D   $   CellTemplate$ 5s      �� 5t   "   .R�5u   &   �� $ 
Horizontal=�61   $��40��6J   .+�5w   *   �� $��Center=�65   .+�5x   .   �� $��16(�6N   ��68   �� *Name+6N   � 5y   .   % � Maximum$	% 100Q�6:   & � Minimum$& 0Q�6H   $��5��5z   :   
���  ��$��0,5,0,0q�6V   ' � Value' 5y   T   �� *
Percentage+5z   V   5{   +   5|   '   5}   #   5      5�      � 5�      $��1��6    5�      �� 5�      $
��145* �6+   �� 5�      $	��21* �6+   �� 5�      $
��235* �6+    5�      �� 5�      $��50 �6(   �� 5�      .+�5�      �� $ 
Horizontal=�6!   $��3��6:   .+�5�      �� -   5        $��cbbProjectState��5�   P   $��16(�6#   $��30��61   $��	240,0,0,0q�6=   .@�5�      �� $��	Pendiente��6+   ( �� 
IsSelected$
( True��6?   �� 5�      $��
Programado��6+   �� 5�      $��Atrasado��6+   5�      �� 5�      -   5        $��btnFilterProjects��5�   1   $��1��6!    	 HomeFilterButton#��[	 6J   $
��Left=�5�   !   $��20,0,0,0q�6\   .��5�        $��25��6+   $��25��66   $ Filter=�6B   5�      5�        5�      -   5        $ FilteredProjectsDataGrid��5�      $��1��5�      #���  6,   # �  5�      # �  5�      # �  5�      $ False��5�   A   $ Single=�5�      $��10,10,10,10q�66   $  False��5�      $��3��66   ! 5�        5�      $" Proyectos Filtrados��65   $# *	 6R   $ 5�   "   �� 5�   &   .R�5�   *   �� $ 
Horizontal=�65   $��40��6N   .+�5�   .   �� $��Center=�69   .+�5�   2   �� $��16(�6R   ��6<   �� *Name+6R   � 5�   2   $	% 100Q�6>   $& 0Q�6L   $��5��5�   >   
���  ��$��0,5,0,0q�6Z   ' 5�   X   �� *
Percentage+5�   Z   5�   /   5�   +   5�   '   5�      0
  *System.Windows.Controls.DataGridTextColumn
  5�      $" Entrega��61   1  +System.Windows.Controls.DataGridBoundColumn)   Binding) 6B   �� *
Deadline+
  5�      $" Estado��61   ) 6A   �� *State+5�      5�      5�      5�      5�      5�      