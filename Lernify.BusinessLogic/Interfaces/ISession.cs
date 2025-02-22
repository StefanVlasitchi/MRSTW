﻿using System.Web;
using Lernify.Domain.Entities.User;
using RestSharp;

namespace Lernify.BusinessLogic.Interfaces
{
     public interface ISession
     {
          ULoginResp UserLogin(ULoginData data);
          ULoginResp UserRegister(USignupData data);
          HttpCookie GenCookie(string loginCredential);
          UserMinimal GetUserByCookie(string apiCookieValue);
     }


}