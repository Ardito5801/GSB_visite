   M S B A M L   `   `   `  ����F  BWpfGSBFrais, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfGSBFraisWpfGSBFrais  5   	       WpfGSBFrais.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfGSBFrais     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5        $��Maingrid��5	      .+�5
   
   	� -   5         	�Name$ radioButton��5
      $��Créée��6+   $
��Left=�6X   $��
190,24,0,0q�6s   $	��Top=�6�    J� RenderTransformOrigin$ -0.116,0.344&�6�    d� 	IsChecked 6;   �� *IsCree+6�   	� 5   
   -   5        $ radioButton1��5      $��	Cloturée��6,   $
��Left=�6`   $��
315,24,0,0q�6{   $	��Top=�6�    6?   �� *	IsCloture+6�   	� 5   
   -   5        $ radioButton2��5      $�� Validée/Paiement��6,   $
��Left=�6f   $��
470,24,0,0q�6�   $	��Top=�6�    6H   �� *	IsValid+6�   	� 5   
   -   5        $ radioButton4��5      $��Remboursée��6,   $
��Left=�6`   $��
670,24,0,0q�6{   $	��Top=�6�    6A   �� *
IsRefund+6�   �� 5   
   -   5         ��Name$ comboBoxMois��5      $
��Left=�6v   $��	28,18,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6)   �� *MoisFicheFrais+ �� SelectedItem 6P   �� *SelectedMois+6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ LigneFraisHorsForfait��5      $
��Left=�6�   $��
357,48,0,0q�6�   $	��Top=�6�   $	��134��6�   $	��425��6�   ��62   �� *ListLigneFraisHorsForfait+ 6e   �� *SelectedLFHF+6�   �� 5   
   -   5         ��Name$ label��5      $��Repas��6   $
��Left=�6/   $��363,200,0,0q�6J   $	��Top=�6_   $ 1.024,0.654&�6w   �� 5   
   -	   5        $ label1��5      $��Nuités��6    $
��Left=�61   $��361,231,0,0q�6L   $	��Top=�6a   �� 5   
   -
   5        $ label2��5      $��Frais Km��6    $
��Left=�63   $��361,262,0,0q�6N   $	��Top=�6c   �� 5   
   -   5        $ label3��5      $��Forfait étape��6    $
��Left=�68   $��361,293,0,0q�6S   $	��Top=�6h   �� 5   
   -   5         ��Name$ listFicheFrais��5      $
��Left=�6}   $	��365��6�   $��	10,45,0,0q�6�   $	��Top=�6�   $	��342��6�   ��6*   �� *ListFicheFrais+ 6Q   �� *SelectedFicheFrais+6�   �� 5   
   -   5        	 ��Name$	 textBox��5      $
��Left=�6#   $��23��6>   $��410,203,0,0q�6J   
 �� TextWrapping$

 Wrap=�6_   $	��Top=�6�   $	��120��6�   ��6s   �� *Repas+6�   �� 5   
   -   5        $	 textBox1��5      $
��Left=�6$   $��24��6?   $��410,233,0,0q�6K   $

 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   �� *Nuite+6�   �� 5   
   -   5        $	 textBox2��5      $
��Left=�6$   $��24��6?   $��421,264,0,0q�6K   $

 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   �� *	Fraiskm+6�   �� 5   
   -   5        $	 textBox3��5      $
��Left=�6$   $��23��6?   $��443,296,0,0q�6K   $

 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   �� *Forfaitetape+6�   �� 5   
   -   5         ��Name$ button��5      $��Enregistrer��6!   $
��Left=�6]   $��427,352,0,0q�6x   $	��Top=�6�   $��75��6�   ��67   �� *ButtonEnregistrer+6�   �� 5   
   -   5        $ button1��5      $��Reporter��6"   $
��Left=�6X   $��543,352,0,0q�6s   $	��Top=�6�   $��75��6�   ��65   �� *ButtonReporter+6�   �� 5   
   -   5        $ button2��5      $��	Supprimer��6"   $
��Left=�6[   $��656,352,0,0q�6v   $	��Top=�6�   $��75��6�   ��66   �� *ButtonSupprimer+6�   5      5      