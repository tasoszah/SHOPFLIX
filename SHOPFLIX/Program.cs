
using SHOPFLIX;
using System;
using System.Collections.Generic;


var voucher = new CreateVoucherResponseModel();

var length = voucher.ShipmentNumber.Length;

var dicks = SHOPFLIXConstants.ReturnStatusToStringMapper;

var number = new int();

var dateOnly = DateOnly.FromDateTime(DateTime.Now);

var formattedDate = dateOnly.ToString("yyyy/MM/dd");

var s = $"{dateOnly:yyyy/MM/dd} {0.5d:0.00}";


var test = new List<string>
{
    "tasos",
    "labros"
};

var r = APIRoutes.PrintOrderVoucherListRoute(false, test, VoucherFormat.Clean);

Console.Write(r);

Console.ReadLine();
