using Syncfusion.Maui.Calendar;
namespace Stethoscope;

public partial class HistoryPage : ContentPage
{
	public HistoryPage()
	{
		InitializeComponent();
		SfCalendar calendar  = new SfCalendar();
		this.Content = calendar;
	}
}