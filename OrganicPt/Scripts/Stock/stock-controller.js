portfolioModule.controller("StockController", function ($scope, portfolioRepository, $interval) {
    callAtInterval();
    $interval(callAtInterval, 10000);
    function callAtInterval() {
        $scope.dataLoaded = false;
        portfolioRepository
            .GetCmp($scope.stock.symbol)
            .then(function (cmp) {
                if ($scope.cmp < cmp) $scope.color = "red";
                else if ($scope.cmp > cmp) $scope.color = "green";
                else { $scope.color = "";}
                $scope.cmp = cmp;
                $scope.dataLoaded = true;
            });
    }
});
