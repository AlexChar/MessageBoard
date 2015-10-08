//home-index.js

var app = angular.module("myapp", []);
 
app.controller("homeIndexController", ["$scope", "$http", function ($scope, $http) {
    $scope.data = [];
    $scope.isBusy = true;

    $http.get("http://localhost/MessageBoard/api/v1/topics?includeReplies=true")
        .then(function (result) {
            //success
            angular.copy(result.data, $scope.data);
        }, function () {
            //error
            console.error("could not load topics");
        })
        .then(function () {
            $scope.isBusy = false;
        });

}]);