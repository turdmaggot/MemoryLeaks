using Syncfusion.Maui.DataGrid;

namespace MemoryLeaks;

public partial class DataGridPage : BasePage
{
	public DataGridPage()
	{
		InitializeComponent();

		BindingContext = new DataGridViewModel();        
    }

}