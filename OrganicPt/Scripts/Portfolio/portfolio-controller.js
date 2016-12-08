portfolioModule.controller("PortfolioController", function ($scope, portfolioRepository) {
    portfolioRepository.GetAllStocks().then(function (stocks) { $scope.stocks = stocks; });
});
