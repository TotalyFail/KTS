   M S B A M L   `   `   `  ����>  :KTS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KTSKTS  5          KTS.KTSRegister   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:KTS     5        N� Title$  KTSRegister��5
      ��5      �� *&$SystemParameters.PrimaryScreenHeight+��5	      �� *%#SystemParameters.PrimaryScreenWidth+.��5      � ��5   
   �� 5       �� ImageSource$ BlueBackground.png��6   .+�5   
   �� -   5         ��Name$ button1��5         btnBlue#��[  6#   $��Prideti vartotoja��6D   $
��Left=�6`   $��163,271,0,0q�6{   $	��Top=�6�   $	��125��6�   6�   �� 5   
   -   5         ��Name$ textboxSamAccountName��5      $
��Left=�61   $��22��6L   $��
136,41,0,0q�6X    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��150��6�   $��5��6�   �� 5   
   $��Name: ��6   $
��Left=�6!   $��	79,94,0,0q�6<   $	��Top=�6O   �� 5   
   $��	Password:��6   $
��Left=�6$   $��	66,67,0,0q�6?   $	��Top=�6R   $��61��6j   �� 5   
   $��SamAccountName: ��6   $
��Left=�6+   $��	17,39,0,0q�6F   $	��Top=�6Y   $	��110��6q   �� 5   
   -   5        $ textboxName��5      $
��Left=�6'   $��23��6B   $��
136,96,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��150��6�   $��7��6�   �� 5   
   -   5        $ textboxPhoneNumber��5      $
��Left=�6.   $��23��6I   $��136,123,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��150��6�   $��8��6�   �� 5   
   -   5        $ textboxSurname��5      $
��Left=�6*   $��24��6E   $��136,149,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��150��6�   $��9��6�   �� 5   
   $��
Tel. Nr.: ��6   $
��Left=�6%   $��
79,120,0,0q�6@   $	��Top=�6T   $��48��6l   $��27��6w   �� 5   
   $��	Surname: ��6   $
��Left=�6$   $��
66,148,0,0q�6?   $	��Top=�6S   $��61��6k   �� 5   
   -   5        $ textboxDescription��5      $
��Left=�6.   $��22��6I   $��136,207,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��150��6�   $��11��6�   �� 5   
   $��Description: ��6   $
��Left=�6(   $��
54,205,0,0q�6C   $	��Top=�6W   $��73��6o   	� 5   
   -   5         	�Name$ radiobuttonEnable��5      $��Enable User��61   $
��Left=�6G   $��160,241,0,0q�6b   $	��Top=�6w    d� 	IsChecked$
 TrueY�6�   G� 5   
   -   5         G�Name$ passwordboxUserPass��5      $
��Left=�63   $��24��6N   $��
136,69,0,0q�6Z   $	��Top=�6n   $	��150��6�   $��6��6�   �� 5    
   -	   5        $ textboxLonOnName��5       $
��Left=�6,   $��22��6G   $��	136,9,0,0q�6S   $
 Wrap=�6f   $	��Top=�6z   $	��150��6�   $��4��6�   �� 5!   
   $��Logon Name:��6   $
��Left=�6&   $��45,9,0,0q�6A   $	��Top=�6S   $��86��6k   �� 5"   
   -
   5        $ textboxDisplayName��5"      $
��Left=�6.   $��24��6I   $��136,177,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��150��6�   $��10��6�   �� 5#   
   $��Display Name:��6   $
��Left=�6(   $��
41,176,0,0q�6C   $	��Top=�6W   $��86��6o   �� 5$   
   $��User to delete:��6   $
��Left=�6*   $��
360,10,0,0q�6E   $	��Top=�6Y   $��86��6q   �� 5%   
   -   5        $ username��5%      $
��Left=�6$   $��22��6?   $��
450,10,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��153��6�   $��1��6�   �� 5&   
   -   5        #��[  5&   .   $
��Left=�6O   $	��Top=�6j   $��50��6�   $	��153��6�   $��
450,50,0,0q�6�   $��1��6�   .��6�   Vartotojo trynimas6�   5'      5(      