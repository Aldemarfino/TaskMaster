   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5      b ^PresentationFramework.Aero2, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          Presentation.App   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ,localclr-namespace:Presentation     5      ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5        �� 	Resources  5       �� MergedDictionaries �� Source �� 
TargetType �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType	 ��Name
 J� SnapsToDevicePixels �Name J� Opacity � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName   DataGridStyle1 �� Padding ��Name � ColumnDefinitions � RowDefinitions   SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column  ��Name! �� CanContentScroll" ��Name# �� ScrollableHeight$ � Maximum% �� Orientation& �� ViewportHeight' �� ViewportSize*( �� #ComputedVerticalScrollBarVisibility) � Value* �� Mode+ �� Mode, �� ScrollableWidth- �� ViewportWidth,. �� %ComputedHorizontalScrollBarVisibility/ �� Triggers0 ]� 
Conditions1 �� Property2 �� Value3 �� Color  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell4   FocusBorderBrushKey  ColumnHeaderGripperStyle  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3  -Microsoft.Windows.Themes.DataGridHeaderBorder5   	IsPressed6 J� IsMouseOver7   	IsHovered8   CanUserSort9   IsClickable:   SortDirection;   SortDirection<   SeparatorVisibility=   SeparatorVisibility>   SeparatorBrush?   SeparatorBrush@ n�Name  DataGridRowStyle1)  #System.Windows.Controls.DataGridRowA ��Name?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid?	  9System.Windows.Controls.Primitives.DataGridCellsPresenterB   
ItemsPanelA
  ;System.Windows.Controls.Primitives.DataGridDetailsPresenterC   DetailsVisibility$D   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientationE   Vertical#F   RowDetailsScrollingConverter:  4System.Windows.Controls.Primitives.DataGridRowHeader
G   Row�� 5   
    5	      �� 5
      $# /Styles/ColorsDictionary.xaml?�6%   �� 5      $% /Styles/ControlsDictionary.xaml?�6%   %d  (��       5      $" DataGridSelectAllButtonStyle��"  )&	  �    (�� T    5^      *DataGrid.FocusBorderBrushKey+)&	 w    &	 (    &	 :    7  7  &	 Z    �� 5      " ��6�   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      � .+�5   "   �� $	 Border��6,   #��� ��6<   $

 True��6}   � 5   "   $ Arrow��6*   
���   �$��Right=�6F   $��8,8,3,3q�6b   $
 0.15Q�6s    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5       5      P� 5   "    �@J�IsMouseOver$
 True��6A   . �5   &   �� $ Border��6?   # � ��6S    � ��5   #   P� 5   "    � ��$
 True��6?   . �5   &   �� $ Border��6=   # � ��6Q    � ��5   #   P� 5   "    � {�$ False��6?   . �5   &   �� $ Arrow��6C    � y�$ 	Collapsed=�6V   5   #   5!      5#      5$      �� 5%      "  6+   .�5&      ��  � ��# � ��6/   �� 5'       � ��# � ��6/   �� 5(       � �� �	#FF688CAF60   �� 5)       � ��$ 1q�64   �� 5*        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�6=   �� 5+       � ��$
 true��6B   �� 5,       �@��PanningMode$
 Both=�6=   �� 5-       �@��IsFlicksEnabled$ False��6;   �� 5.       � �� 5/      �� 50      "  6*   .R�51      �� #��z��6%   #��z��6O   #��z��6{   # z��6�   $

 True��6�   ._�52   "   �� $ DG_ScrollViewer��6/   $|�false��6H   ��53   &   �� 54   *   " ��6:   .R�55   .   �  56   2   �� 57   6   $
��Auto �6G   �� 58   6   $��* �6G   �� 59   6   $
��Auto �6G    5;   2   �� 5<   6   $
��Auto �6D   �� 5=   6   $��* �6D   �� 5>   6   $
��Auto �6D   .+�5@   2   �� #��Z 69   $|�false��6h   ��6z   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5A   2   $! PART_ColumnHeadersPresenter��6Q   $��1��6v   y�6�   �� *HeadersVisibility+# Z # Z  �� "  �� 5B   2   $!  PART_ScrollContentPresenter��6I   #! z��6n   $��2��6�   $��1��6�   �� 5C   2   $" PART_VerticalScrollBar��6<   $��2��6\   #$ z# 6l   $% Vertical=�6�   $��1��6�   #' z& 6!  #y�z( 6Q  ) 6�   �� *VerticalOffset+$* OneWay=� �� $+ TemplatedParent=�6Q  � 5D   2   $��1��67   $��2��6G    5E   6   �� 5F   :   ��6K   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5G   :   $��* �6K   .+�5I   6   �� $" PART_HorizontalScrollBar��6@   $��1��6b   #$ z, 6r   $% 
Horizontal=�6�   #' z- 6  #y�z. 6L  ) 6�   �� *HorizontalOffset+$* OneWay=� �� $+ TemplatedParent=�6L  5J   3   5K   /   5L   +   .��5N   &   �� #
 z
 65   5O   #   5P      5Q      5S      / 5T      ]� 5U      0 5V      �� 5W      1 �@��
IsGrouping$
2 true��6>   �� 5X      "1 �@%�IsVirtualizingWhenGrouping$2 false��6`   ./�5Z      ��  � ��$ false��6J   5[      5]      �� 5^      $3 	#FF000000��6N   �� 5_      "  6/   .�5`      ��  � ��
 ���� 6/   �� 5a       � ��
 ���� 60   �� 5b       � ��$ 1q�64   �� 5c       � �� 5d      �� 5e      "  6*   .R�5f      �� #��z��6%   #��z��6O   #��z��6{   $

 True��6�   ._�5g   "   �� #
 z
 63   5h      5i      5k      / 5l      P� 5m       �@ 
IsSelected$
 True��64   . �5n      ��  � ��# � ��67   �� 5o       � ��# � ��67   �� 5p       � ��# � ��68   5q      P� 5r       �@J�IsKeyboardFocusWithin$
 True��6?   . �5s      ��  � ��# � 4 68   5t      ]� 5u      0 5v      �� 5w      1 �@ 
IsSelected$
2 true��6>   �� 5x      1 �@��IsSelectionActive$2 false��6N   ./�5z      ��  � ��# � /�67   �� 5{       � ��# � /�68   �� 5|       � ��# � .�67   5}      P� 5~       � {�$ false��63   . �5      ��  � ��# � ��67   5�      5�      �� 5�      " n�65   .�5�      ��  � ��$ 8��6*   �� 5�       � ��
 ���� 6/   �� 5�       �@�Cursor$ SizeWE��6+   �� 5�       � �� 5�      �� 5�      " n�6*   .R�5�      �� #��z��6%   # z��6O   5�      5�      5�      �� 5�      "  67   .�5�      ��  � ��$ Center=�6=   �� 5�       � �� 5�      �� 5�      "  6*   .R�5�      � .+�5�   "     #��z��6=   #��z��6g   #��z��6�   #5 z��6�   #7 z6 6�   #9 z8 6  # z��6E  #; z: 6i  #= z< 6�  #? z> 6�  ._�5�   &   �� #��z��67   $
��True��6z   #
 z
 6�   #��z��6�   5�   #   n� 5�   "   $@ PART_LeftHeaderGripper��6(   $
��Left=�6H   8��  6c   n� 5�   "   $@ PART_RightHeaderGripper��6(   $��Right=�6I   8�� 6e   5�      5�      5�      5�      �� 5�      "  6.   .�5�      ��  � ��# � ��6/   �� 5�       �@J�SnapsToDevicePixels$
 true��68   �� 5�       �@=�ErrorTemplate 6=   Z� �� 5�       �@ ValidationErrorTemplate 5�      �� 5�      .R�5�      �� 
���  ��$��2,0,0,0q�69   $��!��6J   $��Center=�6S   5�      5�      �� 5�       � �� 5�      �� 5�      "  6*   .R�5�      �� $A 
DGR_Border��6%   #��z��69   #��z��6c   #��z��6�   $

 True��6�   ._�5�   "      5�   &   �� 5�   *   $
��Auto �6;   �� 5�   *   $��* �6;    5�   &   �� 5�   *   $��* �68   �� 5�   *   $
��Auto �68   .+�5�   &   	  $��1��6=   #��zB 6M   #
 z
 6w   
  5�   &   $��1��6?   $��1��6O   #y�zC 6s  D 6\   �� *AreRowDetailsFrozen+# ZE # ZF  �� "  6s    5�   &   $��2��68   $D Vertical=�6I   y�6�   �� *HeadersVisibility+# ZG # Z  �� "  5�   #   5�      5�      5�      / 5�      P� 5�       �@ 	IsNewItem$
 True��63   . �5�      ��  � �� 63   �� *NewItemMargin+ �� "  5�      5�      5�      5�      