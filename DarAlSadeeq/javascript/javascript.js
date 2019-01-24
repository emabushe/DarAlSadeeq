// JScript source code
$(function () {
    $('#loginBtn').click(function () {
        $('#modalLogin').modal('show');
        return false;
    });
});
$(function () {
    $('#loginFromBlockedModal').click(function () {
        $('#modalSectionBlocked').modal('hide');
        $('#modalLogin').modal('show');
        return false;
    });
});
$(function () {
    $('#btnManageLevel').click(function () {
        $('#modalManageLevels').modal('show');
        return false;
    });
});
$(function () {
    $('#btnManageCategory').click(function () {
        $('#modalManageCategories').modal('show');
        return false;
    });
});
$(function () {
    $('#btnManageSections').click(function () {
        $('#modalManageSections').modal('show');
        return false;
    });
});
$(function () {
    $('#btnManageSubSections').click(function () {
        $('#modalManageSubSections').modal('show');
        return false;
    });
});
$(function () {
    $('#btnLogout').click(function () {
        localStorage.clear();
        location.href = '../ar/Default.aspx';
        return false;
    });
});
function checkUser(url) {
    var userType = document.getElementById('hdnUserType').value;
    var currentURL = location.pathname + location.search;
    if (userType === 'admin') {
        if (url != null) {
            location.href = url;
        }
    }
    else if (userType === 'school') {
        var schoolSections = ["Content.aspx?section=2", "Content.aspx?section=3", "Content.aspx?section=4", "Content.aspx?section=5", "Content.aspx?section=6", "Content.aspx?section=7"];
        if (schoolSections.indexOf(url) > -1) {
            location.href = url;
        }
        else {
            if (url != null) {
                $('#modalSectionBlocked').modal('show');
            }
        }
    }
    else if (userType === 'teacher') {
        var teacherSections = ["Content.aspx?section=7"];
        if (teacherSections.indexOf(url) > -1) {
            location.href = url;
        }
        else {
            if (url != null) {
                $('#modalSectionBlocked').modal('show');
            }
        }
    }
    else if (userType === 'student') {
        var studentSections = ["Content.aspx?section=2", "Content.aspx?section=3", "Content.aspx?section=4", "Content.aspx?section=5", "Content.aspx?section=6"];
        if (studentSections.indexOf(url) > -1) {
            location.href = url;
        }
        else {
            if (url != null) {
                $('#modalSectionBlocked').modal('show');
            }
        }
    }
    else {
        if (url != null) {
            $('#modalSectionBlocked').modal('show');
        }
    }
}
function openContentModal() {
    $('#modalContentViewer').modal({ backdrop: 'static', keyboard: true });
}
function appendURL(data) {
    var param = data.substr(0, data.indexOf('='));
    var val = data.split('=').pop();
    var url = window.location.href;
    if (url.indexOf(param) > -1) {
        url = url.substring(url.indexOf(param) - 1, url.indexOf(''));
    }
    url = url.replace('&' + data, '');
    url = url.replace('?' + data, '');
    if (url.indexOf('?') > -1) {
        url += '&' + param + '=' + val;
    } else {
        url += '?' + param + '=' + val;
    }
    window.location.href = url;
}
function calposition() {
    var winW = 630, winH = 460;
    if (document.body && document.body.offsetWidth) {
        winW = document.body.offsetWidth;
        winH = document.body.offsetHeight;
    }
    if (document.compatMode === 'CSS1Compat' &&
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
function calDialogPosition() {
    var winW = 630, winH = 460;
    if (document.body && document.body.offsetWidth) {
        winW = document.body.offsetWidth;
        winH = document.body.offsetHeight;
    }
    if (document.compatMode === 'CSS1Compat' &&
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
    var TopSpace = (winH - objMainContainer.height() - 200) / 2;
    objMainContainer.css("top", TopSpace);
    var LeftSpace = (winW - objMainContainer.width()) / 2;
    objMainContainer.css("left", LeftSpace);
}
function calDialogPositionW() {
    var winW = 630, winH = 460;
    if (document.body && document.body.offsetWidth) {
        winW = document.body.offsetWidth;
        winH = document.body.offsetHeight;
    }
    if (document.compatMode === 'CSS1Compat' &&
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
    var TopSpace = (winH - objMainContainer.height() - 200) / 2;
    objMainContainer.css("top", TopSpace);
    var LeftSpace = (winW - objMainContainer.width()) / 2;
    objMainContainer.css("left", LeftSpace);
}
function multiImgSelect(obj) {
    var counter = 1;
    while (counter <= jQuery('.img-choise').length) {
        var objCurrent = jQuery(jQuery('.img-choise')[counter - 1]);
        objCurrent.animate({
            opacity: 0.25
        }, 0, function () {
            jQuery(obj).css('opacity', '1');
        });
        counter++;
    }
}
function toggleCorrectAnswer(obj) {
    jQuery('#correct').fadeIn();
}
function toggleWrongAnswer(obj) {
    jQuery('#wrong').fadeIn();
}
function resetAll() {
    jQuery('.img-choise').css('opacity', '1');
    jQuery('#correct').fadeOut();
    jQuery('#wrong').fadeOut();
}
function nextFrame() {
    jQuery('#page1').fadeOut(500);
    jQuery('#page2').delay(500).fadeIn();
}
function prevFrame() {
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
