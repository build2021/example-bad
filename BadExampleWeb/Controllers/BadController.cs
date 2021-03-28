namespace BadExampleWeb.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Data.SqlClient;

    public class BadController : Controller
    {
        [HttpGet]
        public IActionResult Sql([FromQuery] string parameter)
        {
            // CA3001 SQL インジェクションのサンプル
            using var cmd = new SqlCommand
            {
                CommandText = "SELECT ProductId FROM Products WHERE ProductName = '" + parameter + "'"
            };

            return Ok();
        }
    }
}
