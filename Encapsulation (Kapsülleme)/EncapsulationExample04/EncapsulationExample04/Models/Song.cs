using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample04.Models
{
    internal class Song
    {
        private string _title;
        private bool _playing;
        private string _artist;
        private TimeSpan _duraiton;

        public string Title {
            get
            {
                return _title;
            }
            set {
                _title = value;
            }
        }

        public string Artist {
            get
            {
                return _artist;
            }
            set {
                _artist = value;
            }
        }

        public TimeSpan Duration {
            get { return _duraiton;  }
            set { _duraiton = value; } }

        public Boolean Playing {
            get { return _playing;  }
            set { _playing = value;  } }




        public void Oynat()
        {
            if (!_playing)
            {
                Console.WriteLine($"Çalan Şarkı : {Title} - {Artist}");
                Playing = true;
            }

        }

        public void Duraklat()
        {
            if (Playing)
            {
                Console.WriteLine($"Paused: {Title} - {Artist}");
                Playing= false;
            }
            else
            {
                Console.WriteLine("Şarkı zaten devam etmiyor");
            }
        }

        public void DevamEt()
        {
            Console.WriteLine("Devam ET.");
        }
    }
}
