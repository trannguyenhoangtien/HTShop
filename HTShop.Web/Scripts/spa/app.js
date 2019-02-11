/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("myController", myController);
myApp.service("ValidatorService", ValidatorService);
myApp.directive("htShopDirective", htShopDirective)


myController.$inject = ['$scope', 'ValidatorService'];
//declare
function myController($scope, ValidatorService) {
    
    $scope.checkNumber = function () {
        $scope.message = ValidatorService.checkNumber($scope.num);
    }
    $scope.num = 1;
}

function ValidatorService($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return "This is even";
        } else {
            return "This is odd";
        }
    }
}

function htShopDirective() {
    return {
        restrict: "AE",
        templateUrl: "/Scripts/spa/HTShopDirective.html"
    }
}