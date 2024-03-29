﻿namespace ExactAdm.Domain.Entities
{
    public class User : EntidadeBase
    {
        public string USERID { get; set; }
        public string Password { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAILID { get; set; }
        public string PHONE { get; set; }
        public string ACCESS_LEVEL { get; set; }
        public string READ_ONLY { get; set; }
        public bool Admin { get; set; }

        public bool UserIsAdmin(User user)
        {
            return user.Admin;
        }
    }
}
