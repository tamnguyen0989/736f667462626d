﻿(function () {
    angular.module('softbbm.channels', ['softbbm.common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('channels', {
            url: '/channels',
            parent: 'base',
            templateUrl: '/app/components/channels/channelListView.html',
            controller: 'channelListController'
        }).state('edit_channel', {
            url: '/edit_channel/:id',
            parent: 'base',
            templateUrl: '/app/components/channels/channelEditView.html',
            controller: 'channelEditController'
        }).state('add_channel', {
            url: '/add_channel',
            parent: 'base',
            templateUrl: '/app/components/channels/channelAddView.html',
            controller: 'channelAddController'
        });
    }
})();