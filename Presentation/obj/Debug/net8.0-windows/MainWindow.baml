   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	       Presentation.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   $	��520��5      $	��800��6'     � 
ResizeMode$  NoResize=�5	   	   
������  � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      ��  �� CornerRadius$ 12��6   ��5   
   �� 5       �� ImageSource$P Jpack://application:,,,/Presentation;component/Images/Login_Background.jpeg��6    j� Stretch$
 Fill=�5      ._�5   
   �� $ 10��6   
���   �$��5q�5         BackgroundGradient#��[  6%   ._�5      �  � RowDefinitions 5      �� 5      $��25 �6$   �� 5      .+�5      �� -   5         ��Name$ GridTitleBar��5        TitleBarColor#��[ 6/   $ 	10,10,0,0��5      $��
0,-12,0,13q�5   P   ._�5      � 	 � ColumnDefinitions	 5      �� 5       �� 5!      $��25 �6/   .+�5$      �� $��Login��6$     MenuTextBlock#��[ 61   
�������$��10,0,0,0q�5%   7   �� 5'      -   5        
 ��Name$
 btnExit��5'   !   $��1��62     XButtonTitleBar#��[ 6B   .��5)      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6+     IconTitleBar#��[ 68   5*      5+      5,      �� 5.      $��1��6   $	��270��6*   $��	0,30,0,30q�66    �� Orientation$ Vertical=�6I   
�������.+�50      �� $	��150��6   $	��150��6*   $��20q�66   ��51      �� 52      $G Apack://application:,,,/Presentation;component/Images/IconUser.png��6)   54      �� 56      #��[ 6    $��Usuario��6G   $��
20,10,20,0q�6V   �� 58      -   5        $��txtUser��58      $��30��59      $��16(�6*   $��	20,0,20,0q�5:      ���#00001F$��1q�5<      �� 5>      #��[ 6    $��Contraseña��6G   $��
20,20,20,0q�5?       G� 5A      -   5        $��txtPassword��5A   "   $��30��5B   "   $��16(�6.   $��	20,0,20,0q�5C   "   ���#00001F$��1q�5E   "   �� 5G      -   5        $
 btnIngresar��5G        
MenuButton#��[ 5H      $��Ingresar��5I      $��	0,40,0,20q�5J      5K      � 5M       � Orientation$ 
Horizontal=�6    $
��20,0q�69   .+�5O      �� #��[ 6$   $��No tienes una cuenta?��6K   �� 5Q      -   5         ��Name$ btnRegistrar��5Q   $   $��
Registrate��6:   $��16(�6L   $
��Bold"�5R   $   $��Times New Roman)�66   
������ $��8,0,0,0q�5S   =   ��5V      �� 5W   "    �� 
TargetType" ��6(   .�5X   &   ��  �� Property � �� �� Value
 �   �6C    �� Triggers 5Y   &   P� 5Z   *    P� Property �@J�IsMouseOver P� Value$
 True��6I   . �5[   .   ��  � ��
 ��  �6K   5\   +   5^   #   5`      5a      5b      5c      5d      5e      5f      