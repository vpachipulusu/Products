﻿namespace Products.Domain.Authentication
{
    public class AuthenticateResponse
    {

        public string Token { get; set; }

        public AuthenticateResponse(string token)
        {
            Token = token;
        }
    }
}
