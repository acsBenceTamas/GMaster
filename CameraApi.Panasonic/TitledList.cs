﻿using System.Collections.Generic;
using GMaster.Core.Tools;

namespace CameraApi.Panasonic
{
    public class TitledList<TItem> : HashCollection<TItem>
        where TItem : IStringIdItem
    {
        public TitledList()
        {
        }

        public TitledList(IEnumerable<TItem> collection, string title)
            : base(collection)
        {
            Title = title;
        }

        public string Title { get; }
    }
}