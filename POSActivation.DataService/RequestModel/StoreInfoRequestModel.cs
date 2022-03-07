using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace POSActivation.DataService.RequestModel
{

    public class StoreInfoRequestModel
    {
        public string shortcutsToExtra { get; set; }
        public string MarginLogo { get; set; }
        public string BreakLineOrderDetail { get; set; }
        //SERVER
        public string ServerUri { get; set; }
        public string ServerToken { get; set; }
        public string StoreId { get; set; }
        public string DatabaseServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseUsername { get; set; }
        public string DatabasePassword { get; set; }

        //STORE
        public string TerminalName { get; set; }
        public string TerminalAddress { get; set; }
        public string HotLine { get; set; }

        public string ComputerScreenResolution { get; set; }

        public string MainColor { get; set; }
        public string LogoSimple { get; set; }
        public string LogoPrint { get; set; }

        public string QRCodeEnable { get; set; }
        public string QRCodeURL { get; set; }
        public string QRCodeDescription { get; set; }
        public string MomoEnable { get; set; }
        public string ZaloEnable { get; set; }

        //WIFI
        public string IsShowWifiInfo { get; set; }
        public string WifiName { get; set; }
        public string WifiPassword { get; set; }
        public string IsGeneratePassWifi { get; set; }
        public string WiSkyLocationId { get; set; }

        //ENDING TEXT
        public string EndingTextOnBill { get; set; }

        public string OrderCodeText { get; set; }
        public string TakeAwayText { get; set; }
        public string AtStoreText { get; set; }
        public string DeliveryText { get; set; }
        public string OnlineOrderText { get; set; }

        //PRINTER

        public string EnablePrintPreview { get; set; }
        public string EnablePrintBillCook { get; set; }

        //"Microsoft Print to PDF",
        public string PrintBillOrder { get; set; }
        public string IsPrintBillCookWhenSaveTable { get; set; }
        // Main Bill
        public string PrinterBill { get; set; }
        // Cook Bill
        public string PrinterCook1 { get; set; }
        public string PrinterCook2 { get; set; }
        public string PrinterCook3 { get; set; }

        // Label Bill
        public string PrinterLabel { get; set; }
        public string PrinterDetail { get; set; }
        public string MomoConnection { get; set; }

        public string PrintWifiPassword { get; set; }
        public string Whitelist { get; set; }

        //ThirdParty
        public string GiftTalkCardEnable { get; set; }
        public SkyConnectConfig SkyConnectConfig { get; set; }
        public string SkyConnectEnable { get; set; }
        public string SkyConnectForCustomer { get; set; }
        //signalr
        public string SignalrEnable { get; set; }
        public Signalr Signalr { get; set; }
        public string RedisEnable { get; set; }
        public RedisModel RedisModel { get; set; }
        public string RunWcf { get; set; }
        public string RunPrinterManager { get; set; }

        public List<PrinterLabel> PrinterLabels { get; set; }
    }
    public class PrinterLabel
    {
        public int DeviceId { get; set; }
        public List<int> CateLimits { get; set; }
    }

    public class Signalr
    {
        public string Url { get; set; }
        public string UserId { get; set; }
    }

    public class RedisModel
    {
        public string Url { get; set; }
        public string Chanel { get; set; }
    }

    public class SkyConnectConfig
    {
        [JsonProperty("store_id")]
        public int StoreId { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("pgp_public_key")]
        public string PGPPublicKey { get; set; }
        [JsonProperty("des_key")]
        public string DesKey { get; set; }
        [JsonProperty("des_iv")]
        public string DesIV { get; set; }
        [JsonProperty("api_url")]
        public string ServerUri { get; set; }
    }
}
