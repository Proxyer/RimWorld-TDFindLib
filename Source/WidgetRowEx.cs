﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using UnityEngine;

namespace TD_Find_Lib
{
	public static class WidgetRowEx
	{
		public static Rect GetRect(this WidgetRow row, float width, float gap = WidgetRow.DefaultGap)
		{
			Rect result = new Rect(row.FinalX, row.FinalY, width, WidgetRow.IconSize + gap);
			row.Gap(width);
			return result;
		}

		public static bool CheckboxLabeled(this WidgetRow row, string label, ref bool val, float gap = WidgetRow.DefaultGap)
		{
			bool before = val;
			row.Label(label);
			Rect butRect = row.GetRect(WidgetRow.IconSize);
			Widgets.Checkbox(butRect.x, butRect.y, ref val);
			row.Gap(gap);
			return before != val;
		}
	}
}
