/*
Edited by: John Breeden and Stephen Britt
File Name: script.js
Date: 03/04/2022
*/

// Global variables

// Hamburger menu function.
function menu() {                                               // FINAL ELEMENT: hamburger function
    var navlinks = document.getElementById("nav-links");
    var menuicon = document.getElementById("icon");
    if (navlinks.style.display == "block") {
        navlinks.style.display = "none";
        menuicon.style.color = "#f6eee4";
    } else {
        navlinks.style.display = "block";
        menuicon.style.color = "#f6eee4";
    } // end if
} // end function

function displayInfo1() {                                       // FINAL ELEMENT: another function (displays citations on glossary page)
    var refInfo = document.getElementById("ref-info1");
    if (refInfo.style.display == "block") {
        refInfo.style.display = "none";
    } else {
        refInfo.style.display = "block";
    } // end if
} // end function

function displayInfo2() {
    var refInfo = document.getElementById("ref-info2");
    if (refInfo.style.display == "block") {
        refInfo.style.display = "none";
    } else {
        refInfo.style.display = "block";
    } // end if
} // end function

function displayInfo3() {
    var refInfo = document.getElementById("ref-info3");
    if (refInfo.style.display == "block") {
        refInfo.style.display = "none";
    } else {
        refInfo.style.display = "block";
    } // end if
} // end function

function displayInfo4() {
    var refInfo = document.getElementById("ref-info4");
    if (refInfo.style.display == "block") {
        refInfo.style.display = "none";
    } else {
        refInfo.style.display = "block";
    } // end if
} // end function

function displayInfo5() {
    var refInfo = document.getElementById("ref-info5");
    if (refInfo.style.display == "block") {
        refInfo.style.display = "none";
    } else {
        refInfo.style.display = "block";
    } // end if
} // end function