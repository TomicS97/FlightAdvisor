   M S B A M L   `   `   `  ����K  GFlightAdvisorAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightAdvisorAPI.ViewFlightAdvisorAPI.View  5   	   G(clr-namespace:FlightAdvisorAPI.ViewModelFlightAdvisorAPI.ViewModel  5   	   #    FlightAdvisorAPI.View.Regular   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FlightAdvisorAPI.View     5   	   >	viewmodel(clr-namespace:FlightAdvisorAPI.ViewModel     5   	   $	��540��5	   	   $
��1000��6   .��5      � 
�������.+�5   
   �� $
��Left=�6   $	��490��60   $	��Top=�6=   $	��972��6U   $��	10,10,0,0q�6a   $��2��6t   .@�5      �� $��
All Cities��6   $	��200��6*   .��5      � ��5      �� 5        �� ImageSource$&   /images/Srdjan_FlightAdvisor.jpg��6%    j� 
AlignmentX$
 Left=�6T    j� 
AlignmentY$	 Top=�6f    j� Stretch$ UniformToFill=�6w   .+�5      �� $
��Left=�6   $��26��6:   $��
116,10,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6�   $	��252��6�   ��6n   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $
��Bold"�6   $��Search city:��6.   $
��Left=�6F   $	��Top=�6a   $��	10,10,0,0q�6y   &   System.Windows.Controls.DataGrid  5      -   5        $��AllCitiesgrid��5   O      
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 61    J� Opacity$	 0.8Q�6A   $
��Left=�6�   $	��354��6  $��	10,94,0,0q�6%  $	��Top=�68  $	��588��6P  ��6d   �� *
CitiesList+$ PropertyChanged=�	 �� SelectedItem	 6�   �� *
Selected+
 �� Mode$
 TwoWay=�$ PropertyChanged=� � 	Resources 5      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value��%w   '        �� 5      "  6$   .�5   "   ��  � ��
 �����6?   �� 5   "    � ��$ 1q�6;   5      5      5$        5%      -   5        $��Commentgrid��5%   �    . $ * 61   $	 0.8Q�6�   $
��Left=�6  $	��321��6'  $��
603,94,0,0q�64  $	��Top=�6H  $	��349��6`  ��6A   �� *CommentList+$
 TwoWay=�$ PropertyChanged=�	 6�   �� *SelectedCom+$
 TwoWay=�$ PropertyChanged=�5.      �� 5/      $	��Add��6   $
��Left=�6+   $��694,420,0,0q�6F   $	��Top=�6[   $��75��6s   $��28��6~   ��6�   �� *
AddComment+$ PropertyChanged=��� 50      $
��Edit��6   $
��Left=�6,   $��785,420,0,0q�6G   $	��Top=�6\   $��75��6t   $��28��6   ��6�   �� *EditComment+$ PropertyChanged=��� 51      $��Delete��6   $
��Left=�6.   $��877,420,0,0q�6I   $	��Top=�6^   $��75��6v   $��28��6�   ��6�   �� *DeleteComment+$ PropertyChanged=��� 52      $��Log Out��6   $
��Left=�6/   $��
862,10,0,0q�6J   $	��Top=�6^   $��90��6v   $��26��6�   ��6�   �� *	LogOutt+$ PropertyChanged=��� 53      $��Show All��6   $
��Left=�60   $��	10,50,0,0q�6K   $	��Top=�6^   $��75��6v   $��26��6�   ��6�   �� *ShowAllCity+$ PropertyChanged=��� 54      $��Search��6   $
��Left=�6.   $��
430,10,0,0q�6I   $	��Top=�6]   $��75��6u   $��26��6�   ��6�   �� *
SearchCity+$ PropertyChanged=��� 55      $
��View��6   $
��Left=�6,   $��603,420,0,0q�6G   $	��Top=�6\   $��75��6t   $��28��6   ��6�   �� *WholeComment+$ PropertyChanged=�56      57      �� 59      $��Book your flight��6   $	��200��60   .��5:      � ��5;      �� 5<      $
 Left=�6%   $	 Top=�67   $
 Fill=�6H   .+�5>         . $ * 62   $	 0.8Q�6B   $
��Left=�6P   $	��353��6k   $��	10,95,0,0q�6x   $	��Top=�6�   $	��805��6�   ��6�   �� *
FlightList+$ PropertyChanged=�	 6�   �� *SelectedFlight+$
 TwoWay=�$ PropertyChanged=�5@      �� 5A      $
��Bold"�6   $��Flying from: ��6.   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   �� 5B      $
��Bold"�6   $��Flying to: ��6.   $
��Left=�6D   $��	10,64,0,0q�6_   $	��Top=�6r   �� 5C      $
��Left=�6   $��26��69   $��	97,10,0,0q�6E   $
 Wrap=�6X   $	��Top=�6�   $	��306��6�   ��6l   �� *FlFrom+$ PropertyChanged=�6�   �� 5D      $
��Left=�6   $��26��69   $��	97,64,0,0q�6E   $
 Wrap=�6X   $	��Top=�6�   $	��306��6�   ��6l   �� *FlTo+$ PropertyChanged=�6�   �� 5E       �� 	IsDefault . $��Search��6.   $
��Left=�6?   $��
563,64,0,0q�6Z   $	��Top=�6n   $	��111��6�   $��26��6�   ��6�   �� *
ShowFlight+$ PropertyChanged=��� 5F      $��Log Out��6   $
��Left=�6/   $��
862,10,0,0q�6J   $	��Top=�6^   $��90��6v   $��26��6�   ��6�   �� *	LogOutt+$ PropertyChanged=��� 5G      $��	Book Now!��6   $
��Left=�61   $��837,389,0,0q�6L   $	��Top=�6a   $��97��6y   $��31��6�   5H      5I      5J      5K      5L      