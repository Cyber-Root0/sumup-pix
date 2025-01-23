/*
 * Copyright (c) 2025 Bruno Venancio Alves
 *
 * Author: Bruno Venancio Alves
 * Email: boteistem@gmail.com
 *
 * Permission is granted to use, modify, and distribute this software with
 * acknowledgment of the original author. This notice must not be removed
 * or altered from any source distribution.
 */
 using SumUp.SDK.Helper;
 using SumUp.SDK.Client.Checkout;
 using SumUp.SDK.Fields;
 using VarDump;
Config.setAccessToken("");
var checkout = new Checkout();
var fields = new CheckoutFields().setAmount(10).setCurrency("BRL").setDescription("teste")
.setPayerEmail("boteistem@gmail.com").setReference("testref");
var response = checkout.CreateAndProcessPix(fields);
var cs = new CSharpDumper().Dump(response);
Console.WriteLine(cs);
