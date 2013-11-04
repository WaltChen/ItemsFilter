﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.CategoriesFilter
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class EqualFilter { }
#else

	public class EqualFilter : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public EqualFilter()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/Northwind.NET.Sample;component/SampleData/CategoriesFilter/CategoriesFilter.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private double _CountAttachedFilterControls = 0;

		public double CountAttachedFilterControls
		{
			get
			{
				return this._CountAttachedFilterControls;
			}

			set
			{
				if (this._CountAttachedFilterControls != value)
				{
					this._CountAttachedFilterControls = value;
					this.OnPropertyChanged("CountAttachedFilterControls");
				}
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		private bool _IsActive = false;

		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}

			set
			{
				if (this._IsActive != value)
				{
					this._IsActive = value;
					this.OnPropertyChanged("IsActive");
				}
			}
		}

		private CategoryCollection _AvailableValues = new CategoryCollection();

		public CategoryCollection AvailableValues
		{
			get
			{
				return this._AvailableValues;
			}
		}

		private CategoryCollection _SelectedValues = new CategoryCollection();

		public CategoryCollection SelectedValues
		{
			get
			{
				return this._SelectedValues;
			}
		}
	}

	public class Category : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		private string _Description = string.Empty;

		public string Description
		{
			get
			{
				return this._Description;
			}

			set
			{
				if (this._Description != value)
				{
					this._Description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}

		private System.Windows.Media.ImageSource _Picture = null;

		public System.Windows.Media.ImageSource Picture
		{
			get
			{
				return this._Picture;
			}

			set
			{
				if (this._Picture != value)
				{
					this._Picture = value;
					this.OnPropertyChanged("Picture");
				}
			}
		}
	}

	public class CategoryCollection : System.Collections.ObjectModel.ObservableCollection<Category>
	{ 
	}
#endif
}