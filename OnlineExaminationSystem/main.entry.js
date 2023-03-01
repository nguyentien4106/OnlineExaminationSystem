/******/ (() => { // webpackBootstrap
var __webpack_exports__ = {};
// This entry need to be wrapped in an IIFE because it need to be isolated against other entry modules.
(() => {
/*!************************************!*\
  !*** ./src/js/manageUser/index.js ***!
  \************************************/
﻿$(document).ready(function () {
    $(".btn-delete-user").click(function () {
        if (confirm("Do you want to delete this user?")) {
            let userId = $(this).attr('user-id')

            $.ajax({
                url: "/Admin/ManageUser/Delete/" + userId,
                type: "GET",
                contentType: "application/json",
                success: function (res) {
                    console.log(res)
                }
            })
        }
        else {
        }
    })
});
})();

// This entry need to be wrapped in an IIFE because it need to be isolated against other entry modules.
(() => {
/*!************************************!*\
  !*** ./src/js/manageCDIO/index.js ***!
  \************************************/
﻿console.log('manage CDIO')
})();

/******/ })()
;
//# sourceMappingURL=main.entry.js.map