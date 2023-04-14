namespace usingDelegates
{
    public class FilterHelper
    {

        //public delegate bool FilterDelegate(int item);


        public List<int> Filter(List<int> values, Func<int, bool> criteria)
        {
            List<int> filteredCollection = new List<int>();
            foreach (var item in values)
            {
                if (criteria(item))
                {
                    filteredCollection.Add(item);
                }
            }

            return filteredCollection;
        }
    }
}
