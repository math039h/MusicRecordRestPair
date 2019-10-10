using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecordRestPair
{
    public class MusicRecord
    {
        private string _artist;
        private string _title;
        private int _duration;
        private int _yearOfPublication;
        private int _id;

        public MusicRecord()
        {
        }

        public MusicRecord(int id, string artist, string title, int duration, int yearOfPublication)
        {
            _id = id;
            _artist = artist;
            _title = title;
            _duration = duration;
            _yearOfPublication = yearOfPublication;
        }

        public string Artist
        {
            get => _artist;
            set => _artist = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public int Duration
        {
            get => _duration;
            set => _duration = value;
        }

        public int YearOfPublication
        {
            get => _yearOfPublication;
            set => _yearOfPublication = value;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return "This is record " + Id;
        }
    }
}
