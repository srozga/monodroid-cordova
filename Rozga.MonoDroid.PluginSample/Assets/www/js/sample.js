/* Copyright (c) 2013 Szymon Rozga
 *
 * See the file LICENSE.txt for copying permission. */
Rozga = {
    Sample : {
        callSample: function(callback) {
            cordova.exec(
                function (result) {
                    callback(result);
                },
                function() {},
                'Sample', 'test', [1,2,3]);
        }
    }
};