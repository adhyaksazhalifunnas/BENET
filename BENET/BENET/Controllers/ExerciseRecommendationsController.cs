using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BENET.Data;
using BENET.Models;
using Microsoft.AspNetCore.Authorization;

namespace BENET.Controllers
{
    public class ExerciseRecommendationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExerciseRecommendationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExerciseRecommendations
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExerciseRecommendation.ToListAsync());
        }

        // GET: ExerciseRecommendations/ShowSearchForm
        public IActionResult ShowSearchForm()
        {
            return View();
        }

        // GET: ExerciseRecommendations/ShowSearchResult
        public async Task<IActionResult> ShowSearchResult(string SearchPhrase)
        {
            return View("Index", await _context.ExerciseRecommendation
                .Where( j => j.SportName.Contains(SearchPhrase) || 
                j.SportType.Contains(SearchPhrase))
                .ToListAsync());
        }

        // GET: ExerciseRecommendations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseRecommendation = await _context.ExerciseRecommendation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exerciseRecommendation == null)
            {
                return NotFound();
            }

            return View(exerciseRecommendation);
        }

        // GET: ExerciseRecommendations/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExerciseRecommendations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SportName,SportType,SportDrill")] ExerciseRecommendation exerciseRecommendation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exerciseRecommendation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exerciseRecommendation);
        }

        // GET: ExerciseRecommendations/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseRecommendation = await _context.ExerciseRecommendation.FindAsync(id);
            if (exerciseRecommendation == null)
            {
                return NotFound();
            }
            return View(exerciseRecommendation);
        }

        // POST: ExerciseRecommendations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SportName,SportType,SportDrill")] ExerciseRecommendation exerciseRecommendation)
        {
            if (id != exerciseRecommendation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exerciseRecommendation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExerciseRecommendationExists(exerciseRecommendation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(exerciseRecommendation);
        }

        // GET: ExerciseRecommendations/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseRecommendation = await _context.ExerciseRecommendation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exerciseRecommendation == null)
            {
                return NotFound();
            }

            return View(exerciseRecommendation);
        }

        // POST: ExerciseRecommendations/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exerciseRecommendation = await _context.ExerciseRecommendation.FindAsync(id);
            _context.ExerciseRecommendation.Remove(exerciseRecommendation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExerciseRecommendationExists(int id)
        {
            return _context.ExerciseRecommendation.Any(e => e.Id == id);
        }
    }
}
