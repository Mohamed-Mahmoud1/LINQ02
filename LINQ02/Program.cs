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

            //var result = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);
            #endregion

            #region 4. Check if ALL products in the "Seafood" category are in stock

            //var result = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);

            #endregion

            #region 5. Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            #endregion

            #region 6. Group all products by Category and print each group with its product count.

            //var result = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, productcount = g.Count() });
            #endregion

            #region 7. Group products by Category and project only product names per group

            //var result = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, productNames = g.Select(p => p.ProductName) });
            #endregion

            #region 8. Find all categories that have MORE THAN 3 products

            //var result = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3)
            //    .Select(g => g.Key);
            #endregion

            #region 9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.

            //var result = from c in Source.CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };

            #endregion

            #region 10. Calculate the total number of units in stock across all products

            //var result = Source.ProductList
            //    .Sum(p => p.UnitsInStock);
            #endregion

            #region 10. Calculate the total number of units in stock across all products

            //var result = Source.ProductList
            //    .Sum(p => p.UnitsInStock);
            #endregion

            #region 11. Find the CHEAPEST and MOST EXPENSIVE product prices

            //var Cheapest = Source.ProductList.Min(p => p.UnitPrice);
            //var MostExpensive = Source.ProductList.Max(p => p.UnitPrice);

            #endregion

            #region 12. Get a distinct list of all product categories

            //var result = Source.ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            #endregion

            #region 13. find product IDs that are in setA but NOT in setB

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);

            #endregion

            #region 14. Find countries that appear in list1 but NOT in list2 (case-insensitive).

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1
            //             .Except(list2, StringComparer.OrdinalIgnoreCase);


            #endregion

            #region 15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.

            var result = Source.ProductList
                .ToDictionary(p => p.ProductID);


            #endregion

        }
    }
}
