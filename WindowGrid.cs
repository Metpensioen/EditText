using System.Windows;
using System.Windows.Controls;

using static GridEdit;
using static GridMenu;

class WindowGrid : Grid
{
    public Grid GridInit()
    {
        for (int i = 1; i <= 2; i++) // maak 2 rijen
        {
            RowDefinitions.Add(new RowDefinition());
        }

        RowDefinitions[0].Height = new GridLength(30);

        Children.Add(gridMenu.MenuInit());
        Children.Add(gridEdit.EditInit());

        Grid.SetRow(gridEdit, 1);

        return this;
    }

    public void GridDone()
    {
        gridEdit.EditDone();
    }

    public static WindowGrid windowGrid = new WindowGrid();
}