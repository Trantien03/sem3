using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using t2210m_api.DTOs;
using Microsoft.EntityFrameworkCore;
using t2210m.Entities;
using Microsoft.AspNetCore.Authorization;

namespace t2210m_api.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : Controller
    {
        private readonly ApiSem3Context _context;
        public ProductController(ApiSem3Context context)
        {
            _context = context;
        }
        // GET: /<controller>/
        [HttpGet]
        [Authorize(Policy = "Age18Plus")]
        public IActionResult Index()
        {
            var products = _context.Products.Include(p => p.Category).ToList();
            List<ProductDTO> ls = new List<ProductDTO>();
            foreach (Product p in products)
            {
                ls.Add(new ProductDTO
                {
                    id = p.Id,
                    name = p.Name,
                    price = p.Price,
                    description = p.Description,
                    thumbnail = p.Thumbnail,
                    qty = p.Qty,
                    category_id = p.CategoryId,
                    category = new CategoryDTO { id = p.Category.Id, name = p.Category.Name },
                });
            }
            return Ok(ls);
        }

        [HttpGet]
        [Route("get-by-id")]
        public IActionResult Get(int id)
        {
            try
            {
                Product p = _context.Products
                    .Where(p => p.Id == id)
                    .Include(p => p.Category)
                    .First();
                if (p == null)
                    return NotFound();
                return Ok(new ProductDTO
                {
                    id = p.Id,
                    name = p.Name,
                    price = p.Price,
                    description = p.Description,
                    thumbnail = p.Thumbnail,
                    qty = p.Qty,
                    category_id = p.CategoryId,
                    category = new CategoryDTO { id = p.Category.Id, name = p.Category.Name },
                });

            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("relateds")]
        public IActionResult Relateds(int id)
        {
            try
            {
                Product p = _context.Products.Find(id);
                if (p == null)
                    return NotFound();
                List<Product> ls = _context.Products
                    .Where(p => p.CategoryId == p.CategoryId)
                    .Where(p => p.Id != id)
                    .Include(p => p.Category)
                    .Take(4)
                    .OrderByDescending(p => p.Id)
                    .ToList();
                return Ok(ls);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
