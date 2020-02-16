using System;
using System.Collections.Generic;
using System.Linq;

namespace WebCoreMVC.ViewModels
{
    public class UserPageViewModel
    {
        public PaginationViewModel Page { get; set; }

        public IEnumerable<UserViewModel> Users { get; set; }
    }
}
