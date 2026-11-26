namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. Get top 3 most expensive products

            var result  = Source.ProductList
                .OrderByDescending(p => p.UnitPrice)
                .Take(3);
            #endregion


        }
    }
}
