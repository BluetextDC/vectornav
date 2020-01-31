(function ($) {
    var simpleViewModule = angular.module('simpleViewModule', ['expander', 'designer', 'sfFields', 'sfSelectors']);
    angular.module('designer').requires.push('simpleViewModule');

    angular.module('designer').controller('SimpleCtrl', ['$scope', 'propertyService', 'sfLinkService', function ($scope, propertyService, linkService) {

        $scope.proxy = {};
        $scope.feedback.showLoadingIndicator = true;

        propertyService.get()
            .then(function (data) {
                if (data) {
                    $scope.properties = propertyService.toAssociativeArray(data.Items);
                    $scope.currentLink = jQuery($scope.properties.Link.PropertyValue);
                }
            },
            function (data) {
                $scope.feedback.showError = true;
                if (data)
                    $scope.feedback.errorMessage = data.Detail;
            })
            .then(function () {
                $scope.feedback.savingHandlers.push(function () {
                    var htmlLinkObj = linkService.getHtmlLink($scope.proxy.selectedItem);
                    $scope.properties.Link.PropertyValue = htmlLinkObj[0].outerHTML;
                });
            })
            .finally(function () {
                $scope.feedback.showLoadingIndicator = false;
            });
    }]);

     //// NOTE: Use this code only with Sitefinity version 9.1 or above. Otherwise the "ngSanitize" module should no be included. 
    angular.module('designer').requires.push('ngSanitize');
})(jQuery);