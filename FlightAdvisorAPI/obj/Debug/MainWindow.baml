   M S B A M L   `   `   `  ����K  GFlightAdvisorAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FlightAdvisorAPIFlightAdvisorAPI  5   	   G(clr-namespace:FlightAdvisorAPI.ViewModelFlightAdvisorAPI.ViewModel  5   	   =#clr-namespace:FlightAdvisorAPI.ViewFlightAdvisorAPI.View  5   	   !    FlightAdvisorAPI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:FlightAdvisorAPI     5   	   >	viewmodel(clr-namespace:FlightAdvisorAPI.ViewModel     5   	   4view#clr-namespace:FlightAdvisorAPI.View     5   	     � Title$  Flight Advisor��5
   	   $��550.964��6    $��1003.655��61    � 
ResizeMode$ NoResize=�6B    � WindowStartupLocation$ CenterScreen=�6X   .��5      � ��5   
   �� 5       j� Stretch$
 None=�6   .+�5   
   �� 
����� �$
��Left=�6'   $	��269��6B   $��
382,76,0,0q�6O   
���   �$	��Top=�6r   $	��238��6�   �� 5   
   -   5        $��usernameLogin��5   >   $��1q�6   
�����p�$
��Left=�6S   $��23��6n   $��409,147,0,0q�6z    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��185��6�   ��6�   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��	Username:��6   $��Center=�6$   $
��Bold"�6H   $
��Left=�6Z   $��459,116,0,0q�6u   $	��Top=�6�   $��80��6�   �� 5   
   $��	Password:��6   $��Center=�6$   $
��Bold"�6H   $
��Left=�6Z   $��459,198,0,0q�6u   $	��Top=�6�    J� RenderTransformOrigin$ -2.506,0.419&�6�   $��80��6�   �� 5   
   $��Flight Advisor��6   $��32(�6)   $
��Bold"�67   $��Center=�6I   $
��Left=�6m   $��	331,8,0,0q�6�   $	��Top=�6�   $��52��6�   $	��353��6�   �� 5   
   $��Italic$�6   $�� ��6#   $��18(�6.   $
��Bold"�6<   $��Center=�6N   $
��Left=�6r   $��
473,98,0,0q�6�   $	��Top=�6�   $��44��6�   $	��353��6�   G� 5   
   -   5        $��passBox��5      $��1q�6%   
�����p�$
��Left=�6Q   $	��Top=�6l   $ 32.711,8.415&�6�   $��409,229,0,0q�6�   $	��185��6�   $��23��6�   6�   �� 5   
   -   5        $��LoginButton��5      $��Login��6$   $
��Left=�64   $��409,287,0,0q�6O   $	��Top=�6d   $��85��6|   $��28��6�    �� 	IsDefault . ��6�   �� *LoginCommand+$ PropertyChanged=�6�   �� 5   
   -   5        $��RegisterButton��5      $��Register��6'   $
��Left=�6:   $��509,287,0,0q�6U   $	��Top=�6j   $��85��6�   $��28��6�   ��6�   �� *RegisterCommand+$ PropertyChanged=�6�   5      5      