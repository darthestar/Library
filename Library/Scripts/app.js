console.log("Loaded scripts");

angular
    .module("LibraryApp", [])
    .controller("MainAppController", ["$scope", "$http", ($scope, $http) => {
        let booklist = [];
        let _url = "/api/book";
        $http({
            method: "GET",
            url: _url,
        }).then(resp => {
            $scope.books = resp.data;
            console.log($scope.books);
            var titles = $scope.books.map((booktitle =>
                booklist.push(booktitle["Title"].toLowerCase())
            ));
        });

        $scope.checkForBook = () => {
            console.log("looking for book")
            var isBookinLibrary = booklist.indexOf($scope.userInquiry.toLowerCase());
            console.log($scope.userInquiry.toLowerCase());
            console.log(isBookinLibrary);
            if (isBookinLibrary >-1) {
                console.log("do you want to check it out?")
                _url = "api/book/title=" + booklist[isBookinLibrary];
                getBookToCheckout(_url);
            }
            else {
                console.log("Book is not in our library")
            }
            
        }

        const getBookToCheckout =(url) => {
            return $http({
                method: "GET",
                url: url,
            }).then(response => {
                console.log(response.data)
                $scope.bookTitleToCheckout = response.data;
            });
        }
    
    }]);