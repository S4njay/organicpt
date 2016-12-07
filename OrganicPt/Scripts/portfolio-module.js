var portfolioModule = angular.module("portfolioModule", ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when("/Home", { templateUrl: "Scripts/templates/home.html", controller: "HomeController" });
        $routeProvider.when("/Portfolio", { templateUrl: "Scripts/templates/stocks.html", controller: "PortfolioController" });
        $routeProvider.otherwise({
            redirectTo: '/Home'
        });
        $locationProvider.html5Mode(true);
    });