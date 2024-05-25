using HLLNDotNetCore.ConsoleApp.AdoDotNetExamples;
using HLLNDotNetCore.ConsoleApp.DapperExamples;
using HLLNDotNetCore.ConsoleApp.EFCoreExamples;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;


Console.WriteLine("Hello, World!");
AdoDotNet adoDotNet = new AdoDotNet();
//adoDotNet.Create("Test title114", "Test author114", "Test content114");
//adoDotNet.Read();
adoDotNet.Update(5, "Test title22", "Test author2", "Test content");
//adoDotNet.Delete(2004);
//adoDotNet.Edit(2005);
//DapperExample dapper = new DapperExample();
//dapper.Run();
//EFCoreExample efCoreExample = new EFCoreExample();
//efCoreExample.Run();
Console.ReadKey();


