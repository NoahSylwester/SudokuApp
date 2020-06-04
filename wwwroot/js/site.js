// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(".puzzleCell").on("change", function(event) {
    $(this).attr('key', event.target.value);
})
$("#solutionChecker").on("click", function() {
    solutionString = '';
    $(".puzzleCell").each(function(index){
        solutionString += $(this).attr('key');
    })
    console.log($("#solutionChecker").attr("solution"))
    console.log(solutionString)
    if ($("#solutionChecker").attr("solution") === solutionString) {
        alert("Correct!");
    }
    else {
        alert("Incorrect.")
    }
    // console.log('built',solutionString);
    // console.log('stolen',$("#solutionChecker").attr("solution"));
})