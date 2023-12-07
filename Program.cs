using Dapper;
using Oracle.ManagedDataAccess.Client;

[module: DapperAot]

await using var connection = new OracleConnection(
    "Data Source=localhost:1521/service;User Id=my_user;Password=my_password");

var xn = "xn arg";
var xqm = "xqm arg";

var result = await connection.QueryAsync<string>(
    "SELECT DISTINCT MY_ROW FROM MY_VIEW WHERE XN = :arg AND XQM = :xqm",
    new { xn, xqm });