using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DataBindingForWinForms
{
    internal class MainPresenter
    {
        private MainView _view;
        private BindingList<GridItemViewModel> _gridItemList;
        private FilterableBindingList<GridItemViewModel> _filteredList;

        public MainPresenter(MainView view)
        {
            _view = view;
            _gridItemList = new BindingList<GridItemViewModel>();
            _filteredList = new FilterableBindingList<GridItemViewModel>(_gridItemList);

            InitializeEvent();
            InitializeBind();
        }

        private void InitializeEvent()
        {
            _view.InsertButton.Click += OnInsertButtonClick;
            _view.ClearButton.Click += OnClearButtonClick;
            _view.OKButton.Click += OnOKButtonClick;
            _view.EvenButton.Click += OnEvenButtonClick;
            _view.OddButton.Click += OnOddButtonClick;
            _view.AllButton.Click += OnAllButtonClick;
        }

        private void OnEvenButtonClick(object sender, EventArgs e)
        {
            _filteredList.Filter = (x) => x.Id % 2 == 0;
        }

        private void OnOddButtonClick(object sender, EventArgs e)
        {
            _filteredList.Filter = (x) => x.Id % 2 == 1;
        }

        private void OnAllButtonClick(object sender, EventArgs e)
        {
            _filteredList.Filter = null;
        }

        private void OnInsertButtonClick(object sender, EventArgs e)
        {
            var id = int.Parse(_view.IdTextBox.Text);
            var name = _view.NameTextBox.Text;
            _gridItemList.Add(new GridItemViewModel { Id = id, Name = name });
        }

        private void OnClearButtonClick(object sender, EventArgs e)
        {
            _gridItemList.Clear();
        }

        private void OnOKButtonClick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Assert(true);
        }

        private void InitializeBind()
        {
            _view.DataGridView.DataSource = _filteredList;
        }
    }
}
