
$(document).ready(function(){

    $(window).resize(function(e){
        if(window.innerWidth>800)
        {
            $('.main-sidenav').css("left","0px") 
        }else{
            $('.main-sidenav').css("left","-280px") 
        }
    });

    $('.btn-nav-open').click(function(){
        var left = $('.main-sidenav').css("left");
        if(left==='-280px')
        {
            $('.main-sidenav').css("left","0px")
        }else
        {
            $('.main-sidenav').css("left","-280px")
        }
    });


    // ----------- POPUP BUTTON PROFILE --------
    $('.topnav-prof-btn').click(function(e){
        $('.profile-popup').fadeToggle(400);
        console.log(e.target);
    });

    $(document).mouseup(function(e) 
    {
        var container = $(".profile-popup");
        if (!container.is(e.target) && container.has(e.target).length === 0) 
        {
            $('.profile-popup').fadeOut(400);
        }
    });

    // ----------- POPUP BUTTON NOTIFICATION --------
    $('.topnav-notif-btn').click(function(e){
        $('.notification-popup').fadeToggle(400);
        console.log(e.target);
    });

    $(document).mouseup(function(e) 
    {
        var container = $(".notification-popup");
        if (!container.is(e.target) && container.has(e.target).length === 0) 
        {
            $('.notification-popup').fadeOut(400);
        }
    });

    // ----------- POPUP BUTTON EMAIL --------
    $('.topnav-mail-btn').click(function(e){
        $('.email-popup').fadeToggle(400);
        console.log(e.target);
    });

    $(document).mouseup(function(e) 
    {
        var container = $(".email-popup");
        if (!container.is(e.target) && container.has(e.target).length === 0) 
        {
            $('.email-popup').fadeOut(400);
        }
    });


});




// ---------------- DATA TABLES ------------------

