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
    public class GamePlayerAPIController : ApiController
    {
        private _12_10_16_production_ref_portal_apiContext db = new _12_10_16_production_ref_portal_apiContext();

        // GET: api/GamePlayerAPI
        public IQueryable<GamePlayer> GetGamePlayers()
        {
            return db.GamePlayers;
        }

        // GET: api/GamePlayerAPI/5
        [ResponseType(typeof(GamePlayer))]
        public async Task<IHttpActionResult> GetGamePlayer(int id)
        {
            GamePlayer gamePlayer = await db.GamePlayers.FindAsync(id);
            if (gamePlayer == null)
            {
                return NotFound();
            }

            return Ok(gamePlayer);
        }

        // PUT: api/GamePlayerAPI/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGamePlayer(int id, GamePlayer gamePlayer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gamePlayer.Id)
            {
                return BadRequest();
            }

            db.Entry(gamePlayer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GamePlayerExists(id))
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

        // POST: api/GamePlayerAPI
        [ResponseType(typeof(GamePlayer))]
        public async Task<IHttpActionResult> PostGamePlayer(GamePlayer gamePlayer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GamePlayers.Add(gamePlayer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = gamePlayer.Id }, gamePlayer);
        }

        // DELETE: api/GamePlayerAPI/5
        [ResponseType(typeof(GamePlayer))]
        public async Task<IHttpActionResult> DeleteGamePlayer(int id)
        {
            GamePlayer gamePlayer = await db.GamePlayers.FindAsync(id);
            if (gamePlayer == null)
            {
                return NotFound();
            }

            db.GamePlayers.Remove(gamePlayer);
            await db.SaveChangesAsync();

            return Ok(gamePlayer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GamePlayerExists(int id)
        {
            return db.GamePlayers.Count(e => e.Id == id) > 0;
        }
    }
}