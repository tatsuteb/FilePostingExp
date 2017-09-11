using System;
using Microsoft.AspNetCore.Http;

namespace FilePostingExp.ViewModel
{
    public class UserRegistrationViewModel
    {
        public string UserName { get; set; }
        public IFormFile ThumbnailFile { get; set; }
    }
}
