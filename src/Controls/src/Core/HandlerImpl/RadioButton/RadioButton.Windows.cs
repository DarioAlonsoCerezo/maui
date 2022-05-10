﻿#nullable enable

using Microsoft.UI.Xaml;
using Windows.Foundation;

namespace Microsoft.Maui.Controls
{
	public partial class RadioButton
	{
		public static void MapContent(RadioButtonHandler handler, RadioButton radioButton)
		{
			if (radioButton.ResolveControlTemplate() != null)
			{
				handler.PlatformView.Style =
					UI.Xaml.Application.Current.Resources["RadioButtonControlStyle"] as UI.Xaml.Style;
			}
			else
			{
				handler.PlatformView.Style = null;
			}

			RadioButtonHandler.MapContent(handler, radioButton);
		}
	}
}
