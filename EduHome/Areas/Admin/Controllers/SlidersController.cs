//using DAL.Data;
using Business.Implementations;
using Business.Services;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly ISlidersService _slidersService;

        public SlidersController(ISlidersService slidersService)
        {
            _slidersService = slidersService;
        }

        // GET: SliderController
        public async Task<IActionResult> Index()
        {
            List<Slider> datas = new List<Slider>();

            try
            {
                datas = await _slidersService.GetAll();
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = 405,
                    message = ex.Message,

                });

            }
            return View(datas);
        }

        // GET: SliderController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Slider data = new Slider();

            try
            {
                data = await _slidersService.Get(id);
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = 405,
                    message = ex.Message,

                });

            }
            return View(data);
        }

        // GET: SliderController/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: SliderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider data)
        {
            try
            {
                await _slidersService.Create(data);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = 405,
                    message = ex.Message,
                });

            }
        }

            // GET: SliderController/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                var data = await _slidersService.Get(id);

                return View(data);
            }

            // POST: SliderController/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, Slider data)
            {
                try
                {
                    await _slidersService.Update(data);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    return Json(new
                    {
                        status = 405,
                        message = ex.Message,

                    });
                }
            }

            // GET: SliderController/Delete/5
            public async Task<IActionResult> Delete(int id)
            {
                 Slider data = new Slider();

            try
            {
                data = await _slidersService.Get(id);
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = 405,
                    message = ex.Message,

                });

            }
            return View(data);
        }

            // POST: SliderController/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Delete(int id, Slider data)
            {
                try
                {
                   await _slidersService.Delete(id);
                    
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                return Json(new
                {
                    status = 405,
                    message = ex.Message,

                });
            }
            }
        
    }
}