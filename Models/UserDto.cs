﻿namespace aplicatieHandbal.Models
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }

        public string ImageUrl { get; set; }
    }
}
