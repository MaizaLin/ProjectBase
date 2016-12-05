/*
** Global settings.
*/

__ISDEBUG = true;

function __PRINTLOG() {
    
}

/*
** http helper to isolate the ajax implementation.
*/
var httpHelper = (function () {

    var urlBase = "http://localhost:52436";

    var appendAccessToken = function (options) {
        if (sessionStorage.getItem('accessToken')) {
            if (!options.headers) options.headers = {};
            options.headers.Authorization = 'Bearer ' + sessionStorage.getItem('accessToken');
        }
    };

    return {
        get: function (options) {
            try {
                if (options) {

                    appendAccessToken(options);

                    $.ajax({
                        url: urlBase + options.url || '',
                        type: "GET",
                        headers: options.headers,
                        dataType: options.dataType || '',
                        beforeSend: options.beforeSend || function () { },
                        success: options.success || function () { },
                        complete: options.complete || function () { }
                    });
                }
            } catch (e) {

            } 
        },

        post: function (options) {
            try {
                if (options) {

                    appendAccessToken(options);

                    $.ajax({
                        url: urlBase + options.url || '',
                        data: options.data || function () { },
                        type: "POST",
                        dataType: options.dataType || '',
                        contentType: options.contentType || '',
                        beforeSend: options.beforeSend || function () { },
                        success: options.success || function () { },
                        complete: options.complete || function () { }
                    });
                }
            } catch (e) {

            } 
        }
    }
}());


//httpHelper.

//httpHelper.


