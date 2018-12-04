// JScript source code
$(function () {

    $('#loginBtn').click(function () {
        $('#modalLogin').modal('show');
        return false;
    })

});
function calposition()
{
    var winW = 630, winH = 460;
    if (document.body && document.body.offsetWidth) {
	winW = document.body.offsetWidth;
	winH = document.body.offsetHeight;
    }
    if (document.compatMode == 'CSS1Compat' &&
		document.documentElement &&
		document.documentElement.offsetWidth) {
	winW = document.documentElement.offsetWidth;
	winH = document.documentElement.offsetHeight;
    }
    if (window.innerWidth && window.innerHeight) {
	winW = window.innerWidth;
	winH = window.innerHeight;
    }

   /* var objMainContainer = jQuery('#everythingInside');
    var marginTop = (winH - objMainContainer.height())/2.5;
    objMainContainer.css("margin-top", marginTop);*/

}

function calDialogPosition()
{
    var winW = 630, winH = 460;
    if (document.body && document.body.offsetWidth) {
	winW = document.body.offsetWidth;
	winH = document.body.offsetHeight;
    }
    if (document.compatMode == 'CSS1Compat' &&
		document.documentElement &&
		document.documentElement.offsetWidth) {
	winW = document.documentElement.offsetWidth;
	winH = document.documentElement.offsetHeight;
    }
    if (window.innerWidth && window.innerHeight) {
	winW = window.innerWidth;
	winH = window.innerHeight;
    }

    var objMainContainer = jQuery('#correct');
    var TopSpace = (winH - objMainContainer.height()-200)/2;
    objMainContainer.css("top", TopSpace);
    
    var objMainContainer = jQuery('#correct');
    var LeftSpace = (winW - objMainContainer.width())/2;
    objMainContainer.css("left", LeftSpace);

}

function calDialogPositionW()
{
    var winW = 630, winH = 460;
    if (document.body && document.body.offsetWidth) {
	winW = document.body.offsetWidth;
	winH = document.body.offsetHeight;
    }
    if (document.compatMode == 'CSS1Compat' &&
		document.documentElement &&
		document.documentElement.offsetWidth) {
	winW = document.documentElement.offsetWidth;
	winH = document.documentElement.offsetHeight;
    }
    if (window.innerWidth && window.innerHeight) {
	winW = window.innerWidth;
	winH = window.innerHeight;
    }

    var objMainContainer = jQuery('#wrong');
    var TopSpace = (winH - objMainContainer.height()-200)/2;
    objMainContainer.css("top", TopSpace);
    
    var objMainContainer = jQuery('#wrong');
    var LeftSpace = (winW - objMainContainer.width())/2;
    objMainContainer.css("left", LeftSpace);

}


function multiImgSelect(obj)
{
    var counter = 1;
    while(counter <= jQuery('.img-choise').length)
    {
	var objCurrent = jQuery(jQuery('.img-choise')[counter-1]);
	
	objCurrent.animate({
	    opacity: 0.25
	    }, 0, function() {
	    jQuery(obj).css('opacity', '1');
	});
	counter ++;
    }
    
}

function toggleCorrectAnswer(obj)
{
    jQuery('#correct').fadeIn();
}

function toggleWrongAnswer(obj)
{
    
    jQuery('#wrong').fadeIn();
}

function resetAll()
{
    
	jQuery('.img-choise').css('opacity', '1');
	
	jQuery('#correct').fadeOut();
	jQuery('#wrong').fadeOut();
	
}

function nextFrame()
{
    jQuery('#page1').fadeOut(500);
    jQuery('#page2').delay(500).fadeIn();
}
function prevFrame()
{
    debugger;
    $('#page2').fadeOut(500);
    $('#subjectsContainer').fadeOut(500);
    $('#subjectsArrow').fadeOut(500);
    $('#page1').delay(500).fadeIn();
}
function prevFrameNotSubjects() {
    jQuery('#page2').fadeOut(500);
    jQuery('#page1').delay(500).fadeIn();
}
function viewSubjects() {
    jQuery('#subjectsContainer').fadeOut(150);
    jQuery('#subjectsArrow').fadeOut(150);
    jQuery('#subjectsContainer').delay(200).fadeIn();
    jQuery('#subjectsArrow').delay(200).fadeIn();
}

function hideSubjects() {
    jQuery('#subjectsContainer').hide();
    jQuery('#subjectsArrow').hide();
}
/***************** POPUP ********/
function login() {
    jQuery('#login').delay(500).fadeIn();
}
function closePopUp() {
    jQuery('#login').delay(100).fadeOut();
}

/*************** Language ********/
function toEn(currentURL) {

    var str = currentURL.toString();
    var newURL = str.substr(str.indexOf("/ar/") + 4);
    newURL = "../en/" + newURL;
    location.href = newURL;
}

function toAr(currentURL) {

    var str = currentURL.toString();
    var newURL = str.substr(str.indexOf("/en/") + 4);
    newURL = "../ar/" + newURL;
    location.href = newURL;
}

/***** Timer ****/
var count = 8;

var counter = setInterval(timer, 1000); //1000 will  run it every 1 second

function timer() {
    count = count - 1;
    if (count <= 0) {
        clearInterval(counter);
        //counter ended, do something here
        return;
    }

    //Do code for showing the number of seconds here
}
function timer() {
    count = count - 1;
    if (count <= 0) {
        clearInterval(counter);
        return;
    }

    document.getElementById("timer").innerHTML = count ; // watch for spelling
}