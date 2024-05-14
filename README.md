When demonstrating a SfDataGrid with a custom column template of GridTemplateColumn containing a SfComboBox, and when binding the SelectedItem property of the SfComboBox using CommunityToolkit.WinUI.FrameworkElementExtensions, the target property to which SfComboBox.SelectedItem is bound is always null. However, when using the same approach with CommunityToolkit.WinUI.UI.Controls.DataGrid, it operates normally.

The following is a demonstration animation:
![SfDataGrid Error Demo2](https://github.com/weiyoucheng/SfDataGrid_GridTemplateColumn_Test/assets/112521929/05789b57-595d-4c75-98ee-0868f44c33f3)
