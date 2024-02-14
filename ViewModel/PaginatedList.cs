using System;
namespace Razor2Test.ViewModel
{
    //public class PaginatedList<T> : List<T>
    //{
    //    #region Properties

    //    public int PageIndex { get; private set; }
    //    public int TotalPages { get; private set; }

    //    public bool HasPreviousPage => PageIndex > 1;

    //    /// <summary>
    //    /// نشان میدهد که ایا صفجه ی بعدی وجود دارد یا خیر
    //    /// </summary>
    //    // این یک پراپرتی صرفا از جنس گت است که مقدار گفته شده را بر میگرداند.
    //    public bool HasNextPage => PageIndex < TotalPages;

    //    #endregion

    //    #region Ctor

    //    public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
    //    {
    //        PageIndex = pageIndex;
    //        TotalPages = (int)Math.Ceiling(count / (double)pageSize);

    //        this.AddRange(items);
    //    }

    //    #endregion

    //    #region Functions

    //    public static async Task<PaginatedList<T>> CreateAsync(
    //        IQueryable<T> source, int pageIndex, int pageSize)
    //    {
    //        var count = await source.CountAsync();
    //        var items = await source.Skip(
    //            (pageIndex - 1) * pageSize)
    //            .Take(pageSize).ToListAsync();
    //        return new PaginatedList<T>(items, count, pageIndex, pageSize);
    //    }

    //    #endregion
    //}


    public static class Paging
    {
        /// <summary>
        /// کاربرد این تابع برای استفاده از پیجینگ است
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listInput"></param>
        /// <param name="pageIndex">شماره صفحه شما</param>
        /// <param name="pageSize">تعداد ایتم هایی که باید در یک صفحه اورده شود</param>
        /// <returns></returns>
        // اکستنشن متد
        public static PaginationModel<T> ApplyPagination<T>(this IEnumerable<T> listInput, int pageIndex, int pageSize) // where T : class
        {
            // دیتابیس چندتا ایتم داره
            var listCount = listInput.Count();

            var resultItems = listInput.Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var result = new PaginationModel<T>()
            {
                Items = resultItems,
                TotalCount = listCount
            };

            return result;
        }

    }

    public class PaginationModel<TList>
    {
        public IEnumerable<TList> Items { get; set; }
        public int TotalCount { get; set; }
    }

}
