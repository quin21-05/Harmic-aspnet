using Harmic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Harmic.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly HarmicContext _context;

        public BlogViewComponent(HarmicContext context)
        {
            _context = context;
        }
        
/*Include(m => m.CategoryId) :Mục đích ban đầu của Include là để truy vấn thêm thông tin từ bảng liên quan(Category), 
 * nhưng CategoryId không phải là thuộc tính điều hướng.Kết quả là, 
 * đoạn code này gây ra lỗi vì Include yêu cầu thuộc tính điều hướng(navigation property), ví dụ: Include(m => m.Category).
*/        
        /*public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbBlogs.Include(m => m.CategoryId)
                 .Where(m => (bool)m.IsActive);
            return await Task.FromResult<IViewComponentResult>
                (View(items.OrderByDescending(m => m.BlogId).ToList()));
        }*/

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var item = _context.TbBlogs.Where(m => (bool)m.IsActive).ToList();
            return await Task.FromResult<IViewComponentResult>
                (View(item));
        }
    }
}