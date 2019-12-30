using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLMS
{
    public class SmallClasses
    {
        public class MP3 
        {
            public int OriginalRow { get; set; }
            public string FilePath { get; set; }
            public string FileName { get; set; }
            public int TrackNumber { get; set; }
            public string SongTitle { get; set; }
            public string Album { get; set; }
            public string Artists { get; set; }

            public override string ToString()
            {
                return "File Name: " + FileName + ", Track Number: " + TrackNumber.ToString() + ", Song Title: " 
                    + SongTitle + ", On Album: " + Album + ", Contributing Artists: " + Artists;
            }

            public string TracksToString()
            {
                return "File Name: " + FileName + ", Track #: " + TrackNumber.ToString() + ", Tack Title: " + SongTitle;
            }

        }
        public class SortTracks : IComparer<MP3>
        {
            int IComparer<MP3>.Compare(MP3 x, MP3 y)
            {
                if (x.TrackNumber == 0 || y.TrackNumber == 0)
                {
                    return 0;
                }
                return x.TrackNumber.CompareTo(y.TrackNumber);
            }
        }
        public class AlbumsByArtist
        {
            public string artist { get; set; }
            public string album { get; set; }
        }
    }
}
