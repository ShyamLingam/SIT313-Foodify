using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FitnessGuru.Model
{
    public class MediaModel
    {
        public Guid MediaID { get; set; }
        public string Path { get; set; }
        public DateTime LocalDateTime { get; set; }
        private FileImageSource source = null;
        public FileImageSource Source => source ?? (source = new FileImageSource() { File = Path });

    }
}

