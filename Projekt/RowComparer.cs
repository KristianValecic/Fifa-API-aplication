using System.Windows.Forms;

namespace Projekt
{
    internal class RowComparer : DataGridViewColumn
    {
        private SortOrder ascending;

        public RowComparer(SortOrder ascending)
        {
            this.ascending = ascending;
        }
    }
}