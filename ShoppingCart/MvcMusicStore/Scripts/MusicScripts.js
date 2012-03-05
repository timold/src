/// <reference path="jquery-1.5.1.js" />

$(function () {
    $("#album-list img").mouseover(function () {
        animateElement($(this));
    });
});


function animateElement(element) {
    element.animate({ height: '+=25', width: '+=25' })
        .animate({ height: '-=25', width: '-=25' });
}

function searchFailed() {
    $("#searchresults").html("Sorry there was a problem with the search");
}

// short version
$(function () {

    $("[data-autocomplete-source]").each(function () {
        var target = $(this);
        target.autocomplete({ source: target.attr("data-autocomplete-source") });
    });

    $("#album-list img").mouseover(function () {
        $(this).effect("bounce", { time: 3, distance: 40 });
    });
});
