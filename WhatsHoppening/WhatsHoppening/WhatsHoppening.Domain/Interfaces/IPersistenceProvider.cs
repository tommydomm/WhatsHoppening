﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsHoppening.Domain.Interfaces
{
    public interface IPersistenceProvider
    {
        Beer GetBeer(int id);
        Beer GetBeer(string name);
        void SaveBeer(Beer beer);

        IVenue GetBar(int id);
        IVenue GetBar(string name);
        void SaveBar(IVenue bar);

        Brewery GetBrewery(int id);
        Brewery GetBrewery(string name);
        void SaveBrewery(Brewery brewery);

        List<Post> ListPosts();
        List<Post> SearchPosts(SearchPostQuery searchPostQuery);
        void Post(Post post);
    }
}
