using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MusicRecordRestPair.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        private List<MusicRecord> RecordsList = new List<MusicRecord>()
        {
            new MusicRecord(1, "nielsen", "den record", 180, 2019),
            new MusicRecord(2, "birk", "den reco", 120, 2016),
            new MusicRecord(3, "peter", "den cord", 130, 2017),
            new MusicRecord(4, "børge", "en record", 140, 2018)
        };

        // GET: api/MusicRecords
        [HttpGet]
        public IEnumerable<MusicRecord> Get()
        {
            return RecordsList;
        }

        // GET: api/MusicRecords/5
        [HttpGet("{id}", Name = "Get")]
        public MusicRecord Get(int id)
        {
            return RecordsList.Find(i => i.Id == id);
        }

        // POST: api/MusicRecords
        [HttpPost]
        public void Post([FromBody] MusicRecord value)
        {
            RecordsList.Add(value);
        }

        // PUT: api/MusicRecords/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MusicRecord value)
        {
            MusicRecord newRecord = RecordsList.Find(i => i.Id == id);
            newRecord.Artist = value.Artist;
            newRecord.Duration = value.Duration;
            newRecord.Title = value.Title;
            newRecord.YearOfPublication = value.YearOfPublication;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            RecordsList.Remove(RecordsList.Find(i => i.Id == id));
            
        }
    }
}
