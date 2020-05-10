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
using FedtWebAPIService;

namespace FedtWebAPIService.Controllers
{
    public class ExcercisesController : ApiController
    {
        private FedtModel db = new FedtModel();

        // GET: api/Excercises
        public IQueryable<Excercise> GetExcercises()
        {
            return db.Excercises;
        }

        // GET: api/Excercises/5
        [ResponseType(typeof(Excercise))]
        public IHttpActionResult GetExcercise(int id)
        {
            Excercise excercise = db.Excercises.Find(id);
            if (excercise == null)
            {
                return NotFound();
            }

            return Ok(excercise);
        }

        // PUT: api/Excercises/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutExcercise(int id, Excercise excercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != excercise.Excercise_ID)
            {
                return BadRequest();
            }

            db.Entry(excercise).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExcerciseExists(id))
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

        // POST: api/Excercises
        [ResponseType(typeof(Excercise))]
        public IHttpActionResult PostExcercise(Excercise excercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Excercises.Add(excercise);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ExcerciseExists(excercise.Excercise_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = excercise.Excercise_ID }, excercise);
        }

        // DELETE: api/Excercises/5
        [ResponseType(typeof(Excercise))]
        public IHttpActionResult DeleteExcercise(int id)
        {
            Excercise excercise = db.Excercises.Find(id);
            if (excercise == null)
            {
                return NotFound();
            }

            db.Excercises.Remove(excercise);
            db.SaveChanges();

            return Ok(excercise);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExcerciseExists(int id)
        {
            return db.Excercises.Count(e => e.Excercise_ID == id) > 0;
        }
    }
}