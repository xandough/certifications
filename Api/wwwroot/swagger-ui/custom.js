(function () {
    var logo = document.getElementById('logo');
    logo.href = "https://www.foo.com";

    var logoImg = document.getElementsByClassName('logo__img')[0];
    logoImg.alt = "Foo, Inc.";
    logoImg.src = "/swagger-ui/logo.svg";
    logoImg.width = 496;
})();