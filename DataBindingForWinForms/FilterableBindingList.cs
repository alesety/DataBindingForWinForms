using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataBindingForWinForms
{
    public class FilterableBindingList<T> : BindingList<T>
    {
        public Predicate<T> Filter
        {
            get { return _filter; }
            set
            {
                _filter = value;
                OnListChanging();
            }
        }
        private Predicate<T> _filter;

        private IList<T> _dataSource;

        public FilterableBindingList(IList<T> dataSource)
        {
            _dataSource = dataSource;
            InitializeEvent();
            OnListChanging();
        }

        private void InitializeEvent()
        {
            if (_dataSource is IBindingList)
            {
                ((IBindingList)_dataSource).ListChanged += (s, e) => OnListChanging();
            }
        }

        private void OnListChanging()
        {
            Clear();
            foreach (var item in _dataSource)
            {
                if (Filter?.Invoke(item) ?? true)
                {
                    Add(item);
                }
            }
        }
    }
}
