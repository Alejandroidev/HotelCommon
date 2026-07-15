using Microsoft.AspNetCore.Mvc;
using ReservaHotel.Domain.Entities.Base;

namespace Common.Interfaces;

/// <summary>
/// Custom web tools (presentation)
/// </summary>
public interface IWebTools
{
    string GetBaseUrl();
    IActionResult CustomResponse(CustomWebResponse response);
}
