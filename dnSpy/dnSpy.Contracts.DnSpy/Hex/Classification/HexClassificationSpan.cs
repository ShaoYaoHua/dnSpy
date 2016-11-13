﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace dnSpy.Contracts.Hex.Classification {
	/// <summary>
	/// Classification type and span
	/// </summary>
	public struct HexClassificationSpan {
		/// <summary>
		/// Gets the span
		/// </summary>
		public Span Span { get; }

		/// <summary>
		/// Gets the classification type
		/// </summary>
		public IClassificationType ClassificationType { get; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="span">Span</param>
		/// <param name="classification">Classification type</param>
		public HexClassificationSpan(Span span, IClassificationType classification) {
			if (classification == null)
				throw new ArgumentNullException(nameof(classification));
			Span = span;
			ClassificationType = classification;
		}
	}
}
