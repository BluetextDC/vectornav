using System;
using System.Linq;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Security;
using Telerik.Sitefinity;
using Telerik.Sitefinity.Versioning;
using Telerik.Sitefinity.Data;
using System.Collections.Generic;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.GenericContent.Model;

namespace BT_Widgets.Mvc.Models.BT_ModuleTest_CtEmployee
{
    public class CarouselItem
    {
        public string SelectedImageSrc { get; set; }
        public string SelectedPageLink { get; set; }
        public string SelectedVideoSrc { get; set; }
        public string LinkText { get; set; }
    }
    public class BT_ModuleTest_CtEmployeeModel
    {
        public string EmpName { get; set; }
        public string SelectedImageSrc { get; set; }
        public string SelectedPageLink { get; set; }
        public string SelectedVideoSrc { get; set; }
        public string LinkText { get; set; }

        public BT_ModuleTest_CtEmployeeViewModel GetViewModel()
        {
            var viewModel = new BT_ModuleTest_CtEmployeeViewModel();
            viewModel.EmpName_VM = this.EmpName;
            return viewModel;
        }
        #region list of item for an module created by Module-Builder
        public IQueryable<DynamicContent> RetrieveCtEmployee()
        {
            // Set the provider name for the DynamicModuleManager here. All available providers are listed in
            // Administration -> Settings -> Advanced -> DynamicModules -> Providers
            var providerName = String.Empty;

            // Set a transaction name
            var transactionName = "someTransactionName";


            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName, transactionName);
            Type ctEmployeeType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Module_Test.Ct_employee");

            // CreateCtEmployeeItem(dynamicModuleManager, ctEmployeeType, transactionName);

            // This is how we get the ctEmployee items through filtering
            var myFilteredCollection = dynamicModuleManager.GetDataItems(ctEmployeeType);//.Where("Title = \"Some Title\"")

            //foreach (var contentItem in myFilteredCollection)
            //{

            //    string str = contentItem.GetString("Name");
            //    //contentItem.GetValue<string>("Name");


            //}


            // At this point myFilteredCollection contains the items that match the lambda expression passed to the Where extension method
            // If you want only the first matching element you can freely get it by ".First()" extension method like this:
            // var myFirstFilteredItem = myFilteredCollection.First();

            return myFilteredCollection;
        }
        
        public IEnumerable<CarouselItem> GetList_Orig()
        {
            //int id;
            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager();
            Type carouselType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Carousels.Carousel");

            // This is how we get the collection of Carousel items
          //  var myFilteredCollection = dynamicModuleManager.GetDataItems(carouselType).Where(i => i.Status == ContentLifecycleStatus.Live).Where("CarouselId == " + id).AsEnumerable();
            var myFilteredCollection = dynamicModuleManager.GetDataItems(carouselType).Where(i => i.Status == ContentLifecycleStatus.Live).AsEnumerable();

            IList<CarouselItem> myCarousel = new List<CarouselItem>();

            foreach (var row in myFilteredCollection)
            {


                var imageId = ((Telerik.Sitefinity.Model.ContentLinks.ContentLink[])row.GetValue("CarouselImage"))[0].ChildItemId;

                LibrariesManager libManager = LibrariesManager.GetManager();
                var image = libManager.GetImages().Where(d => d.Id == imageId).First();

                // Create a new List collection, extract our details and put them in there
                CarouselItem item = new CarouselItem();
                item.SelectedImageSrc = image.Url;
                item.SelectedPageLink = row.GetValue("CarouselLink").ToString();
                item.SelectedVideoSrc = row.GetValue("CarouselVideo").ToString();
                item.LinkText = row.GetValue("CarouselText").ToString();

                myCarousel.Add(item);
            }
 
            return myCarousel;
        }
        // Creates a new ctEmployee item
        private void CreateCtEmployeeItem(DynamicModuleManager dynamicModuleManager, Type ctEmployeeType, string transactionName)
        {
            DynamicContent ctEmployeeItem = dynamicModuleManager.CreateDataItem(ctEmployeeType);

            // This is how values for the properties are set 
            ctEmployeeItem.SetValue("Title", "Some Title");
            ctEmployeeItem.SetValue("Name", "Some Name");
            ctEmployeeItem.SetValue("Address", "Some Address");


            ctEmployeeItem.SetString("UrlName", "SomeUrlName");
            ctEmployeeItem.SetValue("Owner", SecurityManager.GetCurrentUserId());
            ctEmployeeItem.SetValue("PublicationDate", DateTime.UtcNow);


            ctEmployeeItem.SetWorkflowStatus(dynamicModuleManager.Provider.ApplicationName, "Draft");

            // Create a version and commit the transaction in order changes to be persisted to data store
            var versionManager = VersionManager.GetManager(null, transactionName);
            versionManager.CreateVersion(ctEmployeeItem, false);
            TransactionManager.CommitTransaction(transactionName);
        }

       
        #endregion
    }
}