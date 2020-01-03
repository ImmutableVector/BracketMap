using BracketMap.DAL.Dtos;
using BracketMap.DAL.Entities;
using BracketMap.DAL.Models;
using BracketMap.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketMap.DAL.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly BracketMapContext _context;

        public TeamRepository(BracketMapContext context)
        {
            _context = context;
        }

        public async Task<int> SaveTeam()
        {
            //var entity = dto.ToEntity(dto);
            //_context.Teams.Add(entity);
            //_context.Players.AddRange(entity.Players);
            //await _context.SaveChangesAsync();
            //return entity.TeamId;

            // Create Db
            _context.Database.EnsureCreated();

            // I will add two books to one library
            var book1 = new Book();
            var book2 = new Book();

            // I create the library 
            var lib = new Library();

            // I create two Library2Book which I need them 
            // To map between the books and the library
            var b2lib1 = new Library2Book();
            var b2lib2 = new Library2Book();

            // Mapping the first book to the library.
            // Changed b2lib2.Library to b2lib1.Library
            b2lib1.Book = book1;
            b2lib1.Library = lib;

            // I map the second book to the library.
            b2lib2.Book = book2;
            b2lib2.Library = lib;

            // Linking the books (Library2Book table) to the library
            lib.Library2Books.Add(b2lib1);
            lib.Library2Books.Add(b2lib2);

            // Adding the data to the DbContext.
            _context.Libraries.Add(lib);

            _context.Books.Add(book1);
            _context.Books.Add(book2);

            // Save the changes and everything should be working!
            await _context.SaveChangesAsync();

            return 1;
        }
    }



        //public async Task SaveTeams(List<TeamDto> dto)
        //{
        //    foreach (TeamDto team in dto)
        //    {
        //        var entity = team.ToEntity(team);
        //        _context.Teams.Add(entity);
        //        await _context.SaveChangesAsync();
        //    }
        //}
    //}
}
