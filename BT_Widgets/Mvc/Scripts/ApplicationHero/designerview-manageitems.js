(function ($) {
    var simpleViewModule = angular.module('simpleViewModule', ['expander', 'designer', 'sfFields', 'sfSelectors']);
    angular.module('designer').requires.push('simpleViewModule');

    var designerModule = angular.module('designer');

    //This is basic controller for the "ManageItems" designer view.
    designerModule.controller('ManageItemsCtrl', ['$scope', 'propertyService', 'sfLinkService', function ($scope, propertyService, linkService) {
        $scope.feedback.showLoadingIndicator = true;
        $scope.newListItem = "";
        $scope.newDescription = "";

        $scope.proxy = {};

        $scope.listItemsObj = [];

        //Adds item to list.
        $scope.addListItem = function () {

            if ($scope.listItems.length >= 5) {
                alert("You can not enter more than 5 items.");
                return;
            }

            if ($scope.newListItem.length == 0) {
                alert("Please enter title");
                return;
            }

            var htmlLinkObj = linkService.getHtmlLink($scope.proxy.selectedItem);
            $scope.properties.Link_Single.PropertyValue = htmlLinkObj[0].outerHTML;

            console.log("lINK-Id", $scope.properties.Link_Single.PropertyValue);
            let myObject = {
                title: $scope.newListItem,
                description: $scope.newDescription,
                imageId: $scope.properties.ImageId_Single.PropertyValue,
                ctaLink: $scope.properties.Link_Single.PropertyValue
            };

            $scope.listItemsObj.push(myObject);

            $scope.listItems.push($scope.newListItem);
            $scope.description.push($scope.newDescription);
            $scope.imageId.push($scope.properties.ImageId_Single.PropertyValue);
            $scope.link.push($scope.properties.Link_Single.PropertyValue);

            $scope.properties.ListItems.PropertyValue = JSON.stringify($scope.listItems);
            $scope.properties.Description.PropertyValue = JSON.stringify($scope.description);
            $scope.properties.ImageId.PropertyValue = JSON.stringify($scope.imageId);
            $scope.properties.Link.PropertyValue = JSON.stringify($scope.link);

            $scope.newListItem = "";
            $scope.newDescription = "";
            $scope.currentLink = ""
            $scope.properties.ImageId_Single.PropertyValue = null;
            $scope.properties.Link_Single.PropertyValue = "";
        };

        //Deletes the selected item from the list.
        $scope.deleteListItem = function (index) {

            $scope.listItems.splice(index, 1);
            $scope.description.splice(index, 1);
            $scope.imageId.splice(index, 1);
           // $scope.link.splice(index, 1);

            $scope.listItemsObj.splice(index, 1);

            $scope.properties.ListItems.PropertyValue = JSON.stringify($scope.listItems);
            $scope.properties.Description.PropertyValue = JSON.stringify($scope.description);
            $scope.properties.ImageId.PropertyValue = JSON.stringify($scope.imageId);
            //$scope.properties.Link.PropertyValue = JSON.stringify($scope.link);
            console.log("Node deleted ");
        };

        //Makes call to the controlPropertyService to get the properties for the widgets.
        propertyService.get()
            .then(function (data) {
                $scope.listItemsObj = [];
                if (data) {
                    $scope.properties = propertyService.toAssociativeArray(data.Items);



                    console.log("properties", $scope.properties);
                    if ($scope.properties.ListItems.PropertyValue.length == 0) {
                        console.log("No item in ListItems");
                        $scope.listItems = [];
                    }
                    else {
                        $scope.listItems = $.parseJSON($scope.properties.ListItems.PropertyValue);
                    }
                    if ($scope.properties.Description.PropertyValue.length == 0) {
                        console.log("No item in Description");
                        $scope.description = [];
                    }
                    else {
                        $scope.description = $.parseJSON($scope.properties.Description.PropertyValue);

                    }
                    if ($scope.properties.ImageId.PropertyValue.length == 0) {
                        console.log("No item in ImageId");
                        $scope.imageId = [];
                    }
                    else {
                        $scope.imageId = $.parseJSON($scope.properties.ImageId.PropertyValue);
                    }
                    if ($scope.properties.Link.PropertyValue.length == 0) {
                        console.log("No item in Link");
                        $scope.link = [];
                    }
                    else {
                        $scope.link = $.parseJSON($scope.properties.Link.PropertyValue);

                    }
                    //$scope.currentLink = jQuery($scope.properties.Link.PropertyValue);

                    console.log("In-Get : list items", $scope.listItems);
                    //Add string array to item object to show data on screen
                    $scope.listItems.forEach(function (item, index) {

                        let t_Object = {
                            title: item,
                            description: "",
                            imageId: ""
                        };
                        $scope.listItemsObj.push(t_Object);
                        console.log(item, index);
                    })
                }
            },

                function (data) {
                    $scope.feedback.showError = true;
                    if (data)
                        $scope.feedback.errorMessage = data.Detail;
                })

            .finally(function () {
                $scope.feedback.showLoadingIndicator = false;
            });
    }]);
})(jQuery);