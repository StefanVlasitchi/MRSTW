﻿using System.Collections.Generic;
using Lernify.BusinessLogic.Implementation;
using Lernify.Domain.Entities.Review;

namespace Lernify.BusinessLogic.Interfaces
{
     public interface IReview
     {
          void AddReview(Review review);
          List<Review> GetReviews();
     }
}}
