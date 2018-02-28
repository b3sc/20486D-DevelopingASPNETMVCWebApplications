﻿using System.Collections.Generic;
using System.Linq;

namespace ActorsRazorPages.Models
{
    //This class is used during development to make sure that ther is data to display
    public class Data : IData
    {
        public List<Actor> ActorsList { get; set; }

        //Initialize actors list
        public List<Actor> ActorsInitializeData()
        {
            ActorsList = new List<Actor>()
            {
                new Actor(){Id = 1,FirstName="Kelly",LastName="Bailey" ,KnownFor="Kelly the great",OscarWinner=true,ImageName="actor.jpg"},
                new Actor(){Id = 2,FirstName ="Pauline ",LastName="Tapia" ,KnownFor="woman in white",OscarWinner=true,ImageName="actress.jpg"}
            };

            return ActorsList;
        }

        //Get actor by id
        public Actor GetActorById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return ActorsList.SingleOrDefault(a => a.Id == id);
            }
        }
    }
}
