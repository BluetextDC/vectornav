(function ($) {

    var designerModule = angular.module('designer');
    angular.module('designer').requires.push('sfSelectors');

    designerModule.controller('DefaultDesignerViewCtrl', ['$scope', 'propertyService', function ($scope, propertyService) {
         $scope.selectedPageId = null;
         $scope.selectedPage = null;

        $scope.feedback.showLoadingIndicator = true;

        propertyService.get()
            .then(function (data) {
                if (data) {
                    $scope.properties = propertyService.toAssociativeArray(data.Items);
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

        $scope.$watch('properties.SelectedPage.PropertyValue', function (newValue, oldValue) {
            if (newValue) {
                $scope.selectedPage = JSON.parse(newValue);
            }
        });

        $scope.$watch('selectedPage', function (newValue, oldValue) {
            if (newValue) {
                $scope.properties.SelectedPage.PropertyValue = JSON.stringify(newValue);
            }
        });

        $scope.$watch('properties.SelectedPageId.PropertyValue', function (newValue, oldValue) {
            if (newValue) {
                $scope.selectedPageId = JSON.parse(newValue);
            }
        });

        $scope.$watch('selectedPageId', function (newValue, oldValue) {
            if (newValue) {
                $scope.properties.SelectedPageId.PropertyValue = JSON.stringify(newValue);;
            }
        });

    }]);

})(jQuery);