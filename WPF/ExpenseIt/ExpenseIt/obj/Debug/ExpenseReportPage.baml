   M S B A M L   `   `   `  ����  	ExpenseIt!    ExpenseIt.ExpenseReportPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  ExpenseIt - View Expense��5      .��5	      �  � 	Resources 5   
      typeItemTemplate �� XPath  amountItemTemplate��%�   &	        &	 I     �� 5      .R�5      �� ��6   �� $ @ExpenseType��5      �� 5      .R�5      �� ��6   �� $ @ExpenseAmount��5      5      ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5    
   �� $��1��6     headerTextStyle#��[ 6    .��6I   Expense Report For:5"      � 5#   
   $��10q�6   $��1��6   $��1��6+    5$      �� 5%      �� 5&       5(      �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      .+�5.      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�5/      .+�50      ��   
labelStyle#��[ 6   .��6<   Name:6C   �� 51      #��[ 6   ��6=   �� $ @Name��52      53      �� 55      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�56      .+�57      �� #��[ 6   .��6<   Department:6I   �� 58      #��[ 6   ��6<   �� $ @Department��59      5:      � 5;      $��0��6   $��2��6#   $��2��67   $	��Top=�5<      $
��Left=�5=      .+�5?      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 5@         AutoGenerateColumns .  	   RowHeaderWidth$	 0Q�5A      ��5?      �� $ Expense��
   Columns
 5B      0  *System.Windows.Controls.DataGridTextColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� $ @ExpenseType��  5E      $ Amount��6-    6=   �� $ @ExpenseAmount��5H      5I      5J      5K      5L      