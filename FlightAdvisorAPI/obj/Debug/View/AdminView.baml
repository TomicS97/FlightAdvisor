   M S B A M L   `   `   `  ����K  GFlightAdvisorAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightAdvisorAPI.ViewFlightAdvisorAPI.View  5      %    FlightAdvisorAPI.View.AdminView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FlightAdvisorAPI.View     5      .��5	      � .+�5
   
   �� $
��Left=�6   $	��490��60   $	��Top=�6=   $	��972��6U   $��	10,10,0,0q�6a   $��2��6t   .@�5      �� $��Add City��6   $	��200��6(   .��5      � ��5      �� 5        �� ImageSource$&   /images/Srdjan_FlightAdvisor.jpg��6%    j� 
AlignmentX$
 Left=�6T    j� 
AlignmentY$	 Top=�6f    j� Stretch$ UniformToFill=�6w   .+�5      �� $
��Bold"�6   $��
City name:��6.   $
��Left=�6C   $��	92,58,0,0q�6^   $	��Top=�6q   $��25��6�   $	��107��6�   �� 5      $
��Bold"�6   $��Country name:��6.   $
��Left=�6F   $��	92,88,0,0q�6a   $	��Top=�6t   $��25��6�   $	��107��6�   �� 5      $
��Bold"�6   $��Description:��6.   $
��Left=�6E   $��
92,143,0,0q�6`   $	��Top=�6t   $��25��6�   $	��107��6�   �� 5      $
��Left=�6   $��23��69   $��
241,58,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6�   $	��222��6�   $��2��6�   ��6m   �� *
CityName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $
��Left=�6   $��23��69   $��
241,88,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6�   $	��222��6�   $��2��6�   ��6m   �� *CountryName+$ PropertyChanged=�6�   �� 5       J� Opacity$	 0.6Q�6   $
��Left=�6,   $	��198��6G   $��241,143,0,0q�6T   $
 Wrap=�6i   $	��Top=�6�   $	��335��6�    J� RenderTransformOrigin$ 0.658,0.506&�6�   $��2��6  ��6}   �� *DescriptCity+$ PropertyChanged=�6  �� 5       �� 	IsDefault . $��Add city��6.   $
��Left=�6A   $��213,382,0,0q�6\   $	��Top=�6q   $��85��6�   $��28��6�   $��1��6�   ��6�   �� *	AddCity+$ PropertyChanged=�6�   �� 5      -   5        $��Log Out��5      $
��Left=�6/   $��
584,10,0,0q�6J   $	��Top=�6^   $��85��6v   $��28��6�   $��1��6�   ��6�   �� *Logout+$ PropertyChanged=�6�   5      5      �� 5      $��
ImportData��6   $	��200��6*   .��5      � ��5      �� 5      $
 Left=�6%   $	 Top=�67   $
 Fill=�6H   .+�5       �� 
�������$	 0.7Q�65   
���   �$��1q�6W   $
��Left=�6k   $	��178��6�   $��	59,63,0,0q�6�   $	��Top=�6�   $	��320��6�   �� 5!      
�������$	 0.7Q�65   
���   �$��1q�6W   $
��Left=�6k   $	��178��6�   $��
564,63,0,0q�6�   $	��Top=�6�   $	��320��6�   �� 5"      
�������$
��Bold"�63   $��Import airports file: ��6E   $
��Left=�6f   $��	90,98,0,0q�6�   $	��Top=�6�   $	��167��6�   �� 5#      
�������$
��Bold"�63   $��Import routes file: ��6E   $
��Left=�6d   $��
574,98,0,0q�6   $	��Top=�6�   $	��167��6�   �� 5$      -   5        $��RoutesFileRoute��5$      $
��Left=�65   $��26��6P   $��574,147,0,0q�6\   $
 Wrap=�6q   $�� ��6�   $	��Top=�6�   $	��291��6�   �� 5%      -   5        $��airportBrowseButton��5%   ^   $��Browse..��6y   $
��Left=�6�   $��
285,98,0,0q�6�   $	��Top=�6�   $��75��6�   $��26��6�   ��6   �� *Browse+$ PropertyChanged=�6�   �� 5&      -   5        $��routesBrowseButton��5&   _   $��Browse..��6y   $
��Left=�6�   $��
790,98,0,0q�6�   $	��Top=�6�   $��75��6�   $��26��6�   ��6   �� *	Browse2+$ PropertyChanged=�6�   �� 5'      -   5        	 ��Name$!	 airportBrowseButton_Confirm��5'      $��Import��6B   $
��Left=�6S   $��285,196,0,0q�6n   $	��Top=�6�   $��75��6�   $��26��6�   �� 5(      -   5        $ 	 routesBrowseButton_Confirm��5(      $��Import��6A   $
��Left=�6R   $��790,196,0,0q�6m   $	��Top=�6�   $��75��6�   $��26��6�   �� 5)      -   5        $��HomepageButton��5)      $��Log Out��63   $
��Left=�6E   $��
868,10,0,0q�6`   $	��Top=�6t   $��79��6�   $��26��6�   ��6�   �� *Logout+$ PropertyChanged=��� 5*      $
��Left=�6   $��
90,147,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $��26��6�   $	��270��6�   ��6a   �� *IspisPutanje+
 �� Mode$
 TwoWay=�$ PropertyChanged=�6�   5-      5.      5/      50      51      