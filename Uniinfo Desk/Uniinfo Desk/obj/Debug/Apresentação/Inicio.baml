   M S B A M L   `   `   `  ����G  CUniinfo Desk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Uniinfo_Desk.ApresentaçãoUniinfo_Desk.Apresentação  5   	   A%clr-namespace:Uniinfo_Desk.PropertiesUniinfo_Desk.Properties  5   	   (    "Uniinfo_Desk.Apresentação.Inicio   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Uniinfo_Desk.Apresentação     5   	   <
Properties%clr-namespace:Uniinfo_Desk.Properties     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6B   -   5          �Name$  
mnConsulta��5   �    � Title$ Chamados��5	   	   $��469.5��6   $��551.5��6)    � 
ResizeMode$ NoResize=�67   ���	#00000000���	#00000000���	#00000000 � Icon$ Home.png��6�   .��5
      � 
�������.+�5   
   &   System.Windows.Controls.DataGrid  $
��Left=�6   $	��100��6/   $��338,160,0,0q�6<   $	��Top=�6Q   $	��100��6i   =  7System.Windows.Controls.Primitives.DataGridColumnHeader  5   
   
���   �65     5   
   -   5          Name$
 grid��5      $
��Left=�6!   $	��397��6<   $��0,44,0,0q�6I   $	��Top=�6[   $	��530��6s      MinColumnWidth$ 1Q�6      RowHeaderWidth$	 NaNQ�6�   |�.  $ �� IsSynchronizedWithCurrentItem$ FalseY�6      GridLinesVisibility$ 
Horizontal=�6&  	   HorizontalGridLinesBrush	 �	#FF006DBE
   RowDetailsVisibilityMode$
 Visible=�6l     SelectionMode$ Single=�6�     VerticalGridLinesBrush �	#FF82A9C5   FrozenColumnCount$ 1��6�     CanUserReorderColumns .     HeadersVisibility$ Column=�6�  !   EnableColumnVirtualization .    
IsReadOnly .   �� IsTextSearchCaseSensitive . ��6�   Z� 6L  �� 5   
   $��Consulta de Chamados��6   $
��Left=�6/   $	��Top=�6J   ���	#FF006DBE$	��546��6y   $��Century)�6�   ���	#DDFFFFFF$��44��6�   $��22(�6�   �� 5   
   -   5         ��Name$ btnExibirChamado��5      $��Atualizar Lista��6+   $
��Left=�6E   $��	296,6,0,0q�6`   $	��Top=�6s   $	��146��6�    �� 	IsDefault . $��32��6�   ���	#FF006DBE���	#FFF9F4F4$��Medium"�6�   $��	Condensed&�6  &   System.Windows.Media.TextOptions   TextHintingMode$ Animated=�6(  $��Yu Gothic UI)�6O   J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6#      ShadowDepth$ 1Q�6;      Color$ 	#FF1232FF��6K   5      �� 5   
   -   5        $ 
btnLoggout��5      $�� ��6%   $
��Left=�60   $��
506,10,0,0q�6K   $	��Top=�6_   $��24��6w   $��25��6�   ��6�   Z� ��5      �� 5       �� ImageSource$ Imagens/Loggout.png��6    j� Stretch$ UniformToFill=�6?   5      5      5      