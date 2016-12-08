portfolioModule.controller("HomeController", function ($scope, portfolioRepository) {
    portfolioRepository.GetWorldmarkets().then(function (stocks) { $scope.stocks = stocks; });
});