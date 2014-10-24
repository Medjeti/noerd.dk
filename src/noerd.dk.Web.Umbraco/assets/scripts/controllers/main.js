(function (undefined) {
    'use strict';

    /**
     * @ngdoc overview
     * @name noerddk - MainController
     * @description
     * # noerddk
     *
     * Main module of the application.
     */

    angular
      .module('noerddk')
      .controller('MainCtrl', MainCtrl);

    /* @ngInject */
    function MainCtrl() {
        console.log('MainCtrl');
    }
})();