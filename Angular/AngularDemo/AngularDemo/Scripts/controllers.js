var servicesExampleApp = angular.module('servicesExampleApp', ['ngResource']);

//This syntax to declare this to deal with minification is:
// <app>.controllercontroller('UserRegistrationController', ['$scope', 'Users', function ($scope, Users) {...}]
servicesExampleApp.controller('UserRegistrationController', function ($scope, Users) {
    Users.query(function (data) {
        $scope.users = data;
    });

    $scope.getUser = function (id) {
        Users.get({ id: id }, function (data) {
            $scope.currentUser = data;
        });
    };

    $scope.addUser = function () {
        Users.save($scope.currentUser, function () {
            Users.query(function (data) {
                $scope.users = data;
            });
            $scope.currentUser = {};
        });
    }
});

//This equivlent syntax to declare this that doesn't deal with minification is:
// <app>.controllercontroller('User', function ($scope, Users) {...})
servicesExampleApp.factory('Users', ['$resource', function ($resource) {
        return $resource("/api/Users/:id");
    }
]);