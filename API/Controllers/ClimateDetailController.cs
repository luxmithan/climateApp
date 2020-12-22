using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimateDetailController : ControllerBase
    {
        private readonly ClimateDetailContext context;

        public ClimateDetailController(ClimateDetailContext context)
        {
            this.context = context;
        }

        // GET: api/ClimateDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClimateDetail>>> GetClimateDetails()
        {
            return await this.context.ClimateDetails.ToListAsync();
        }

        // GET: api/ClimateDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClimateDetail>> GetClimateDetail(int id)
        {
            var climateDetail = await this.context.ClimateDetails.FindAsync(id);

            if (climateDetail == null)
            {
                return NotFound();
            }

            return climateDetail;
        }

        // POST: api/ClimateDetail
        [HttpPost]
        public async Task<ActionResult<ClimateDetail>> PostClimateDetail(ClimateDetail climateDetail)
        {
            this.context.ClimateDetails.Add(climateDetail);
            await this.context.SaveChangesAsync();

            return CreatedAtAction("GetClimateDetail", new { id = climateDetail.ClimateDetailId }, climateDetail);
        }

        // DELETE: api/ClimateDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClimateDetail(int id)
        {
            var climateDetail = await this.context.ClimateDetails.FindAsync(id);
            if (climateDetail == null)
            {
                return NotFound();
            }

            this.context.ClimateDetails.Remove(climateDetail);
            await this.context.SaveChangesAsync();

            return NoContent();
        }
    }
}
