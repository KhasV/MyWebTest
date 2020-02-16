using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyWebTest.Models;
using MyWebTest.ViewModels;
using System.Security.Claims;

namespace MyWebTest
{
    public class Chat : Hub
    {
        private SystemContext _context;
        public Chat(SystemContext context)
        {
            _context = context;
        }
        public async Task SendMessage(string user, string message)
        {
            var current_comment = new Comment
            {
                Text = message,
                UserName = user
            };
            _context.Comments.Add(current_comment);
            _context.SaveChanges();
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
