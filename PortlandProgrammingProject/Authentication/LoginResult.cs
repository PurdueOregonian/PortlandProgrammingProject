﻿namespace PortlandProgrammingProject.Authentication
{
    public class LoginResult
    {
        public bool Success { get; set; }
        // Set if unexpected exception
        public string? ErrorMessage { get; set; }
    }
}
