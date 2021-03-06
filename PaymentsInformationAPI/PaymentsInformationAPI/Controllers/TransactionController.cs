﻿using Microsoft.AspNetCore.Mvc;
using PaymentsInformationAPI.Domain;
using PaymentsInformationAPI.Services.Interfaces;
using System;

namespace PaymentsInformationAPI.Controllers
{
    [Route("transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService TransactionService;

        public TransactionController(ITransactionService transactionService)
        {
            TransactionService = transactionService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] TransactionRequest newTransaction)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var transaction = TransactionService.Create(newTransaction);
                    return Ok(transaction);
                }

                return BadRequest("Parâmetros inválidos. Tente novamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}