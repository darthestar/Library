console.log("Loaded scripts");

angular
    .module("LibraryApp", [])
    .controller("MainAppController", ["$scope", "$http", ($scope, $http) => {
        $http({
            method: "GET",
            url: "/api/book"
        }).then(resp => {
            console.log(resp.data);
            $scope.books = resp.data;
        })
    }]);