﻿using System.ComponentModel.DataAnnotations;

namespace goodtrip.Storage.Entity
{
    public class ImageExcurtion
    {
        [Key]
        public Guid Id { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
        public Guid ExcurtionId { get; set; }
        public Excurtion Excurtion { get; set; }
    }
}
