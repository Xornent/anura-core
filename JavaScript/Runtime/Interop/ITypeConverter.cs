﻿using System;

namespace Anura.JavaScript.Runtime.Interop
{
    public interface ITypeConverter
    {
        object Convert(object value, Type type, IFormatProvider formatProvider);
        bool TryConvert(object value, Type type, IFormatProvider formatProvider, out object converted);
    }
}
