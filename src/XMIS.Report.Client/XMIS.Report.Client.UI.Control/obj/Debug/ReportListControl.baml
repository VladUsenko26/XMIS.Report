   M S B A M L   `   `   `  ����X  TXMIS.Report.Client.UI.Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:XMIS.Report.Client.UI.ControlXMIS.Report.Client.UI.Control  5      5    /XMIS.Report.Client.UI.Control.ReportListControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:XMIS.Report.Client.UI.Control     5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  $��10q�5          GridLinesVisibility$
  None=�5         CanUserAddRows .     CanUserSortColumns .     CanUserResizeRows .     
IsReadOnly .    AutoGenerateColumns .     SelectionUnit$ FullRow=�5      ��. $
��Auto=�5      ��5
      �� *	Reports+ �� SelectedItem 5      ��  �� Path$ SelectedReport�	 �� Mode$	 TwoWay=�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# Название отчета��6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ReportDisplayName+6K     5         
Visibility$ Hidden=�6B    6%   �� *
ReportId+6B     5      $ Hidden=�6D    6%   �� *
ReportName+6D   5      5      5      