using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.SignalR;
using System.Collections;
using System.Security.Cryptography;

namespace Training.CircleSquareGame.Api;

public class XOHub : Hub
{

    public async Task GetField(string fieldId)
    {
        await Clients.All.SendAsync("CurrentFieldValue", fieldId, "");
    }

    public async Task SetFieldX(string fieldId)
    {
        await Clients.All.SendAsync("CurrentFieldValue", fieldId, "x");
    }
    public async Task SetFieldO(string fieldId)
    {
        await Clients.All.SendAsync("CurrentFieldValue", fieldId, "o");
    }

}