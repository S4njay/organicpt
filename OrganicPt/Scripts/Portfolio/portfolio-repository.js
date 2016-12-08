portfolioModule.factory('portfolioRepository', function ($http, $q) {
    return {
        GetAllStocks: function () {
            var deferred = $q.defer();
            $http.get('api/Info/GetAllStocks').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        },
        GetCmp: function (id) {
            var deferred = $q.defer();
            $http.get('api/Info/GetCmp/?symbol=' + id).success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        },
        GetWorldmarkets: function () {
            var deferred = $q.defer();
            $http.get('api/Info/GetWorldmarkets').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }
    }
});