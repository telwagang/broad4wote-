
var num = 0 ; 
var hide = "hidden",
    click_cancel = $(".clickcancel"),
    click_next = $(".clicknext"),
        file_dp = $("#upload"),
        img_dp = $("#dpfile");

click_next.click(function () {

    num++;
  
    if (num == 1)
    {
        $(".one").removeClass(hide);
    }
    else if (num == 2)
    {
        $(".one").addClass(hide);
        
       $(".two").removeClass(hide);
    }
    else if (num == 3)
    {
        $(".two").addClass(hide);
        $(".three").removeClass(hide);
    }
    else if (num == 4)
    {
        $(".three").addClass(hide);
        $(".four").removeClass(hide);
    }
    else if (num == 5)
    {
        num = 0; 
        window.location("register");
    }
  
});

click_cancel.click(function () {
    window.location("home");
});

function showImage(fileInput) {

    var files = fileInput.files;

    for (var i = 0; i < files.length; i++) {

        var file = files[i];

        var imageType = /image.*/;

        if (!file.type.match(imageType)) {
            continue;
        }
       
        img_dp.file = file;

        var reader = new FileReader();

        reader.onload = (function (aImg) {
            return function (e) {
                aImg.src = e.target.result;
            };
        })(img_dp);
        reader.readAsDataURL(file);
    }
};