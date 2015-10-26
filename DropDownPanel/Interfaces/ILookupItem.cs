using System;

namespace YongFa365.Controls.ComboBoxTree
{
	public interface ILookupItem<T> where T: struct
	{
		T		Id		{ get; }
		string	Text	{ get; }
	}
    
}
