   M S B A M L   `   `   `  ����K  GFlightAdvisorAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightAdvisorAPI.ViewFlightAdvisorAPI.View  5      $    FlightAdvisorAPI.View.Register   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FlightAdvisorAPI.View     5      .��5      � ��5   
   �� 5        �� ImageSource$&   /images/Srdjan_FlightAdvisor.jpg��6    j� 
AlignmentX$ Right=�6H    j� 
AlignmentY$ Center=�6[    j� Stretch$ UniformToFill=�6o   .+�5   
   �� $��14(�6   $��First name:��6   $
��Left=�64   $��	76,57,0,0q�6O   $	��Top=�6b    J� RenderTransformOrigin$ -3.838,-1.972&�6z   $	��100��6�   $��32��6�   �� 5   
   $��14(�6   $��
Last name:��6   $
��Left=�63   $��	76,99,0,0q�6N   $	��Top=�6a   $ -3.838,-1.972&�6y   $	��100��6�   $��30��6�   �� 5   
   $��14(�6   $��	Username:��6   $
��Left=�62   $��
76,149,0,0q�6M   $	��Top=�6a   $ -3.838,-1.972&�6y   $	��100��6�   $��30��6�   �� 5   
   $��14(�6   $��	Password:��6   $
��Left=�62   $��
76,187,0,0q�6M   $	��Top=�6a   $ -3.838,-1.972&�6y   $	��100��6�   $��34��6�   �� 5   
   $y�Hidden=�6   $��14(�6$   $��Salt:��62   $
��Left=�6B   $��
76,256,0,0q�6]   $	��Top=�6q   $ -3.838,-1.972&�6�   $	��100��6�   $��30��6�   �� 5   
   -   5        $��FirstNameInput��5   >   $��1q�6   
�����p�$
��Left=�6T   $��29��6o   $��
201,60,0,0q�6{    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��188��6�   ��6�   �� *	Firstname+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $��LastNameInput��5   >   $��1q�6   
�����p�$
��Left=�6S   $��29��6n   $��201,100,0,0q�6z   $
 Wrap=�6�   $	��Top=�6�   $	��188��6�   ��6�   �� *
Lastname+$ PropertyChanged=�6�   �� 5   
   -   5        $��UserNameInput��5   >   $��1q�6   
�����p�$
��Left=�6S   $��30��6n   $��201,149,0,0q�6z   $
 Wrap=�6�   $	��Top=�6�   $	��188��6�   ��6�   �� *
Username+$ PropertyChanged=�6�   G� 5   
   -   5        $��PasswordInput��5   B   $��1q�6   
�����p�$
��Left=�6W   $	��Top=�6r   $ 0,0.583&�6�   $��201,192,0,0q�6�   $��29��6�   $	��188��6�   6�   �� 5   
   -   5        $��	SaltInput��5   '   $y�Hidden=�6   $
��Left=�68   $��29��6S   $��201,257,0,0q�6_   $	��Top=�6t   $	��188��6�   �� 5   
   -   5        $��RegFinishBtn��5   "    �� 	IsDefault . $��Register��66   $
��Left=�6I   $��201,362,0,0q�6d   $	��Top=�6y   $	��188��6�   $��27��6�   ��6�   �� *	AddUser+$ PropertyChanged=��� 5   
   -   5        $��
RegExitBtn��5      $��Back to Login��6#   $
��Left=�6;   $��
49,362,0,0q�6V   $	��Top=�6j   $��96��6�   $��27��6�   ��6�   �� *	LoginPage+$ PropertyChanged=�5      5      