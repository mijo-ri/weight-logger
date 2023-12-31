﻿using Application.Core;
using Application.Logs;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class LogsController : BaseApiController
    {
        [HttpGet] // api/logs
        public async Task<IActionResult> GetLogs([FromQuery]LogParams param)
        {
            // Get logs directly from entity framework
            //return await _context.Logs.ToListAsync();

            // Get logs from mediator which uses entity framework
            return HandleResult(await Mediator.Send(new List.Query { Params = param }));
        }

        [HttpGet("{id}")] // api/logs/{id}
        public async Task<IActionResult> GetLog(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost] // api/logs
        public async Task<IActionResult> CreateLog(LogDto log)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Log = log }));
        }

        [Authorize(Policy = "IsLogOwner")]
        [HttpPut("{id}")] // api/logs/{id}
        public async Task<IActionResult> EditLog(Guid id, LogDto log)
        {
            log.Id = id;
            return HandleResult(await Mediator.Send(new Edit.Command { Log = log }));
        }

        [Authorize(Policy = "IsLogOwner")]
        [HttpDelete("{id}")] // api/logs/{id}
        public async Task<IActionResult> DeleteLog(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}
