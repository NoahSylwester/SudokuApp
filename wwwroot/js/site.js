// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(".puzzleCell").on("change", function(event) {
    if (['1','2','3','4','5','6','7','8','9'].includes($(this).val()) && $(this).val().length === 1 ) {
        $(this).attr('key', event.target.value);
    }
    else {
        $(this).val('');
    }
})
$("#solutionChecker").on("click", function() {
    solutionString = '';
    $(".puzzleCell").each(function(index){
        solutionString += $(this).attr('key');
    })
    if ($("#solutionChecker").attr("solution") === solutionString) {
        alert("Correct!");
    }
    else {
        alert("Incorrect.")
    }
    // $.ajax(  
    //     {  
    //         type: 'POST',  
    //         dataType: 'JSON',  
    //         url: '/',  
    //         data: { solutionString },  
    //         success:  
    //             function (response)  
    //             {  
    //                 console.log(response);
    //             },  
    //         error:  
    //             function (response)  
    //             {  
    //                 alert("Error: " + response);  
    //             }  
    //     });
})