   M S B A M L   `   `   `  ����  	WPFAgenda!    WPFAgenda.Views.ContatoView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ContatoView��5   	   $	��400��6   $	��320��6)   .��5      � $��5q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5	      $��5 �6   6+   �� 5
      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��30 �6   6*   �� 5      $
��Auto �6   6,   �� 5      $��30 �6   6*   �� 5      $
��Auto �6   6,   �� 5      $��30 �6   6*   �� 5      $
��Auto �6   6,   �� 5      $��30 �6   6*   �� 5      $
��Auto �6   6,   .+�5   
   �� $��0��5      $��0��6   $��Nome:��5      $
��Left=�5       �� Target 5      ��  �� ElementName$ nomeTxt���� 5   
   -   5         ��Name$ 
nomeomeTxt��5       $��0��5!      $��2��6   ��5"      ��  �� Path$ Contato.Nome� �� UpdateSourceTrigger$ PropertyChanged=��� 5%   
   $��2��5&      $��0��6   $��
Sobrenome:��5'      $
��Left=�5(       5)      �� $ sobrenomeTxt���� 5+   
   -   5        $ sobrenomeTxt��5,      $��2��5-      $��2��6   ��5.      �� $ Contato.Sobrenome�$ PropertyChanged=��� 51   
   $��4��52      $��0��6   $��E-mail:��53      $
��Left=�54       55      �� $ emailTxt���� 57   
   -   5        $ emailTxt��58      $��4��59      $��2��6   ��5:      �� $ Contato.Email�$ PropertyChanged=��� 5=   
   $��6��5>      $��0��6   $��	Twitter::��5?      $
��Left=�5@       5A      �� $ 
twitterTxt���� 5C   
   -   5        $ 
twitterTxt��5D      $��6��5E      $��2��6   ��5F      �� $ Contato.Twitter�$ PropertyChanged=��� 5I   
   $��8��5J      $��2��6   $��_Salvar��5L      $��Right=�5M      $��6q�5N      $��5q�5O      $��60��5P      ��5K      �� $ SalvarCommand�5P      5R      5S      