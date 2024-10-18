using SHOPFLIX;
using System;
using System.IO;
using System.Linq;

var voucher = new CreateVoucherResponseModel();

var credentials = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SHOPFLIXEmail.txt"));

var array = credentials.Split(",");

var username = array[0];
var password = array[1];

var client = new SHOPFLIXClient(new SHOPFLIXCredentials(username, password), true);

//var ordersResponse = await client.GetOrdersAsync(new OrderAPIArgs() { });

int orderNumber = 4002431;

int returnNumber = 4002439;

int shipmentId = 4043413;

var ordersResponse = await client.GetOrdersAsync();

var order = ordersResponse.Result.First(x => x.OrderId == 4002444);

var acceptResponse = await client.AcceptOrDeclineOrderAsync(order.OrderId, true);

var orderResponse = await client.GetOrderAsync(order.OrderId);

var shipmentResponse = await client.GetShipmentAsync(orderResponse.Result.ShipmentIds.First());

var r = await client.CreateVoucherAsync(123);

r = await client.CreateVoucherAsync(shipmentResponse.Result.ShipmentId);

var voucherResponse = await client.CreateVoucherAsync(shipmentResponse.Result.ShipmentId, 0);

if (!voucherResponse.IsSuccessful)
{
    // Show error dialog
    //DialogHelpers.ShowError(voucherResponse.ErrorMessage);

    return;
}


//var printResponse = await client.PrintVoucherAsync(shipmentResponse.Result.TrackingNumber, VoucherFormat.Clean);

//var base64 = printResponse.Result.Voucher;

//await File.WriteAllBytesAsync(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SHOPFLIXVOucher.pdf"), Convert.FromBase64String(base64));

var shipmentTracking = await client.ShipmentRouteAsync(shipmentResponse.Result.TrackingNumber);

//foreach(var trackingNumber in voucherResponse.Result.TrackingNumbers)
//{
//    var printResponse = await client.PrintVoucherAsync(trackingNumber, VoucherFormat.PDF);

//    var base64 = printResponse.Result.Voucher;

//    await File.WriteAllBytesAsync(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SHOPFLIXVOucher.pdf"), Convert.FromBase64String(base64));
//}

//var orderResponse = await client.GetSingleOrderAsync(orderNumber);

//var request = JsonConvert.DeserializeObject<AcceptOrDeclineOrderRequestModel>(jsonToAcceptOrder)!;

//var changeOrderStatus = await client.AcceptOrDeclineOrderAsync(orderNumber, request);

//var returnsResponse = await client.GetReturnsAsync(new OrderAPIArgs() { });

//var returnResponse = await client.GetSingleReturnAsync(returnNumber);

//var shipmentsResponse = await client.GetShipmentsAsync();

//var shipmentResponse = await client.GetShipmentAsync(shipmentId);


Console.ReadLine();