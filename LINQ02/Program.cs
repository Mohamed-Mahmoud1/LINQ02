namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. Get top 3 most expensive products

            //var result  = Source.ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3);
            #endregion


            #region 2. show page 2 of products, with page size = 5

            //var result  = Source.ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Skip(5)
            //    .Take(5);
            #endregion

            #region 3. Take products from the list as long as Their UnitPrice is less than $25 (list is ordered by price).

            var result = Source.ProductList
                .OrderBy(p => p.UnitPrice)
                .TakeWhile(p => p.UnitPrice < 25);
            #endregion


        }
    }
}
