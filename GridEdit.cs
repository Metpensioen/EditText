using System.Windows.Controls;

using static EditText;

class GridEdit : Grid
{
    public Grid EditInit()
    {
        Children.Add(editText.TextInit());

        return this;
    }

    public void EditDone()
    {
        editText.TextSave();
    }

    public static GridEdit gridEdit = new GridEdit();
}