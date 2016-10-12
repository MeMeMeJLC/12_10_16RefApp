using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using _12_10_16_production_ref_portal_api.Models;

namespace _12_10_16_production_ref_portal_api.Controllers
{
    public class GameTeamAPIController : ApiController
    {
        private _12_10_16_production_ref_portal_apiContext db = new _12_10_16_production_ref_portal_apiContext();

        // GET: api/GameTeamAPI
        public IQueryable<GameTeam> GetGameTeams()
        {
            return db.GameTeams;
        }

        // GET: api/GameTeamAPI/5
        [ResponseType(typeof(GameTeam))]
        public async Task<IHttpActionResult> GetGameTeam(int id)
        {
            GameTeam gameTeam = await db.GameTeams.FindAsync(id);
            if (gameTeam == null)
            {
                return NotFound();
            }

            return Ok(gameTeam);
        }

        // PUT: api/GameTeamAPI/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGameTeam(int id, GameTeam gameTeam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gameTeam.Id)
            {
                return BadRequest();
            }

            db.Entry(gameTeam).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameTeamExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/GameTeamAPI
        [ResponseType(typeof(GameTeam))]
        public async Task<IHttpActionResult> PostGameTeam(GameTeam gameTeam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GameTeams.Add(gameTeam);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = gameTeam.Id }, gameTeam);
        }

        // DELETE: api/GameTeamAPI/5
        [ResponseType(typeof(GameTeam))]
        public async Task<IHttpActionResult> DeleteGameTeam(int id)
        {
            GameTeam gameTeam = await db.GameTeams.FindAsync(id);
            if (gameTeam == null)
            {
                return NotFound();
            }

            db.GameTeams.Remove(gameTeam);
            await db.SaveChangesAsync();

            return Ok(gameTeam);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GameTeamExists(int id)
        {
            return db.GameTeams.Count(e => e.Id == id) > 0;
        }
    }
}