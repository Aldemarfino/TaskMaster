   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	   !    Presentation.MainMenuWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   $	��700��5      $
��1300��6'     � WindowStyle$
  None=�5	   	   
������  � AllowsTransparency$
 True��5
   	    � WindowStartupLocation$ CenterScreen=�6#    � DataContext 5   	   ��  �� RelativeSource �� *Self+.��5      ��  �� CornerRadius$ 10��6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��250 �6#   �� 5      $��* �6#   .+�5      �� $ 	10,0,0,10��6      Background1#��[  6.   ._�5      �� .+�5      �� $��50��6!   $��
15,25,0,40q�6-    �� Orientation$ 
Horizontal=�6A   .+�5      �� $��50��6!   ��5      �� 5   "    �� ImageSource$I Cpack://application:,,,/Presentation;component/Images/TaskMaster.png��6-   5      �� 5      $��
TaskMaster��6$   $��30(�66   $
��Bold"�5   $   $��
Montserrat)�66   $��Center=�5   $   $��20,0,0,0q�6?     Foreground3#��[ 5   $   5       	� 5"      -   5        	 	�Name$	 rdbHome��5"   "     MainMenuButton#��[ 63   

 � Tag#
 [ 5#   "   .��5&      �� $ 
Horizontal=�6%   $
��Left=�6>   $	��230��6Y   .+�5'      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     IconMenuButton#��[ 67   �� 5(      $��Proyectos Activos��6(     TextMenuButton#��[ 6A   5*      5+      	� 5-      -   5        $	 rdbCalendar��5-   "   #��[ 67   #
 [ 5.   "   .��51      �� $ 
Horizontal=�6%   $
��Left=�6>   $	��230��6Y   .+�52        $ Calendar=�6+   #��[ 6;   �� 53      $��
Calendario��6(   #��[ 6:   55      56      	� 58      -   5        $	 rdbInvProjects��58   "   #��[ 6:   #
 [ 59   "   .��5<      �� $ 
Horizontal=�6%   $
��Left=�6>   $	��230��6Y   .+�5=        $ Users=�6+   #��[ 68   �� 5>      $��Proyectos Invitados��6(   #��[ 6C   5@      5A      �� 5B      $	��365��6    	� 5C      -   5        $	 	rdbLogOut��5C   "   #��[ 65   #
 [ 5D   "   .��5F      �� $ 
Horizontal=�6%   $
��Left=�6>   $	��230��6Y   .+�5G        $ RightFromBracket=�6+   #��[ 6C   �� 5H      $��Cerrar Sesión��6(   #��[ 6=   5J      5K      5L      5M      �� 5N      $��1��6   $ 0,10,0,0��6%     Background2#��[ 6=   ._�5O      �  � RowDefinitions 5P      �� 5Q      $��25 �6(   �� 5R      $��35 �6(   �� 5S      $��* �6(   .+�5V      �� -   5         ��Name$ TitleBar��5V        TitleBarColor#��[ 6/   $ 0,10,0,0��5X      ._�5Z      �� $ 
Horizontal=�6%   $��RightToLeft=�6>   
������ .+�5\      �� -   5         ��Name$ btnExit��5\   %     XButtonTitleBar#��[ 66   .��5^   "     $ Xmark=�6/     IconTitleBar#��[ 6<   5_      �� 5a      -   5        $ btnSize��5a   %    	 ControlButtonTitleBar#��[	 66   .��5c   "     $ Square=�6/   #��[ 6=   5d      �� 5f      -   5        $ btnMinimize��5f   %   #��[	 6:   .��5h   "     $ WindowMinimize=�6/   #��[ 6F   5i      5k      5l      � 5n      $��1��6    5o      �� 5p      �� 5q      .+�5t      �� $ 
Horizontal=�6%   $��Center=�6>   .+�5u        $��25��5v   +   $��25��67    
 Foreground2   
Foreground# [
 5w   +   $��	35,0,10,0q�5x   +    5u   +   �� *Icon1+5x   +   �� 5z      #��[
 6@   $��20(�5{   (   $��
Montserrat)�5|   (   $��Medium"�5}   (   $��Center=�5~   (   ��5z   (   �� *Title1+5~   (   5      �� 5�      $��1��6%   $ 
Horizontal=�5�   %   $��RightToLeft=�6>   $��Center=�5�   %   $��0,0,10,0q�5�   %   .+�5�      �� $��20(�6F   $
��Bold"�5�   (   
���������5�   (   �� *CurrentUser1+5�   :     5�      $ UserAlt=�6+   $
��10,0q�6:   $��30��6H   5�      5�      �� 5�      -	   5         ��Name$ ViewContent��5�   2   $��2��6%   $��25q�6G   5�      5�      5�      5�      5�      