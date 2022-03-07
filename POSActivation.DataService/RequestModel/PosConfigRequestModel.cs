using System;
using System.Collections.Generic;

namespace POSActivation.DataService.RequestModel
{
    public class MenuItemInfo
    {
        public String Code { get; set; }
        public int Quantity { get; set; }
    }
    public class MenuInfo
    {
        public List<MenuItemInfo> MenuList { get; set; }
    }
    public class PaymentTypeConfig
    {
        //money|cc-visa|cc-mastercard|ticket|cc|users|hashtag|star-half-o|
        public string Tab1 { get; set; }
        public string Tab2 { get; set; }
        public string Tab3 { get; set; }
        public string Tab4 { get; set; }
        public string Tab5 { get; set; }
        public string Tab6 { get; set; }
        public string Tab7 { get; set; }
        public string Tab8 { get; set; }
    }



    public class PosConfigRequestModel
    {
        //SKYPOS
        public string LoadTableScreenFirst { get; set; }

        //SEVER - STORE
        public string EnableRunningAutoData { get; set; }
        public string EnableGetAndProcessOrderFromServer { get; set; }

        //--------------DO NOT CHANGE THIS !!!--------------
        //"InvoideCodepattern": "TEST-{StoreId}-{Code}",
        public string InvoideCodepattern { get; set; }
        //--------------DO NOT CHANGE THIS !!!--------------

        //POS
        public string Language { get; set; }
        public string EnableSound { get; set; }
        public string EnableOnscreenKeyboard { get; set; }
        public string NotiSoundName { get; set; }

        public string SaveTableStatus { get; set; }
        public string EnableUpdatePassword { get; set; }
        public string EnableAutoExchange { get; set; }

        //MAIN SCREEN
        public string HasDelivery { get; set; }
        public string HasTakeAway { get; set; }
        public string HasAtStore { get; set; }
        public string TakeAwayDifferDelivery { get; set; }
        public string EnableServeTypeDialog { get; set; }

        //Floor name
        public string Floor0 { get; set; }
        public string Floor1 { get; set; }
        public string Floor2 { get; set; }
        public string Floor3 { get; set; }
        public string Floor4 { get; set; }
        public string Floor5 { get; set; }

        //SALE SCREEN
        //Scale (cân) area
        public string ScaleCommunicatePort { get; set; }
        public double RatioToGram { get; set; }
        public string ResultWeightUnit { get; set; }
        public string IsUsingScale { get; set; }
        public string IsUpdateExtraWhenUpdateOrderDetail { get; set; }

        public string IsShowMostOrderMenu { get; set; }
        public string UsingCategoryLevel { get; set; }

        public string IsShowMemberPoint { get; set; }
        public string IsShowCustomerNotes { get; set; }

        public string EnableVAT { get; set; }
        public string EnableOwe { get; set; }
        public string EnableTakeNote { get; set; }
        public string EnableChangeTable { get; set; }
        public string EnableQuickSaleMode { get; set; }
        public string EnableChangeOrderType { get; set; }
        public string EnableChangeServedStaff { get; set; }

        public int BarcodeDurationTime { get; set; }
        public int BarcodeRecognizeTime { get; set; }
        public string BarcodeCompletedPromotion { get; set; }
        public string EnableSecondScreen { get; set; }
        public string EnableScanBarcodeForProdcut { get; set; }

        //VIEW ORDER
        public string EnableDeliveryStatus { get; set; }
        public string RequiredPasswordExportReport { get; set; }
        public string RequiredPasswordUpdate { get; set; }
        public string RequiredPasswordCancel { get; set; }
        public string IsShowMoneyReport { get; set; }
        public string EnableReceiptPrintPreview { get; set; }
        public string EnableViewCancelDetail { get; set; }
        public string EnableQuantityColor { get; set; }

        public PaymentTypeConfig paymentType { get; set; }
        public MenuInfo menuInfo { get; set; }

        //KITCHEN SCREEN
        public string EnableKitchenMode { get; set; }
        public string IsOnlyUseKitchen { get; set; }
        public string EnableAutoRefreshKitchenScreen { get; set; }
    }
}
