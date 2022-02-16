using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PornHub.Branding
{
	// Token: 0x0200003A RID: 58
	internal static class GetControls
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0001DE68 File Offset: 0x0001C068
		public static IEnumerable<T> FindAllChildrenByType<T>(this Control control)
		{
			IEnumerable<Control> source = control.Controls.Cast<Control>();
			return source.OfType<T>().Concat(source.SelectMany((Control ctrl) => ctrl.FindAllChildrenByType<T>()));
		}
	}
}
