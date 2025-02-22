﻿using Microsoft.AspNetCore.Mvc;
using CashFlow.Communication.Requests;
using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Responses;
using CashFlow.Exceptions.ExceptionsBase;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request) 
    {
        try
        {
            var useCase = new RegisterExpenseUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }
        catch (ErrorOnValidationException ex)
        {
            var errorResponse = new ResponseErrorJson(ex.Errors);

            return BadRequest(ex.Message);
        }
        catch
        {
            var errorResponse = new ResponseErrorJson("unknown error");

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}
