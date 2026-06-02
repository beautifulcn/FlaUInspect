using FlaUInspect.Core;
using FlaUInspect.Properties;

namespace FlaUInspect.ViewModels;

public class AboutViewModel : ObservableObject, IDialogViewModel {
	public string Title { get; } = Resources.AboutFlaUInspect;
	public string CloseButtonText { get; } = Resources.Ok;
	public string SaveButtonText { get; } = "";
	public bool IsSaveVisible { get; }
	public bool IsCloseVisible { get; } = true;
	public bool CanClose { get; } = true;

	public void Save() {
	}

	public void Close() {
	}
}