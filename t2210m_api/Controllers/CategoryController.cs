﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using t2210m.Entities;
using t2210m_api.Models;
using t2210m_api.DTOs;

namespace t2210m_api.Controllers
{
    [ApiController]
    [Route("/api/category")]
    public class CategoryController : Controller
    {
        private readonly ApiSem3Context _context;
        public CategoryController(ApiSem3Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<CategoryDTO> ls = _context.Categories
                .Select(m => new CategoryDTO
                {
                    id = m.Id,
                    name = m.Name
                })
                .ToList();
            return Ok(ls);
        }

        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Category category = new Category { Name = model.name };
                    _context.Categories.Add(category);
                    _context.SaveChanges();
                    return Created("", new CategoryDTO
                    {
                        id = category.Id,
                        name = category.Name
                    });
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            return BadRequest("Error");
        }

        [HttpPut]
        public IActionResult Edit(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Categories.Update(new Category { Id = model.id, Name = model.name });
                    _context.SaveChanges();
                    return Ok("Successfully");
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }

            }
            return BadRequest("Error");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                Category category = _context.Categories.Find(id);
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
