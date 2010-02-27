﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Fujiy.ExtensionMethods
{
    public static class InterfaceEnumerableExtension
    {
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first,
                                                           IEnumerable<TSource> second, Func<TSource, TSource, bool> comparer, Func<TSource, int> hashFunction)
        {
            return first.Except(second, new LambdaComparer<TSource>(comparer, hashFunction));
        }
    }
}


