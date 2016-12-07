portfolioModule.controller("StockController", function ($scope, portfolioRepository, $interval) {
    callAtInterval();
    $interval(callAtInterval, 10000);
    function callAtInterval() {
        $scope.dataLoaded = false;
        portfolioRepository
            .GetCmp($scope.stock.stockId.toUpperCase())
            .then(function (cmp) {
                $scope.cmp = cmp;
                $scope.dataLoaded = true;
            });
    }
});

