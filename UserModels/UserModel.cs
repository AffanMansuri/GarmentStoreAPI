﻿namespace GarmentStoreAPI.UserModels
{
    public class UserModel
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public Roles Role { get; set; }
    }
}