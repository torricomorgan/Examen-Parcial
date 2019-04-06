using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APIFriend2.Models;

namespace APIFriend2.Controllers
{
    public class MatiasTorricoFriendsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/MatiasTorricoFriends
        public IQueryable<MatiasTorricoFriend> GetMatiasTorricoFriends()
        {
            return db.MatiasTorricoFriends;
        }

        // GET: api/MatiasTorricoFriends/5
        [ResponseType(typeof(MatiasTorricoFriend))]
        public IHttpActionResult GetMatiasTorricoFriend(int id)
        {
            MatiasTorricoFriend matiasTorricoFriend = db.MatiasTorricoFriends.Find(id);
            if (matiasTorricoFriend == null)
            {
                return NotFound();
            }

            return Ok(matiasTorricoFriend);
        }

        // PUT: api/MatiasTorricoFriends/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMatiasTorricoFriend(int id, MatiasTorricoFriend matiasTorricoFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != matiasTorricoFriend.FriendId)
            {
                return BadRequest();
            }

            db.Entry(matiasTorricoFriend).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatiasTorricoFriendExists(id))
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

        // POST: api/MatiasTorricoFriends
        [ResponseType(typeof(MatiasTorricoFriend))]
        public IHttpActionResult PostMatiasTorricoFriend(MatiasTorricoFriend matiasTorricoFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MatiasTorricoFriends.Add(matiasTorricoFriend);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = matiasTorricoFriend.FriendId }, matiasTorricoFriend);
        }

        // DELETE: api/MatiasTorricoFriends/5
        [ResponseType(typeof(MatiasTorricoFriend))]
        public IHttpActionResult DeleteMatiasTorricoFriend(int id)
        {
            MatiasTorricoFriend matiasTorricoFriend = db.MatiasTorricoFriends.Find(id);
            if (matiasTorricoFriend == null)
            {
                return NotFound();
            }

            db.MatiasTorricoFriends.Remove(matiasTorricoFriend);
            db.SaveChanges();

            return Ok(matiasTorricoFriend);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MatiasTorricoFriendExists(int id)
        {
            return db.MatiasTorricoFriends.Count(e => e.FriendId == id) > 0;
        }
    }
}